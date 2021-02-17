using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FmsbwebCoreApi.Entity.Fmsb2;
using FmsbwebCoreApi.Entity.SAP;
using FmsbwebCoreApi.Helpers;
using FmsbwebCoreApi.Models;
using FmsbwebCoreApi.Models.Intranet;
using FmsbwebCoreApi.Models.SAP;
using FmsbwebCoreApi.ResourceParameters;
using FmsbwebCoreApi.ResourceParameters.SAP;
using FmsbwebCoreApi.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using UtilityLibrary.Service.Interface;
using DateShiftLib.Extensions;
using Scrap = FmsbwebCoreApi.Models.SAP.Scrap;

namespace FmsbwebCoreApi.Services
{
    public class KpiService : IKpiService
    {
        private readonly IScrapService _scrapService;
        private readonly IProductionService _productionService;
        private readonly IKpiTargetService _kpiTargetService;
        private readonly IUtilityService _utilityService;
        private readonly IDataAccessUtilityService _dataAccessUtilityService;
        private readonly IEndOfShiftReportService _endOfShiftReportService;
        private readonly IConverterService _converterService;
        private readonly IEmailService _emailService;

        public KpiService(
            IScrapService scrapService,
            IProductionService productionService,
            IKpiTargetService kpiTargetService,
            IUtilityService utilityService,
            IDataAccessUtilityService dataAccessUtilityService,
            IEndOfShiftReportService endOfShiftReportService,
            IConverterService converterService,
            IEmailService emailService)
        {
            _scrapService = scrapService ?? throw new ArgumentNullException(nameof(scrapService));
            _productionService = productionService ?? throw new ArgumentNullException(nameof(productionService));
            _kpiTargetService = kpiTargetService ?? throw new ArgumentNullException(nameof(kpiTargetService));
            _utilityService = utilityService ?? throw new ArgumentNullException(nameof(utilityService));
            _dataAccessUtilityService = dataAccessUtilityService ?? throw new ArgumentNullException(nameof(dataAccessUtilityService));
            _endOfShiftReportService = endOfShiftReportService ?? throw new ArgumentNullException(nameof(endOfShiftReportService));
            _converterService = converterService ?? throw new ArgumentNullException(nameof(converterService));
            _emailService = emailService ?? throw new ArgumentNullException(nameof(emailService));
        }
        public async Task<List<DailyDepartmentKpiDto>> GetDailyKpiChart(DateTime startDateTime, DateTime endDateTime, string area)
        {
            //fetch data
            var production = await _productionService.GetProductionQueryable(new ProductionResourceParameter
            {
                StartDate = startDateTime,
                EndDate = endDateTime,
                Area = area
            })
                .GroupBy(x => new { x.ShiftDate, x.Area })
                .Select(x => new
                {
                    x.Key.Area,
                    x.Key.ShiftDate,
                    TotalProd = x.Sum(s => s.QtyProd)
                })
                .ToListAsync()
                .ConfigureAwait(false);

            var scrap = await _scrapService.GetScrap2Queryable(new ScrapResourceParameter
            {
                StartDate = startDateTime,
                EndDate = endDateTime,
                Area = area
            }).GroupBy(x => new { x.ShiftDate, x.Area })
                .Select(x => new
                {
                    x.Key.Area,
                    x.Key.ShiftDate,
                    TotalScrap = x.Sum(s => s.Qty)
                })
                .ToListAsync()
                .ConfigureAwait(false);

            var hxh = (await _productionService.DailyHxHTargetByArea(startDateTime, endDateTime, area).ConfigureAwait(false)).ToList();

            //get distinct dates
            var distinctShiftDates = production.Select(x => x.ShiftDate.ToDateTime()).Distinct().ToList();
            var distinctShiftDatesScrap = scrap.Select(x => x.ShiftDate.ToDateTime()).Distinct().ToList();
            var distinctShiftDatesTargets = hxh.Select(x => x.ShiftDate).Distinct().ToList();
            distinctShiftDates.AddRange(distinctShiftDatesScrap);
            distinctShiftDates.AddRange(distinctShiftDatesTargets);

            var shiftDates = distinctShiftDates.Select(x => x).Distinct().OrderBy(x => x).ToList();

            return shiftDates.Select(x =>
            {
                var shiftDate = x;

                var prodByDate = production.Where(s => s.ShiftDate == shiftDate).ToList();
                var scrapByDate = scrap.Where(s => s.ShiftDate == shiftDate).ToList();
                var hxhByDate = hxh.Where(s => s.ShiftDate == shiftDate).ToList();

                var areaByDate = prodByDate.FirstOrDefault()?.Area;
                var totalProd = prodByDate.Sum(s => s.TotalProd ?? 0);
                var totalAreaScrap = scrapByDate.Sum(s => s.TotalScrap ?? 0);
                var target = hxhByDate.Sum(s => s.Target);
                var hxhGross = hxhByDate.Sum(s => s.Gross);
                var hxhNet = hxhByDate.Sum(s => s.Net);

                var sapGross = totalAreaScrap + totalProd;
                var sapOae = Math.Round((target == 0 ? 0 : totalProd / (decimal)target), 5);
                var scrapRate = Math.Round((sapGross == 0 ? 0 : totalAreaScrap / (decimal)sapGross), 5);
                var downtimeRate = 1 - sapOae - scrapRate;
                downtimeRate = downtimeRate < 0 ? 0 : downtimeRate;

                return new DailyDepartmentKpiDto
                {
                    Area = areaByDate,
                    ShiftDate = shiftDate,
                    TotalProduction = totalProd,
                    TotalAreaScrap = totalAreaScrap,
                    Target = target,
                    SapGross = sapGross,
                    SapOae = sapOae,
                    ScrapRate = scrapRate,
                    DowntimeRate = downtimeRate,
                    HxHGross = hxhGross,
                    HxHNet = hxhNet
                };
            })
            .OrderBy(x => x.ShiftDate)
            .ToList();
        }

