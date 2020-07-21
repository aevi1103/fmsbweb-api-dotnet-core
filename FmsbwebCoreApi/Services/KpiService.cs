using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FmsbwebCoreApi.Entity.Fmsb2;
using FmsbwebCoreApi.Entity.SAP;
using FmsbwebCoreApi.Helpers;
using FmsbwebCoreApi.Models.Intranet;
using FmsbwebCoreApi.Models.SAP;
using FmsbwebCoreApi.ResourceParameters;
using FmsbwebCoreApi.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using Scrap = FmsbwebCoreApi.Models.SAP.Scrap;

namespace FmsbwebCoreApi.Services
{
    public class KpiService : IKpiService
    {
        private readonly IScrapService _scrapService;
        private readonly IProductionService _productionService;
        private readonly IKpiTargetService _kpiTargetService;
        private readonly IUtilityService _utilityService;

        public KpiService(
            IScrapService scrapService,
            IProductionService productionService,
            IKpiTargetService kpiTargetService,
            IUtilityService utilityService)
        {
            _scrapService = scrapService ?? throw new ArgumentNullException(nameof(scrapService));
            _productionService = productionService ?? throw new ArgumentNullException(nameof(productionService));
            _kpiTargetService = kpiTargetService ?? throw new ArgumentNullException(nameof(kpiTargetService));
            _utilityService = utilityService ?? throw new ArgumentNullException(nameof(utilityService));
        }
        public async Task<List<DailyDepartmentKpiDto>> GetDailyKpiChart(DateTime startDateTime, DateTime endDateTime, string area)
        {
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

            var targets = (await _kpiTargetService.DailyHxHTargetByArea(startDateTime, endDateTime, area).ConfigureAwait(false)).ToList();

            //transform to chart object
            var result = production
                            .Select(x =>
                            {
                                var shiftDate = x.ShiftDate.ToDateTime();
                                var totalProd = x.TotalProd.ToInt();
                                var totalAreaScrap = scrap.Where(s => s.ShiftDate == x.ShiftDate).Sum(s => s.TotalScrap ?? 0);
                                var target = targets.Where(s => s.ShiftDate == x.ShiftDate).Sum(s => s.Target);

                                var sapGross = totalAreaScrap + totalProd;
                                var sapOae = Math.Round((target == 0 ? 0 : totalProd / (decimal)target), 2);
                                var scrapRate = Math.Round((sapGross == 0 ? 0 : totalAreaScrap / (decimal)sapGross), 2);
                                var downtimeRate = 1 - sapOae - scrapRate;
                                downtimeRate = downtimeRate < 0 ? 0 : downtimeRate;

                                return new DailyDepartmentKpiDto
                                {
                                    Area = x.Area,
                                    ShiftDate = shiftDate,
                                    TotalProduction = totalProd,
                                    TotalAreaScrap = totalAreaScrap,
                                    Target = target,
                                    SapGross = sapGross,
                                    SapOae = sapOae,
                                    ScrapRate = scrapRate,
                                    DowntimeRate = downtimeRate
                                };
                            })
                            .OrderBy(x => x.ShiftDate)
                            .ToList();

            return result;
        }

        private IEnumerable<ProductionByLineDto> GetDepartmentDetailsByLine(
            List<Scrap> scrap,
            List<SapProdDetailDto> prod,
            List<HxHProductionByLineDto> hxh,
            IEnumerable<Scrap> warmers,
            IEnumerable<SwotTargetWithDeptId> lineTargets)
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
                                    Qty = x.Sum(s => s.Qty)
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
                                    Qty = x.Sum(s => s.Qty)
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
                    var hxhByLine = hxh.FirstOrDefault(x => x.Line == line);
                    var dept = hxhByLine?.Department ?? "";
                    var area = hxhByLine?.Area ?? "";
                    var target = hxhByLine?.Target ?? 0;
                    var hxhGross = hxhByLine?.Gross ?? 0;

                    //targets
                    var lineTarget = targets.FirstOrDefault(x => x.Line == line);
                    var oaeTarget = lineTarget?.OaeTarget ?? 0;
                    var foundryScrapTarget = lineTarget?.FoundryScrapTarget ?? 0;
                    var machiningScrapTarget = lineTarget?.MachineScrapTarget ?? 0;
                    var afScrapTarget = lineTarget?.AfScrapTarget ?? 0;

