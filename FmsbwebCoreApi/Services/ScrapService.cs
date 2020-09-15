using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FmsbwebCoreApi.Context.SAP;
using FmsbwebCoreApi.Entity.SAP;
using FmsbwebCoreApi.Helpers;
using FmsbwebCoreApi.Models.SAP;
using FmsbwebCoreApi.Repositories;
using FmsbwebCoreApi.Repositories.Interfaces;
using FmsbwebCoreApi.ResourceParameters;
using FmsbwebCoreApi.ResourceParameters.SAP;
using FmsbwebCoreApi.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using Scrap = FmsbwebCoreApi.Models.SAP.Scrap;

namespace FmsbwebCoreApi.Services
{
    public class ScrapService : ScrapRepository, IScrapService
    {
        private readonly IUtilityService _utilityService;

        public ScrapService(SapContext context, IUtilityService utilityService) : base(context)
        {
            _utilityService = utilityService ?? throw new ArgumentNullException(nameof(utilityService));
        }

        private async Task<List<DailyScrapByShiftDto>> GetDailyScrapByShiftList(DailyScrapByShiftResourceParameter resourceParams)
        {
            if (resourceParams == null) throw new ArgumentNullException(nameof(resourceParams));

            //get scrap data from repo
            var scrapQry = GetScrap2Queryable(new ScrapResourceParameter
            {
                StartDate = resourceParams.Start,
                EndDate = resourceParams.End,
                IsPurchasedScrap = resourceParams.IsPurchasedScrap,
                ScrapCode = resourceParams.ScrapCode,
                Department = resourceParams.Department,
                Line = resourceParams.Line,
                Program = resourceParams.Program
            });

            var scrap = await scrapQry.Select(x => new
            {
                x.ShiftDate,
                x.Shift,
                x.ScrapCode,
                x.ScrapDesc,
                x.Qty
            })
                .ToListAsync()
                .ConfigureAwait(false);

            return scrap.Count > 0
                ? scrap
                    .GroupBy(x => new {x.ShiftDate, x.Shift, x.ScrapCode, x.ScrapDesc})
                    .Select(x => new DailyScrapByShiftDto
                    {
                        ShiftDate = x.Key.ShiftDate.ToDateTime(),
                        Shift = x.Key.Shift,
                        ShiftOrder = _utilityService.MapShiftToShiftOrder(x.Key.Shift),
                        ScrapCode = x.Key.ScrapCode,
                        ScrapDesc = x.Key.ScrapDesc,
                        Qty = x.Sum(s => s.Qty).ToInt()
                    })
                    .OrderBy(x => x.ShiftDate)
                    .ThenBy(x => x.ShiftOrder)
                    .ToList()
                : new List<DailyScrapByShiftDto>();
        }

        public async Task<dynamic> GetDailyScrapByShift(DailyScrapByShiftResourceParameter resourceParams)
        {
            var summary = await GetDailyScrapByShiftList(resourceParams).ConfigureAwait(false);
            var distinctShift = summary.Select(x => new { x.Shift, x.ShiftOrder }).Distinct().ToList();

            //get scrap data each day by filtered date range
            var result = new List<dynamic>();
            var tempStart = resourceParams.Start;
            while (tempStart <= resourceParams.End)
            {
                foreach (var shift in distinctShift.OrderBy(x => x.ShiftOrder))
                {
                    var isExist = summary.Any(x => x.ShiftDate == tempStart && x.Shift == shift.Shift);
                    if (isExist)
                    {
                        var data = summary.First(x => x.ShiftDate == tempStart && x.Shift == shift.Shift);
                        result.Add(new
                        {
                            data.ShiftDate,
                            data.Shift,
                            data.ShiftOrder,
                            data.ScrapCode,
                            data.ScrapDesc,
                            data.Qty
                        });
                    }
                    else
                    {
                        result.Add(new
                        {
                            ShiftDate = tempStart,
                            shift.Shift,
                            shift.ShiftOrder,
                            resourceParams.ScrapCode,
                            ScrapDesc = "",
                            Qty = 0
                        });
                    }
                }
                tempStart = tempStart.AddDays(1);
            }

            //group by shift
            var shifts = distinctShift.Select(x => new
            {
                shift = x.Shift,
                shiftOrder = x.ShiftOrder,
                dailyScrap = new
                {
                    data = result.Where(s => s.Shift == x.Shift),
                    trendline = TrendLine.GetTrendLine(result.Where(s => s.Shift == x.Shift), "Qty")
                }
            });

            return new
            {
                AllShifts = new
                {
                    trendline = TrendLine.GetTrendLine(result, "Qty"),
                    data = result
                },
                Shift = shifts
            };
        }