        private IEnumerable<ProductionByLineDto> GetDepartmentDetailsByLine(
            List<Scrap> scrap,
            List<SapProdDetailDto> prod,
            List<HxHProductionByLineDto> hxh,
            IEnumerable<Scrap> warmers,
            IEnumerable<SwotTargetWithDeptId> lineTargets,
            DateTime startDate, DateTime endDate)
        {
            if (scrap == null) throw new ArgumentNullException(nameof(scrap));
            if (prod == null) throw new ArgumentNullException(nameof(prod));
            if (hxh == null) throw new ArgumentNullException(nameof(hxh));
            if (warmers == null) throw new ArgumentNullException(nameof(warmers));
            if (lineTargets == null) throw new ArgumentNullException(nameof(lineTargets));

            //distinct lines
            var scrapLines = scrap.Select(x => x.Line).Distinct();
            var sapProdLine = prod.Select(x => x.Line).Distinct();
            var hxhLine = hxh.Select(x => x.Line).Distinct();
            var distinctLines = (scrapLines.Concat(sapProdLine).Concat(hxhLine)).Distinct();

            var targets = lineTargets.Select(x => new
            {
                Line = x.Line2,
                x.OaeTarget,
                x.FoundryScrapTarget,
                x.MachineScrapTarget,
                x.AfScrapTarget,
            }).ToList();

            var scrapByLine = scrap
                                .GroupBy(x => new { x.Department, x.Area, x.Line, x.ScrapAreaName, x.ScrapCode, x.ScrapDesc, x.IsPurchashedExclude, x.IsPurchashedExclude2 })
                                .Select(x => new Scrap
                                {
                                    Department = x.Key.Department,
                                    Area = x.Key.Area,
                                    Line = x.Key.Line,
                                    ScrapAreaName = x.Key.ScrapAreaName,
                                    ScrapCode = x.Key.ScrapCode,
                                    ScrapDesc = x.Key.ScrapDesc,
                                    IsPurchashedExclude = x.Key.IsPurchashedExclude,
                                    IsPurchashedExclude2 = x.Key.IsPurchashedExclude2,
                                    Qty = x.Sum(s => s.Qty),
                                    StartDate = startDate,
                                    EndDate = endDate
                                })
                                .OrderByDescending(x => x.Qty)
                                .ToList();

            var warmersByLine = warmers
                                .GroupBy(x => new { x.Department, x.Area, x.Line, x.ScrapAreaName, x.ScrapCode, x.ScrapDesc, x.IsPurchashedExclude, x.IsPurchashedExclude2 })
                                .Select(x => new Scrap
                                {
                                    Department = x.Key.Department,
                                    Area = x.Key.Area,
                                    Line = x.Key.Line,
                                    ScrapAreaName = x.Key.ScrapAreaName,
                                    ScrapCode = x.Key.ScrapCode,
                                    ScrapDesc = x.Key.ScrapDesc,
                                    IsPurchashedExclude = x.Key.IsPurchashedExclude,
                                    IsPurchashedExclude2 = x.Key.IsPurchashedExclude2,
                                    Qty = x.Sum(s => s.Qty),
                                    StartDate = startDate,
                                    EndDate = endDate
                                })
                                .OrderByDescending(x => x.Qty)
                                .ToList();

            var sbScrap = scrapByLine.Where(x => x.IsPurchashedExclude == false).ToList();
            var purchasedScrap = scrapByLine.Where(x => x.IsPurchashedExclude).ToList();
            var afScrap = scrapByLine
                            .Where(x => x.IsPurchashedExclude == false && _utilityService.GetAssemblyFinishingScrapAreaNames().Contains(x.ScrapAreaName))
                            .ToList();

            //details
            var result = distinctLines.Select(line =>
                {
                    //hxh
                    var hxhByLine = hxh.FirstOrDefault(x => string.Equals(x.Line.Trim(), line.Trim(), StringComparison.OrdinalIgnoreCase));
                    var dept = hxhByLine?.Department ?? "";
                    var area = hxhByLine?.Area ?? "";
                    var target = hxhByLine?.Target ?? 0;
                    var hxhGross = hxhByLine?.GrossWithWarmers ?? 0;

                    //targets
                    var lineTarget = targets.FirstOrDefault(x => string.Equals(x.Line.Trim(), line.Trim(), StringComparison.OrdinalIgnoreCase));
                    var oaeTarget = lineTarget?.OaeTarget ?? 0;
                    var foundryScrapTarget = lineTarget?.FoundryScrapTarget ?? 0;
                    var machiningScrapTarget = lineTarget?.MachineScrapTarget ?? 0;
                    var afScrapTarget = lineTarget?.AfScrapTarget ?? 0;

                    //scrap
                    var totalScrap = scrapByLine.Where(x => x.Line == line).Sum(s => s.Qty);
                    var totalSbScrap = sbScrap.Where(x => x.Line == line).Sum(s => s.Qty);
                    var totalPurchaseScrap = purchasedScrap.Where(x => x.Line == line).Sum(s => s.Qty);
                    var totalAfScrap = afScrap.Where(x => x.Line == line).Sum(s => s.Qty);
                    var totalWarmers = warmersByLine.Where(x => x.Line == line).Sum(s => s.Qty);
                    var scrapDetails = sbScrap.Where(x => x.Line == line).ToList();
                    var purchasedScrapDetails = purchasedScrap.Where(x => x.Line == line).ToList();

                    //net, oae
                    var hxhNet = hxhByLine?.Net ?? 0;
                    var hxhOae = target == 0 ? 0 : hxhNet / target;
                    var sapNet = prod.Where(x => x.Line == line).Sum(s => s.SapNet);
                    var sapNetDetails = prod.Where(x => x.Line == line).OrderBy(x => x.DateScanned).ToList();
                    var sapOae = target == 0 ? 0 : sapNet / target;

                    //scrap rates
                    var sapGross = sapNet + totalScrap;
                    var totalScrapRate = sapGross > 0 ? (decimal)totalScrap / sapGross : 0;
                    var totalSbScrapRate = sapGross > 0 ? (decimal)totalSbScrap / sapGross : 0;
                    var totalPurchaseScrapRate = sapGross > 0 ? (decimal)totalPurchaseScrap / sapGross : 0;
                    var totalAfScrapRate = sapGross > 0 ? (decimal)totalAfScrap / sapGross : 0;

                    var sbAreaScrapDetails = sbScrap
                        .Where(s => s.Line == line)
                        .GroupBy(s => new { s.Area, s.ScrapAreaName, s.IsPurchashedExclude2 })
                        .Select(s =>
                        {
                            var scrapQty = s.Sum(q => q.Qty);
                            var scrapRate = sapGross == 0 ? 0 : (decimal)scrapQty / sapGross;
                            return new ScrapByCodeDetailsDto
                            {
                                Area = s.Key.Area,
                                ScrapType = s.Key.IsPurchashedExclude2,
                                ScrapAreaName = s.Key.ScrapAreaName,
                                Qty = scrapQty,
                                SapGross = sapGross,
                                ScrapRate = scrapRate,
                                Details = scrap
                                    .Where(d => d.IsPurchashedExclude == false && d.Line == line && d.ScrapAreaName == s.Key.ScrapAreaName)
                                    .GroupBy(d => new { d.Department, d.Area, d.ScrapAreaName, d.ScrapCode, d.ScrapDesc, d.IsPurchashedExclude2 })
                                    .Select(d => new Scrap
                                    {
                                        Department = d.Key.Department,
                                        Area = d.Key.Area,
                                        Line = line,
                                        ScrapAreaName = d.Key.ScrapAreaName,
                                        IsPurchashedExclude2 = d.Key.IsPurchashedExclude2,
                                        ScrapCode = d.Key.ScrapCode,
                                        ScrapDesc = d.Key.ScrapDesc,
                                        Qty = d.Sum(q => q.Qty),
                                        StartDate = startDate,
                                        EndDate = endDate
                                    })
                                    .OrderByDescending(d => d.Qty)
                            };
                        }).ToList();

                    return new ProductionByLineDto
                    {
                        Department = dept,
                        Area = area,
                        Line = line,
                        Target = target.ToInt(),

                        HxHGross = hxhGross,
                        HxHNet = hxhNet,
                        HxHOae = hxhOae,

                        OaeTarget = oaeTarget,
                        FoundryScrapRateTarget = foundryScrapTarget,
                        MachiningScrapRateTarget = machiningScrapTarget,
                        AfScrapRateTarget = afScrapTarget,

                        SapGross = sapGross,
                        SapNet = sapNet,
                        SapOae = sapOae,
                        SapNetDetails = sapNetDetails,

                        TotalScrap = totalScrap,
                        TotalSbScrap = totalSbScrap,
                        TotalPurchaseScrap = totalPurchaseScrap,
                        TotalAfScrap = totalAfScrap,
                        TotalWarmers = totalWarmers,
                        SbScrapDetails = scrapDetails,
                        PurchaseScrapDetails = purchasedScrapDetails,

                        TotalScrapRate = totalScrapRate,
                        TotalSbScrapRate = totalSbScrapRate,
                        TotalPurchaseScrapRate = totalPurchaseScrapRate,
                        TotalAfScrapRate = totalAfScrapRate,

                        SbScrapAreaDetails = sbScrap.Any(s => s.Line == line) ? sbAreaScrapDetails : new List<ScrapByCodeDetailsDto>()
                    };

                });

            return result.OrderBy(x => x.Line).ToList();
        }