                    //scrap
                    var totalScrap = scrapByLine.Any(x => x.Line == line)
                        ? scrapByLine.Where(x => x.Line == line).Sum(s => s.Qty)
                        : 0;
                    var totalSbScrap = sbScrap.Any(x => x.Line == line)
                        ? sbScrap.Where(x => x.Line == line).Sum(s => s.Qty)
                        : 0;
                    var totalPurchaseScrap = purchasedScrap.Any(x => x.Line == line)
                        ? purchasedScrap.Where(x => x.Line == line).Sum(s => s.Qty)
                        : 0;
                    var totalAfScrap = afScrap.Any(x => x.Line == line)
                        ? afScrap.Where(x => x.Line == line).Sum(s => s.Qty)
                        : 0;
                    var totalWarmers = warmersByLine.Any(x => x.Line == line)
                        ? warmersByLine.Where(x => x.Line == line).Sum(s => s.Qty)
                        : 0;
                    var scrapDetails = sbScrap.Any(x => x.Line == line)
                        ? sbScrap.Where(x => x.Line == line).ToList()
                        : new List<Scrap>();
                    var purchasedScrapDetails = purchasedScrap.Any(x => x.Line == line)
                        ? purchasedScrap.Where(x => x.Line == line).ToList()
                        : new List<Scrap>();

                    //net, oae
                    var hxhNet = (area.ToLower() == "foundry cell" || area.ToLower() == "machine line") ? hxhGross - totalScrap : hxhGross;
                    var hxhOae = target == 0 ? 0 : hxhNet / target;

                    var isLineExistInSapProd = prod.Any(x => x.Line == line);
                    var sapNet = isLineExistInSapProd ? prod.Where(x => x.Line == line).Sum(s => s.SapNet) : 0;
                    var sapNetDetails = isLineExistInSapProd
                        ? prod.Where(x => x.Line == line).OrderBy(x => x.DateScanned).ToList()
                        : new List<SapProdDetailDto>();
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
                                        Qty = d.Sum(q => q.Qty)
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
            List<SapProdDetailDto> prod,
            List<HxhProductionByProgramDto> hxh)
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
                                    Qty = x.Sum(s => s.Qty)
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
                    var hxhGross = hxhByProgram?.Gross ?? 0;

                    //scrap
                    var totalScrap = scrapByProgram.Any(x => x.Program == program)
                        ? scrapByProgram.Where(x => x.Program == program).Sum(s => s.Qty)
                        : 0;
                    var totalSbScrap = sbScrap.Any(x => x.Program == program)
                        ? sbScrap.Where(x => x.Program == program).Sum(s => s.Qty)
                        : 0;
                    var totalPurchaseScrap = purchasedScrap.Any(x => x.Program == program)
                        ? purchasedScrap.Where(x => x.Program == program).Sum(s => s.Qty)
                        : 0;
                    var sbScrapDetails = sbScrap.Any(x => x.Program == program)
                        ? sbScrap.Where(x => x.Program == program).ToList()
                        : new List<Scrap>();
                    var purchaseScrapDetails = purchasedScrap.Any(x => x.Program == program)
                        ? purchasedScrap.Where(x => x.Program == program).ToList()
                        : new List<Scrap>();

                    //net
                    var sapNet = prod.Any(x => x.Program == program)
                        ? prod.Where(x => x.Program == program).Sum(s => s.SapNet)
                        : 0;
                    var sapNetDetails = prod.Any(x => x.Program == program)
                        ? prod.Where(x => x.Program == program).OrderBy(x => x.DateScanned).ToList()
                        : new List<SapProdDetailDto>();

