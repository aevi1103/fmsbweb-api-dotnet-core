using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using FmsbwebCoreApi.Context.FmsbOee;
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

        public async Task<dynamic> GetOee(OeeResourceParameter resourceParameter)
        {
            if (resourceParameter == null) throw new ArgumentNullException(nameof(resourceParameter));

            var oee = await _fmsbOeeContext
                .Oee
                .AsNoTracking()
                .Include(x => x.OeeLine)
                .FirstOrDefaultAsync(x => x.OeeId == resourceParameter.OeeId)
                .ConfigureAwait(false);

            if (oee == null) throw new ArgumentNullException(nameof(oee));

            var now = DateTime.Now;

            // Get data
            var prod = await _productionService
                .GetPlcProductionQueryable(new PlcProdResourceParameter
                {
                    StartDate = oee.StartDateTime,
                    EndDate = oee.EndDateTime ?? now,
                    TagName = oee.OeeLine.TagName
                })
                .ToListAsync()
                .ConfigureAwait(false);

            var scrap = await _scrapService
                .GetScrapList(
                    oee.StartDateTime,
                    oee.EndDateTime ?? now,
                    oee.OeeLine.WorkCenter)
                .ConfigureAwait(false);

            var downtime = await _downtimeRepository.GetPlcDowntimeQueryable(new PlcDowntimeResourceParameter
            {
                StartDate = oee.StartDateTime,
                EndDate = oee.EndDateTime ?? now,
                Line = oee.OeeLine.GroupName
            })
                .ToListAsync()
                .ConfigureAwait(false);

            //transform data

            var downtimeMap = downtime.Select(x =>
            {
                var ppm = oee.OeeLine.CycleTimeSeconds == 0 ? 0 : 60 / oee.OeeLine.CycleTimeSeconds;

                var startTime = Convert.ToDateTime(x.StartStamp, new CultureInfo("en-US"));
                var endTime = x.EndStamp ?? now;

                var startTimeStripSeconds = DateTime.Parse(startTime.ToString("MM/dd/yyyy HH:mm"));
                var endTimeStripSeconds = DateTime.Parse(endTime.ToString("MM/dd/yyyy HH:mm"));

                var downtimeInMinutes = (endTimeStripSeconds - startTimeStripSeconds).TotalMinutes;
                var downtimeInSeconds = (endTimeStripSeconds - startTimeStripSeconds).TotalSeconds;
                var downtimeInParts = (decimal)downtimeInMinutes * ppm;

                return new
                {
                    x.TagName,
                    StartStamp = startTimeStripSeconds,
                    EndStamp = endTimeStripSeconds,
                    Fixed = x.EndStamp != null,
                    OriginalDowntimeMinute = x.DowntimeMinutes,
                    DowntimeInMinutes = downtimeInMinutes,
                    DowntimeInSeconds = downtimeInSeconds,
                    DowntimeInParts = downtimeInParts
                };

            }).ToList();

            var productionTotal = prod.Sum(x => x.Count ?? 0);
            var scrapTotal = scrap.Sum(x => x.Qty ?? 0);
            var downtimeTotalMinutes = downtimeMap.Sum(x => x.DowntimeInMinutes);
            var downtimeTotalParts = downtimeMap.Sum(x => x.DowntimeInParts);

            return new
            {
                Oee = oee,
                ProductionTotal = productionTotal,
                ScrapTotal = scrapTotal,
                DowntimeTotalMinutes = Math.Round(downtimeTotalMinutes, 0),
                DowntimeTotalParts = Math.Round(downtimeTotalParts, 0),
                DataList = new
                {
                    prod,
                    scrap,
                    downtime = downtimeMap,
                }
            };
        }
    }
}