        private static IEnumerable<ProductionByProgramDto> GetDepartmentDetailsByProgram(
            List<Scrap> scrap,
            List<Scrap> warmers,
            List<SapProdDetailDto> prod,
            List<HxhProductionByProgramDto> hxh,
            DateTime startDate, DateTime endDate)
        {
            if (scrap == null) throw new ArgumentNullException(nameof(scrap));
            if (prod == null) throw new ArgumentNullException(nameof(prod));
            if (hxh == null) throw new ArgumentNullException(nameof(hxh));

            //distinct program
            var scrapProgram = scrap.Select(x => x.Program).Distinct();
            var sapProdProgram = prod.Select(x => x.Program).Distinct();
            var hxhProgram = hxh.Select(x => x.Program).Distinct();
            var distinctProgram = (scrapProgram.Concat(sapProdProgram).Concat(hxhProgram)).Distinct();

            //transform data
            var scrapByProgram = scrap
                                .GroupBy(x => new { x.Department, x.Area, x.Program, x.ScrapAreaName, x.ScrapCode, x.ScrapDesc, x.IsPurchashedExclude, x.IsPurchashedExclude2 })
                                .Select(x => new Scrap
                                {
                                    Department = x.Key.Department,
                                    Area = x.Key.Area,
                                    Program = x.Key.Program,
                                    ScrapAreaName = x.Key.ScrapAreaName,
                                    ScrapCode = x.Key.ScrapCode,
                                    ScrapDesc = x.Key.ScrapDesc,
                                    IsPurchashedExclude = x.Key.IsPurchashedExclude,
                                    IsPurchashedExclude2 = x.Key.IsPurchashedExclude2,
                                    Qty = x.Sum(s => s.Qty),
                                    StartDate = startDate,
                                    EndDate = endDate
                                })
                                .OrderByDescending(x => x.Qty)
                                .ToList();

            var sbScrap = scrapByProgram.Where(x => x.IsPurchashedExclude == false).ToList();
            var purchasedScrap = scrapByProgram.Where(x => x.IsPurchashedExclude).ToList();

            //details
            var result = distinctProgram.Select(program =>
                {
                    //hxh
                    var hxhByProgram = hxh.FirstOrDefault(x => x.Program == program);
                    var dept = hxhByProgram?.Department ?? "";
                    var area = hxhByProgram?.Area ?? "";
                    var target = hxhByProgram?.Target ?? 0;
                    var hxhGross = hxhByProgram?.GrossWithWarmers ?? 0;

                    //scrap
                    var totalWarmers = warmers.Where(x => x.Program == program).Sum(s => s.Qty);
                    var totalScrap = scrapByProgram.Where(x => x.Program == program).Sum(s => s.Qty);
                    var totalSbScrap = sbScrap.Where(x => x.Program == program).Sum(s => s.Qty);
                    var totalPurchaseScrap = purchasedScrap.Where(x => x.Program == program).Sum(s => s.Qty);
                    var sbScrapDetails = sbScrap.Where(x => x.Program == program).ToList();
                    var purchaseScrapDetails = purchasedScrap.Where(x => x.Program == program).ToList();

                    //net
                    var sapNet = prod.Where(x => x.Program == program).Sum(s => s.SapNet);
                    var sapNetDetails = prod.Where(x => x.Program == program).OrderBy(x => x.DateScanned).ToList();

                    var hxhNet = hxhByProgram?.Net ?? 0;
                    var hxhOae = target == 0 ? 0 : hxhNet / target;

                    var sapOae = target == 0 ? 0 : sapNet / target;

                    //scrap rates
                    var sapGross = sapNet + totalScrap;
                    var totalScrapRate = sapGross > 0 ? (decimal)totalScrap / sapGross : 0;
                    var totalSbScrapRate = sapGross > 0 ? (decimal)totalSbScrap / sapGross : 0;

                    var sbScrapAreaDetails = sbScrap
                        .Where(s => s.Program == program)
                        .GroupBy(s => new { s.Area, s.ScrapAreaName, s.IsPurchashedExclude2 })
                        .Select(s => new ScrapByCodeDetailsDto
                        {
                            Area = s.Key.Area,
                            ScrapType = s.Key.IsPurchashedExclude2,
                            ScrapAreaName = s.Key.ScrapAreaName,
                            Qty = s.Sum(q => q.Qty),
                            SapGross = sapGross,
                            ScrapRate = sapGross == 0 ? 0 : (decimal)s.Sum(q => q.Qty) / sapGross,

                            Details = scrap
                                .Where(d => d.IsPurchashedExclude == false && d.Program == program &&
                                            d.ScrapAreaName == s.Key.ScrapAreaName)
                                .GroupBy(d => new
                                {
                                    d.Department,
                                    d.Area,
                                    d.ScrapAreaName,
                                    d.ScrapCode,
                                    d.ScrapDesc,
                                    d.IsPurchashedExclude2
                                })
                                .Select(d => new Scrap
                                {
                                    Department = d.Key.Department,
                                    Area = d.Key.Area,
                                    Program = program,
                                    ScrapAreaName = d.Key.ScrapAreaName,
                                    IsPurchashedExclude2 = d.Key.IsPurchashedExclude2,
                                    ScrapCode = d.Key.ScrapCode,
                                    ScrapDesc = d.Key.ScrapDesc,
                                    Qty = d.Sum(q => q.Qty),
                                    StartDate = startDate,
                                    EndDate = endDate
                                })
                                .OrderByDescending(d => d.Qty)
                        }).ToList();

                    return new ProductionByProgramDto
                    {
                        Department = dept,
                        Area = area,
                        Program = program,
                        Target = target.ToInt(),

                        HxHGross = hxhGross,
                        HxHNet = hxhNet,
                        HxHOae = hxhOae,

                        SapGross = sapGross,
                        SapNet = sapNet,
                        SapOae = sapOae,
                        SapNetDetails = sapNetDetails,

                        TotalWarmers = totalWarmers,
                        TotalScrap = totalScrap,
                        TotalSbScrap = totalSbScrap,
                        TotalPurchaseScrap = totalPurchaseScrap,
                        SbScrapDetails = sbScrapDetails,
                        PurchaseScrapDetails = purchaseScrapDetails,

                        TotalScrapRate = totalScrapRate,
                        TotalSbScrapRate = totalSbScrapRate,
                        TotalPurchaseScrapRate = totalSbScrapRate,

                        SbScrapAreaDetails = sbScrap.Any(s => s.Program == program) ? sbScrapAreaDetails : new List<ScrapByCodeDetailsDto>()
                    };

                });

            return result.OrderBy(x => x.Program).ToList();
        }

