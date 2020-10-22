using System;
using System.Collections.Generic;
using System.Drawing;
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

        private static dynamic GetScrapPareto(IEnumerable<Scrap2> scrap, SwotResourceParameter parameter, string line = "")
        {
            var start = parameter.StartDate;
            var end = parameter.EndDate;

            var qry = scrap
                .Where(x => x.ScrapCode != "8888")
                .Where(x => x.ShiftDate >= start && x.ShiftDate <= end).AsQueryable();

            if (!string.IsNullOrEmpty(line))
                qry = qry.Where(x => x.Machine2 == line);

            var data = qry
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
                .OrderByDescending(x => x.Qty)
                .AsQueryable();

            if (parameter.Take > 0)
                data = data.Take(parameter.Take);

            return new
            {
                StartDate = start.ToShortDateString(),
                EndDate = end.ToShortDateString(),
                Line = line,
                Data = data.ToList()
            };
        }

        private static dynamic GetScrapParetoByArea(IEnumerable<Scrap2> scrap, SwotResourceParameter parameter, string line = "")
        {
            var start = parameter.StartDate;
            var end = parameter.EndDate;

            var qry = scrap
                .Where(x => x.ScrapCode != "8888")
                .Where(x => x.ShiftDate >= start && x.ShiftDate <= end)
                .AsQueryable();

            if (!string.IsNullOrEmpty(line))
                qry = qry.Where(x => x.Machine2 == line);

            var data = qry
                .ToList()
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
                        .OrderByDescending(t => t.Qty)
                        .AsQueryable();

                    if (parameter.Take > 0)
                        details = details.Take(parameter.Take);

                    return new
                    {
                        x.Key.ScrapAreaName,
                        x.Key.ColorCode,
                        Qty = x.Sum(q => q.Qty),
                        Details = details.ToList()
                    };

                })
                .OrderByDescending(x => x.Qty)
                .ToList();

            return new
            {
                StartDate = start.ToShortDateString(),
                EndDate = end.ToShortDateString(),
                Line = line,
                Data = data
            };
        }

        private static dynamic GetScrapByShift(IEnumerable<Scrap2> scrap, SwotResourceParameter parameter, string line = "")
        {
            var start = parameter.StartDate;
            var end = parameter.EndDate;

            var qry = scrap
                .Where(x => x.ScrapCode != "8888")
                .Where(x => x.ShiftDate >= start && x.ShiftDate <= end).AsQueryable();

            if (!string.IsNullOrEmpty(line))
                qry = qry.Where(x => x.Machine2 == line);

            var data = qry
                .ToList()
                .GroupBy(x => new
                {
                    x.Shift
                })
                .Select(x => new
                {
                    x.Key.Shift,
                    Qty = x.Sum(q => q.Qty),

                    //scrap area details
                    ScrapAreaNameDetails = x.GroupBy(d => new { d.ScrapAreaName, d.ColorCode })
                        .Select(d =>
                        {
                            var details = d.GroupBy(f => new { f.ScrapDesc })
                                .Select(f => new
                                {
                                    f.Key.ScrapDesc,
                                    Qty = f.Sum(q => q.Qty)
                                })
                                .OrderByDescending(t => t.Qty)
                                .AsQueryable();

                            if (parameter.Take > 0)
                                details = details.Take(parameter.Take);

                            return new
                            {
                                d.Key.ScrapAreaName,
                                d.Key.ColorCode,
                                Qty = d.Sum(q => q.Qty),

                                //defect details
                                DefectDetails = details.ToList()
                            };

                        }).OrderByDescending(d => d.Qty)

                })
                .OrderByDescending(x => x.Qty)
                .ToList();

            return new
            {
                StartDate = start.ToShortDateString(),
                EndDate = end.ToShortDateString(),
                Line = line,
                Data = data
            };
        }

        private static dynamic GetScrapByProgram(IEnumerable<Scrap2> scrap, SwotResourceParameter parameter, string line = "")
        {
            var start = parameter.StartDate;
            var end = parameter.EndDate;

            var qry = scrap
                .Where(x => x.ScrapCode != "8888")
                .Where(x => x.ShiftDate >= start && x.ShiftDate <= end).AsQueryable();

            if (!string.IsNullOrEmpty(line))
                qry = qry.Where(x => x.Machine2 == line);

            var data = qry
                .ToList()
                .GroupBy(x => new
                {
                    x.Program
                })
                .Select(x => new
                {
                    x.Key.Program,
                    Qty = x.Sum(q => q.Qty),

                    //scrap area details
                    ScrapAreaNameDetails = x.GroupBy(d => new { d.ScrapAreaName, d.ColorCode })
                        .Select(d =>
                        {
                            var details = d.GroupBy(f => new { f.ScrapDesc })
                                .Select(f => new
                                {
                                    f.Key.ScrapDesc,
                                    Qty = f.Sum(q => q.Qty)
                                })
                                .OrderByDescending(t => t.Qty)
                                .AsQueryable();

                            if (parameter.Take > 0)
                                details = details.Take(parameter.Take);

                            return new
                            {
                                d.Key.ScrapAreaName,
                                d.Key.ColorCode,
                                Qty = d.Sum(q => q.Qty),

                                //defect details
                                DefectDetails = details.ToList()
                            };

                        }).OrderByDescending(d => d.Qty)

                })
                .OrderByDescending(x => x.Qty)
                .ToList();

            return new
            {
                StartDate = start.ToShortDateString(),
                EndDate = end.ToShortDateString(),
                Line = line,
                Data = data
            };
        }

        /// <summary>
        /// Monthly SB Scrap
        /// </summary>
        /// <param name="scrap"></param>
        /// <param name="prod"></param>
        /// <param name="parameter"></param>
        /// <param name="line"></param>
        /// <returns></returns>
        private static dynamic GetMonthlySbScrapRates(IEnumerable<Scrap2> scrap, IEnumerable<Production2> prod, SwotResourceParameter parameter, string line = "")
        {
            var start = parameter.MonthStart;
            var end = parameter.MonthEnd;

            #region Net

            var netQry = prod
                .Where(x => x.ShiftDate >= start && x.ShiftDate <= end)
                .AsQueryable();

            if (!string.IsNullOrEmpty(line))
                netQry = netQry.Where(x => x.Line == line);

            var monthlyNet = netQry
                .ToList()
                .GroupBy(x => new
                {
                    Year = x.ShiftDate.ToYear(),
                    MonthName = x.ShiftDate.ToMonthName(),
                    MonthNumber = x.ShiftDate.ToMonth()
                })
                .Select(x => new
                {
                    x.Key.Year,
                    x.Key.MonthNumber,
                    x.Key.MonthName,
                    Qty = x.Sum(q => q.QtyProd)
                })
                .ToList();

            #endregion

            #region Scrap

            var scrapQry = scrap
                .Where(x => x.ShiftDate >= start && x.ShiftDate <= end && x.ScrapCode != "8888")
                .AsQueryable();

            if (!string.IsNullOrEmpty(line))
                scrapQry = scrapQry.Where(x => x.Machine2 == line);

            var filteredScrapByLine = scrapQry.ToList();

            var monthlyScrap = filteredScrapByLine
                .GroupBy(x => new
                {
                    Year = x.ShiftDate.ToYear(),
                    MonthNumber = x.ShiftDate.ToMonth(),
                    MonthName = x.ShiftDate.ToMonthName()
                })
                .Select(x => new
                {
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

            #endregion

            var monthlyGross = monthlyScrap.Select(x =>
            {
                var net = monthlyNet.Where(n => n.Year == x.Year && n.MonthNumber == x.MonthNumber).Sum(n => n.Qty) ?? 0;
                var gross = (net + x.Qty) ?? 0;

                return new
                {
                    x.Year,
                    x.MonthName,
                    x.MonthNumber,
                    ScrapQty = x.Qty,
                    Net = net,
                    Gross = gross
                };

            }).ToList();

            var result = filteredScrapByLine
                .Where(x => x.IsPurchashed == false)
                .GroupBy(x => new { x.ScrapAreaName, x.ColorCode })
                .Select(x => new
                {
                    x.Key.ScrapAreaName,
                    x.Key.ColorCode,
                    MonthlyScrapDetails = monthlyGross
                        .Select(m =>
                        {
                            var scrapByMonth = x.Where(s => s.ShiftDate.ToYear() == m.Year 
                                                            && s.ShiftDate.ToMonth() == m.MonthNumber
                                                            && s.IsPurchashedExclude == false) //exclude purchased scrap
                                                    .Sum(s => s.Qty) ?? 0;

                            var scrapRate = m.Gross == 0 ? 0 : (decimal)scrapByMonth / m.Gross;

                            return new
                            {
                                x.Key.ScrapAreaName,
                                x.Key.ColorCode,
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

        /// <summary>
        /// Weekly SB Scrap
        /// </summary>
        /// <param name="scrap"></param>
        /// <param name="prod"></param>
        /// <param name="parameter"></param>
        /// <param name="line"></param>
        /// <returns></returns>
        private static dynamic GetWeeklySbScrapRates(IEnumerable<Scrap2> scrap, IEnumerable<Production2> prod, SwotResourceParameter parameter, string line = "")
        {
            var start = parameter.WeekStart;
            var end = parameter.WeekEnd;

            #region Net

            var netQry = prod
                .Where(x => x.ShiftDate >= start && x.ShiftDate <= end)
                .AsQueryable();

            if (!string.IsNullOrEmpty(line))
                netQry = netQry.Where(x => x.Line == line);

            var weeklyNet = netQry
                .GroupBy(x => new
                {
                    Year = x.ShiftDate.ToYear(),
                    WeekNumber = x.ShiftDate.ToWeekNumber()
                })
                .Select(x => new
                {
                    x.Key.Year,
                    x.Key.WeekNumber,
                    Qty = x.Sum(q => q.QtyProd)
                })
                .ToList();

            #endregion

            #region Scrap

            var scrapQry = scrap
                .Where(x => x.ShiftDate >= start && x.ShiftDate <= end && x.ScrapCode != "8888")
                .AsQueryable();

            if (!string.IsNullOrEmpty(line))
                scrapQry = scrapQry.Where(x => x.Machine2 == line);

            var filteredScrapByLine = scrapQry.ToList();

            var weeklyScrap = filteredScrapByLine
                .GroupBy(x => new
                {
                    Year = x.ShiftDate.ToYear(),
                    WeekNumber = x.ShiftDate.ToWeekNumber()
                })
                .Select(x => new
                {
                    x.Key.Year,
                    x.Key.WeekNumber,
                    Qty = x.Sum(q => q.Qty)
                })
                .ToList();

            #endregion

            var weeklyGross = weeklyScrap.Select(x =>
            {
                var net = weeklyNet.Where(n => n.Year == x.Year && n.WeekNumber == x.WeekNumber).Sum(n => n.Qty) ?? 0;
                var gross = (net + x.Qty) ?? 0;

                return new
                {
                    x.Year,
                    x.WeekNumber,
                    ScrapQty = x.Qty,
                    Net = net,
                    Gross = gross
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
                            var scrapByWeek = x.Where(s => s.ShiftDate.ToYear() == m.Year 
                                                           && s.ShiftDate.ToWeekNumber() == m.WeekNumber
                                                           && s.IsPurchashedExclude == false) //exclude purchased scrap
                                                    .Sum(s => s.Qty) ?? 0;

                            var scrapRate = m.Gross == 0 ? 0 : (decimal)scrapByWeek / m.Gross;

                            return new
                            {
                                x.Key.ScrapAreaName,
                                x.Key.ColorCode,
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

        /// <summary>
        /// SB Scrap Only
        /// </summary>
        /// <param name="scrap"></param>
        /// <param name="prod"></param>
        /// <param name="parameter"></param>
        /// <param name="line"></param>
        /// <returns></returns>
        private static dynamic GetDailySbScrapRateByShift(List<Scrap2> scrap, List<Production2> prod, SwotResourceParameter parameter, string line = "")
        {
            var start = parameter.LastDayStart;
            var end = parameter.LastDayEnd;

            #region Net

            var netQry = prod
                .Where(x => x.ShiftDate >= start && x.ShiftDate <= end)
                .AsQueryable();

            if (!string.IsNullOrEmpty(line))
                netQry = netQry.Where(x => x.Line == line);

            var prodData = netQry
                .GroupBy(x => new
                {
                    x.Shift,
                    x.ShiftDate
                })
                .Select(x => new
                {
                    x.Key.ShiftDate,
                    x.Key.Shift,
                    Qty = x.Sum(q => q.QtyProd ?? 0)
                });

            #endregion

            #region Scrap

            var scrapQry = scrap
                .Where(x => x.ShiftDate >= start && x.ShiftDate <= end && x.ScrapCode != "8888")
                .AsQueryable();

            if (!string.IsNullOrEmpty(line))
                scrapQry = scrapQry.Where(x => x.Machine2 == line);

            var scrapData = scrapQry.GroupBy(x => new
                {
                    x.ShiftDate,
                    x.Shift,
                    x.ScrapAreaName,
                    x.ColorCode,
                    x.IsPurchashedExclude,
                    x.ScrapDesc,
                    x.ScrapCode
                })
                .Select(x => new
                {
                    x.Key.ShiftDate,
                    x.Key.Shift,
                    x.Key.ScrapAreaName,
                    x.Key.IsPurchashedExclude,
                    x.Key.ColorCode,
                    x.Key.ScrapDesc,
                    x.Key.ScrapCode,
                    Qty = x.Sum(q => q.Qty ?? 0)
                });

            #endregion

            var distinctShiftDates = scrapData.Select(x => x.ShiftDate).ToList();
            distinctShiftDates.AddRange(prodData.Select(x => x.ShiftDate));
            var shiftDates = distinctShiftDates.Distinct();

            var distinctShift = scrapData.Select(x => x.Shift).ToList();
            distinctShift.AddRange(prodData.Select(x => x.Shift));
            distinctShift.Add("All");
            var shifts = distinctShift.Distinct();

            var result = shifts.Select(shift =>
            {
                var details = shiftDates.Select(shiftDate =>
                {
                    var scrapByDate = shift == "All" 
                        ? scrapData.Where(s => s.ShiftDate == shiftDate)
                        : scrapData.Where(s => s.Shift == shift && s.ShiftDate == shiftDate);

                    var netByDate = shift == "All"  
                        ? prodData.Where(s => s.ShiftDate == shiftDate)
                        : prodData.Where(s => s.Shift == shift && s.ShiftDate == shiftDate);

                    var totalScrap = scrapByDate.Sum(s => s.Qty);
                    var totalSbScrap = scrapByDate.Where(s => s.IsPurchashedExclude == false).Sum(s => s.Qty);
                    var totalPurchasedScrap = scrapByDate.Where(s => s.IsPurchashedExclude == true).Sum(s => s.Qty);
                    var totalNet = netByDate.Sum(s => s.Qty);
                    var gross = totalScrap + totalNet;
                    var scrapRate = gross == 0 ? 0 : (decimal)totalSbScrap / gross;

                    var scrapAreaDetails = scrapByDate
                        .Where(a => a.IsPurchashedExclude == false)
                        .GroupBy(a => new {a.ScrapAreaName, a.ColorCode })
                        .Select(a => new
                        {
                            a.Key.ScrapAreaName,
                            a.Key.ColorCode,
                            Qty = a.Sum(q => q.Qty),
                            ScrapRate = gross == 0 ? 0 : (decimal)(a.Sum(q => q.Qty)) / gross,
                            DefectDetails = scrapByDate
                                .Where(defect => defect.ScrapAreaName == a.Key.ScrapAreaName)
                                .Where(defect => defect.IsPurchashedExclude == false)
                                .GroupBy(defect => new { defect.ScrapDesc })
                                .Select(defect => new
                                {
                                    defect.Key.ScrapDesc,
                                    Qty = defect.Sum(q => q.Qty),
                                    ScrapRate = gross == 0 ? 0 : (decimal)(defect.Sum(q => q.Qty)) / gross
                                }).OrderByDescending(defect => defect.ScrapRate)
                        })
                        .OrderByDescending(a => a.ScrapRate);

                    return new
                    {
                        Shift = shift,
                        ShiftDate = shiftDate,
                        Net = totalNet,
                        Scrap = totalScrap,
                        SbScrap = totalSbScrap,
                        PurchasedScrap = totalPurchasedScrap,
                        Gross = gross,
                        ScrapRate = scrapRate,
                        ScrapAreaDetails = scrapAreaDetails
                    };
                });

                return new
                {
                    Shift = shift,
                    Details = details.OrderBy(d => d.ShiftDate)
                };
            });

            return new
            {
                StartDate = start.ToShortDateString(),
                EndDate = end.ToShortDateString(),
                ShiftDates = shiftDates.OrderBy(x => x),
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

        private static dynamic DailyProduction(IEnumerable<Production2> prod, IEnumerable<HxHProdDto> targets, SwotResourceParameter parameter, string line = "")
        {
            var start = parameter.LastDayStart;
            var end = parameter.LastDayEnd;

            var targetQry = targets
                .Where(x => x.ShiftDate >= start && x.ShiftDate <= end)
                .AsQueryable();

            if (!string.IsNullOrEmpty(line))
                targetQry = targetQry.Where(x => x.MachineName == line);

            var dailyTarget = targetQry
                .GroupBy(x => new
                {
                    x.ShiftDate
                })
                .Select(x => new
                {
                    x.Key.ShiftDate,
                    Target = x.Sum(q => q.Target)
                })
                .ToList();

            var netQry = prod
                .Where(x => x.ShiftDate >= start && x.ShiftDate <= end)
                .AsQueryable();

            if (!string.IsNullOrEmpty(line))
                netQry = netQry.Where(x => x.Line == line);

            var dailyProduction = netQry
                .ToList()
                .GroupBy(x => new { x.ShiftDate })
                .Select(x =>
                {

                    var net = x.Sum(q => q.QtyProd) ?? 0;
                    var target = dailyTarget.Where(t => t.ShiftDate == x.Key.ShiftDate).Sum(t => t.Target);
                    var oae = target == 0 ? 0 : net / target;

                    return new
                    {
                        x.Key.ShiftDate,
                        Target = target,
                        Qty = net,
                        Oae = oae
                    };

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

        private static dynamic DailyProductionFinishing(IEnumerable<HourlyProductionDto> prod, SwotResourceParameter parameter, string line = "")
        {
            var start = parameter.LastDayStart;
            var end = parameter.LastDayEnd;

            var netQry = prod
                .Where(x => x.ShiftDate >= start && x.ShiftDate <= end)
                .AsQueryable();

            if (!string.IsNullOrEmpty(line))
                netQry = netQry.Where(x => x.MachineName == line);

            var dailyProduction = netQry
                .ToList()
                .GroupBy(x => new { x.ShiftDate })
                .Select(x =>
                {

                    var net = x.Sum(q => q.Net);
                    var target = x.Sum(q => q.Target);
                    var oae = target == 0 ? 0 : net / target;

                    return new
                    {
                        x.Key.ShiftDate,
                        Target = target,
                        Qty = net,
                        Oae = oae
                    };

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

        private static dynamic GetProductionByShift(IEnumerable<Production2> prod, IEnumerable<HxHProdDto> targets, SwotResourceParameter parameter, string line = "")
        {
            var start = parameter.StartDate;
            var end = parameter.EndDate;

            var targetQry = targets
                .Where(x => x.ShiftDate >= start && x.ShiftDate <= end)
                .AsQueryable();

            if (!string.IsNullOrEmpty(line))
                targetQry = targetQry.Where(x => x.MachineName == line);

            var shiftTarget = targetQry
                .GroupBy(x => new
                {
                    x.Shift
                })
                .Select(x => new
                {
                    x.Key.Shift,
                    Target = x.Sum(q => q.Target)
                })
                .ToList();

            var netQry = prod
                .Where(x => x.ShiftDate >= start && x.ShiftDate <= end)
                .AsQueryable();

            if (!string.IsNullOrEmpty(line))
                netQry = netQry.Where(x => x.Line == line);

            var dailyProduction = netQry
                .ToList()
                .GroupBy(x => new { x.Shift })
                .Select(x =>
                {
                    var net = x.Sum(q => q.QtyProd) ?? 0;
                    var target = shiftTarget.Where(t => t.Shift == x.Key.Shift).Sum(t => t.Target);
                    var oae = target == 0 ? 0 : net / target;

                    var shiftOrder = x.Key.Shift switch
                    {
                        "3" => 1,
                        "1" => 2,
                        "2" => 3,
                        _ => 0
                    };

                    return new
                    {
                        x.Key.Shift,
                        ShiftOrder = shiftOrder,
                        Target = target,
                        Qty = net,
                        Oae = oae
                    };

                })
                .OrderBy(x => x.ShiftOrder)
                .ToList();

            return new
            {
                StartDate = start.ToShortDateString(),
                EndDate = end.ToShortDateString(),
                Line = line,
                Data = dailyProduction
            };
        }

        private static dynamic GetProductionByShiftFinishing(IEnumerable<HourlyProductionDto> prod, SwotResourceParameter parameter, string line = "")
        {
            var start = parameter.StartDate;
            var end = parameter.EndDate;

            var netQry = prod
                .Where(x => x.ShiftDate >= start && x.ShiftDate <= end)
                .AsQueryable();

            if (!string.IsNullOrEmpty(line))
                netQry = netQry.Where(x => x.MachineName == line);

            var dailyProduction = netQry
                .ToList()
                .GroupBy(x => new { x.Shift })
                .Select(x =>
                {
                    var net = x.Sum(q => q.Net);
                    var target = x.Sum(q => q.Target);
                    var oae = target == 0 ? 0 : net / target;

                    var shiftOrder = x.Key.Shift switch
                    {
                        "3" => 1,
                        "1" => 2,
                        "2" => 3,
                        _ => 0
                    };

                    return new
                    {
                        x.Key.Shift,
                        ShiftOrder = shiftOrder,
                        Target = target,
                        Qty = net,
                        Oae = oae
                    };

                })
                .OrderBy(x => x.ShiftOrder)
                .ToList();

            return new
            {
                StartDate = start.ToShortDateString(),
                EndDate = end.ToShortDateString(),
                Line = line,
                Data = dailyProduction
            };
        }

        private static dynamic GetProductionByProgram(IEnumerable<Production2> prod, SwotResourceParameter parameter, string line = "")
        {
            var start = parameter.StartDate;
            var end = parameter.EndDate;

            var qry = prod
                .Where(x => x.ShiftDate >= start && x.ShiftDate <= end)
                .AsQueryable();

            if (!string.IsNullOrEmpty(line))
                qry = qry.Where(x => x.Line == line);

            var dailyProduction = qry
                .GroupBy(x => new { x.Program })
                .Select(x => new
                {
                    x.Key.Program,
                    Qty = x.Sum(q => q.QtyProd)
                })
                .OrderByDescending(x => x.Qty)
                .ToList();

            return new
            {
                StartDate = start.ToShortDateString(),
                EndDate = end.ToShortDateString(),
                Line = line,
                Data = dailyProduction
            };
        }

        private static dynamic MonthlyOae(IEnumerable<Production2> prod, IEnumerable<HxHProdDto> targets, SwotResourceParameter parameter, string line = "")
        {
            var start = parameter.MonthStart;
            var end = parameter.MonthEnd;

            #region Net

            var netQry = prod
                .Where(x => x.ShiftDate >= start && x.ShiftDate <= end)
                .AsQueryable();

            if (!string.IsNullOrEmpty(line))
                netQry = netQry.Where(x => x.Line == line);

            var monthlyProd = netQry
                .GroupBy(x => new
                {
                    Year = x.ShiftDate.ToYear(),
                    MonthName = x.ShiftDate.ToMonthName(),
                    MonthNumber = x.ShiftDate.ToMonth()
                })
                .Select(x => new
                {
                    x.Key.Year,
                    x.Key.MonthName,
                    x.Key.MonthNumber,
                    QtyProd = x.Sum(q => q.QtyProd)
                })
                .ToList();

            #endregion

            #region Target

            var targetQry = targets
                .Where(x => x.ShiftDate >= start && x.ShiftDate <= end)
                .AsQueryable();

            if (!string.IsNullOrEmpty(line))
                targetQry = targetQry.Where(x => x.MachineName == line);

            var monthlyTarget = targetQry
                .GroupBy(x => new
                {
                    Year = x.ShiftDate.ToYear(),
                    MonthName = x.ShiftDate.ToMonthName(),
                    MonthNumber = x.ShiftDate.ToMonth()
                })
                .Select(x => new
                {
                    x.Key.Year,
                    x.Key.MonthName,
                    x.Key.MonthNumber,
                    Target = x.Sum(q => q.Target)
                })
                .ToList();

            #endregion

            var result = monthlyProd.Select(x =>
            {
                var target = monthlyTarget
                    .Where(t => t.Year == x.Year && t.MonthNumber == x.MonthNumber)
                    .Sum(t => t.Target);

                var oae = target == 0 ? 0 : (decimal)(x.QtyProd ?? 0) / target;

                return new
                {
                    x.Year,
                    x.MonthName,
                    x.MonthNumber,
                    Target = target,
                    Net = x.QtyProd,
                    Oae = oae
                };
            })
                .OrderBy(x => x.Year)
                .ThenBy(x => x.MonthNumber)
                .ToList();

            return new
            {
                StartDate = start.ToShortDateString(),
                EndDate = end.ToShortDateString(),
                Line = line,
                Data = result
            };
        }

        private static dynamic MonthlyOaeFinishing(IEnumerable<HourlyProductionDto> prod, SwotResourceParameter parameter, string line = "")
        {
            var start = parameter.MonthStart;
            var end = parameter.MonthEnd;

            #region Net

            var netQry = prod
                .Where(x => x.ShiftDate >= start && x.ShiftDate <= end)
                .AsQueryable();

            if (!string.IsNullOrEmpty(line))
                netQry = netQry.Where(x => x.MachineName == line);

            var monthlyProd = netQry
                .GroupBy(x => new
                {
                    Year = x.ShiftDate.ToYear(),
                    MonthName = x.ShiftDate.ToMonthName(),
                    MonthNumber = x.ShiftDate.ToMonth()
                })
                .Select(x => new
                {
                    x.Key.Year,
                    x.Key.MonthName,
                    x.Key.MonthNumber,
                    Target = x.Sum(q => q.Target),
                    QtyProd = x.Sum(q => q.Net)
                })
                .ToList();

            #endregion

            var result = monthlyProd.Select(x =>
            {
                var oae = x.Target == 0 ? 0 : (decimal)x.QtyProd / x.Target;

                return new
                {
                    x.Year,
                    x.MonthName,
                    x.MonthNumber,
                    Target = x.Target,
                    Net = x.QtyProd,
                    Oae = oae
                };
            })
                .OrderBy(x => x.Year)
                .ThenBy(x => x.MonthNumber)
                .ToList();

            return new
            {
                StartDate = start.ToShortDateString(),
                EndDate = end.ToShortDateString(),
                Line = line,
                Data = result
            };
        }

        private static dynamic WeeklyOae(IEnumerable<Production2> prod, IEnumerable<HxHProdDto> targets, SwotResourceParameter parameter, string line = "")
        {
            var start = parameter.WeekStart;
            var end = parameter.WeekEnd;

            #region Net

            var netQry = prod
                .Where(x => x.ShiftDate >= start && x.ShiftDate <= end)
                .AsQueryable();

            if (!string.IsNullOrEmpty(line))
                netQry = netQry.Where(x => x.Line == line);

            var weeklyProd = netQry
                .GroupBy(x => new
                {
                    Year = x.ShiftDate.ToYear(),
                    WeekNumber = x.ShiftDate.ToWeekNumber()
                })
                .Select(x => new
                {
                    x.Key.Year,
                    x.Key.WeekNumber,
                    QtyProd = x.Sum(q => q.QtyProd)
                })
                .ToList();

            #endregion

            #region Target

            var targetQry = targets
                .Where(x => x.ShiftDate >= start && x.ShiftDate <= end)
                .AsQueryable();

            if (!string.IsNullOrEmpty(line))
                targetQry = targetQry.Where(x => x.MachineName == line);

            var monthlyTarget = targetQry
                .GroupBy(x => new
                {
                    Year = x.ShiftDate.ToYear(),
                    WeekNumber = x.ShiftDate.ToWeekNumber()
                })
                .Select(x => new
                {
                    x.Key.Year,
                    x.Key.WeekNumber,
                    Target = x.Sum(q => q.Target)
                })
                .ToList();

            #endregion

            var result = weeklyProd.Select(x =>
            {
                var target = monthlyTarget
                    .Where(t => t.Year == x.Year && t.WeekNumber == x.WeekNumber)
                    .Sum(t => t.Target);

                var oae = target == 0 ? 0 : (decimal)(x.QtyProd ?? 0) / target;

                return new
                {
                    x.Year,
                    x.WeekNumber,
                    Target = target,
                    Net = x.QtyProd,
                    Oae = oae
                };
            })
                .OrderBy(x => x.Year)
                .ThenBy(x => x.WeekNumber)
                .ToList();

            return new
            {
                StartDate = start.ToShortDateString(),
                EndDate = end.ToShortDateString(),
                Line = line,
                Data = result
            };
        }

        private static dynamic WeeklyOaeFinishing(IEnumerable<HourlyProductionDto> prod, SwotResourceParameter parameter, string line = "")
        {
            var start = parameter.WeekStart;
            var end = parameter.WeekEnd;

            #region Net

            var netQry = prod
                .Where(x => x.ShiftDate >= start && x.ShiftDate <= end)
                .AsQueryable();

            if (!string.IsNullOrEmpty(line))
                netQry = netQry.Where(x => x.MachineName == line);

            var weeklyProd = netQry
                .GroupBy(x => new
                {
                    Year = x.ShiftDate.ToYear(),
                    WeekNumber = x.ShiftDate.ToWeekNumber()
                })
                .Select(x => new
                {
                    x.Key.Year,
                    x.Key.WeekNumber,
                    QtyProd = x.Sum(q => q.Net),
                    Target = x.Sum(q => q.Target),
                })
                .ToList();

            #endregion

            var result = weeklyProd.Select(x =>
            {
                var oae = x.Target == 0 ? 0 : (decimal)(x.QtyProd) / x.Target;

                return new
                {
                    x.Year,
                    x.WeekNumber,
                    Target = x.Target,
                    Net = x.QtyProd,
                    Oae = oae
                };
            })
                .OrderBy(x => x.Year)
                .ThenBy(x => x.WeekNumber)
                .ToList();

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

        private static dynamic DowntimeParetoByReason(IEnumerable<DowntimeDto> downtime, DateTime start, DateTime end, string line = "", int take = 0)
        {
            var qry = downtime
                .Where(x => x.ShifDate >= start && x.ShifDate <= end)
                .AsQueryable();

            if (!string.IsNullOrEmpty(line))
                qry = qry.Where(x => x.Line == line);

            var data = qry
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

        private static dynamic DowntimeParetoByMachine(IEnumerable<DowntimeDto> downtime, DateTime start, DateTime end, string line = "", int take = 0)
        {
            var qry = downtime
                .Where(x => x.ShifDate >= start && x.ShifDate <= end)
                .AsQueryable();

            if (!string.IsNullOrEmpty(line))
                qry = qry.Where(x => x.Line == line);

            var data = qry
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

        private static dynamic DailyDowntimeByReason(IEnumerable<DowntimeDto> downtime, SwotResourceParameter parameter, string line = "")
        {
            var start = parameter.LastDayStart;
            var end = parameter.LastDayEnd;

            var qry = downtime
                .Where(x => x.ShifDate >= start && x.ShifDate <= end)
                .AsQueryable();

            if (!string.IsNullOrEmpty(line))
                qry = qry.Where(x => x.Line == line);

            var data = qry
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

        private static dynamic DailyDowntimeByMachine(IEnumerable<DowntimeDto> downtime, SwotResourceParameter parameter, string line = "")
        {
            var start = parameter.LastDayStart;
            var end = parameter.LastDayEnd;

            var qry = downtime
                .Where(x => x.ShifDate >= start && x.ShifDate <= end)
                .AsQueryable();

            if (!string.IsNullOrEmpty(line))
                qry = qry.Where(x => x.Line == line);

            var data = qry
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

        #region Deparment

        private static dynamic GetDepartmentKpi(
            SwotResourceParameter parameter,
            List<Scrap2> scrap,
            List<Production2> prod,
            List<HxHProdDto> hxhProduction,
            List<DowntimeDto> downtime,
            List<KpiTarget> departmentTargets,
            List<HourlyProductionDto> hxh)
        {
            var target = departmentTargets
                .Where(x => x.Year == parameter.EndDate.Year && x.MonthNumber == parameter.EndDate.Month)
                .Select(x => new
                {
                    OaeTarget = x.OaeTarget / 100,
                    OverallScrapTarget = x.ScrapRateTarget / 100
                })
                .FirstOrDefault();

            var start = parameter.StartDate;
            var end = parameter.EndDate;

            //production
            var hxhTarget = hxhProduction.Where(t => t.ShiftDate >= start && t.ShiftDate <= end).Sum(t => t.Target);
            var net = prod.Where(n => n.ShiftDate >= start && n.ShiftDate <= end).Sum(n => n.QtyProd) ?? 0;
            var oae = hxhTarget == 0 ? 0 : net / hxhTarget;

            //hxh production
            var hxhNet = hxh.Where(t => t.ShiftDate >= start && t.ShiftDate <= end).Sum(t => t.Net);
            var hxhOae = hxhTarget == 0 ? 0 : (decimal)hxhNet / hxhTarget;

            //scrap
            var filteredScrap = scrap.Where(s => s.ShiftDate >= start && s.ShiftDate <= end).ToList();
            var totalScrap = filteredScrap.Sum(s => s.Qty) ?? 0;
            var sbScrap = filteredScrap.Where(s => s.IsPurchashed == false).Sum(s => s.Qty) ?? 0;
            var purchaseScrap = filteredScrap.Where(s => s.IsPurchashed == true).Sum(s => s.Qty) ?? 0;
            var warmers = filteredScrap.Where(s => s.ScrapCode == "8888").Sum(s => s.Qty) ?? 0;

            //gross
            var gross = totalScrap + net;

            //scrap rates
            var scrapByAreaRates = filteredScrap
                .GroupBy(s => new { s.ScrapAreaName })
                .Select(s =>
                {
                    var qty = s.Sum(q => q.Qty) ?? 0;
                    var scrapRates = gross == 0 ? 0 : (decimal)qty / gross;
                    return new
                    {
                        s.Key.ScrapAreaName,
                        Qty = qty,
                        Gross = gross,
                        ScrapRate = scrapRates
                    };
                })
                .OrderByDescending(s => s.Qty)
                .ToList();

            var deptData = new
            {
                Targets = target,
                Department = parameter.Dept,

                Target = hxhTarget,
                Gross = gross,

                Net = !parameter.IsFinishing ? net : hxhNet,
                Oae = !parameter.IsFinishing ? oae : hxhOae,

                SbScrap = sbScrap,
                PurchasedScrap = purchaseScrap,
                Warmers = warmers,
                TotalScrap = totalScrap,
                ScrapRateByArea = scrapByAreaRates,

                ScrapCharts = new
                {
                    ScrapPareto = GetScrapPareto(scrap, parameter),
                    ScrapParetoByShift = GetScrapByShift(scrap, parameter),
                    ScrapParetoByProgram = GetScrapByProgram(scrap, parameter),
                    ScrapParetoByArea = GetScrapParetoByArea(scrap, parameter),
                    MonthlyScrapRates = parameter.ShowMonthlyCharts ? GetMonthlySbScrapRates(scrap, prod, parameter) : null,
                    WeeklyScrapRates = parameter.ShowMonthlyCharts ? GetWeeklySbScrapRates(scrap, prod, parameter) : null,
                    DailySbScrapRateByShift = parameter.ShowLastSevenDays ? GetDailySbScrapRateByShift(scrap, prod, parameter) : null,
                },

                ProductionCharts = new
                {
                    ProductionByShift = !parameter.IsFinishing
                        ? GetProductionByShift(prod, hxhProduction, parameter)
                        : GetProductionByShiftFinishing(hxh, parameter),

                    ProductionByProgram = GetProductionByProgram(prod, parameter),

                    DailyProduction = parameter.ShowLastSevenDays
                        ? !parameter.IsFinishing
                            ? DailyProduction(prod, hxhProduction, parameter)
                            : DailyProductionFinishing(hxh, parameter)
                        : null,

                    MonthlyOae = parameter.ShowMonthlyCharts
                        ? !parameter.IsFinishing
                            ? MonthlyOae(prod, hxhProduction, parameter)
                            : MonthlyOaeFinishing(hxh, parameter)
                        : null,

                    WeeklyOae = parameter.ShowMonthlyCharts
                        ? !parameter.IsFinishing
                            ? WeeklyOae(prod, hxhProduction, parameter)
                            : WeeklyOaeFinishing(hxh, parameter)
                        : null
                },

                DowntimeCharts = new
                {
                    LastDowntimeByReason = parameter.ShowLastSevenDays
                        ? DowntimeParetoByReason(downtime, parameter.LastDayStart, parameter.LastDayEnd, "", parameter.Take)
                        : null,
                    LastDowntimeByMachine = parameter.ShowLastSevenDays
                        ? DowntimeParetoByMachine(downtime, parameter.LastDayStart, parameter.LastDayEnd, "", parameter.Take)
                        : null,

                    DailyDowntimeByReason = parameter.ShowLastSevenDays ? DailyDowntimeByReason(downtime, parameter) : null,
                    DailyDowntimeByMachine = parameter.ShowLastSevenDays ? DailyDowntimeByMachine(downtime, parameter) : null,
                    DowntimeByReason = DowntimeParetoByReason(downtime, parameter.StartDate, parameter.EndDate, "", parameter.Take),
                    DowntimeByMachine = DowntimeParetoByMachine(downtime, parameter.StartDate, parameter.EndDate, "", parameter.Take),

                }
            };

            return deptData;
        }

        #endregion

        public async Task<dynamic> GetCharts(SwotResourceParameter parameter)
        {
            var start = parameter.StartDate;
            var end = parameter.EndDate;

            if (parameter.StartDate > parameter.MonthStart)
            {
                start = parameter.ShowMonthlyCharts
                    ? parameter.MonthStart
                    : parameter.ShowLastSevenDays
                        ? parameter.LastDayStart
                        : parameter.StartDate;
            }


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
                StartDate = start,
                EndDate = end,
                Lines = selectedLines,
                Department = parameter.Dept,
                Area = parameter.Area
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

            List<HxHProdDto> hxhProduction;
            if (parameter.Dept.ToLower() == "machining")
            {
                hxhProduction = await _productionService.GetMachiningEosProduction(start, end);
            }
            else
            {
                hxhProduction = await _productionService.GetHxHProduction(productionParams);
            }

            // Only use for hourly production
            var swotTarget = await _kpiTargetService.GetSwotTargets(parameter.Dept).ConfigureAwait(false);
            var hxh = await _productionService.GetHourByHourProductionByHour(hxhParams, scrapHxh, swotTarget);

            var downtime = await _downtimeRepository.GetDowntime(downtimeParameter);

            var departmentTargets = await _kpiTargetService.GetDepartmentTargets(parameter.Dept, parameter.MonthStart, parameter.MonthEnd);

            #endregion

            // Get Lines
            var lineData = selectedLines
                .Select(line =>
                {
                    var lineStartDate = parameter.StartDate;
                    var lineEndDate = parameter.EndDate;

                    //target
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

                    //production
                    var target = hxhProduction.Where(t => t.MachineName == line && t.ShiftDate >= lineStartDate && t.ShiftDate <= lineEndDate).Sum(t => t.Target);

                    //sap production
                    var net = prod.Where(n => n.Line == line && n.ShiftDate >= lineStartDate && n.ShiftDate <= lineEndDate).Sum(n => n.QtyProd) ?? 0;
                    var oae = target == 0 ? 0 : net / target;

                    //hxh production
                    var hxhNet = hxh.Where(t => t.MachineName == line && t.ShiftDate >= lineStartDate && t.ShiftDate <= lineEndDate).Sum(t => t.Net);
                    var hxhOae = target == 0 ? 0 : hxhNet / target;

                    //scrap
                    var filteredScrap = scrap.Where(s => s.Machine2 == line && s.ShiftDate >= lineStartDate && s.ShiftDate <= lineEndDate).ToList();
                    var totalScrap = filteredScrap.Sum(s => s.Qty) ?? 0;
                    var sbScrap = filteredScrap.Where(s => s.IsPurchashed == false).Sum(s => s.Qty) ?? 0;
                    var purchaseScrap = filteredScrap.Where(s => s.IsPurchashed == true).Sum(s => s.Qty) ?? 0;
                    var warmers = filteredScrap.Where(s => s.ScrapCode == "8888").Sum(s => s.Qty) ?? 0;

                    //gross
                    var gross = totalScrap + net;

                    //scrap rates
                    var scrapByAreaRates = filteredScrap
                        .GroupBy(s => new { s.ScrapAreaName })
                        .Select(s =>
                        {
                            var qty = s.Sum(q => q.Qty) ?? 0;
                            var scrapRates = gross == 0 ? 0 : (decimal)qty / gross;
                            return new
                            {
                                s.Key.ScrapAreaName,
                                Qty = qty,
                                Gross = gross,
                                ScrapRate = scrapRates
                            };
                        })
                        .OrderByDescending(s => s.Qty)
                        .ToList();

                    var chart = new SwotChart
                    {
                        Line = line,

                        Target = target,
                        Gross = gross,

                        Net = !parameter.IsFinishing ? net : hxhNet,
                        Oae = !parameter.IsFinishing ? oae : hxhOae,

                        SbScrap = sbScrap,
                        PurchasedScrap = purchaseScrap,
                        Warmers = warmers,
                        TotalScrap = totalScrap,
                        ScrapRateByArea = scrapByAreaRates,

                        SwotTarget = lineSwotTarget,

                        ScrapCharts = new
                        {
                            ScrapPareto = GetScrapPareto(scrap, parameter, line),
                            ScrapParetoByShift = GetScrapByShift(scrap, parameter, line),
                            ScrapParetoByProgram = GetScrapByProgram(scrap, parameter, line),
                            ScrapParetoByArea = GetScrapParetoByArea(scrap, parameter, line),
                            MonthlyScrapRates = parameter.ShowMonthlyCharts ? GetMonthlySbScrapRates(scrap, prod, parameter, line) : null,
                            WeeklyScrapRates = parameter.ShowMonthlyCharts ? GetWeeklySbScrapRates(scrap, prod, parameter, line) : null,
                            DailyScrapRateByShift = parameter.ShowLastSevenDays ? GetDailySbScrapRateByShift(scrap, prod, parameter, line) : null,
                        },

                        ProductionCharts = new
                        {
                            HourlyProduction = GetHourlyProduction(hxh, parameter, line, lineSwotTarget),

                            ProductionByShift = !parameter.IsFinishing 
                                                    ? GetProductionByShift(prod, hxhProduction, parameter, line)
                                                    : GetProductionByShiftFinishing(hxh, parameter, line),

                            ProductionByProgram = GetProductionByProgram(prod, parameter, line),

                            DailyProduction = parameter.ShowLastSevenDays 
                                                ? !parameter.IsFinishing 
                                                    ? DailyProduction(prod, hxhProduction, parameter, line) 
                                                    : DailyProductionFinishing(hxh, parameter, line)
                                                : null,

                            MonthlyOae = parameter.ShowMonthlyCharts 
                                            ? !parameter.IsFinishing 
                                                ? MonthlyOae(prod, hxhProduction, parameter, line) 
                                                : MonthlyOaeFinishing(hxh, parameter, line)
                                            : null,

                            WeeklyOae = parameter.ShowMonthlyCharts 
                                            ? !parameter.IsFinishing 
                                                ? WeeklyOae(prod, hxhProduction, parameter, line) 
                                                : WeeklyOaeFinishing(hxh, parameter, line)
                                            : null
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

            return new
            {
                DepartmentData = parameter.LinesArr.Count == 0
                                    ? GetDepartmentKpi(parameter, scrap, prod, hxhProduction, downtime, departmentTargets, hxh)
                                    : null,
                Filters = parameter,
                LineData = lineData
            };

        }


    }
}