                    var hxhNet = (area.ToLower() == "foundry cell" || area.ToLower() == "machine line")
                        ? hxhGross - totalScrap
                        : hxhGross;
                    var hxhOae = target == 0
                        ? 0
                        : ((area.ToLower() == "foundry cell" || area.ToLower() == "machine line")
                            ? hxhGross - totalScrap
                            : hxhGross) / target;

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
                                .Select(d => new Models.SAP.Scrap
                                {
                                    Department = d.Key.Department,
                                    Area = d.Key.Area,
                                    Program = program,
                                    ScrapAreaName = d.Key.ScrapAreaName,
                                    IsPurchashedExclude2 = d.Key.IsPurchashedExclude2,
                                    ScrapCode = d.Key.ScrapCode,
                                    ScrapDesc = d.Key.ScrapDesc,
                                    Qty = d.Sum(q => q.Qty)
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

        public async Task<DepartmentDetailsDto> GetDepartmentDetails(DateTime start, DateTime end, string area)
        {
            var dept = _utilityService.MapAreaToDepartment(area);

            var sapProdData = await _productionService.GetProductionQueryable(new ProductionResourceParameter
            {
                StartDate = start,
                EndDate = end,
                Area = area
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

            var scrapData = await _scrapService.GetScrap2Queryable(new ScrapResourceParameter
            {
                StartDate = start,
                EndDate = end,
                Area = area
            }, false)
                .Select(x => new Scrap
                {
                    Department = x.Department,
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

            var hxhProductionData = await _productionService.GetHxhProdByLineAndProgram(
                new ProductionResourceParameter
                {
                    StartDate = start,
                    EndDate = end,
                    Area = area
                }).ConfigureAwait(false);

            var lineTargets = await _kpiTargetService
                .GetLineTargets(dept)
                .ConfigureAwait(false);

            var deptTargets = await _kpiTargetService.GetDepartmentTargets(dept, area, start, end)
                .ConfigureAwait(false);

            //transform data
            var scrap = scrapData.Where(x => x.ScrapCode != "8888").ToList();
            var warmers = scrapData.Where(x => x.ScrapCode == "8888").ToList();

            //get total
            var target = hxhProductionData.LineDetails.Sum(x => x.Target);
            var sapNet = sapProdData.Sum(x => x.SapNet);
            var totalScrap = scrap.Sum(x => x.Qty);
            var totalSbScrap = scrap.Where(x => x.IsPurchashedExclude == false).Sum(x => x.Qty);
            var totalPurchasedScrap = scrap.Where(x => x.IsPurchashedExclude == true).Sum(x => x.Qty);

            var sapGross = sapNet + totalScrap;

            var totalScrapRate = sapGross == 0 ? 0 : (decimal)totalScrap / sapGross;
            var totalSbScrapRate = sapGross == 0 ? 0 : (decimal)totalSbScrap / sapGross;
            var totalPurchasedScrapRate = sapGross == 0 ? 0 : (decimal)totalPurchasedScrap / sapGross;

            var sapOae = target == 0 ? 0 : (decimal)sapNet / target;

            var hxhGross = hxhProductionData.LineDetails.Sum(x => x.Gross);
            var hxhNet = (area.ToLower() == "foundry cell" || area.ToLower() == "machine line") ? hxhGross - totalScrap : hxhGross;
            var hxhOae = target == 0 ? 0 : (decimal)hxhNet / target;

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
                                    Qty = d.Sum(q => q.Qty)
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
                    Qty = x.Sum(s => s.Qty)
                })
                .OrderByDescending(x => x.Qty).ToList();

            //result
            return new DepartmentDetailsDto
            {
                Area = area,
                Target = (int)target,
                SapGross = sapGross,
                OaeTarget = deptTargets.OaeTarget / 100,
                SapNet = sapNet,
                SapOae = sapOae,
                HxhGross = hxhGross,
                HxHNet = hxhNet,
                HxHOae = hxhOae,
                TotalScrap = totalScrap,
                TotalSbScrap = totalSbScrap,
                TotalPurchaseScrap = totalPurchasedScrap,
                TotalScrapRate = totalScrapRate,
                TotalSbScrapRate = totalSbScrapRate,
                TotalPurchaseScrapRate = totalPurchasedScrapRate,
                SbScrapAreaDetails = scrapAreaDetails,
                DetailsByLine = GetDepartmentDetailsByLine(scrap, sapProdData, hxhProductionData.LineDetails.ToList(), warmers, lineTargets),
                DetailsByProgram = GetDepartmentDetailsByProgram(scrap, sapProdData, hxhProductionData.ProgramDetails.ToList()),
                SbScrapDetails = scrapList.Where(s => s.IsPurchashedExclude == false),
                PurchaseScrapDetails = scrapList.Where(s => s.IsPurchashedExclude)
            };
        }
    }
}