        private static IEnumerable<ProductionByProgramLineDto> GetdepartmentDetailsByProgramByLine(
            List<Scrap> scrap,
            List<Scrap> warmers,
            List<SapProdDetailDto> prod,
            List<HxhProductionByProgramLineDto> hxh,
            DateTime startDate, DateTime endDate)
        {
            if (scrap == null) throw new ArgumentNullException(nameof(scrap));
            if (prod == null) throw new ArgumentNullException(nameof(prod));
            if (hxh == null) throw new ArgumentNullException(nameof(hxh));

            //distinct program
            var scrapProgramLine = scrap.Select(x => new { x.Program, x.Line }).Distinct();
            var sapProdProgramLine = prod.Select(x => new { x.Program, x.Line }).Distinct();
            var hxhProgramLine = hxh.Select(x => new { x.Program , x.Line }).Distinct();

            var distinctProgramLine = (scrapProgramLine.Concat(sapProdProgramLine).Concat(hxhProgramLine)).Distinct();

            //transform data
            var scrapByProgramLine = scrap
                                .GroupBy(x => new
                                {
                                    x.Department,
                                    x.Area,
                                    x.Program,
                                    x.Line,
                                    x.ScrapAreaName,
                                    x.ScrapCode,
                                    x.ScrapDesc,
                                    x.IsPurchashedExclude,
                                    x.IsPurchashedExclude2
                                })
                                .Select(x => new Scrap
                                {
                                    Department = x.Key.Department,
                                    Area = x.Key.Area,
                                    Program = x.Key.Program,
                                    Line = x.Key.Line,
                                    ScrapAreaName = x.Key.ScrapAreaName,
                                    ScrapCode = x.Key.ScrapCode,
                                    ScrapDesc = x.Key.ScrapDesc,
                                    IsPurchashedExclude = x.Key.IsPurchashedExclude,
                                    IsPurchashedExclude2 = x.Key.IsPurchashedExclude2,
                                    Qty = x.Sum(s => s.Qty),
                                    StartDate = startDate,
                                    EndDate = endDate
                                })
                                .OrderByDescending(x => x.Qty)
                                .ToList();

            var sbScrap = scrapByProgramLine.Where(x => x.IsPurchashedExclude == false).ToList();
            var purchasedScrap = scrapByProgramLine.Where(x => x.IsPurchashedExclude).ToList();

            //details
            var result = distinctProgramLine.Select(programLine =>
            {
                //hxh
                var hxhByProgram = hxh.FirstOrDefault(x => x.Program == programLine.Program && x.Line == programLine.Line);
                var dept = hxhByProgram?.Department ?? "";
                var area = hxhByProgram?.Area ?? "";
                var target = hxhByProgram?.Target ?? 0;
                var hxhGross = hxhByProgram?.GrossWithWarmers ?? 0;

                //scrap
                var totalWarmers = warmers.Where(x => x.Program == programLine.Program && x.Line == programLine.Line).Sum(s => s.Qty);
                var totalScrap = scrapByProgramLine.Where(x => x.Program == programLine.Program && x.Line == programLine.Line).Sum(s => s.Qty);
                var totalSbScrap = sbScrap.Where(x => x.Program == programLine.Program && x.Line == programLine.Line).Sum(s => s.Qty);
                var totalPurchaseScrap = purchasedScrap.Where(x => x.Program == programLine.Program && x.Line == programLine.Line).Sum(s => s.Qty);
                var sbScrapDetails = sbScrap.Where(x => x.Program == programLine.Program && x.Line == programLine.Line).ToList();
                var purchaseScrapDetails = purchasedScrap.Where(x => x.Program == programLine.Program && x.Line == programLine.Line).ToList();

                //net
                var sapNet = prod.Where(x => x.Program == programLine.Program && x.Line == programLine.Line).Sum(s => s.SapNet);
                var sapNetDetails = prod.Where(x => x.Program == programLine.Program && x.Line == programLine.Line).OrderBy(x => x.DateScanned).ToList();

                var hxhNet = hxhByProgram?.Net ?? 0;
                var hxhOae = target == 0 ? 0 : hxhNet / target;

                var sapOae = target == 0 ? 0 : sapNet / target;

                //scrap rates
                var sapGross = sapNet + totalScrap;
                var totalScrapRate = sapGross > 0 ? (decimal)totalScrap / sapGross : 0;
                var totalSbScrapRate = sapGross > 0 ? (decimal)totalSbScrap / sapGross : 0;

                var sbScrapAreaDetails = sbScrap
                    .Where(s => s.Program == programLine.Program && s.Line == programLine.Line)
                    .GroupBy(s => new { s.Area, s.ScrapAreaName, s.IsPurchashedExclude2 })
                    .Select(s => new ScrapByCodeDetailsDto
                    {
                        Area = s.Key.Area,
                        ScrapType = s.Key.IsPurchashedExclude2,
                        ScrapAreaName = s.Key.ScrapAreaName,
                        Qty = s.Sum(q => q.Qty),
                        SapGross = sapGross,
                        ScrapRate = sapGross == 0 ? 0 : (decimal)s.Sum(q => q.Qty) / sapGross,

                        Details = scrap
                            .Where(d => d.IsPurchashedExclude == false && d.Program == programLine.Program && d.Line == programLine.Line && d.ScrapAreaName == s.Key.ScrapAreaName)
                            .GroupBy(d => new
                            {
                                d.Department,
                                d.Area,
                                d.ScrapAreaName,
                                d.ScrapCode,
                                d.ScrapDesc,
                                d.IsPurchashedExclude2
                            })
                            .Select(d => new Scrap
                            {
                                Department = d.Key.Department,
                                Area = d.Key.Area,
                                Program = programLine.Program,
                                Line = programLine.Line,
                                ScrapAreaName = d.Key.ScrapAreaName,
                                IsPurchashedExclude2 = d.Key.IsPurchashedExclude2,
                                ScrapCode = d.Key.ScrapCode,
                                ScrapDesc = d.Key.ScrapDesc,
                                Qty = d.Sum(q => q.Qty),
                                StartDate = startDate,
                                EndDate = endDate
                            })
                            .OrderByDescending(d => d.Qty)
                    }).ToList();

                return new ProductionByProgramLineDto
                {
                    Department = dept,
                    Area = area,
                    Program = programLine.Program,
                    Line = programLine.Line,
                    Target = target.ToInt(),

                    HxHGross = hxhGross,
                    HxHNet = hxhNet,
                    HxHOae = hxhOae,

                    SapGross = sapGross,
                    SapNet = sapNet,
                    SapOae = sapOae,
                    SapNetDetails = sapNetDetails,

                    TotalWarmers = totalWarmers,
                    TotalScrap = totalScrap,
                    TotalSbScrap = totalSbScrap,
                    TotalPurchaseScrap = totalPurchaseScrap,
                    SbScrapDetails = sbScrapDetails,
                    PurchaseScrapDetails = purchaseScrapDetails,

                    TotalScrapRate = totalScrapRate,
                    TotalSbScrapRate = totalSbScrapRate,
                    TotalPurchaseScrapRate = totalSbScrapRate,

                    SbScrapAreaDetails = sbScrap.Any(s => s.Program == programLine.Program && s.Line == programLine.Line) ? sbScrapAreaDetails : new List<ScrapByCodeDetailsDto>()
                };

            });

            return result
                .OrderBy(x => x.Line)
                .ThenBy(x => x.Program)
                .ToList();
        }

        private static IEnumerable<ProductionByShiftDto> GetDepartmentDetailsByShift(
            List<Scrap> scrap,
            List<Scrap> warmers,
            List<SapProdDetailDto> prod,
            List<HxHProductionByShiftDto> hxh,
            DateTime startDate, DateTime endDate)
        {
            if (scrap == null) throw new ArgumentNullException(nameof(scrap));
            if (prod == null) throw new ArgumentNullException(nameof(prod));
            if (hxh == null) throw new ArgumentNullException(nameof(hxh));

            //distinct program
            var scrapShift = scrap.Select(x => x.Shift).Distinct();
            var sapProdShift = prod.Select(x => x.Shift).Distinct();
            var hxhShift = hxh.Select(x => x.Shift).Distinct();
            var distinctShift = (scrapShift.Concat(sapProdShift).Concat(hxhShift)).Distinct().OrderBy(x => x);

            //transform data
            var scrapByShift = scrap
                                .GroupBy(x => new { x.Department, x.Area, x.Shift, x.ScrapAreaName, x.ScrapCode, x.ScrapDesc, x.IsPurchashedExclude, x.IsPurchashedExclude2 })
                                .Select(x => new Scrap
                                {
                                    Department = x.Key.Department,
                                    Area = x.Key.Area,
                                    Shift = x.Key.Shift,
                                    ScrapAreaName = x.Key.ScrapAreaName,
                                    ScrapCode = x.Key.ScrapCode,
                                    ScrapDesc = x.Key.ScrapDesc,
                                    IsPurchashedExclude = x.Key.IsPurchashedExclude,
                                    IsPurchashedExclude2 = x.Key.IsPurchashedExclude2,
                                    Qty = x.Sum(s => s.Qty),
                                    StartDate = startDate,
                                    EndDate = endDate
                                })
                                .OrderByDescending(x => x.Qty)
                                .ToList();

            var sbScrap = scrapByShift.Where(x => x.IsPurchashedExclude == false).ToList();
            var purchasedScrap = scrapByShift.Where(x => x.IsPurchashedExclude).ToList();

            //details
            var result = distinctShift.Select(shift =>
            {
                //hxh
                var hxhByShift = hxh.Where(x => x.Shift == shift).ToList();
                var dept = hxhByShift.FirstOrDefault()?.Department ?? "";
                var area = hxhByShift.FirstOrDefault()?.Area ?? "";
                var target = hxhByShift.Sum(t => t.Target);
                var hxhGross = hxhByShift.Sum(t => t.GrossWithWarmers);

                //scrap
                var totalWarmers = warmers.Where(x => x.Shift == shift).Sum(s => s.Qty);
                var totalScrap = scrapByShift.Where(x => x.Shift == shift).Sum(s => s.Qty);
                var totalSbScrap = sbScrap.Where(x => x.Shift == shift).Sum(s => s.Qty);
                var totalPurchaseScrap = purchasedScrap.Where(x => x.Shift == shift).Sum(s => s.Qty);
                var sbScrapDetails = sbScrap.Where(x => x.Shift == shift).ToList();
                var purchaseScrapDetails = purchasedScrap.Where(x => x.Shift == shift).ToList();

                //net
                var sapNet = prod.Where(x => x.Shift == shift).Sum(s => s.SapNet);
                var sapNetDetails = prod.Where(x => x.Shift == shift).OrderBy(x => x.DateScanned).ToList();

                var hxhNet = hxhByShift.Sum(t => t.Net);
                var hxhOae = target == 0 ? 0 : hxhNet / target;
                var sapOae = target == 0 ? 0 : sapNet / target;

                //scrap rates
                var sapGross = sapNet + totalScrap;
                var totalScrapRate = sapGross > 0 ? (decimal)totalScrap / sapGross : 0;
                var totalSbScrapRate = sapGross > 0 ? (decimal)totalSbScrap / sapGross : 0;

                var sbScrapAreaDetails = sbScrap
                    .Where(s => s.Shift == shift)
                    .GroupBy(s => new { s.Area, s.ScrapAreaName, s.IsPurchashedExclude2 })
                    .Select(s => new ScrapByCodeDetailsDto
                    {
                        Area = s.Key.Area,
                        ScrapType = s.Key.IsPurchashedExclude2,
                        ScrapAreaName = s.Key.ScrapAreaName,
                        Qty = s.Sum(q => q.Qty),
                        SapGross = sapGross,
                        ScrapRate = sapGross == 0 ? 0 : (decimal)s.Sum(q => q.Qty) / sapGross,

                        Details = scrap
                            .Where(d => d.IsPurchashedExclude == false && d.Shift == shift && d.ScrapAreaName == s.Key.ScrapAreaName)
                            .GroupBy(d => new
                            {
                                d.Department,
                                d.Area,
                                d.ScrapAreaName,
                                d.ScrapCode,
                                d.ScrapDesc,
                                d.IsPurchashedExclude2
                            })
                            .Select(d => new Scrap
                            {
                                Department = d.Key.Department,
                                Area = d.Key.Area,
                                Shift = shift,
                                ScrapAreaName = d.Key.ScrapAreaName,
                                IsPurchashedExclude2 = d.Key.IsPurchashedExclude2,
                                ScrapCode = d.Key.ScrapCode,
                                ScrapDesc = d.Key.ScrapDesc,
                                Qty = d.Sum(q => q.Qty),
                                StartDate = startDate,
                                EndDate = endDate
                            })
                            .OrderByDescending(d => d.Qty)
                    }).ToList();

                return new ProductionByShiftDto
                {
                    Department = dept,
                    Area = area,
                    Shift = shift,
                    Target = target.ToInt(),

                    HxHGross = hxhGross,
                    HxHNet = hxhNet,
                    HxHOae = hxhOae,

                    SapGross = sapGross,
                    SapNet = sapNet,
                    SapOae = sapOae,
                    SapNetDetails = sapNetDetails,

                    TotalWarmers = totalWarmers,
                    TotalScrap = totalScrap,
                    TotalSbScrap = totalSbScrap,
                    TotalPurchaseScrap = totalPurchaseScrap,
                    SbScrapDetails = sbScrapDetails,
                    PurchaseScrapDetails = purchaseScrapDetails,

                    TotalScrapRate = totalScrapRate,
                    TotalSbScrapRate = totalSbScrapRate,
                    TotalPurchaseScrapRate = totalSbScrapRate,

                    SbScrapAreaDetails = sbScrap.Any(s => s.Shift == shift) ? sbScrapAreaDetails : new List<ScrapByCodeDetailsDto>()
                };

            });

            return result.OrderBy(x => x.Shift).ToList();
        }