        public async Task<List<DailyScrapByShiftDateDto>> GetDailyScrapRate(DateTime start, DateTime end, string area, IProductionService productionService, bool isPurchasedScrap = false)
        {
            if (productionService == null) throw new ArgumentNullException(nameof(productionService));

            var productionQry = productionService.GetProductionQueryable(new ProductionResourceParameter { StartDate = start, EndDate = end, Area = area });
            var production = await productionQry.GroupBy(x => new { x.ShiftDate })
                .Select(x => new
                {
                    x.Key.ShiftDate,
                    TotalProd = x.Sum(s => s.QtyProd)
                })
                .ToListAsync()
                .ConfigureAwait(false);

            var finScrap = new List<string> { "anodize", "skirt coat" };
            var scrapQry = GetScrap2Queryable(new ScrapResourceParameter
            {
                StartDate = start,
                EndDate = end,
                IsPurchasedScrap = isPurchasedScrap
            });

            scrapQry = scrapQry.Where(x => area.ToLower() == "skirt coat"
                                        ? (finScrap.Contains(x.ScrapAreaName.ToLower()))
                                        : (x.ScrapAreaName == _utilityService.MapAreaToDepartment(area)));

            var scrapData = await scrapQry
                    .GroupBy(x => new { x.ShiftDate })
                    .Select(x => new
                    {
                        x.Key.ShiftDate,
                        TotalScrap = x.Sum(s => s.Qty)
                    })
                    .ToListAsync()
                    .ConfigureAwait(false);

            var distinctShiftDates = production.Select(x => x.ShiftDate).Distinct().ToList();
            var distinctShiftDatesScrap = scrapData.Select(x => x.ShiftDate).Distinct().ToList();
            distinctShiftDates.AddRange(distinctShiftDatesScrap);
            var shiftDates = distinctShiftDates.Select(x => x).Distinct().OrderBy(x => x).ToList();

            var data = shiftDates.Select(x =>
            {
                var shiftDate = x.ToDateTime();
                var scrap = scrapData.Where(q => q.ShiftDate == shiftDate);
                var prod = production.Where(q => q.ShiftDate == shiftDate);

                var totalScrap = scrap.Sum(q => q.TotalScrap ?? 0);
                var sapNet = prod.Sum(p => p.TotalProd ?? 0);
                var sapGross = sapNet + totalScrap;
                var scrapRate = sapNet == 0 ? null : (decimal?)totalScrap / sapGross;

                return new DailyScrapByShiftDateDto
                {
                    ShiftDate = shiftDate,
                    TotalScrap = totalScrap,
                    SapNet = sapNet,
                    SapGross = sapGross,
                    ScrapRate = scrapRate
                };
            })
            .OrderBy(x => x.ShiftDate)
            .ToList(); 

            return data;
        }

        public List<Scrap> GetScrapSummary(List<Scrap2> data, DateTime startDate, DateTime endDate)
        {
            return data.GroupBy(d => new { d.ScrapCode, d.ScrapAreaName, d.ScrapDesc, d.Department, d.Area, d.MachineHxh })
                .Select(d => new Scrap
                {
                    Department = d.Key.Department,
                    Area = d.Key.Area,
                    Line = d.Key.MachineHxh,
                    ScrapAreaName = d.Key.ScrapAreaName,
                    ScrapCode = d.Key.ScrapCode,
                    ScrapDesc = d.Key.ScrapDesc,
                    Qty = d.Sum(q => q.Qty ?? 0),
                    StartDate = startDate,
                    EndDate = endDate
                }).OrderByDescending(d => d.Qty).ToList();
        }
    }
}
