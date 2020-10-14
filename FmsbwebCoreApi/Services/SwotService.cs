using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FmsbwebCoreApi.Entity.Fmsb2;
using FmsbwebCoreApi.Entity.SAP;
using FmsbwebCoreApi.Helpers;
using FmsbwebCoreApi.Models;
using FmsbwebCoreApi.Models.FMSB2;
using FmsbwebCoreApi.Models.Intranet;
using FmsbwebCoreApi.Repositories.Interfaces;
using FmsbwebCoreApi.ResourceParameters;
using FmsbwebCoreApi.ResourceParameters.FMSB;
using FmsbwebCoreApi.Services.FmsbMvc;
using FmsbwebCoreApi.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace FmsbwebCoreApi.Services
{
    public class SwotService : ISwotService
    {
        private readonly IScrapService _scrapService;
        private readonly IProductionService _productionService;
        private readonly IMachineMappingRepository _machineMappingRepository;
        private readonly IUtilityService _utilityService;
        private readonly IKpiTargetService _kpiTargetService;
        private readonly IFmsbMvcLibraryRepository _downtimeRepository;

        public SwotService(
            IScrapService scrapService,
            IProductionService productionService,
            IMachineMappingRepository machineMappingRepository,
            IUtilityService utilityService,
            IKpiTargetService kpiTargetService,
            IFmsbMvcLibraryRepository downtimeRepository)
        {
            _scrapService = scrapService ?? throw new ArgumentNullException(nameof(scrapService));
            _productionService = productionService ?? throw new ArgumentNullException(nameof(productionService));
            _machineMappingRepository = machineMappingRepository ?? throw new ArgumentNullException(nameof(machineMappingRepository));
            _utilityService = utilityService ?? throw new ArgumentNullException(nameof(utilityService));
            _kpiTargetService = kpiTargetService ?? throw new ArgumentNullException(nameof(kpiTargetService));
            _downtimeRepository = downtimeRepository ?? throw new ArgumentNullException(nameof(downtimeRepository));
        }

        public async Task<List<SwotLineDto>> GetLines(string department)
        {
            var area = _utilityService.MapDepartmentToArea(department);
            var data = await _machineMappingRepository.GetMachines(area);
            var distinctLines = data.Select(x => x.Line).Distinct();
            return distinctLines.Select(x => new SwotLineDto { Line = x }).ToList();
        }

        #region Scrap

        private static dynamic GetScrapPareto(IEnumerable<Scrap2> scrap, SwotResourceParameter parameter, string line)
        {
            var start = parameter.StartDate;
            var end = parameter.EndDate;

            var data = scrap
                .Where(x => x.Machine2 == line)
                .Where(x => x.ShiftDate >= start && x.ShiftDate <= end)
                .GroupBy(x => new
                {
                    x.ScrapAreaName,
                    x.ColorCode,
                    x.ScrapDesc,
                    x.ScrapCode
                })
                .Select(x => new
                {
                    x.Key.ScrapAreaName,
                    x.Key.ColorCode,
                    x.Key.ScrapDesc,
                    x.Key.ScrapCode,
                    Qty = x.Sum(q => q.Qty)
                })
                .AsQueryable();

            if (parameter.Take > 0)
                data = data.Take(Convert.ToInt32(parameter.Take));

            return new
            {
                StartDate = start.ToShortDateString(),
                EndDate = end.ToShortDateString(),
                Line = line,
                Data = data.OrderByDescending(x => x.Qty).ToList()
            };
        }

        private static dynamic GetScrapParetoByArea(IEnumerable<Scrap2> scrap, SwotResourceParameter parameter, string line)
        {
            var start = parameter.StartDate;
            var end = parameter.EndDate;

            var data = scrap
                .Where(x => x.Machine2 == line)
                .Where(x => x.ShiftDate >= start && x.ShiftDate <= end)
                .GroupBy(x => new
                {
                    x.ScrapAreaName,
                    x.ColorCode
                })
                .Select(x => 
                {
                    var details = x.GroupBy(d => new { d.ScrapDesc, d.ScrapCode, d.ColorCode })
                        .Select(d => new
                        {
                            d.Key.ScrapDesc,
                            d.Key.ScrapCode,
                            d.Key.ColorCode,
                            Qty = d.Sum(q => q.Qty)
                        })
                        .AsQueryable();

                    if (parameter.Take > 0)
                        details = details.Take(Convert.ToInt32(parameter.Take));

                    return new
                    {
                        x.Key.ScrapAreaName,
                        x.Key.ColorCode,
                        Qty = x.Sum(q => q.Qty),
                        Details = details.OrderByDescending(t => t.Qty).ToList()
                    };

                })
                .OrderBy(x => x.ScrapAreaName)
                .ToList();

            return new
            {
                StartDate = start.ToShortDateString(),
                EndDate = end.ToShortDateString(),
                Line = line,
                Data = data
            };
        }

        private static dynamic GetMonthlyScrapRates(List<Scrap2> scrap, List<Production2> prod, SwotResourceParameter parameter, string line)
        {
            var start = parameter.MonthStart;
            var end = parameter.MonthEnd;

            var monthlyNet = prod
                .Where(x => x.ShiftDate >= start && x.ShiftDate <= end)
                .Where(x => x.Line == line)
                .GroupBy(x => new
                {
                    x.Line,
                    Year = x.ShiftDate.ToYear(),
                    MonthName = x.ShiftDate.ToMonthName(),
                    MonthNumber = x.ShiftDate.ToMonth()
                })
                .Select(x => new
                {
                    x.Key.Line,
                    x.Key.Year,
                    x.Key.MonthNumber,
                    x.Key.MonthName,
                    Qty = x.Sum(q => q.QtyProd)
                })
                .ToList();

            var filteredScrapByLine = scrap
                .Where(x => x.ShiftDate >= start && x.ShiftDate <= end)
                .Where(x => x.Machine2 == line)
                .ToList();

            var monthlyScrap = filteredScrapByLine
                .GroupBy(x => new
                {
                    Line = x.Machine2,
                    Year = x.ShiftDate.ToYear(),
                    MonthNumber = x.ShiftDate.ToMonth(),
                    MonthName = x.ShiftDate.ToMonthName()
                })
                .Select(x => new
                {
                    x.Key.Line,
                    x.Key.Year,
                    x.Key.MonthNumber,
                    x.Key.MonthName,
                    Qty = x.Sum(q => q.Qty),
                    SbScrapAreaDetails = x
                        .Where(s => s.IsPurchashed == false)
                        .GroupBy(s => new { s.ScrapAreaName })
                        .Select(s => new
                        {
                            s.Key.ScrapAreaName,
                            Qty = s.Sum(q => q.Qty)
                        })
                })
                .ToList();


            var monthlyGross = monthlyScrap.Select(x =>
            {
                var net = monthlyNet.Where(n => n.Year == x.Year && n.MonthNumber == x.MonthNumber).Sum(n => n.Qty) ??
                          0;
                var gross = (net + x.Qty) ?? 0;
                var scrapRate = gross == 0 ? 0 : (decimal) (x.Qty ?? 0) / gross;

                return new
                {
                    x.Line,
                    x.Year,
                    x.MonthName,
                    x.MonthNumber,
                    ScrapQty = x.Qty,
                    Net = net,
                    Gross = gross,
                    ScrapRate = scrapRate
                };

            }).ToList();

            var result = filteredScrapByLine
                .Where(x => x.IsPurchashed == false)
                .GroupBy(x => new {x.ScrapAreaName, x.ColorCode })
                .Select(x => new
                {
                    x.Key.ScrapAreaName,
                    x.Key.ColorCode,
                    MonthlyScrapDetails = monthlyGross
                        .Select(m =>
                        {
                            var scrapByMonth = x.Where(s => s.ShiftDate.ToYear() == m.Year && s.ShiftDate.ToMonth() == m.MonthNumber).Sum(s => s.Qty) ?? 0;
                            var scrapRate = m.Gross == 0 ? 0 : (decimal) scrapByMonth / m.Gross;

                            return new
                            {
                                x.Key.ScrapAreaName,
                                x.Key.ColorCode,
                                m.Line,
                                m.Year,
                                m.MonthNumber,
                                m.MonthName,
                                m.Gross,
                                Qty = scrapByMonth,
                                ScrapRate = scrapRate
                            };
                        })
                        .OrderBy(m => m.Year)
                        .ThenBy(m => m.MonthNumber)
                }).OrderBy(x => x.ScrapAreaName);

            return new
            {
                StartDate = start.ToShortDateString(),
                EndDate = end.ToShortDateString(),
                Line = line,
                Data = result
            };

        }

        private static dynamic GetWeeklyScrapRates(IEnumerable<Scrap2> scrap, IEnumerable<Production2> prod, SwotResourceParameter parameter, string line)
        {
            var start = parameter.WeekStart;
            var end = parameter.WeekEnd;

            var weeklyNet = prod
                .Where(x => x.ShiftDate >= start && x.ShiftDate <= end)
                .Where(x => x.Line == line)
                .GroupBy(x => new
                {
                    x.Line,
                    Year = x.ShiftDate.ToYear(),
                    WeekNumber = x.ShiftDate.ToWeekNumber()
                })
                .Select(x => new
                {
                    x.Key.Line,
                    x.Key.Year,
                    x.Key.WeekNumber,
                    Qty = x.Sum(q => q.QtyProd)
                })
                .ToList();

            var filteredScrapByLine = scrap
                .Where(x => x.ShiftDate >= start && x.ShiftDate <= end)
                .Where(x => x.Machine2 == line)
                .ToList();

            var weeklyScrap = filteredScrapByLine
                .GroupBy(x => new
                {
                    Line = x.Machine2,
                    Year = x.ShiftDate.ToYear(),
                    WeekNumber = x.ShiftDate.ToWeekNumber()
                })
                .Select(x => new
                {
                    x.Key.Line,
                    x.Key.Year,
                    x.Key.WeekNumber,
                    Qty = x.Sum(q => q.Qty)
                })
                .ToList();

            var weeklyGross = weeklyScrap.Select(x =>
            {
                var net = weeklyNet.Where(n => n.Year == x.Year && n.WeekNumber == x.WeekNumber).Sum(n => n.Qty) ??
                          0;
                var gross = (net + x.Qty) ?? 0;
                var scrapRate = gross == 0 ? 0 : (decimal)(x.Qty ?? 0) / gross;

                return new
                {
                    x.Line,
                    x.Year,
                    x.WeekNumber,
                    ScrapQty = x.Qty,
                    Net = net,
                    Gross = gross,
                    ScrapRate = scrapRate
                };

            }).ToList();

            var result = filteredScrapByLine
                .Where(x => x.IsPurchashed == false)
                .GroupBy(x => new { x.ScrapAreaName, x.ColorCode })
                .Select(x => new
                {
                    x.Key.ScrapAreaName,
                    x.Key.ColorCode,
                    WeeklyScrapDetails = weeklyGross
                        .Select(m =>
                        {
                            var scrapByWeek = x.Where(s => s.ShiftDate.ToYear() == m.Year && s.ShiftDate.ToWeekNumber() == m.WeekNumber).Sum(s => s.Qty) ?? 0;
                            var scrapRate = m.Gross == 0 ? 0 : (decimal)scrapByWeek / m.Gross;

                            return new
                            {
                                x.Key.ScrapAreaName,
                                x.Key.ColorCode,
                                m.Line,
                                m.Year,
                                m.WeekNumber,
                                m.Gross,
                                Qty = scrapByWeek,
                                ScrapRate = scrapRate
                            };
                        })
                        .OrderBy(m => m.Year)
                        .ThenBy(m => m.WeekNumber)
                }).OrderBy(x => x.ScrapAreaName);

            return new
            {
                StartDate = start.ToShortDateString(),
                EndDate = end.ToShortDateString(),
                Line = line,
                Data = result
            };

        }

        #endregion

        #region Production

        private static dynamic GetHourlyProduction(IEnumerable<HourlyProductionDto> hxhProd, SwotResourceParameter parameter, string line, SwotTargetDto lineSwotTarget)
        {
            var start = parameter.StartDate;
            var end = parameter.EndDate;

            var data = hxhProd
                .Where(x => x.MachineName == line)
                .Where(x => x.ShiftDate >= start && x.ShiftDate <= end)
                .Select(x =>
                {

                    var oae = x.Target == 0 ? 0 : x.Net / x.Target;

                    return new
                    {
                        x.ShiftDate,
                        x.Shift,
                        x.ShiftOrder,
                        x.Line,
                        x.MachineName,
                        x.Hour,
                        x.CellSide,

                        NetRateTarget = x.SwotTarget.NetRate,
                        x.SwotTarget.OaeTarget,

                        x.Target,
                        x.Gross,
                        x.Net,
                        Oae = oae,

                        x.Warmers,
                        x.TotalScrap,

                        x.HxHUrl

                    };

                })
                .OrderBy(x => x.CellSide)
                .ThenBy(x => x.ShiftDate)
                .ThenBy(x => x.ShiftOrder)
                .ThenBy(x => x.Hour)
                .ToList();

            return new
            {
                StartDate = start.ToShortDateString(),
                EndDate = end.ToShortDateString(),
                Line = line,
                NetRateTarget = lineSwotTarget?.NetRate ?? 0,
                Data = data
            };
        }

        private static dynamic DailyProduction(IEnumerable<Production2> prod, SwotResourceParameter parameter, string line)
        {
            var start = parameter.LastDayStart;
            var end = parameter.LastDayEnd;

            var dailyProduction = prod
                .Where(x => x.ShiftDate >= parameter.LastDayStart && x.ShiftDate <= parameter.LastDayEnd)
                .Where(x => x.Line == line)
                .GroupBy(x => new { x.ShiftDate })
                .Select(x => new
                {
                    x.Key.ShiftDate,
                    Qty = x.Sum(q => q.QtyProd)
                })
                .OrderBy(x => x.ShiftDate)
                .ToList();

            return new
            {
                StartDate = start.ToShortDateString(),
                EndDate = end.ToShortDateString(),
                Line = line,
                Data = dailyProduction
            };
        }

        private static dynamic MonthlyOae(IEnumerable<Production2> prod, IEnumerable<HxHProdDto> targets, SwotResourceParameter parameter, string line)
        {
            var start = parameter.MonthStart;
            var end = parameter.MonthEnd;

            var monthlyProd = prod
                .Where(x => x.Line == line)
                .Where(x => x.ShiftDate >= start && x.ShiftDate <= end)
                .GroupBy(x => new
                {
                    x.Line,
                    Year = x.ShiftDate.ToYear(),
                    MonthName = x.ShiftDate.ToMonthName(),
                    MonthNumber = x.ShiftDate.ToMonth()
                })
                .Select(x => new
                {
                    x.Key.Line,
                    x.Key.Year,
                    x.Key.MonthName,
                    x.Key.MonthNumber,
                    QtyProd = x.Sum(q => q.QtyProd)
                })
                .ToList();

            var monthlyTarget = targets
                .Where(x => x.MachineName == line)
                .Where(x => x.ShiftDate >= start && x.ShiftDate <= end)
                .GroupBy(x => new
                {
                    Line = x.MachineName,
                    Year = x.ShiftDate.ToYear(),
                    MonthName = x.ShiftDate.ToMonthName(),
                    MonthNumber = x.ShiftDate.ToMonth()
                })
                .Select(x => new
                {
                    x.Key.Line,
                    x.Key.Year,
                    x.Key.MonthName,
                    x.Key.MonthNumber,
                    Target = x.Sum(q => q.Target)
                })
                .ToList();

            var result = monthlyProd.Select(x =>
            {
                var target = monthlyTarget
                    .Where(t => t.Year == x.Year && t.MonthNumber == x.MonthNumber)
                    .Sum(t => t.Target);

                var oae = target == 0 ? 0 : (decimal)(x.QtyProd ?? 0) / target;

                return new
                {
                    x.Line,
                    x.Year,
                    x.MonthName,
                    x.MonthNumber,
                    Target = target,
                    Net = x.QtyProd,
                    Oae = oae
                };
            });

            return new
            {
                StartDate = start.ToShortDateString(),
                EndDate = end.ToShortDateString(),
                Line = line,
                Data = result
            };
        }

        private static dynamic WeeklyOae(IEnumerable<Production2> prod, IEnumerable<HxHProdDto> targets, SwotResourceParameter parameter, string line)
        {
            var start = parameter.WeekStart;
            var end = parameter.WeekEnd;

            var weeklyProd = prod
                .Where(x => x.Line == line)
                .Where(x => x.ShiftDate >= start && x.ShiftDate <= end)
                .GroupBy(x => new
                {
                    x.Line,
                    Year = x.ShiftDate.ToYear(),
                    WeekNumber = x.ShiftDate.ToWeekNumber()
                })
                .Select(x => new
                {
                    x.Key.Line,
                    x.Key.Year,
                    x.Key.WeekNumber,
                    QtyProd = x.Sum(q => q.QtyProd)
                })
                .ToList();

            var monthlyTarget = targets
                .Where(x => x.MachineName == line)
                .Where(x => x.ShiftDate >= start && x.ShiftDate <= end)
                .GroupBy(x => new
                {
                    Line = x.MachineName,
                    Year = x.ShiftDate.ToYear(),
                    WeekNumber = x.ShiftDate.ToWeekNumber()
                })
                .Select(x => new
                {
                    x.Key.Line,
                    x.Key.Year,
                    x.Key.WeekNumber,
                    Target = x.Sum(q => q.Target)
                })
                .ToList();

            var result = weeklyProd.Select(x =>
            {
                var target = monthlyTarget
                    .Where(t => t.Year == x.Year && t.WeekNumber == x.WeekNumber)
                    .Sum(t => t.Target);

                var oae = target == 0 ? 0 : (decimal)(x.QtyProd ?? 0) / target;

                return new
                {
                    x.Line,
                    x.Year,
                    x.WeekNumber,
                    Target = target,
                    Net = x.QtyProd,
                    Oae = oae
                };
            });

            return new
            {
                StartDate = start.ToShortDateString(),
                EndDate = end.ToShortDateString(),
                Line = line,
                Data = result
            };
        }

        #endregion

        #region Downtime

        private static dynamic DowntimeParetoByReason(IEnumerable<DowntimeDto> downtime, DateTime start, DateTime end, string line, int take)
        {
            var data = downtime
                .Where(x => x.ShifDate >= start && x.ShifDate <= end)
                .Where(x => x.Line == line)
                .GroupBy(x => new
                {
                    x.Reason2
                })
                .Select(x => new
                {
                    x.Key.Reason2,
                    Downtime = x.Sum(q => q.DowntimeLoss),
                    MachineDetails = x.GroupBy(m => new { m.Machine })
                        .Select(m => new
                        {
                            m.Key.Machine,
                            Downtime = m.Sum(q => q.DowntimeLoss)
                        })
                        .OrderByDescending(m => m.Downtime)
                })
                .AsQueryable();

            if (take > 0)
                data = data.Take(take);

            return new
            {
                StartDate = start.ToShortDateString(),
                EndDate = end.ToShortDateString(),
                Line = line,
                Data = data.OrderByDescending(x => x.Downtime).ToList()
            };
        }

        private static dynamic DowntimeParetoByMachine(IEnumerable<DowntimeDto> downtime, DateTime start, DateTime end, string line, int take)
        {
            var data = downtime
                .Where(x => x.ShifDate >= start && x.ShifDate <= end)
                .Where(x => x.Line == line)
                .GroupBy(x => new
                {
                    x.Machine
                })
                .Select(x => new
                {
                    x.Key.Machine,
                    Downtime = x.Sum(q => q.DowntimeLoss),
                    ReasonDetails = x.GroupBy(r => new { r.Reason2 })
                        .Select(r => new
                        {
                            r.Key.Reason2,
                            Downtime = r.Sum(q => q.DowntimeLoss)
                        })
                        .OrderByDescending(r => r.Downtime)
                })
                .AsQueryable();

            if (take > 0)
                data = data.Take(take);

            return new
            {
                StartDate = start.ToShortDateString(),
                EndDate = end.ToShortDateString(),
                Line = line,
                Data = data.OrderByDescending(x => x.Downtime).ToList()
            };
        }

        private static dynamic DailyDowntimeByReason(IEnumerable<DowntimeDto> downtime, SwotResourceParameter parameter, string line)
        {
            var start = parameter.LastDayStart;
            var end = parameter.LastDayEnd;

            var data = downtime
                .Where(x => x.ShifDate >= start && x.ShifDate <= end)
                .Where(x => x.Line == line)
                .GroupBy(x => new
                {
                    x.ShifDate
                })
                .Select(x => new
                {
                    x.Key.ShifDate,
                    Downtime = x.Sum(q => q.DowntimeLoss),
                    ReasonDetails = x.GroupBy(d => new { d.Reason2 })
                                .Select(d => new
                                {
                                    d.Key.Reason2,
                                    Downtime = d.Sum(q => q.DowntimeLoss),
                                    MachineDetails = d.GroupBy(m => new { m.Machine })
                                        .Select(m => new
                                        {
                                            m.Key.Machine,
                                            Downtime = m.Sum(q => q.DowntimeLoss)
                                        })
                                        .OrderByDescending(m => m.Downtime)
                                })
                                .OrderByDescending(d => d.Downtime)
                })
                .OrderBy(x => x.ShifDate)
                .ToList();

            return new
            {
                StartDate = start.ToShortDateString(),
                EndDate = end.ToShortDateString(),
                Line = line,
                Data = data
            };
        }

        private static dynamic DailyDowntimeByMachine(IEnumerable<DowntimeDto> downtime, SwotResourceParameter parameter, string line)
        {
            var start = parameter.LastDayStart;
            var end = parameter.LastDayEnd;

            var data = downtime
                .Where(x => x.ShifDate >= start && x.ShifDate <= end)
                .Where(x => x.Line == line)
                .GroupBy(x => new
                {
                    x.ShifDate
                })
                .Select(x => new
                {
                    x.Key.ShifDate,
                    Downtime = x.Sum(q => q.DowntimeLoss),
                    MachineDetails = x.GroupBy(d => new { d.Machine })
                        .Select(d => new
                        {
                            d.Key.Machine,
                            Downtime = d.Sum(q => q.DowntimeLoss),
                            ReasonDetails = d.GroupBy(r => new { r.Reason2 })
                                .Select(r => new
                                {
                                    r.Key.Reason2,
                                    Downtime = r.Sum(q => q.DowntimeLoss)
                                })
                                .OrderByDescending(r => r.Downtime)
                        })
                        .OrderByDescending(d => d.Downtime)
                })
                .OrderBy(x => x.ShifDate)
                .ToList();

            return new
            {
                StartDate = start.ToShortDateString(),
                EndDate = end.ToShortDateString(),
                Line = line,
                Data = data
            };
        }

        #endregion

        public async Task<List<SwotChart>> GetCharts(SwotResourceParameter parameter)
        {
            var start = parameter.ShowMonthlyCharts
                ? parameter.MonthStart
                : parameter.ShowLastSevenDays
                    ? parameter.LastDayStart
                    : parameter.StartDate;

            var end = parameter.ShowMonthlyCharts
                ? parameter.MonthEnd
                : parameter.ShowLastSevenDays
                    ? parameter.LastDayEnd
                    : parameter.EndDate;

            var selectedLines = parameter.LinesArr;
            if (!parameter.LinesArr.Any())
            {
                // Get all lines 
                selectedLines = (await GetLines(parameter.Dept)).Select(x => x.Line).ToList();
            }

            #region Parameters

            var productionParams = new ProductionResourceParameter
            {
                StartDate = start,
                EndDate = end,
                Lines = selectedLines
            };

            var scrapParams = new ScrapResourceParameter
            {
                StartDate = start,
                EndDate = end,
                Lines = selectedLines
            };

            // Only use this params for hourly production which only use the users selected start and end date
            var hxhStart = parameter.StartDate;
            var hxhEnd = parameter.EndDate;
            var hxhParams = new ProductionResourceParameter
            {
                StartDate = hxhStart,
                EndDate = hxhEnd,
                Lines = selectedLines,
                Department = parameter.Dept,
                Area = _utilityService.MapDepartmentToArea(parameter.Dept)
            };

            var downtimeParameter = new DowntimeResourceParameter
            {
                Start = parameter.LastDayStart,
                End = parameter.LastDayEnd,
                Lines = selectedLines
            };



            #endregion

            #region Data

            var prod = await _productionService.GetProductionQueryable(productionParams).ToListAsync();
            var scrap = await _scrapService.GetScrap2Queryable(scrapParams, false).ToListAsync(); 
            var scrapHxh = scrap.Where(x => x.ShiftDate >= hxhStart && x.ShiftDate <= hxhEnd).ToList();

            List<HxHProdDto> hxhTarget;
            if (parameter.Dept.ToLower() == "machining")
            {
                hxhTarget = await _productionService.GetMachiningEosProduction(start, end); 
            }
            else
            {
                hxhTarget = await _productionService.GetHxHProduction(productionParams);
            }

            // Only use for hourly production
            var swotTarget = await _kpiTargetService.GetSwotTargets(parameter.Dept).ConfigureAwait(false); 
            var hxh = await _productionService.GetHourByHourProductionByHour(hxhParams, scrapHxh, swotTarget); 

            var downtime = await _downtimeRepository.GetDowntime(downtimeParameter); 

            #endregion

            // Get Lines
            var lineData = selectedLines
                .Select(line =>
                {
                    var lineSwotTarget = swotTarget
                        .Where(t => t.MachineName == line)
                        .Select(x => new SwotTargetDto
                    {
                        OaeTarget = x.OaeTarget,
                        TargetPartsPerHour = x.TargetPartsPerHour,
                        FoundryScrapTarget = x.FoundryScrapTarget,
                        MachineScrapTarget = x.MachineScrapTarget,
                        AfScrapTarget = x.AfScrapTarget
                    }).FirstOrDefault();
                    

                    var chart = new SwotChart
                    {
                        Line = line,
                        Filters = parameter,
                        SwotTarget = lineSwotTarget,

                        ScrapCharts = new
                        {
                            ScrapPareto = GetScrapPareto(scrap, parameter, line),
                            ScrapParetoByArea = GetScrapParetoByArea(scrap, parameter, line),
                            MonthlyScrapRates = parameter.ShowMonthlyCharts ? GetMonthlyScrapRates(scrap, prod, parameter, line) : null,
                            WeeklyScrapRates = parameter.ShowMonthlyCharts ? GetWeeklyScrapRates(scrap, prod, parameter, line) : null
                        },

                        ProductionCharts = new
                        {
                            HourlyProduction = GetHourlyProduction(hxh, parameter, line, lineSwotTarget),
                            DailyProduction = parameter.ShowLastSevenDays ? DailyProduction(prod, parameter, line) : null,
                            MonthlyOae = parameter.ShowMonthlyCharts ? MonthlyOae(prod, hxhTarget, parameter, line) : null,
                            WeeklyOae = parameter.ShowMonthlyCharts ? WeeklyOae(prod, hxhTarget, parameter, line) : null
                        },

                        DowntimeCharts = new
                        {
                            LastDowntimeByReason = parameter.ShowLastSevenDays ? DowntimeParetoByReason(downtime, parameter.LastDayStart, parameter.LastDayEnd, line, parameter.Take) : null,
                            LastDowntimeByMachine = parameter.ShowLastSevenDays ? DowntimeParetoByMachine(downtime, parameter.LastDayStart, parameter.LastDayEnd, line, parameter.Take) : null,

                            DailyDowntimeByReason = parameter.ShowLastSevenDays ? DailyDowntimeByReason(downtime, parameter, line) : null,
                            DailyDowntimeByMachine = parameter.ShowLastSevenDays ? DailyDowntimeByMachine(downtime, parameter, line) : null,

                            DowntimeByReason = DowntimeParetoByReason(downtime, parameter.StartDate, parameter.EndDate, line, parameter.Take),
                            DowntimeByMachine = DowntimeParetoByMachine(downtime, parameter.StartDate, parameter.EndDate, line, parameter.Take),
                            
                        }
                    };
                    return chart;
                }).ToList();

            return lineData;

        }


    }
}