        public async Task<DepartmentDetailsDto> GetDepartmentDetails(SapResourceParameter parameters)
        {
            var dept = _utilityService.MapAreaToDepartment(parameters.Area);

            //production
            var sapProdData = await _productionService.GetProductionQueryable(new ProductionResourceParameter
            {
                StartDate = parameters.Start,
                EndDate = parameters.End,
                Area = parameters.Area,
                Shift = parameters.Shift
            })
                .GroupBy(x => new { x.LocalDateTime, x.ShiftDate, x.Shift, x.Program, x.Material, x.MachineHxh, x.EnteredUser })
                .Select(x => new SapProdDetailDto
                {
                    DateScanned = (DateTime)x.Key.LocalDateTime,
                    ShiftDate = (DateTime)x.Key.ShiftDate,
                    Shift = x.Key.Shift,
                    Line = x.Key.MachineHxh,
                    Program = x.Key.Program,
                    Part = x.Key.Material,
                    User = x.Key.EnteredUser,
                    SapNet = (int)x.Sum(s => s.QtyProd)
                })
                .ToListAsync()
                .ConfigureAwait(false);

            //scrap
            var scrapData = await _scrapService.GetScrap2Queryable(new ScrapResourceParameter
            {
                StartDate = parameters.Start,
                EndDate = parameters.End,
                Area = parameters.Area,
                Shift = parameters.Shift
            }, false)
                .Select(x => new Scrap
                {
                    Department = x.Department,
                    Shift = x.Shift,
                    Area = x.Area,
                    Line = x.MachineHxh,
                    Program = x.Program,
                    ScrapAreaName = x.ScrapAreaName,
                    ScrapCode = x.ScrapCode,
                    IsPurchashedExclude = (bool)x.IsPurchashedExclude,
                    IsPurchashedExclude2 = x.IsPurchashedExclude2,
                    ScrapDesc = x.ScrapDesc,
                    Qty = x.Qty ?? 0
                })
                .ToListAsync()
                .ConfigureAwait(false);

            //hxh production
            var hxhProductionData = await _productionService.GetHxhProdByLineProgramShift(
                parameters.Start, parameters.End, parameters.Area, parameters.Shift)
                .ConfigureAwait(false);

            //targets
            var lineTargets = await _kpiTargetService
                .GetLineTargets(dept)
                .ConfigureAwait(false);

            var deptTargets = await _kpiTargetService.GetDepartmentTargets(dept, parameters.Area, parameters.Start, parameters.End)
                .ConfigureAwait(false);

            //transform data
            var scrap = scrapData.Where(x => x.ScrapCode != "8888").ToList();
            var warmers = scrapData.Where(x => x.ScrapCode == "8888").ToList();

            //get total
            var target = hxhProductionData.LineDetails.Sum(x => Math.Round(x.Target, 0));
            var sapNet = sapProdData.Sum(x => x.SapNet);

            var totalWarmers = warmers.Sum(x => x.Qty);
            var totalScrap = scrap.Sum(x => x.Qty);
            var totalSbScrap = scrap.Where(x => x.IsPurchashedExclude == false).Sum(x => x.Qty);
            var totalPurchasedScrap = scrap.Where(x => x.IsPurchashedExclude == true).Sum(x => x.Qty);

            var sapGross = sapNet + totalScrap;

            var totalScrapRate = sapGross == 0 ? 0 : (decimal)totalScrap / sapGross;
            var totalSbScrapRate = sapGross == 0 ? 0 : (decimal)totalSbScrap / sapGross;
            var totalPurchasedScrapRate = sapGross == 0 ? 0 : (decimal)totalPurchasedScrap / sapGross;

            var sapOae = target == 0 ? 0 : (decimal)sapNet / target;

            var hxhGross = hxhProductionData.LineDetails.Sum(x => x.GrossWithWarmers);
            var hxhNet = hxhProductionData.LineDetails.Sum(x => x.Net);
            var hxhOae = target == 0 ? 0 : hxhNet / target;

            //get scrap area details scrap
            var scrapAreaDetails = scrap
                        .Where(s => s.IsPurchashedExclude == false)
                        .GroupBy(s => new { s.Area, s.ScrapAreaName, s.IsPurchashedExclude2 })
                        .Select(s =>
                        {
                            var qty = s.Sum(q => q.Qty);
                            var scrapRate = sapGross == 0 ? 0 : qty / (decimal)sapGross;

                            var details = scrap
                                .Where(d => d.IsPurchashedExclude == false && d.ScrapAreaName == s.Key.ScrapAreaName)
                                .GroupBy(d => new { d.Department, d.Area, d.ScrapAreaName, d.ScrapCode, d.ScrapDesc, d.IsPurchashedExclude2 })
                                .Select(d => new Scrap
                                {
                                    Department = d.Key.Department,
                                    Area = d.Key.Area,
                                    ScrapAreaName = d.Key.ScrapAreaName,
                                    IsPurchashedExclude2 = d.Key.IsPurchashedExclude2,
                                    ScrapCode = d.Key.ScrapCode,
                                    ScrapDesc = d.Key.ScrapDesc,
                                    Qty = d.Sum(q => q.Qty),
                                    StartDate = parameters.Start,
                                    EndDate = parameters.End
                                })
                                .OrderByDescending(d => d.Qty);

                            return new ScrapByCodeDetailsDto
                            {
                                Area = s.Key.Area,
                                ScrapType = s.Key.IsPurchashedExclude2,
                                ScrapAreaName = s.Key.ScrapAreaName,
                                Qty = qty,
                                SapGross = sapGross,
                                ScrapRate = scrapRate,
                                Details = details
                            };

                        }).ToList();

            //get area scrap by scrap code
            var scrapList = scrap
                .GroupBy(x => new { x.Department, x.Area, x.ScrapAreaName, x.ScrapCode, x.ScrapDesc, x.IsPurchashedExclude2, x.IsPurchashedExclude })
                .Select(x => new Scrap
                {
                    Department = x.Key.Department,
                    Area = x.Key.Area,
                    ScrapAreaName = x.Key.ScrapAreaName,
                    ScrapCode = x.Key.ScrapCode,
                    ScrapDesc = x.Key.ScrapDesc,
                    IsPurchashedExclude2 = x.Key.IsPurchashedExclude2,
                    IsPurchashedExclude = x.Key.IsPurchashedExclude,
                    Qty = x.Sum(s => s.Qty),
                    StartDate = parameters.Start,
                    EndDate = parameters.End
                })
                .OrderByDescending(x => x.Qty).ToList();

            //result
            return new DepartmentDetailsDto
            {
                Area = parameters.Area,
                Target = (int)Math.Round(target, 0),
                SapGross = sapGross,
                OaeTarget = deptTargets.OaeTarget / 100,
                SapNet = sapNet,
                SapOae = sapOae,
                HxhGross = hxhGross,
                HxHNet = hxhNet,
                HxHOae = hxhOae,
                TotalWarmers = totalWarmers,
                TotalScrap = totalScrap,
                TotalSbScrap = totalSbScrap,
                TotalPurchaseScrap = totalPurchasedScrap,
                TotalScrapRate = totalScrapRate,
                TotalSbScrapRate = totalSbScrapRate,
                TotalPurchaseScrapRate = totalPurchasedScrapRate,
                SbScrapAreaDetails = scrapAreaDetails,

                DetailsByLine = GetDepartmentDetailsByLine(scrap, sapProdData, hxhProductionData.LineDetails.ToList(), warmers, lineTargets, parameters.Start, parameters.End),
                DetailsByProgram = GetDepartmentDetailsByProgram(scrap, warmers, sapProdData, hxhProductionData.ProgramDetails.ToList(), parameters.Start, parameters.End),
                DetailsByProgramLine = GetdepartmentDetailsByProgramByLine(scrap, warmers, sapProdData, hxhProductionData.ProgramLineDetails.ToList(), parameters.Start, parameters.End),
                DetailsByShift = GetDepartmentDetailsByShift(scrap, warmers, sapProdData, hxhProductionData.LineShiftDetails.ToList(), parameters.Start, parameters.End),

                SbScrapDetails = scrapList.Where(s => s.IsPurchashedExclude == false),
                PurchaseScrapDetails = scrapList.Where(s => s.IsPurchashedExclude)
            };
        }

