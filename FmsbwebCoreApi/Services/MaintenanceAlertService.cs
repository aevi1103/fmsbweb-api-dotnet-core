using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FmsbwebCoreApi.Context.FmsbMvc;
using FmsbwebCoreApi.Entity.FmsbMvc;
using FmsbwebCoreApi.Models;
using FmsbwebCoreApi.Repositories;
using FmsbwebCoreApi.ResourceParameters;
using FmsbwebCoreApi.Services.Interfaces;
using DateTime = System.DateTime;

namespace FmsbwebCoreApi.Services
{
    public class MaintenanceAlertService : MaintenanceAlertRepository, IMaintenanceAlertService
    {
        public MaintenanceAlertService(FmsbMvcContext context) : base(context)
        {
        }

        private static List<DateTime> GetDates(DateTime start, DateTime end)
        {
            var list = new List<DateTime>();
            var tempStart = start.Date;
            while (tempStart <= end.Date)
            {
                list.Add(tempStart);
                tempStart = tempStart.AddDays(1);
            }
            return list;
        }

        private static List<Mtbb> GetMtbbList(IReadOnlyList<MaintenanceAlert> machineData, IEnumerable<DateTime> dates)
        {
            var data = machineData.Select((maintenanceAlert, index) =>
            {
                var currentItem = maintenanceAlert;
                var previousItem = index > 0 ? machineData[index - 1] : null;

                var mtbbMinutes = previousItem == null
                    ? null
                    : (double?)currentItem.RequestDateTime.Subtract(previousItem.RequestDateTime).TotalMinutes;

                var mtbbHours = previousItem == null
                    ? null
                    : (double?)currentItem.RequestDateTime.Subtract(previousItem.RequestDateTime).TotalHours;

                return new Mtbb
                {
                    Date = maintenanceAlert.RequestDateTime.Date,
                    RequestDateTime = maintenanceAlert.RequestDateTime,
                    PreviousRequestDateTime = previousItem?.RequestDateTime,
                    MtbbMinutes = mtbbMinutes,
                    MtbbHours = mtbbHours
                };
            });

            var result = dates.Select(x =>
            {
                var item = data.FirstOrDefault(i => i.Date == x);

                return item ?? new Mtbb
                {
                    Date = x,
                    RequestDateTime = x,
                    PreviousRequestDateTime = null,
                    MtbbMinutes = null,
                    MtbbHours = null
                };
            });

            return result.ToList();
        }

        public async Task<dynamic> GetMeanTimeBeforeBreakDown(MaintenanceAlertResourceParameter parameter)
        {
            var data = await GetMaintenanceJobs(parameter).ConfigureAwait(false);
            var dates = GetDates(data.Min(x => x.RequestDateTime.Date), data.Max(x => x.RequestDateTime.Date));

            var mtbbByMachine = data.GroupBy(x => new
                {
                    Line = x.Machine.MachineName,
                    Machine = x.SubMachine.SubMachineName
                })
                .Select(groupedMachine =>
                {
                    var machineData = groupedMachine.OrderBy(x => x.RequestDateTime).ToList();
                    var mtbb = GetMtbbList(machineData, dates);

                    return new
                    {
                        groupedMachine.Key.Line,
                        groupedMachine.Key.Machine,
                        NumberOfBreakdowns = mtbb.Count(m => m.MtbbMinutes != null),
                        Mtbb = mtbb
                    };
                })
                .Where(x => x.NumberOfBreakdowns > 0)
                .OrderBy(x => x.Line)
                .ThenBy(x => x.Machine)
                .ToList();

            var summary = mtbbByMachine
                .GroupBy(x => new {x.Line})
                .Select(x => new
                {
                    x.Key.Line,
                    Data = x.ToList()
                });

            return new
            {
                Dates = dates.Select(d => d.Date.ToShortDateString()).ToList(),
                summary
            };
        }
    }
}
