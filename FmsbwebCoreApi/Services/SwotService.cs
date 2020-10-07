using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FmsbwebCoreApi.Entity.SAP;
using FmsbwebCoreApi.Models;
using FmsbwebCoreApi.Models.Intranet;
using FmsbwebCoreApi.Repositories.Interfaces;
using FmsbwebCoreApi.ResourceParameters;
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

        public SwotService(
            IScrapService scrapService,
            IProductionService productionService,
            IMachineMappingRepository machineMappingRepository,
            IUtilityService utilityService,
            IKpiTargetService kpiTargetService)
        {
            _scrapService = scrapService ?? throw new ArgumentNullException(nameof(scrapService));
            _productionService = productionService ?? throw new ArgumentNullException(nameof(productionService));
            _machineMappingRepository = machineMappingRepository ?? throw new ArgumentNullException(nameof(machineMappingRepository));
            _utilityService = utilityService ?? throw new ArgumentNullException(nameof(utilityService));
            _kpiTargetService = kpiTargetService ?? throw new ArgumentNullException(nameof(kpiTargetService));
        }

        public async Task<List<SwotLineDto>> GetLines(string department)
        {
            var area = _utilityService.MapDepartmentToArea(department);
            var data = await _machineMappingRepository.GetMachines(area);
            return data.Select(x => new SwotLineDto { Line = x.Line }).ToList();
        }

        #region Scrap

        private dynamic GetScrapPareto(IEnumerable<Scrap2> scrap, string line, int take = 10)
        {
            var data = scrap
                .Where(x => x.Machine2 == line)
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
                .Take(take)
                .ToList();

            return data;
        }

        private dynamic GetScrapParetoByArea(IEnumerable<Scrap2> scrap, string line, int take = 10)
        {
            var data = scrap
                .Where(x => x.Machine2 == line)
                .GroupBy(x => new
                {
                    x.ScrapAreaName,
                    x.ColorCode
                })
                .Select(x => new
                {
                    x.Key.ScrapAreaName,
                    x.Key.ColorCode,
                    Qty = x.Sum(q => q.Qty),
                    Details = x.GroupBy(d => new { d.ScrapDesc, d.ScrapCode, d.ColorCode })
                        .Select(d => new
                        {
                            d.Key.ScrapDesc,
                            d.Key.ScrapCode,
                            d.Key.ColorCode,
                            Qty = d.Sum(q => q.Qty)
                        })
                        .OrderByDescending(d => d.Qty)
                        .Take(take)
                })
                .OrderByDescending(x => x.Qty)
                .ToList();

            return data;
        }

        #endregion

        #region Production

        private dynamic GetHourlyProduction(IEnumerable<HourlyProductionDto> hxhProd, string line)
        {
            var data = hxhProd.Select(x => new
                {
                    x.ShiftDate,
                    x.Shift,
                    x.ShiftOrder,
                    x.Line,
                    x.CellSide,
                    x.Hour,
                    x.SwotTarget,

                    x.Target,
                    x.Gross,
                    x.Net,

                    x.Warmers,
                    x.Sol,
                    x.GageScrap,
                    x.VisualScrap,
                    x.Eol,
                    x.TotalScrap
                })
                .OrderBy(x => x.ShiftDate)
                .ThenBy(x => x.ShiftOrder)
                .ThenBy(x => x.Hour)
                .ToList();

            return data;
        }

        #endregion

        #region Downtime

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

            var area = _utilityService.MapDepartmentToArea(parameter.Dept);

            //params
            var productionParams = new ProductionResourceParameter
            {
                StartDate = start,
                EndDate = end,
                Lines = parameter.Lines
            };

            var scrapParams = new ScrapResourceParameter
            {
                StartDate = start,
                EndDate = end,
                Lines = parameter.Lines
            };

            var hxhParams = new ProductionResourceParameter
            {
                StartDate = parameter.StartDate,
                EndDate = parameter.EndDate,
                Lines = parameter.Lines
            };

            // Get data
            var prod = await _productionService.GetProductionQueryable(productionParams).ToListAsync();
            var scrap = await _scrapService.GetScrap2Queryable(scrapParams).ToListAsync();

            var scrapForHxH = scrap.Where(x => x.ShiftDate >= parameter.StartDate && x.ShiftDate <= parameter.EndDate).ToList();
            var targetData = await _kpiTargetService.GetSwotTargets(parameter.Dept).ConfigureAwait(false);
            var hxh = _productionService.GetHourByHourProductionByHour(hxhParams, scrapForHxH, targetData);

            return new List<SwotChart>();

        }


    }
}