        private List<EndOfShiftScrapDetailDto> GetScrapDetails(IEnumerable<Scrap2> data, int sapGross, SwotTargetWithDeptId target)
        {
            return data
                .GroupBy(x => new { x.ScrapAreaName, x.MachineHxh })
                .Select(x => new EndOfShiftScrapDetailDto
                {
                    ScrapArea = x.Key.ScrapAreaName,
                    Qty = x.Sum(q => q.Qty ?? 0),
                    ScrapTargetRate = _kpiTargetService.GetScrapTarget(target, x.Key.ScrapAreaName),
                    ScrapRate = sapGross == 0 ? 0 : (decimal)x.Sum(q => q.Qty ?? 0) / sapGross,
                    Details = x.GroupBy(d => new { d.ScrapCode, d.ScrapAreaName, d.ScrapDesc, d.Department, d.Area, d.MachineHxh })
                        .Select(d => new Scrap
                        {
                            Department = d.Key.Department,
                            Area = d.Key.Area,
                            Line = d.Key.MachineHxh,
                            ScrapAreaName = d.Key.ScrapAreaName,
                            ScrapCode = d.Key.ScrapCode,
                            ScrapDesc = d.Key.ScrapDesc,
                            Qty = d.Sum(q => q.Qty ?? 0)
                        }).OrderByDescending(d => d.Qty).ToList()
                })
                .OrderByDescending(x => x.ScrapArea)
                .ToList();
        }

        private EndOfShiftDto MapEndOfShiftDto(
            List<Production2> production,
            List<Scrap2> scrap,
            HxHProductionByLineDto hxh,
            SwotTargetWithDeptId target,
            EndOfShiftReport eos,
            string dept, string shift, string hxhUrl, string line, int machineId, DateTime shiftDate)
        {
            var area = _utilityService.MapDepartmentToArea(dept);

            var oaeTarget = target?.OaeTarget ?? 0;
            var afScrapRateTarget = target?.AfScrapTarget ?? 0;
            var overallScrapRateTarget = target == null
                ? 0
                : target.FoundryScrapTarget + target.MachineScrapTarget + target.AfScrapTarget;

            var hxhTarget = hxh?.Target ?? 0;
            var hxhGross = hxh?.Gross ?? 0;
            var hxhNet = hxh?.Net ?? 0;


            var sbScrap = scrap.Where(x => x.IsPurchashedExclude == false).ToList();
            var purchasedScrap = scrap.Where(x => x.IsPurchashedExclude == true).ToList();
            var afScrap = scrap.Where(x => x.IsPurchashedExclude == false && _utilityService.GetAssemblyFinishingScrapAreaNames().Contains(x.ScrapAreaName)).ToList();

            var totalScrap = scrap.Sum(x => x.Qty ?? 0);
            var totalSbScrap = sbScrap.Sum(x => x.Qty ?? 0);
            var totalPurchasedScrap = purchasedScrap.Sum(x => x.Qty ?? 0);
            var totalAfScrap = afScrap.Sum(x => x.Qty ?? 0);

            //var hxhNet = (area.ToLower() == "foundry cell" || area.ToLower() == "machine line") ? hxhGross - totalScrap : hxhGross;
            var hxhOae = hxhTarget == 0 ? 0 : hxhNet / hxhTarget;
            var sapNet = production.Sum(x => x.QtyProd ?? 0);
            var sapGross = sapNet + totalScrap;
            var sapOae = hxhTarget == 0 ? 0 : sapNet / hxhTarget;

            var sBScrapDetails = GetScrapDetails(sbScrap, sapGross, target);

            var totalScrapRate = sapGross == 0 ? 0 : (decimal)totalScrap / sapGross;
            var totalSbScrapRate = sapGross == 0 ? 0 : (decimal)totalSbScrap / sapGross;
            var totalPurchasedScrapRate = sapGross == 0 ? 0 : (decimal)totalPurchasedScrap / sapGross;
            var totalAfScrapRate = sapGross == 0 ? 0 : (decimal)totalAfScrap / sapGross;

            var productionDetails = production.Select(x => new SapProdDetailDto
            {
                DateScanned = x.LocalDateTime.ToDateTime(),
                ShiftDate = x.ShiftDate.ToDateTime(),
                Shift = x.Shift,
                Line = x.WorkCenter,
                Program = x.Program,
                Part = x.Material,
                User = x.EnteredUser,
                SapNet = x.QtyProd ?? 0
            })
                .OrderBy(x => x.DateScanned)
                .ToList();

            return new EndOfShiftDto
            {
                Id = eos?.EndOfShiftReportId ?? 0,

                Department = dept.ToUpper(),
                Area = area.ToUpper(),

                Line = line.ToUpper(),
                MachineId = machineId,
                ShiftDate = shiftDate,
                Shift = shift,

                Target = hxhTarget,
                OaeTarget = oaeTarget,
                AfScrapRateTarget = afScrapRateTarget,
                OverallScrapRateTarget = overallScrapRateTarget,
                HxHGross = hxhGross,
                HxHNet = hxhNet,
                HxHOae = hxhOae,
                SapGross = sapGross,
                SapNet = sapNet,
                SapOae = sapOae,

                TotalScrap = totalScrap,
                TotalSbScrap = totalSbScrap,
                TotalPurchaseScrap = totalPurchasedScrap,
                TotalAfScrap = totalAfScrap,

                TotalScrapRate = totalScrapRate,
                TotalSbScrapRate = totalSbScrapRate,
                TotalPurchaseScrapRate = totalPurchasedScrapRate,
                TotalAfScrapRate = totalAfScrapRate,

                SbScrapDetails = sBScrapDetails,
                SbScrapDefects = _scrapService.GetScrapSummary(sbScrap, shiftDate, shiftDate),
                AfScrapDefects = _scrapService.GetScrapSummary(afScrap, shiftDate, shiftDate),
                TotalScrapDefects = _scrapService.GetScrapSummary(scrap, shiftDate, shiftDate),

                ProductionDetails = productionDetails,
                HxHUrl = hxhUrl,

                ScrapComment = eos?.ScrapComment,
                DowntimeComment = eos?.DowntimeComment,
                Manning = eos?.Manning,
                Ppmh = _utilityService.CalculatePpmh(hxhGross, eos?.Manning),

                TimeStamp = eos?.TimeStamp
            };
        }

