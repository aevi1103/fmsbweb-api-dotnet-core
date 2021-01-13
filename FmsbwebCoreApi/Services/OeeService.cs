using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using DateShiftLib.Extensions;
using FmsbwebCoreApi.Context.FmsbOee;
using FmsbwebCoreApi.Entity.FmsbOee;
using FmsbwebCoreApi.Enums;
using FmsbwebCoreApi.Repositories.Interfaces;
using FmsbwebCoreApi.ResourceParameters;
using FmsbwebCoreApi.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace FmsbwebCoreApi.Services
{
    public class OeeService : IOeeService
    {
        private readonly IProductionService _productionService;
        private readonly IScrapService _scrapService;
        private readonly IDowntimeRepository _downtimeRepository;
        private readonly FmsbOeeContext _fmsbOeeContext;

        public OeeService(
            IProductionService productionService,
            IScrapService scrapService,
            IDowntimeRepository downtimeRepository,
            FmsbOeeContext fmsbOeeContext)
        {
            _productionService = productionService ?? throw new ArgumentNullException(nameof(productionService));
            _scrapService = scrapService ?? throw new ArgumentNullException(nameof(scrapService));
            _downtimeRepository = downtimeRepository ?? throw new ArgumentNullException(nameof(downtimeRepository));
            _fmsbOeeContext = fmsbOeeContext ?? throw new ArgumentNullException(nameof(fmsbOeeContext));
        }

        public async Task<dynamic> GetOee(Guid lineId)
        {
            var entity = await _fmsbOeeContext
                .Oee
                .Include(x => x.Line)
                .AsNoTracking()
                .FirstOrDefaultAsync(x => x.LineId == lineId && x.EndDateTime == null)
                .ConfigureAwait(false);

            if (entity == null) return null;

            var lineData = await _fmsbOeeContext
                .Oee
                .AsNoTracking()
                .Include(x => x.Line)
                //.Include(x => x.Line.MachineGroups)
                .FirstOrDefaultAsync(x => x.OeeId == entity.OeeId)
                .ConfigureAwait(false);

            if (lineData == null) throw new OperationCanceledException("Invalid OEE ID");

            var now = DateTime.Now;

            // Get data
            var prod = await _productionService
                .GetPlcProductionQueryable(new PlcProdResourceParameter
                {
                    StartDate = lineData.StartDateTime,
                    EndDate = lineData.EndDateTime ?? now,
                    TagName = lineData.Line.TagName
                })
                .ToListAsync()
                .ConfigureAwait(false);

            var scrap = await _scrapService
                .GetScrapList(
                    lineData.StartDateTime,
                    lineData.EndDateTime ?? now,
                    lineData.Line.WorkCenter)
                .ConfigureAwait(false);

            var plcDowntime = await _downtimeRepository.GetPlcDowntimeQueryable(new DowntimeResourceParameter
            {
                StartDate = lineData.StartDateTime,
                EndDate = lineData.EndDateTime ?? now,
                Line = lineData.Line.GroupName
            })
                .ToListAsync()
                .ConfigureAwait(false);

            var operatorDowntimeEvents = await _downtimeRepository.GetDowntimeEvents(new DowntimeResourceParameter
            {
                OeeId = lineData.OeeId
            })
                .ToListAsync()
                .ConfigureAwait(false);

            //transform data

            var plannedDowntimeEvents = operatorDowntimeEvents
                .Where(x => x.DowntimeEventType == DowntimeEventType.Planned)
                .ToList();

            var unPlannedDowntimeEvents = operatorDowntimeEvents
                .Where(x => x.DowntimeEventType == DowntimeEventType.Unplanned)
                .ToList();

            var plcDowntimeEvents = plcDowntime.Select(x =>
            {
                const string dateFormat = "MM/dd/yyyy HH:mm";
                var startTime = Convert.ToDateTime(x.StartStamp, new CultureInfo("en-US"));
                var endTime = x.EndStamp ?? now;
                var startTimeStripSeconds = DateTime.Parse(startTime.ToString(dateFormat));
                var endTimeStripSeconds = DateTime.Parse(endTime.ToString(dateFormat));
                var downtimeInMinutes = (endTimeStripSeconds - startTimeStripSeconds).TotalMinutes;
                var downtimeInSeconds = (endTimeStripSeconds - startTimeStripSeconds).TotalSeconds;

                return new
                {
                    x.TagName,
                    Line = _downtimeRepository.GetAssemblyMachineName(x.TagName),
                    StartStamp = startTimeStripSeconds,
                    EndStamp = endTimeStripSeconds,
                    Fixed = x.EndStamp != null,
                    OriginalDowntimeMinute = x.DowntimeMinutes,
                    DowntimeInMinutes = downtimeInMinutes,
                    DowntimeInSeconds = downtimeInSeconds
                };

            }).ToList();

            #region Summary

            var productionTotal = prod.Sum(x => x.Count ?? 0);
            var scrapTotal = scrap.Sum(x => x.Qty ?? 0);

            // PLC counter is located before scrap inspection, meaning the counter counts gross parts
            var gross = lineData.Line.ScrapInspectionLocation == ScrapInspectionLocation.Before
                ? productionTotal
                : productionTotal + scrapTotal;

            // PLC counter is located after inspection, meaning the counter counts net/good parts
            var net = lineData.Line.ScrapInspectionLocation == ScrapInspectionLocation.After
                ? productionTotal
                : productionTotal - scrapTotal;

            // Downtime
            var totalPlcDowntime = (int)plcDowntimeEvents.Sum(x => x.DowntimeInMinutes);
            var totalPlannedDowntime = plannedDowntimeEvents.Sum(x => x.Downtime);
            var totalUnplannedDowntime = unPlannedDowntimeEvents.Sum(x => x.Downtime);

            // oee calculation
            var allTime = ((lineData.EndDateTime ?? now) - lineData.StartDateTime).TotalMinutes;
            var ppt = allTime - totalPlannedDowntime; // planned production time

            //* todo: ask eloise how to handle downtime if whether to add the operator downtime as well
            var runTime = ppt - totalPlcDowntime;

            var availability = ppt == 0 ? 0 : (decimal)runTime / (decimal)ppt;
            var capacity = (1 / lineData.Line.CycleTimeMinutes) * (decimal)runTime;

            //var performance = runTime == 0 ? 0 : (lineData.Line.CycleTimeMinutes * gross) / (decimal)runTime;
            var performance = capacity == 0 ? 0 : gross / capacity;

            var quality = gross == 0 ? 0 : (decimal)net / gross;
            var oee = availability * performance * quality;

            #endregion

            return new
            {
                Line = lineData,
                Status = new
                {
                    lineData.OeeId,
                    Running = lineData.EndDateTime == null,
                    StartTime = lineData.StartDateTime,
                    EndTime = lineData.EndDateTime ?? now,
                    lineData.Line.CycleTimeSeconds,
                    lineData.Line.CycleTimeMinutes,
                    PlcDowntime = totalPlcDowntime,
                    PlannedDowntime = totalPlannedDowntime,
                    UnPlannedDowntime = totalUnplannedDowntime,
                    AllTime = allTime,
                    PlannedProductionTime = ppt,
                    RuntTime = runTime,
                    PlcCounter = productionTotal,
                    Gross = gross,
                    ScrapTotal = scrapTotal,
                    Net = net,
                    Capacity = capacity,
                    Availability = availability,
                    Performance = performance,
                    Quality = quality,
                    Oee = oee
                },
                DataList = new
                {
                    Prod = prod.GroupBy(x => new
                    {
                        x.TimeStamp.Date,
                        x.TimeStamp.Hour,
                        Label = $"{x.TimeStamp:h tt}"
                    })
                        .Select(x => new
                        {
                            x.Key.Date,
                            x.Key.Hour,
                            x.Key.Label,
                            Count = x.Sum(q => q.Count)
                        })
                        .OrderBy(x => x.Date)
                        .ThenBy(x => x.Hour),

                    Scrap = scrap.GroupBy(x => new { x.ScrapAreaName, x.ScrapDesc })
                        .Select(x => new
                        {
                            x.Key.ScrapAreaName,
                            x.Key.ScrapDesc,
                            Qty = x.Sum(q => q.Qty ?? 0)
                        })
                        .OrderByDescending(x => x.Qty)
                        .ToList(),

                    downtime = plcDowntimeEvents.GroupBy(x => new { x.Line })
                        .Select(x => new
                        {
                            Machine = x.Key.Line,
                            Downtime = x.Sum(q => q.DowntimeInMinutes)
                        }).OrderByDescending(x => x.Downtime),
                }
            };
        }
    }
}