        public async Task<EndOfShiftDto> GetEndOfShiftDto(string line, string dept, DateTime shiftDate, string shift)
        {
            if (line == null) throw new ArgumentNullException(nameof(line));
            if (dept == null) throw new ArgumentNullException(nameof(dept));
            if (shift == null) throw new ArgumentNullException(nameof(shift));

            var area = _utilityService.MapDepartmentToArea(dept);
            var machine = await _dataAccessUtilityService.GetMachine(new Machines { Line2 = line }).ConfigureAwait(false);
            var createHxh = await _dataAccessUtilityService.GerHourByHour(shiftDate, machine.MachineId, shift).ConfigureAwait(false);
            var hxhUrl = _utilityService.CreateHourByHourUrl(createHxh, machine) ?? "";

            if (machine == null) throw new OperationCanceledException("Line does not exist");

            //production
            var production = await _productionService.GetProductionQueryable(new ProductionResourceParameter
            {
                StartDate = shiftDate,
                EndDate = shiftDate,
                Area = area,
                Line = line,
                Shift = shift
            })
                .ToListAsync()
                .ConfigureAwait(false);

            //scrap
            var scrap = await _scrapService.GetScrap2Queryable(new ScrapResourceParameter
            {
                StartDate = shiftDate,
                EndDate = shiftDate,
                Area = area,
                Line = line,
                Shift = shift
            }, false)
                .ToListAsync()
                .ConfigureAwait(false);

            //hxh production
            var hxh = await _productionService.GetHourByHourProductionByLine(new ProductionResourceParameter
            {
                StartDate = shiftDate,
                EndDate = shiftDate,
                Line = line,
                Shift = shift,
                Area = area
            }, scrap).ConfigureAwait(false);

            //targets
            var target = await _kpiTargetService.GetSwotTarget(line).ConfigureAwait(false);

            //eos
            var eos = await _endOfShiftReportService.GetEos(shiftDate, shift, machine.MachineId).ConfigureAwait(false);

            return MapEndOfShiftDto(production, scrap, hxh.FirstOrDefault(), target, eos, dept, shift, hxhUrl, line, machine.MachineId, shiftDate);
        }

        public async Task<List<EndOfShiftDto>> GetEndOfShiftListDto(string dept, DateTime shiftDate, string shift)
        {
            var area = _utilityService.MapDepartmentToArea(dept);

            //eos
            var eosData = await _endOfShiftReportService.GetEos(shiftDate, shift, dept).ConfigureAwait(false);

            if (eosData.Count == 0) return new List<EndOfShiftDto>();

            var machines = await _dataAccessUtilityService.GetMachines(eosData.Select(x => x.MachineId).ToList()).ConfigureAwait(false);

            //production
            var prodData = await _productionService.GetProductionQueryable(new ProductionResourceParameter
            {
                StartDate = shiftDate,
                EndDate = shiftDate,
                Area = area,
                Shift = shift,
                WorkCenters = machines.Select(x => x.Machine).ToList()
            })
                .ToListAsync()
                .ConfigureAwait(false);

            //scrap
            var scrapData = await _scrapService.GetScrap2Queryable(new ScrapResourceParameter
            {
                StartDate = shiftDate,
                EndDate = shiftDate,
                Area = area,
                Shift = shift,
                WorkCenters = machines.Select(x => x.Machine).ToList()
            }, false)
                .ToListAsync()
                .ConfigureAwait(false);

            //hxh production
            var hxhData = await _productionService.GetHourByHourProductionByLine(new ProductionResourceParameter
            {
                StartDate = shiftDate,
                EndDate = shiftDate,
                Shift = shift,
                Area = area,
                MachinesHxh = machines.Select(x => x.MachineHxh).ToList()
            }, scrapData).ConfigureAwait(false);

            //targets
            var targetData = await _kpiTargetService.GetSwotTargets(machines.Select(x => x.MachineHxh).ToList()).ConfigureAwait(false);

            //hxh views
            var createHxhData = await _dataAccessUtilityService.GetHxHs(shiftDate, shift, machines.Select(x => x.MachineId ?? 0).ToList()).ConfigureAwait(false);

            //transform data
            var res = eosData.Select(eos =>
            {
                var map = machines.FirstOrDefault(m => m.MachineId == eos.MachineId);

                var production = prodData.Where(p => p.WorkCenter == map.Machine).ToList();
                var scrap = scrapData.Where(s => s.WorkCenter == map.Machine).ToList();
                var hxh = hxhData.FirstOrDefault(h => h.Line == map.MachineHxh);
                var target = targetData.FirstOrDefault(t => t.Line2 == map.MachineHxh);
                var createHxh = createHxhData.FirstOrDefault(c => c.Machineid == map.MachineId);
                var hxhUrl = _utilityService.CreateHourByHourUrl(createHxh, map) ?? "";

                return MapEndOfShiftDto(production, scrap, hxh, target, eos, dept, shift, hxhUrl, map.MachineHxh, map.MachineId ?? 0, shiftDate);
            })
                .OrderBy(x => x.Line)
                .ToList();

            return res;
        }

        public async Task<EndOfShiftDto> GetOverallEosTotal(List<EndOfShiftDto> data, string dept, DateTime shiftDate, string shift)
        {
            var area = _utilityService.MapDepartmentToArea(dept);

            //kpi target
            var deptTargets = await _kpiTargetService.GetDepartmentTargets(dept, area, shiftDate, shiftDate).ConfigureAwait(false);
            var oaeTarget = deptTargets.OaeTarget / 100;
            var scrapTarget = deptTargets.ScrapRateTarget / 100;
            var ppmhTarget = deptTargets.PpmhTarget;

            //totals
            var target = data.Sum(x => x.Target);
            var hxhGross = data.Sum(x => x.HxHGross);
            var hxhNet = data.Sum(x => x.HxHNet);
            var hxhOae = target == 0 ? 0 : hxhNet / target;

            var sapGross = data.Sum(x => x.SapGross);
            var sapNet = data.Sum(x => x.SapNet);
            var sapOae = target == 0 ? 0 : sapNet / target;

            var sbScrap = data.Sum(x => x.TotalSbScrap);
            var purchasedScrap = data.Sum(x => x.TotalPurchaseScrap);
            var afScrap = data.Sum(x => x.TotalAfScrap);
            var overallScrap = data.Sum(x => x.TotalScrap);

            var sbScrapRate = sapGross == 0 ? 0 : (decimal)sbScrap / sapGross;
            var purchasedScrapRate = sapGross == 0 ? 0 : (decimal)purchasedScrap / sapGross;
            var afScrapRate = sapGross == 0 ? 0 : (decimal)afScrap / sapGross;
            var overallScrapRate = sapGross == 0 ? 0 : (decimal)overallScrap / sapGross;

            var manning = data.Sum(x => x.Manning);
            var ppmh = _utilityService.CalculatePpmh(hxhGross, manning);

            return new EndOfShiftDto
            {
                Department = dept,
                ShiftDate = shiftDate,
                Shift = shift,
                Target = target,
                OaeTarget = oaeTarget,

                PpmhTarget = ppmhTarget,

                HxHGross = hxhGross,
                HxHNet = hxhNet,
                HxHOae = hxhOae,
                SapGross = sapGross,
                SapNet = sapNet,
                SapOae = sapOae,
                TotalSbScrap = sbScrap,
                TotalPurchaseScrap = purchasedScrap,
                TotalAfScrap = afScrap,
                TotalScrap = overallScrap,
                TotalSbScrapRate = sbScrapRate,
                TotalPurchaseScrapRate = purchasedScrapRate,
                TotalAfScrapRate = afScrapRate,
                TotalScrapRate = overallScrapRate,
                Manning = manning,
                Ppmh = ppmh
            };
        }

        public async Task<dynamic> GetHourlyProduction(string dept, DateTime shiftDate, string shift)
        {
            var area = _utilityService.MapDepartmentToArea(dept);

            //scrap
            var scrapData = await _scrapService.GetScrap2Queryable(new ScrapResourceParameter
            {
                StartDate = shiftDate,
                EndDate = shiftDate,
                Area = area,
                Shift = shift
            }, false)
                .ToListAsync()
                .ConfigureAwait(false);

            //targets
            var targetData = await _kpiTargetService.GetSwotTargets(dept).ConfigureAwait(false);

            var hxh = await _productionService.GetHourByHourProductionByHour(new ProductionResourceParameter
            {
                StartDate = shiftDate,
                EndDate = shiftDate,
                Shift = shift,
                Area = area,
                Department = dept
            }, scrapData, targetData)
                .ConfigureAwait(false);

            var dataSet = hxh.Where(x => !x.IsCurrentHour).Select(x => new
            {
                x.ShiftDate,
                x.Shift,
                x.ShiftOrder,
                x.Department,
                x.Area,
                x.Line,
                x.CellSide,
                x.MachineId,
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
                x.TotalScrap,

                WarmersDefects = _scrapService.GetScrapSummary(x.WarmersDefects, shiftDate, shiftDate),
                SolDefects = _scrapService.GetScrapSummary(x.SolDefects, shiftDate, shiftDate),
                GageScrapDefects = _scrapService.GetScrapSummary(x.GageScrapDefects, shiftDate, shiftDate),
                VisualScrapDefects = _scrapService.GetScrapSummary(x.VisualScrapDefects, shiftDate, shiftDate),
                EolDefects = _scrapService.GetScrapSummary(x.EolDefects, shiftDate, shiftDate),
                TotalScrapDefects = _scrapService.GetScrapSummary(x.TotalScrapDefects, shiftDate, shiftDate),

                x.HxHUrl,
                x.IsCurrentHour
            })
                .OrderBy(x => x.MachineId)
                .ThenBy(x => x.CellSide)
                .ThenBy(x => x.ShiftDate)
                .ThenBy(x => x.ShiftOrder)
                .ThenBy(x => x.Hour)
                .ToList();

            var rows = dataSet.Select(x => new { x.MachineId, x.Line }).Distinct().OrderBy(x => x.MachineId).ToList();
            var columns = dataSet.Select(x => new { x.ShiftDate, x.Shift, x.ShiftOrder, x.Hour }).Distinct()
                .OrderBy(x => x.ShiftDate)
                .ThenBy(x => x.ShiftOrder)
                .ThenBy(x => x.Hour)
                .ToList();

            return new
            {
                dataSet,
                rows,
                columns
            };
        }

        public async Task<bool> SendEosReport(List<EndOfShiftDto> data, string dept, DateTime shiftDate, string shift)
        {
            var summaryList = new List<EndOfShiftDto>();
            var summaryData = await GetOverallEosTotal(data, dept, shiftDate, shift).ConfigureAwait(false);
            summaryList.Add(summaryData);

            if (!data.Any()) throw new OperationCanceledException($"No data available at {dept.ToUpper()}, Please enter data before sending report!");

            var lines = data.Select(x => new EndOfShiftEmailDto
            {
                Department = x.Department,
                Line = x.Line,
                Shift_Date = x.ShiftDate.ToShortDateString(),
                Shift = x.Shift,
                Target = $"{x.Target:##,###}",
                OAE_Target = $"{x.OaeTarget:P}",
                AF_Scrap_Target = $"{x.AfScrapRateTarget:P}",
                Overall_Scrap_Target = $"{x.OverallScrapRateTarget:P}",
                HxH_Gross = $"{x.HxHGross:##,###}",
                HxH_OAE = $"{x.HxHOae:P} ({x.HxHNet:##,###})",
                SAP_OAE = $"{x.SapOae:P} ({x.SapNet:##,###})",
                SB_Scrap = $"{x.TotalSbScrapRate:P} ({x.TotalSbScrap:##,###})",
                Purchased_Scrap = $"{x.TotalPurchaseScrapRate:P} ({x.TotalPurchaseScrap:##,###})",
                AF_Scrap = $"{x.TotalAfScrapRate:P} ({x.TotalAfScrap:##,###})",
                Overall_Scrap = $"{x.TotalScrapRate:P} ({x.TotalScrap:##,###})",
                Scrap_Comment = x.ScrapComment,
                Downtime_Comment = x.DowntimeComment,
                Manning = x.Manning,
                PPMH = x.Ppmh
            }).ToList();

            var summary = summaryList.Select(x => new EndOfShiftEmailSummaryDto
            {
                Department = x.Department.ToUpper(),
                Shift_Date = x.ShiftDate.ToShortDateString(),
                Shift = x.Shift,
                Target = $"{x.Target:##,###}",
                OAE_Target = $"{x.OaeTarget:P}",
                AF_Scrap_Target = $"{x.AfScrapRateTarget:P}",
                Overall_Scrap_Target = $"{x.OverallScrapRateTarget:P}",
                HxH_Gross = $"{x.HxHGross:##,###}",
                HxH_OAE = $"{x.HxHOae:P} ({x.HxHNet:##,###})",
                SAP_OAE = $"{x.SapOae:P} ({x.SapNet:##,###})",
                SB_Scrap = $"{x.TotalSbScrapRate:P} ({x.TotalSbScrap:##,###})",
                Purchased_Scrap = $"{x.TotalPurchaseScrapRate:P} ({x.TotalPurchaseScrap:##,###})",
                AF_Scrap = $"{x.TotalAfScrapRate:P} ({x.TotalAfScrap:##,###})",
                Overall_Scrap = $"{x.TotalScrapRate:P} ({x.TotalScrap:##,###})",
                Manning = x.Manning,
                PPMH = x.Ppmh
            }).ToList();

            var linesHtml = _converterService.ConvertToHtml(lines);
            var summaryHtml = _converterService.ConvertToHtml(summary);

            var sb = new StringBuilder();
            sb.Append($"<h1>{dept.ToUpper()} EOS REPORT: {shiftDate.ToShortDateString()} - {shift} Shift</h1>");
            sb.Append($"<h2><a href='http://10.129.224.149:82/af/eos?dept={dept}&date={shiftDate.ToShortDateString()}&shift={shift}'>Click here to view report</a></h2>");

            sb.Append("<h2>DEPARTMENT SUMMARY:</h>");
            sb.Append(summaryHtml);

            sb.Append("<h2>LINE SUMMARY:</h>");
            sb.Append(linesHtml);

            var sender = $"{dept.Replace(" ", "-").ToLower()}-eos@tenneco.com";
            var subject = $"{dept} End Of Shift Report - {shiftDate.ToShortDateString()} - {shift} Shift";
            var recipientsList = await _endOfShiftReportService.GetEosEmailRecipients(dept).ConfigureAwait(false);
            var recipients = string.Join(",", recipientsList.Select(x => x.Email));


            //recipients = "aebbie.rontos@tenneco.com";

            //await _emailService.SendEmailAsync(sender, recipients, subject, sb.ToString()).ConfigureAwait(false);
            _emailService.SendEmail(sender, recipients, subject, sb.ToString());

            return true;
        }

        public async Task<bool> SendEosReport(string dept, DateTime shiftDate, string shift)
        {
            var data = await GetEndOfShiftListDto(dept, shiftDate, shift).ConfigureAwait(false);
            return await SendEosReport(data, dept, shiftDate, shift).ConfigureAwait(false);
        }
    }
}
