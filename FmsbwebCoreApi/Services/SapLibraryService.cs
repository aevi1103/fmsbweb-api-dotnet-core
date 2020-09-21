using FmsbwebCoreApi.Context.Fmsb2;
using FmsbwebCoreApi.Context.SAP;
using FmsbwebCoreApi.Entity.Fmsb2;
using FmsbwebCoreApi.Entity.SAP;
using FmsbwebCoreApi.Helpers;
using FmsbwebCoreApi.Models.Intranet;
using FmsbwebCoreApi.Models.SAP;
using FmsbwebCoreApi.ResourceParameters.FMSB;
using FmsbwebCoreApi.ResourceParameters.SAP;
using FmsbwebCoreApi.Services.FMSB2;
using FmsbwebCoreApi.Services.FmsbMvc;
using FmsbwebCoreApi.Services.Intranet;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using FmsbwebCoreApi.Repositories.Interfaces;
using FmsbwebCoreApi.ResourceParameters;
using FmsbwebCoreApi.Services.Interfaces;
using Scrap = FmsbwebCoreApi.Models.SAP.Scrap;

namespace FmsbwebCoreApi.Services
{
    public class SapLibraryService : ISapLibraryService, IDisposable
    {
        private const decimal DmaxHourRate = 0.01252m;
        private readonly SapContext _context;
        private readonly Fmsb2Context _fmsbContext;
        private readonly MapArea _mapArea;

        private readonly IFmsb2LibraryRepository _fmsb2Repo;
        private readonly IFmsbMvcLibraryRepository _fmsbMvcRepo;

        private readonly IScrapService _scrapService;
        private readonly IProductionService _productionService;

        public SapLibraryService(
            SapContext context,
            Fmsb2Context fmsbContext,
            IFmsb2LibraryRepository fmsb2Repo,
            IFmsbMvcLibraryRepository fmsbMvcRepo,
            IScrapService scrapService,
            IProductionService productionService)
        {
            _scrapService = scrapService ?? throw new ArgumentNullException(nameof(scrapService));
            _productionService = productionService ?? throw new ArgumentNullException(nameof(productionService));
            _context = context ?? throw new ArgumentNullException(nameof(context));
            _fmsbContext = fmsbContext ?? throw new ArgumentNullException(nameof(fmsbContext));
            _fmsb2Repo = fmsb2Repo ?? throw new ArgumentNullException(nameof(fmsb2Repo));
            _fmsbMvcRepo = fmsbMvcRepo ?? throw new ArgumentNullException(nameof(fmsbMvcRepo));
            _mapArea = new MapArea();
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                // dispose resources when needed
            }
        }

        #region implementation Details

        private static ScrapByCodeDto GetScrapByCode(List<Scrap> scrap, string area, bool isSbScrap, int sapNet)
        {
            if (scrap == null) throw new ArgumentNullException(nameof(scrap));

            var summary = scrap
                            .Where(x => x.IsPurchashedExclude2 == (isSbScrap ? "SB Scrap" : "Purchased Scrap"))
                            .Where(x => x.ScrapCode != "8888")
                            .AsQueryable();

            switch (area)
            {
                case "Foundry Cell":
                    summary = summary.Where(x => x.ScrapAreaName.ToLower(CultureInfo.CurrentCulture) == "foundry");
                    break;
                case "Machine Line":
                    summary = summary.Where(x => x.ScrapAreaName.ToLower(CultureInfo.CurrentCulture) == "machining");
                    break;
                case "Skirt Coat":
                    {
                        var finScrap = new List<string> { "anodize", "skirt coat" };
                        summary = summary.Where(x => finScrap.Contains(x.ScrapAreaName.ToLower(CultureInfo.CurrentCulture)));
                        break;
                    }
                case "Assembly":
                    summary = summary.Where(x => x.ScrapAreaName.ToLower(CultureInfo.CurrentCulture) == "assembly");
                    break;
            }

            var totalScrap = summary.Sum(x => x.Qty);
            var sapGross = totalScrap + sapNet;

            var scrapDetails = summary
                            .GroupBy(x => new { x.Area, x.ScrapAreaName })
                            .Select(x => new ScrapByCodeDetailsDto
                            {
                                Area = x.Key.Area,
                                ScrapType = (isSbScrap ? "SB Scrap" : "Purchased Scrap"),
                                ScrapAreaName = x.Key.ScrapAreaName,
                                Qty = x.Sum(s => s.Qty),
                                SapGross = sapGross, // add sap net + total
                                ScrapRate = sapGross == 0 ? 0 : (decimal)x.Sum(s => s.Qty) / (decimal)sapGross,
                                Details = x.GroupBy(d => new { d.ScrapAreaName, d.ScrapCode, d.ScrapDesc })
                                            .Select(d => new Models.SAP.Scrap
                                            {
                                                ScrapAreaName = d.Key.ScrapAreaName,
                                                ScrapCode = d.Key.ScrapCode,
                                                ScrapDesc = d.Key.ScrapDesc,
                                                Qty = d.Sum(t => t.Qty)
                                            }).OrderByDescending(d => d.Qty)
                            })
                            .OrderByDescending(x => x.Qty)
                            .ToList();

            var result = new ScrapByCodeDto
            {
                Total = totalScrap,
                SapGross = sapGross,
                ScrapRate = sapGross == 0 ? 0 : (decimal)totalScrap / (decimal)sapGross,
                Details = scrapDetails
            };

            return result;
        }

        private static DepartmentScrapDto GetDepartmentScrap(IEnumerable<Scrap> scrap, string area, int sapNet)
        {
            if (scrap == null) throw new ArgumentNullException(nameof(scrap));

            var summary = scrap
                            .Where(x => x.ScrapCode != "8888")
                            .Where(x => x.Area == area)
                            .ToList();

            var totalScrap = summary.Sum(x => x.Qty);
            var sapGross = totalScrap + sapNet;

            var scrapDetails = summary
                            .GroupBy(x => new { x.Area, x.IsPurchashedExclude2 })
                            .Select(x => new DepartmentScrapDetailsDto
                            {
                                Area = x.Key.Area,
                                ScrapType = x.Key.IsPurchashedExclude2,
                                Qty = x.Sum(s => s.Qty),
                                SapGross = sapGross,
                                ScrapRate = sapGross == 0 ? 0 : (decimal)x.Sum(s => s.Qty) / (decimal)sapGross
                            })
                            .ToList();

            var result = new DepartmentScrapDto
            {
                Total = totalScrap,
                SapGross = sapGross,
                ScrapRate = sapGross == 0 ? 0 : (decimal)totalScrap / (decimal)sapGross,
                Details = scrapDetails
            };

            return result;

        }

        private static SapProductionByTypeDto GetSapProductionByType(IEnumerable<SapProdDto> sapProd, string area)
        {
            if (sapProd == null) throw new ArgumentNullException(nameof(sapProd));

            List<SapProdDto> data;
            var total = 0;

            switch (area)
            {
                case "Foundry Cell":

                    data = sapProd.Where(x => x.SapType == "P5C").ToList();
                    total = data.Sum(x => x.Qty);

                    return new SapProductionByTypeDto
                    {
                        Total = total,
                        Details = data
                                    .GroupBy(x => new { x.Area, x.SapType })
                                    .Select(x => new SapProductionTypeDetailsDto
                                    {
                                        Area = x.Key.Area,
                                        SapType = x.Key.SapType,
                                        SapNet = x.Sum(s => s.Qty)
                                    })
                                    .ToList()
                    };

                case "Machine Line":

                    data = sapProd.Where(x => x.SapType == "P3M").ToList();
                    total = data.Sum(x => x.Qty);

                    return new SapProductionByTypeDto
                    {
                        Total = total,
                        Details = data
                                    .GroupBy(x => new { x.Area, x.SapType })
                                    .Select(x => new SapProductionTypeDetailsDto
                                    {
                                        Area = x.Key.Area,
                                        SapType = x.Key.SapType,
                                        SapNet = x.Sum(s => s.Qty)
                                    })
                                    .ToList()
                    };

                case "Skirt Coat":

                    var fin = new List<string> { "P1F", "P2F" };

                    data = sapProd.Where(x => fin.Contains(x.SapType)).ToList();
                    total = data.Sum(x => x.Qty);

                    return new SapProductionByTypeDto
                    {
                        Total = total,
                        Details = data
                                    .GroupBy(x => new { x.Area, x.SapType })
                                    .Select(x => new SapProductionTypeDetailsDto
                                    {
                                        Area = x.Key.Area,
                                        SapType = x.Key.SapType,
                                        SapNet = x.Sum(s => s.Qty)
                                    })
                                    .ToList()
                    };

                case "Assembly":

                    data = sapProd.Where(x => x.SapType == "P1A").ToList();
                    total = data.Sum(x => x.Qty);

                    return new SapProductionByTypeDto
                    {
                        Total = total,
                        Details = data
                                    .GroupBy(x => new { x.Area, x.SapType })
                                    .Select(x => new SapProductionTypeDetailsDto
                                    {
                                        Area = x.Key.Area,
                                        SapType = x.Key.SapType,
                                        SapNet = x.Sum(s => s.Qty)
                                    })
                                    .ToList()
                    };


                default:

                    return new SapProductionByTypeDto();
            }
        }

        private async Task<IEnumerable<Scrap>> GetScrapDataByScrapAreaFromDb(DateTime start, DateTime end, string area)
        {
            if (area == null) throw new ArgumentNullException(nameof(area));

            var qry = _context.Scrap2Summary2.Where(x => x.ShiftDate >= start && x.ShiftDate <= end).AsQueryable();
            area = area.ToLower().Trim();

            switch (area)
            {
                case "foundry cell":
                    qry = qry.Where(x => x.ScrapAreaName.ToLower() == "foundry");
                    break;
                case "machine line":
                    qry = qry.Where(x => x.ScrapAreaName.ToLower() == "machining");
                    break;
                case "skirt coat":
                    {
                        var fin = new List<string> { "anodize", "skirt coat" };
                        qry = qry.Where(x => fin.Contains(x.ScrapAreaName.ToLower().Trim()));
                        break;
                    }
                case "assembly":
                    qry = qry.Where(x => x.ScrapAreaName.ToLower() == "assembly");
                    break;
            }

            return await qry
                            .Select(x => new Scrap
                            {
                                Department = x.Department,
                                Area = x.Area,
                                ScrapAreaName = x.ScrapAreaName,
                                ScrapCode = x.ScrapCode,
                                IsPurchashedExclude = (bool)x.IsPurchashedExclude,
                                IsPurchashedExclude2 = x.IsPurchashedExclude2,
                                ScrapDesc = x.ScrapDesc,
                                Qty = (int)x.Qty
                            })
                            .ToListAsync()
                            .ConfigureAwait(false);
        }

 
        private async Task<IEnumerable<Scrap>> GetScrapDataByDepartmentFromDb(DateTime start, DateTime end, string area)
        {
            return await _context.Scrap2Summary2
                                .Where(x => x.ShiftDate >= start && x.ShiftDate <= end)
                                .Where(x => x.Area == area)
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
                                    Qty = (int)x.Qty
                                }).ToListAsync()
                                .ConfigureAwait(false);
        }

        private async Task<IEnumerable<SapProdDto>> GetSapProdByAreaFromDb(DateTime start, DateTime end, string area)
        {
            return await _context.Production2Summary
                                .Where(x => x.ShiftDate >= start && x.ShiftDate <= end)
                                .Where(x => x.Area == area)

                                .GroupBy(x => new { x.Area, sapType = x.Material.Substring(0, 3) })
                                .Select(x => new SapProdDto
                                {
                                    SapType = x.Key.sapType,
                                    Area = x.Key.Area,
                                    Qty = (int)x.Sum(s => s.Qty)
                                })
                                .ToListAsync()
                                .ConfigureAwait(false);
        }

        private async Task<IEnumerable<SapProdDto>> GetSapProdByTypeFromDb(DateTime start, DateTime end, string area)
        {
            if (area == null) throw new ArgumentNullException(nameof(area));

            var qry = _context
                        .Production2Summary
                        .Where(x => x.ShiftDate >= start && x.ShiftDate <= end)
                        .AsQueryable();

            switch (area.ToLower().Trim())
            {
                case "foundry cell":
                    qry = qry.Where(x => x.Type.ToLower().Trim() == "p5c");
                    break;
                case "machine line":
                    qry = qry.Where(x => x.Type.ToLower().Trim() == "p3m");
                    break;
                case "skirt coat":
                    {
                        var fin = new List<string> { "p1f", "p2f" };
                        qry = qry.Where(x => fin.Contains(x.Type.ToLower().Trim()));
                        break;
                    }
                case "assembly":
                    qry = qry.Where(x => x.Type.ToLower().Trim() == "p1a");
                    break;
            }

            return await qry
                            .GroupBy(x => new { x.Area, sapType = x.Material.Substring(0, 3) })
                            .Select(x => new SapProdDto
                            {
                                SapType = x.Key.sapType,
                                Area = x.Key.Area,
                                Qty = (int)x.Sum(s => s.Qty)
                            }).ToListAsync().ConfigureAwait(false);
        }

        private static string GetColorCode(KpiTarget targets, string type, decimal? value)
        {
            targets = targets ?? throw new ArgumentNullException(nameof(targets));

            const string black = "#262626";
            const string red = "#FF4136";
            const string green = "#19A974";

            if (value == null) return black;

            return type switch
            {
                "oae" => value <= targets.OaeTarget / 100 ? red : green,
                "scrap" => value <= targets.ScrapRateTarget / 100 ? green : red,
                "ppmh" => value <= targets.PpmhTarget ? red : green,
                "downtime" => value <= targets.DowntimeRateTarget / 100 ? red : green,
                _ => black
            };
        }

        private static IEnumerable<ProductionByLineDto> GetDepartmentDetailsByLine(
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
                                .Select(x => new Models.SAP.Scrap
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
                                .Select(x => new Models.SAP.Scrap
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
                            .Where(x => x.IsPurchashedExclude == false)
                            .Where(x => x.ScrapAreaName == "Anodize" || x.ScrapAreaName == "Skirt Coat" || x.ScrapAreaName == "Assembly")
                            .ToList();

            //details
            var result = distinctLines.Select(line =>
                {
                    var isHxHExist = hxh.Any(x => x.Line == line);
                    var isTargetsExist = targets.Any(x => x.Line == line);
                    var isSapProdExist = prod.Any(x => x.Line == line);

                    string dept = "", area = "";
                    int target = 0, hxhGross = 0;
                    if (isHxHExist)
                    {
                        var hxhEntity = hxh.First(x => x.Line == line);
                        dept = hxhEntity.Department;
                        area = hxhEntity.Area;
                        target = (int)hxhEntity.Target;
                        hxhGross = hxhEntity.Gross;
                    }

                    decimal oaeTarget = 0, fsTarget = 0, msTarget = 0, afTarget = 0;
                    if (isTargetsExist)
                    {
                        var targetsEntity = targets.First(x => x.Line == line);
                        oaeTarget = targetsEntity.OaeTarget;
                        fsTarget = targetsEntity.FoundryScrapTarget;
                        msTarget = targetsEntity.MachineScrapTarget;
                        afTarget = targetsEntity.AfScrapTarget;
                    }

                    var sapNetDetails = new List<SapProdDetailDto>();
                    var sapNet = 0;
                    if (isSapProdExist)
                    {
                        sapNetDetails = prod.Where(x => x.Line == line).OrderBy(x => x.DateScanned).ToList();
                        sapNet = prod.Where(x => x.Line == line).Sum(s => s.SapNet);
                    }

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

                    var sbScrapDetails = sbScrap.Any(x => x.Line == line)
                        ? sbScrap.Where(x => x.Line == line).ToList()
                        : new List<Scrap>();

                    var purchasedScrapDetails = purchasedScrap.Any(x => x.Line == line)
                        ? purchasedScrap.Where(x => x.Line == line).ToList()
                        : new List<Scrap>();

                    return new ProductionByLineDto
                    {
                        Department = dept,
                        Area = area,
                        Line = line,
                        Target = target,
                        OaeTarget = oaeTarget,
                        FoundryScrapRateTarget = fsTarget,
                        MachiningScrapRateTarget = msTarget,
                        AfScrapRateTarget = afTarget,
                        HxHGross = hxhGross,
                        SapNet = sapNet,
                        SapNetDetails = sapNetDetails,
                        TotalScrap = totalScrap,
                        TotalSbScrap = totalSbScrap,
                        TotalPurchaseScrap = totalPurchaseScrap,
                        TotalAfScrap = totalAfScrap,
                        TotalWarmers = totalWarmers,
                        SbScrapDetails = sbScrapDetails,
                        PurchaseScrapDetails = purchasedScrapDetails
                    };
    
                })
            .Select(x => new ProductionByLineDto
            {
                Department = x.Department,
                Area = x.Area,
                Line = x.Line,
                Target = x.Target,

                OaeTarget = x.OaeTarget,
                FoundryScrapRateTarget = x.FoundryScrapRateTarget,
                MachiningScrapRateTarget = x.MachiningScrapRateTarget,
                AfScrapRateTarget = x.AfScrapRateTarget,

                HxHGross = x.HxHGross,
                HxHNet = (x.Area.ToLower() == "foundry cell" || x.Area.ToLower() == "machine line") ? x.HxHGross - x.TotalScrap : x.HxHGross,
                HxHOae = x.Target == 0 ? 0
                            : (decimal)((x.Area.ToLower() == "foundry cell" || x.Area.ToLower() == "machine line") ? x.HxHGross - x.TotalScrap : x.HxHGross) / (decimal)x.Target,

                SapNet = x.SapNet,
                SapNetDetails = x.SapNetDetails,
                SapGross = x.SapNet + x.TotalScrap,
                SapOae = x.Target == 0 ? 0 : (decimal)x.SapNet / (decimal)x.Target,

                TotalScrap = x.TotalScrap,
                TotalSbScrap = x.TotalSbScrap,
                TotalPurchaseScrap = x.TotalPurchaseScrap,
                TotalAfScrap = x.TotalAfScrap,

                TotalWarmers = x.TotalWarmers,

                TotalScrapRate = (x.SapNet + x.TotalScrap) == 0 ? 0 : (decimal)x.TotalScrap / (decimal)(x.SapNet + x.TotalScrap),
                TotalSbScrapRate = (x.SapNet + x.TotalScrap) == 0 ? 0 : (decimal)x.TotalSbScrap / (decimal)(x.SapNet + x.TotalScrap),
                TotalPurchaseScrapRate = (x.SapNet + x.TotalScrap) == 0 ? 0 : (decimal)x.TotalPurchaseScrap / (decimal)(x.SapNet + x.TotalScrap),
                TotalAfScrapRate = (x.SapNet + x.TotalScrap) == 0 ? 0 : (decimal)x.TotalAfScrap / (decimal)(x.SapNet + x.TotalScrap),

                SbScrapDetails = x.SbScrapDetails,
                PurchaseScrapDetails = x.PurchaseScrapDetails,

                SbScrapAreaDetails = sbScrap.Any(s => s.Line == x.Line) ?

                                        sbScrap
                                        .Where(s => s.Line == x.Line)
                                        .GroupBy(s => new { s.Area, s.ScrapAreaName, s.IsPurchashedExclude2 })
                                        .Select(s => new ScrapByCodeDetailsDto
                                        {
                                            Area = s.Key.Area,
                                            ScrapType = s.Key.IsPurchashedExclude2,
                                            ScrapAreaName = s.Key.ScrapAreaName,
                                            Qty = s.Sum(s => s.Qty),
                                            SapGross = (x.SapNet + x.TotalScrap),
                                            ScrapRate = (x.SapNet + x.TotalScrap) == 0 ? 0 : (decimal)s.Sum(s => s.Qty) / (decimal)(x.SapNet + x.TotalScrap),

                                            Details = scrap
                                                        .Where(d => d.IsPurchashedExclude == false)
                                                        .Where(d => d.Line == x.Line)
                                                        .Where(d => d.ScrapAreaName == s.Key.ScrapAreaName)
                                                        .GroupBy(d => new { d.Department, d.Area, d.ScrapAreaName, d.ScrapCode, d.ScrapDesc, d.IsPurchashedExclude2 })
                                                        .Select(d => new Models.SAP.Scrap
                                                        {
                                                            Department = d.Key.Department,
                                                            Area = d.Key.Area,
                                                            Line = x.Line,
                                                            ScrapAreaName = d.Key.ScrapAreaName,
                                                            IsPurchashedExclude2 = d.Key.IsPurchashedExclude2,
                                                            ScrapCode = d.Key.ScrapCode,
                                                            ScrapDesc = d.Key.ScrapDesc,
                                                            Qty = d.Sum(q => q.Qty)
                                                        })
                                                        .OrderByDescending(d => d.Qty)
                                        }).ToList()

                                        : new List<ScrapByCodeDetailsDto>()

            })
            .ToList();

            return result;
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
                                .GroupBy(x => new { x.Department, x.Area, x.Program, x.ScrapAreaName, x.ScrapCode,
                                    x.ScrapDesc, x.IsPurchashedExclude, x.IsPurchashedExclude2 })
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
                    var isHxHExist = hxh.Any(x => x.Program == program);

                    string dept = "", area = "";
                    int target = 0, gross = 0;
                    if (isHxHExist)
                    {
                        var hxhEntity = hxh.First(x => x.Program == program);
                        dept = hxhEntity.Department;
                        area = hxhEntity.Area;
                        target = (int)hxhEntity.Target;
                        gross = hxhEntity.Gross;
                    }

                    return new ProductionByProgramDto
                    {
                        Department = dept,
                        Area = area,
                        Program = program,
                        Target = target,
                        HxHGross = gross,
                        SapNet = prod.Any(x => x.Program == program)
                            ? prod.Where(x => x.Program == program).Sum(s => s.SapNet)
                            : 0,
                        SapNetDetails = prod.Any(x => x.Program == program)
                            ? prod.Where(x => x.Program == program).OrderBy(x => x.DateScanned).ToList()
                            : new List<SapProdDetailDto>(),

                        TotalScrap = scrapByProgram.Any(x => x.Program == program)
                            ? scrapByProgram.Where(x => x.Program == program).Sum(s => s.Qty)
                            : 0,
                        TotalSbScrap = sbScrap.Any(x => x.Program == program)
                            ? sbScrap.Where(x => x.Program == program).Sum(s => s.Qty)
                            : 0,
                        TotalPurchaseScrap = purchasedScrap.Any(x => x.Program == program)
                            ? purchasedScrap.Where(x => x.Program == program).Sum(s => s.Qty)
                            : 0,
                        SbScrapDetails = sbScrap.Any(x => x.Program == program)
                            ? sbScrap.Where(x => x.Program == program).ToList()
                            : new List<Scrap>(),
                        PurchaseScrapDetails = purchasedScrap.Any(x => x.Program == program)
                            ? purchasedScrap.Where(x => x.Program == program).ToList()
                            : new List<Scrap>()
                    };

                })
            .Select(x => new ProductionByProgramDto
            {
                Department = x.Department,
                Area = x.Area,
                Program = x.Program,
                Target = x.Target,

                HxHGross = x.HxHGross,
                HxHNet = (x.Area.ToLower() == "foundry cell" || x.Area.ToLower() == "machine line") ? x.HxHGross - x.TotalScrap : x.HxHGross,
                HxHOae = x.Target == 0 ? 0
                            : (decimal)((x.Area.ToLower() == "foundry cell" || x.Area.ToLower() == "machine line") ? x.HxHGross - x.TotalScrap : x.HxHGross) / (decimal)x.Target,

                SapNet = x.SapNet,
                SapNetDetails = x.SapNetDetails,
                SapGross = x.SapNet + x.TotalScrap,
                SapOae = x.Target == 0 ? 0 : (decimal)x.SapNet / (decimal)x.Target,

                TotalScrap = x.TotalScrap,
                TotalSbScrap = x.TotalSbScrap,
                TotalPurchaseScrap = x.TotalPurchaseScrap,

                TotalScrapRate = (x.SapNet + x.TotalScrap) == 0 ? 0 : (decimal)x.TotalScrap / (decimal)(x.SapNet + x.TotalScrap),
                TotalSbScrapRate = (x.SapNet + x.TotalScrap) == 0 ? 0 : (decimal)x.TotalSbScrap / (decimal)(x.SapNet + x.TotalScrap),
                TotalPurchaseScrapRate = (x.SapNet + x.TotalScrap) == 0 ? 0 : (decimal)x.TotalPurchaseScrap / (decimal)(x.SapNet + x.TotalScrap),

                SbScrapDetails = x.SbScrapDetails,
                PurchaseScrapDetails = x.PurchaseScrapDetails,

                SbScrapAreaDetails = sbScrap.Any(s => s.Program == x.Program) ?

                                        sbScrap
                                        .Where(s => s.Program == x.Program)
                                        .GroupBy(s => new { s.Area, s.ScrapAreaName, s.IsPurchashedExclude2 })
                                        .Select(s => new ScrapByCodeDetailsDto
                                        {
                                            Area = s.Key.Area,
                                            ScrapType = s.Key.IsPurchashedExclude2,
                                            ScrapAreaName = s.Key.ScrapAreaName,
                                            Qty = s.Sum(s => s.Qty),
                                            SapGross = (x.SapNet + x.TotalScrap),
                                            ScrapRate = (x.SapNet + x.TotalScrap) == 0 ? 0 : (decimal)s.Sum(s => s.Qty) / (decimal)(x.SapNet + x.TotalScrap),

                                            Details = scrap
                                                        .Where(d => d.IsPurchashedExclude == false)
                                                        .Where(d => d.Program == x.Program)
                                                        .Where(d => d.ScrapAreaName == s.Key.ScrapAreaName)
                                                        .GroupBy(d => new { d.Department, d.Area, d.ScrapAreaName, d.ScrapCode, d.ScrapDesc, d.IsPurchashedExclude2 })
                                                        .Select(d => new Models.SAP.Scrap
                                                        {
                                                            Department = d.Key.Department,
                                                            Area = d.Key.Area,
                                                            Program = x.Program,
                                                            ScrapAreaName = d.Key.ScrapAreaName,
                                                            IsPurchashedExclude2 = d.Key.IsPurchashedExclude2,
                                                            ScrapCode = d.Key.ScrapCode,
                                                            ScrapDesc = d.Key.ScrapDesc,
                                                            Qty = d.Sum(q => q.Qty)
                                                        })
                                                        .OrderByDescending(d => d.Qty)
                                        }).ToList()

                                        : new List<ScrapByCodeDetailsDto>()

            })
            .ToList();

            return result;
        }

        private static int MapShiftToShiftOrder(string shift)
        {
            return shift switch
            {
                "A" => 1,
                "C" => 2,
                "B" => 1,
                "D" => 2,
                "3" => 1,
                "1" => 2,
                "2" => 3,
                _ => 0
            };
        }

        private static decimal? CalculatePlantPpmh(decimal? overallHours, decimal? sapNetDmax, decimal sapNetLessDmax)
        {
            var dmaxHours = sapNetLessDmax == 0 ? 0 : sapNetDmax * DmaxHourRate / sapNetLessDmax;
            var hours = overallHours - dmaxHours;
            return hours == 0 ? 0 : sapNetLessDmax / hours;
        }

        private static decimal? GetOverallHours(decimal? regular, decimal? overtime, decimal? doubleTime, decimal? orientation)
        {
            return regular + overtime + doubleTime + orientation;
        }

        private decimal? GetOverallHoursLessDmax(decimal? overallHours, decimal? sapNetDmax, decimal? sapNetLessDmax)
        {
            var dmaxHours = sapNetLessDmax == 0 ? 0 : sapNetDmax * DmaxHourRate / sapNetLessDmax;
            return overallHours - dmaxHours;
        }

        private async Task<IEnumerable<dynamic>> GetScrapByProgram(DateTime start, DateTime end, string area, bool isPurchasedScrap = false)
        {
            try
            {
                //query production data
                var productionQry = _productionService.GetProductionQueryable(new ProductionResourceParameter
                {
                    StartDate = start,
                    EndDate = end,
                    Area = area
                });

                var productionByProgram = await productionQry
                        .GroupBy(x => new { x.Program })
                        .Select(x => new
                        {
                            x.Key.Program,
                            TotalProd = x.Sum(s => s.QtyProd)
                        })
                        .ToListAsync()
                        .ConfigureAwait(false);

                //query scrap data
                var finScrap = new List<string> { "anodize", "skirt coat" };
                var scrapQry = _scrapService.GetScrap2Queryable(new ScrapResourceParameter
                {
                    StartDate = start,
                    EndDate = end,
                    IsPurchasedScrap = isPurchasedScrap
                });
                scrapQry = scrapQry.Where(x =>
                        area.ToLower() == "skirt coat"
                            ? (finScrap.Contains(x.ScrapAreaName.ToLower()))
                            : (x.ScrapAreaName == _mapArea.RanameAreaToDepartment(area)));

                var scrap = await scrapQry
                                    .GroupBy(x => new { x.Program, x.Area, x.ScrapAreaName, x.MachineHxh })
                                    .Select(x => new
                                    {
                                        x.Key.Program,
                                        x.Key.Area,
                                        x.Key.ScrapAreaName,
                                        x.Key.MachineHxh,
                                        Qty = x.Sum(s => s.Qty),

                                    })
                                    .ToListAsync()
                                    .ConfigureAwait(false);

                //transform data
                var scrapByProgram = scrap
                                        .GroupBy(x => new
                                        {
                                            x.Program,
                                            ScrapAreaName = (x.ScrapAreaName.ToLower() == "anodize" || x.ScrapAreaName.ToLower() == "skirt coat") ? "Finishing" : x.ScrapAreaName
                                        })
                                        .Select(x => new
                                        {
                                            x.Key.Program,
                                            x.Key.ScrapAreaName,
                                            Qty = x.Sum(t => t.Qty),
                                            AreaDetails = x.GroupBy(a => new { a.Area })
                                                            .Select(a => new
                                                            {
                                                                a.Key.Area,
                                                                Qty = (int)a.Sum(t => t.Qty),
                                                                LineDetails = a.GroupBy(l => new { l.MachineHxh })
                                                                                .Select(l => new
                                                                                {
                                                                                    l.Key.MachineHxh,
                                                                                    Qty = l.Sum(t => t.Qty)
                                                                                })
                                                            })
                                        }).ToList();

                var result = scrapByProgram
                                .Select(x => new
                                {
                                    x.Program,
                                    x.ScrapAreaName,
                                    SapNet = productionByProgram.Any(n => n.Program == x.Program)
                                                ? (int)productionByProgram.Where(n => n.Program == x.Program).Sum(n => n.TotalProd)
                                                : 0,

                                    Qty = scrapByProgram.Any(s => s.Program == x.Program)
                                            ? (int)scrapByProgram.Where(s => s.Program == x.Program).Sum(s => s.Qty)
                                            : 0,

                                    SapGross = (productionByProgram.Any(n => n.Program == x.Program)
                                                ? (int)productionByProgram.Where(n => n.Program == x.Program).Sum(n => n.TotalProd)
                                                : 0)
                                                +
                                                (scrapByProgram.Any(s => s.Program == x.Program)
                                                ? (int)scrapByProgram.Where(s => s.Program == x.Program).Sum(s => s.Qty)
                                                : 0),

                                    AreaDetails = scrapByProgram.Any(s => s.Program == x.Program)
                                                    ? scrapByProgram.First(s => s.Program == x.Program).AreaDetails.ToList()
                                                    : null,
                                })
                                .Select(x => new
                                {
                                    key = $"{x.ScrapAreaName.Replace(" ", "_")}-{x.Program.Replace(" ", "_")}",
                                    x.ScrapAreaName,
                                    x.Program,
                                    x.SapNet,
                                    x.Qty,
                                    x.SapGross,
                                    ScrapRate = x.SapGross == 0 ? 0 : (decimal)x.Qty / x.SapGross,
                                    AreaDetails = x.AreaDetails
                                                    .Select(a => new
                                                    {
                                                        key = $"{x.ScrapAreaName.Replace(" ", "_")}-{x.Program.Replace(" ", "_")}-{a.Area.Replace(" ", "_")}",
                                                        x.ScrapAreaName,
                                                        x.Program,
                                                        a.Area,
                                                        a.Qty,
                                                        ScrapRate = x.SapGross == 0 ? 0 : (decimal)a.Qty / x.SapGross,
                                                        LineDetails = a.LineDetails
                                                                        .Select(l => new
                                                                        {
                                                                            key = $"{x.ScrapAreaName.Replace(" ", "_")}-{x.Program.Replace(" ", "_")}-{a.Area.Replace(" ", "_")}-{l.MachineHxh.Replace(" ", "_")}",
                                                                            x.ScrapAreaName,
                                                                            x.Program,
                                                                            a.Area,
                                                                            Line = l.MachineHxh,
                                                                            l.Qty,
                                                                            ScrapRate = x.SapGross == 0 ? 0 : (decimal)l.Qty / x.SapGross,
                                                                        })
                                                    })
                                                    .OrderByDescending(a => a.ScrapRate)
                                                    .ToList()

                                })
                                .OrderByDescending(x => x.ScrapRate)
                                .ToList();

                return isPurchasedScrap ? result : result.Where(x => x.ScrapRate < 1);

            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

        }

        private async Task<List<DailyScrapByShiftDto>> GetDailyScrapByShiftList(DailyScrapByShiftResourceParameter resourceParams)
        {
            if (resourceParams == null) throw new ArgumentNullException(nameof(resourceParams));

            //get scrap data from repo
            var scrapQry = _scrapService.GetScrap2Queryable(new ScrapResourceParameter
            {
                StartDate = resourceParams.Start,
                EndDate = resourceParams.End,
                IsPurchasedScrap = resourceParams.IsPurchasedScrap,
                ScrapCode = resourceParams.ScrapCode,
                Department = resourceParams.Department,
                Line = resourceParams.Line,
                Program = resourceParams.Program
            });

            var summary = await scrapQry
                .GroupBy(x => new { x.ShiftDate, x.Shift, x.ScrapCode, x.ScrapDesc })
                .Select(x => new DailyScrapByShiftDto
                {
                    ShiftDate = x.Key.ShiftDate.ToDateTime(),
                    Shift = x.Key.Shift,
                    ShiftOrder = MapShiftToShiftOrder(x.Key.Shift),
                    ScrapCode = x.Key.ScrapCode,
                    ScrapDesc = x.Key.ScrapDesc,
                    Qty = x.Sum(s => s.Qty).ToInt()
                })
                .OrderBy(x => x.ShiftDate)
                .ThenBy(x => x.ShiftOrder)
                .ToListAsync()
                .ConfigureAwait(false);

            return summary;
        }

        #endregion


        #region Scrap

        public async Task<dynamic> GetDailyScrapByShift(DailyScrapByShiftResourceParameter resourceParams)
        {
            if (resourceParams == null) throw new ArgumentNullException(nameof(resourceParams));

            var summary = await GetDailyScrapByShiftList(resourceParams).ConfigureAwait(false);
            var distinctShift = summary.Select(x => new { x.Shift, x.ShiftOrder }).Distinct().ToList();

            //transform data
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

        public async Task<IEnumerable<DailyScrapByShiftDateDto>> GetDailyScrapRate(DateTime start, DateTime end, string area, bool isPurchasedScrap = false)
        {
            try
            {
                //query production data
                var productionQry = _productionService.GetProductionQueryable(new ProductionResourceParameter { StartDate = start, EndDate = end, Area = area});
                var production = await productionQry.GroupBy(x => new { x.ShiftDate })
                        .Select(x => new
                        {
                            x.Key.ShiftDate,
                            TotalProd = x.Sum(s => s.QtyProd)
                        })
                        .ToListAsync()
                        .ConfigureAwait(false);

                //query scrap data
                var finScrap = new List<string> { "anodize", "skirt coat" };
                var scrapQry = _scrapService.GetScrap2Queryable(new ScrapResourceParameter
                {
                    StartDate = start,
                    EndDate = end,
                    IsPurchasedScrap = isPurchasedScrap
                });

                scrapQry = scrapQry.Where(x => area.ToLower() == "skirt coat"
                        ? (finScrap.Contains(x.ScrapAreaName.ToLower()))
                        : (x.ScrapAreaName == _mapArea.RanameAreaToDepartment(area)));

                var scrapData = await scrapQry
                        .GroupBy(x => new { x.ShiftDate })
                        .Select(x => new
                        {
                            x.Key.ShiftDate,
                            TotalScrap = x.Sum(s => s.Qty)
                        })
                        .ToListAsync()
                        .ConfigureAwait(false);

                //transform data
                var data = scrapData
                        .Select(x => new DailyScrapByShiftDateDto
                        {
                            ShiftDate = (DateTime)x.ShiftDate,
                            TotalScrap = x.TotalScrap ?? 0,
                            SapNet = production.Where(p => p.ShiftDate == x.ShiftDate).Sum(p => p.TotalProd ?? 0),
                            SapGross = production.Any(p => p.ShiftDate == x.ShiftDate)
                                        ? production.Where(p => p.ShiftDate == x.ShiftDate).Sum(p => p.TotalProd ?? 0) + x.TotalScrap ?? 0
                                        : 0,

                            ScrapRate = (production.Any(p => p.ShiftDate == x.ShiftDate)
                                            ? (decimal)production.Where(p => p.ShiftDate == x.ShiftDate).Sum(p => p.TotalProd ?? 0) + x.TotalScrap ?? 0
                                            : 0) == 0

                                        ? null
                                        : x.TotalScrap / (production.Any(p => p.ShiftDate == x.ShiftDate)
                                              ? (decimal)production.Where(p => p.ShiftDate == x.ShiftDate).Sum(p => p.TotalProd ?? 0) + x.TotalScrap ?? 0
                                              : 0)
                        })
                        .Select(x => new DailyScrapByShiftDateDto
                        {
                            ShiftDate = x.ShiftDate,
                            TotalScrap = x.TotalScrap,
                            SapNet = x.SapNet,
                            SapGross = x.SapGross,
                            ScrapRate = x.SapNet > 0 ? x.ScrapRate : null
                        })
                        .OrderBy(x => x.ShiftDate)
                        .ToList();

                return data;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

        }

        public async Task<List<dynamic>> GetScrapVariance(SapResourceParameter @params)
        {
            var areas = new List<string> { "Foundry Cell", "Machine Line", "Skirt Coat", "Assembly" };
            if (!@params.IsPlantTotal)
            {
                areas = areas.Where(x => x.ToLower().Trim() == @params.Area.ToLower().Trim()).ToList();
            }

            var list = new List<dynamic>();
            foreach (var a in areas)
            {
                var details = await GetPlantWideScrapVariance(@params.Start, @params.End, a, @params.IsPurchasedScrap).ConfigureAwait(false);
                var rec = new
                {
                    ScrapType = a switch
                    {
                        "Foundry Cell" => "Foundry",
                        "Machine Line" => "Machining",
                        "Skirt Coat" => "Finishing",
                        _ => a
                    },
                    Details = details
                };
                list.Add(rec);
            }

            return list;

        }

        public async Task<List<dynamic>> GetScrapVariancePerProgram(SapResourceParameter @params)
        {
            var areas = new List<string> { "Foundry Cell", "Machine Line", "Skirt Coat", "Assembly" };
            if (!@params.IsPlantTotal)
            {
                areas = areas.Where(x => x.ToLower().Trim() == @params.Area.ToLower().Trim()).ToList();
            }

            var list = new List<dynamic>();

            foreach (var a in areas)
            {
                var details = await GetScrapByProgram(@params.Start, @params.End, a, @params.IsPurchasedScrap).ConfigureAwait(false);
                var rec = new
                {
                    ScrapType = a switch
                    {
                        "Foundry Cell" => "Foundry",
                        "Machine Line" => "Machining",
                        "Skirt Coat" => "Finishing",
                        _ => a
                    },
                    Details = details
                };
                list.Add(rec);
            }

            return list;
        }

        public async Task<IEnumerable<dynamic>> GetScrapByShift(SapResourceParameter @params)
        {
            try
            {
                //get production data
                var productionQry = _productionService.GetProductionQueryable(new ProductionResourceParameter
                {
                    StartDate = @params.Start,
                    EndDate = @params.End,
                    Area = @params.Area
                });
                var prodByShift = await productionQry
                                .GroupBy(x => new { x.Shift })
                                .Select(x => new
                                {
                                    x.Key.Shift,
                                    TotalProd = x.Sum(s => s.QtyProd)
                                })
                                .ToListAsync()
                                .ConfigureAwait(false);


                //get scrap data
                var scrapQry = _scrapService.GetScrap2Queryable(new ScrapResourceParameter
                {
                    StartDate = @params.Start,
                    EndDate = @params.End,
                    IsPurchasedScrap = @params.IsPurchasedScrap,
                    Area = @params.Area
                });

                var scrap = await scrapQry
                                    .GroupBy(x => new { x.Area, x.Shift, x.ScrapAreaName, x.MachineHxh })
                                    .Select(x => new
                                    {
                                        x.Key.Area,
                                        x.Key.Shift,
                                        x.Key.ScrapAreaName,
                                        x.Key.MachineHxh,
                                        Qty = x.Sum(s => s.Qty)
                                    })
                                    .ToListAsync().ConfigureAwait(false);

                //transform data
                var scrapByShift = scrap
                                        .GroupBy(x => new { x.Shift })
                                        .Select(x => new
                                        {
                                            x.Key.Shift,
                                            Qty = x.Sum(t => t.Qty),
                                            ScrapAreaName = x.GroupBy(s => new { s.ScrapAreaName })
                                                                .Select(s => new
                                                                {
                                                                    s.Key.ScrapAreaName,
                                                                    Qty = s.Sum(t => t.Qty),
                                                                    LineDetals = s.GroupBy(l => new { l.MachineHxh })
                                                                                    .Select(l => new
                                                                                    {
                                                                                        Line = l.Key.MachineHxh,
                                                                                        Qty = l.Sum(t => t.Qty)
                                                                                    })
                                                                })
                                        }).ToList();

                var result = scrapByShift
                                .Select(x => new
                                {
                                    x.Shift,
                                    SapNet = prodByShift.Any(n => n.Shift == x.Shift)
                                                ? prodByShift.Where(n => n.Shift == x.Shift).Sum(n => n.TotalProd ?? 0)
                                                : 0,

                                    Qty = scrapByShift.Any(s => s.Shift == x.Shift)
                                            ? scrapByShift.Where(s => s.Shift == x.Shift).Sum(s => s.Qty ?? 0)
                                            : 0,

                                    SapGross = (prodByShift.Any(n => n.Shift == x.Shift)
                                                ? prodByShift.Where(n => n.Shift == x.Shift).Sum(n => n.TotalProd ?? 0)
                                                : 0)
                                                +
                                                (scrapByShift.Any(s => s.Shift == x.Shift)
                                                ? scrapByShift.Where(s => s.Shift == x.Shift).Sum(s => s.Qty ?? 0)
                                                : 0),

                                    scrapAreaNameDetails = scrapByShift.Any(s => s.Shift == x.Shift)
                                                            ? scrapByShift.First(s => s.Shift == x.Shift).ScrapAreaName.ToList()
                                                            : null,
                                })
                                .Select(x => new
                                {
                                    key = $"{@params.Area.Replace(" ", "_")}-{x.Shift.Replace(" ", "_")}",
                                    x.Shift,
                                    x.SapNet,
                                    x.Qty,
                                    x.SapGross,
                                    ScrapRate = x.SapGross == 0 ? 0 : (decimal)x.Qty / x.SapGross,
                                    scrapAreaNameDetails = x.scrapAreaNameDetails
                                                        .Select(a => new
                                                        {
                                                            key = $"{@params.Area.Replace(" ", "_")}-{x.Shift.Replace(" ", "_")}_{a.ScrapAreaName.Replace(" ", "_")}",
                                                            x.Shift,
                                                            a.ScrapAreaName,
                                                            a.Qty,
                                                            ScrapRate = x.SapGross == 0 ? 0 : (decimal)a.Qty / x.SapGross,
                                                            LineDetails = a.LineDetals
                                                                            .Select(l => new
                                                                            {
                                                                                key = $"{@params.Area.Replace(" ", "_")}-{x.Shift.Replace(" ", "_")}_{a.ScrapAreaName.Replace(" ", "_")}_{l.Line.Replace(" ", "_")}",
                                                                                x.Shift,
                                                                                a.ScrapAreaName,
                                                                                l.Line,
                                                                                l.Qty,
                                                                                ScrapRate = x.SapGross == 0 ? 0 : (decimal)l.Qty / x.SapGross,
                                                                            }).OrderByDescending(l => l.ScrapRate)
                                                        })
                                                        .OrderByDescending(a => a.ScrapRate)

                                })
                                .OrderByDescending(x => x.ScrapRate)
                                .ToList();

                return @params.IsPurchasedScrap ? result : result.Where(x => x.ScrapRate < 1);

            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public async Task<IEnumerable<dynamic>> GetScrapByDept(SapResourceParameter @params)
        {
            try
            {
                var prod = await _context.Production2
                                .Where(x => x.ShiftDate >= @params.Start && x.ShiftDate <= @params.End)
                                .GroupBy(x => new { x.Area })
                                .Select(x => new
                                {
                                    x.Key.Area,
                                    TotalProd = x.Sum(s => s.QtyProd)
                                })
                                .ToListAsync().ConfigureAwait(false);

                var scrap = await _context.Scrap2
                                    .Where(x => x.ShiftDate >= @params.Start && x.ShiftDate <= @params.End)
                                    .Where(x => x.ScrapCode != "8888")
                                    .Where(x => x.IsPurchashedExclude == @params.IsPurchasedScrap)
                                    .GroupBy(x => new { x.Area, x.ScrapAreaName, x.MachineHxh })
                                    .Select(x => new
                                    {
                                        x.Key.Area,
                                        x.Key.ScrapAreaName,
                                        x.Key.MachineHxh,
                                        Qty = x.Sum(s => s.Qty),

                                    })
                                    .ToListAsync().ConfigureAwait(false);

                var scrapByArea = scrap
                                        .GroupBy(x => new { x.Area })
                                        .Select(x => new
                                        {
                                            x.Key.Area,
                                            Qty = x.Sum(t => t.Qty),
                                            ScrapAreaNameDetails = x.GroupBy(a => new { a.ScrapAreaName })
                                                            .Select(a => new
                                                            {
                                                                a.Key.ScrapAreaName,
                                                                Qty = a.Sum(t => t.Qty ?? 0),
                                                                LineDetails = a.GroupBy(l => new { l.MachineHxh })
                                                                                .Select(l => new
                                                                                {
                                                                                    l.Key.MachineHxh,
                                                                                    Qty = l.Sum(t => t.Qty)
                                                                                })
                                                            })
                                        }).ToList();

                var result = scrapByArea
                                .Select(x => new
                                {
                                    x.Area,
                                    SapNet = prod.Any(n => n.Area == x.Area)
                                                ? prod.Where(n => n.Area == x.Area).Sum(n => n.TotalProd ?? 0)
                                                : 0,

                                    Qty = scrap.Any(s => s.Area == x.Area)
                                            ? scrap.Where(s => s.Area == x.Area).Sum(s => s.Qty ?? 0)
                                            : 0,

                                    SapGross = (prod.Any(n => n.Area == x.Area)
                                                ? prod.Where(n => n.Area == x.Area).Sum(n => n.TotalProd ?? 0)
                                                : 0)
                                                +
                                                (scrap.Any(s => s.Area == x.Area)
                                                ? scrap.Where(s => s.Area == x.Area).Sum(s => s.Qty ?? 0)
                                                : 0),

                                    ScrapAreaNameDetails = scrapByArea.Any(s => s.Area == x.Area)
                                                    ? scrapByArea.First(s => s.Area == x.Area).ScrapAreaNameDetails.ToList()
                                                    : null,
                                })
                                .Select(x => new
                                {
                                    key = $"{x.Area.Replace(" ", "_")}",
                                    x.Area,
                                    x.SapNet,
                                    x.Qty,
                                    x.SapGross,
                                    ScrapRate = x.SapGross == 0 ? 0 : (decimal)x.Qty / x.SapGross,
                                    ScrapAreaNameDetails = x.ScrapAreaNameDetails
                                                            .Select(a => new
                                                            {
                                                                key = $"{x.Area.Replace(" ", "_")}-{a.ScrapAreaName.Replace(" ", "_")}",
                                                                x.Area,
                                                                a.ScrapAreaName,
                                                                a.Qty,
                                                                ScrapRate = x.SapGross == 0 ? 0 : (decimal)a.Qty / x.SapGross,
                                                                LineDetails = a.LineDetails
                                                                                .Select(l => new
                                                                                {
                                                                                    key = $"{x.Area.Replace(" ", "_")}-{a.ScrapAreaName.Replace(" ", "_")}-{l.MachineHxh.Replace(" ", "_")}",
                                                                                    x.Area,
                                                                                    a.ScrapAreaName,
                                                                                    Line = l.MachineHxh,
                                                                                    l.Qty,
                                                                                    ScrapRate = x.SapGross == 0 ? 0 : (decimal)l.Qty / x.SapGross,
                                                                                }).OrderByDescending(o => o.ScrapRate)
                                                            })
                                                            .OrderByDescending(a => a.ScrapRate)
                                                            .ToList()

                                }).OrderByDescending(x => x.ScrapRate).ToList();

                return @params.IsPurchasedScrap ? result : result.Where(x => x.ScrapRate < 1);

            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public async Task<IEnumerable<dynamic>> GetPlantWideScrapVariance(DateTime start, DateTime end, string area = "", bool isPurchasedScrap = false)
        {
            try
            {
                var scrapTypeName = area switch
                {
                    "Foundry Cell" => "Foundry",
                    "Machine Line" => "Machining",
                    "Skirt Coat" => "Finishing",
                    _ => area
                };

                var scrapData = await GetDailyScrapRate(start, end, area, isPurchasedScrap).ConfigureAwait(false);
                var targets = await _fmsb2Repo.GetTargets(area, start.Year, end.Year).ConfigureAwait(false);
                var monthlyTarget = targets
                                .Select(x => new
                                {
                                    x.Department,
                                    x.MonthNumber,
                                    x.Year,
                                    x.Quarter,
                                    x.ScrapRateTarget,
                                    ScrapRateTargetDecimal = x.ScrapRateTarget / 100
                                }).ToList();

                var quarterlyTarget = monthlyTarget
                                        .GroupBy(x => new {x.Year, x.Quarter})
                                        .Select(x => new
                                        {
                                            x.Key.Year,
                                            x.Key.Quarter,
                                            AvgScrapTarget = x.Average(t => t.ScrapRateTarget),
                                            AvgScrapRateTargetDecimal = x.Average(t => t.ScrapRateTarget) / 100
                                        }).ToList();

                var summary = scrapData
                                .GroupBy(x => new { x.ShiftDate.Year, Quarter = x.ShiftDate.ToQuarter() })
                                .Select(x => new
                                {
                                    x.Key.Year,
                                    Quarter = $"{x.Key.Year}-Q{x.Key.Quarter}",
                                    Key = $"{area.Replace(" ", "_")}-{x.Key.Year}-Q{x.Key.Quarter}",
                                    Area = scrapTypeName,
                                    SapGross = x.Sum(t => t.SapGross),
                                    SapNet = x.Sum(t => t.SapNet),
                                    TotalScrap = x.Sum(t => t.TotalScrap),
                                    Target = quarterlyTarget.First(k => k.Quarter == x.Key.Quarter && k.Year == x.Key.Year).AvgScrapRateTargetDecimal,
                                    ScrapRate = x.Sum(t => t.SapGross) == 0
                                                ? 0
                                                : (decimal)x.Sum(t => t.TotalScrap) / x.Sum(t => t.SapGross),

                                    MonthDetails = x.GroupBy(m => new { m.ShiftDate.Month })
                                                    .Select(m => new
                                                    {
                                                        m.Key.Month,
                                                        MonthName = $"{x.Key.Year}-Q{x.Key.Quarter}-{DateTimeFormatInfo.CurrentInfo.GetAbbreviatedMonthName(m.Key.Month)}",
                                                        Key = $"{area.Replace(" ", "_")}-{x.Key.Year}-Q{x.Key.Quarter}-M{m.Key.Month}",
                                                        Area = scrapTypeName,
                                                        SapGross = m.Sum(t => t.SapGross),
                                                        SapNet = m.Sum(t => t.SapNet),
                                                        TotalScrap = m.Sum(t => t.TotalScrap),
                                                        Target = monthlyTarget.First(k => k.MonthNumber == m.Key.Month && k.Year == x.Key.Year).ScrapRateTargetDecimal,
                                                        ScrapRate = m.Sum(t => t.SapGross) == 0
                                                                    ? 0
                                                                    : (decimal)m.Sum(t => t.TotalScrap) / m.Sum(t => t.SapGross),

                                                        WeekDetails = m.GroupBy(w => new { WeekNumber = w.ShiftDate.ToWeekNumber() })
                                                                        .Select(w => new
                                                                        {
                                                                            WeekNumber = $"{x.Key.Year}-Q{x.Key.Quarter}-{DateTimeFormatInfo.CurrentInfo.GetAbbreviatedMonthName(m.Key.Month)}-WK-{w.Key.WeekNumber}",
                                                                            Key = $"{area.Replace(" ", "_")}-{x.Key.Year}-Q{x.Key.Quarter}-M{m.Key.Month}-WK{w.Key.WeekNumber}",
                                                                            Area = scrapTypeName,
                                                                            SapGross = w.Sum(t => t.SapGross),
                                                                            SapNet = w.Sum(t => t.SapNet),
                                                                            TotalScrap = w.Sum(t => t.TotalScrap),
                                                                            ScrapRate = w.Sum(t => t.SapGross) == 0
                                                                                            ? 0
                                                                                            : (decimal)w.Sum(t => t.TotalScrap) / w.Sum(t => t.SapGross),
                                                                        }).OrderBy(w => w.WeekNumber)
                                                    }).OrderBy(m => m.Month)
                                }).OrderBy(x => x.Year).ThenBy(x => x.Quarter);

                return summary;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }



        #endregion

        #region Production KPI

        public async Task<GetSapProdAndScrapDto> GetSapProdAndScrap(SapResourceParameter @params)
        {
            //get data from db
            var prod = await _context.Production2
                            .Where(x => x.ShiftDate >= @params.Start && x.ShiftDate <= @params.End)
                            .Where(x => x.Area == @params.Area)
                            .GroupBy(x => new { x.ShiftDate, x.Area })
                            .Select(x => new DailySapProdDto
                            {
                                ShiftDate = (DateTime)x.Key.ShiftDate,
                                Area = x.Key.Area,
                                Qty = (int)x.Sum(s => s.QtyProd)
                            })
                            .OrderBy(x => x.ShiftDate)
                            .ToListAsync();

            var scrap = await _context.Scrap2
                            .Where(x => x.ShiftDate >= @params.Start && x.ShiftDate <= @params.End)
                            .Where(x => x.ScrapAreaName == _mapArea.RanameAreaToDepartment(@params.Area))
                            .Where(x => x.ScrapCode != "8888")
                            .GroupBy(x => new
                            {
                                x.ScrapAreaName,
                                x.Area,
                                x.IsPurchashedExclude,
                                x.IsPurchashedExclude2,
                                x.ScrapCode,
                                x.ScrapDesc,
                            })
                            .Select(x => new
                            {
                                x.Key.Area,
                                x.Key.ScrapAreaName,
                                x.Key.ScrapCode,
                                x.Key.ScrapDesc,
                                IsPurchaseScrap = x.Key.IsPurchashedExclude ?? false,
                                ScrapType = x.Key.IsPurchashedExclude2,
                                Qty = (int)x.Sum(s => s.Qty ?? 0)
                            })
                            .OrderByDescending(x => x.Qty)
                            .ToListAsync();

            var targets = (await _productionService.GetHxhProduction(@params.Start, @params.End, @params.Area).ConfigureAwait(false)).ToList();

            //transform data ScrapByCodeDetailsDto

            var target = targets.Sum(x => x.Target);
            var sapProd = prod.Sum(x => x.Qty);
            var sbScrap = scrap.Where(x => x.IsPurchaseScrap == false).Sum(x => x.Qty);
            var purchasedScrap = scrap.Where(x => x.IsPurchaseScrap).Sum(x => x.Qty);

            var sapGross = sapProd + sbScrap;
            var sbScrapRate = sapGross == 0 ? 0 : sbScrap / (decimal)sapGross;
            var purchaseScrapRate = sapGross == 0 ? 0 : purchasedScrap / (decimal)sapGross;
            var sapOae = target == 0 ? 0 : sapProd / target;

            var scrapByType = scrap
                    //.Where(sb => sb.IsPurchaseScrap == false)
                    .GroupBy(sb => new { sb.Area, sb.ScrapType, sb.ScrapAreaName, sb.IsPurchaseScrap })
                    .Select(sb => new ScrapByCodeDetailsDto
                    {
                        Area = sb.Key.Area,
                        ScrapType = sb.Key.ScrapType,
                        ScrapAreaName = sb.Key.ScrapAreaName,
                        IsPurchaseScrap = sb.Key.IsPurchaseScrap,
                        Qty = sb.Sum(t => t.Qty),
                        SapGross = sapProd + sb.Sum(t => t.Qty),
                        ScrapRate = (sapProd + sb.Sum(t => t.Qty)) == 0 ? 0 : (decimal)sb.Sum(t => t.Qty) / (decimal)(sapProd + sb.Sum(t => t.Qty)),
                        Details = sb.GroupBy(d => new { d.ScrapCode, d.ScrapDesc })
                                    .Select(d => new Models.SAP.Scrap
                                    {
                                        Area = @params.Area,
                                        ScrapAreaName = sb.Key.ScrapAreaName,
                                        ScrapCode = d.Key.ScrapCode,
                                        ScrapDesc = d.Key.ScrapDesc,
                                        Qty = d.Sum(t => t.Qty)
                                    }).OrderByDescending(d => d.Qty)
                    })
                    .OrderByDescending(sb => sb.Qty)
                    .ToList();

            return new GetSapProdAndScrapDto
            {
                StartDate = @params.Start,
                EndDate = @params.End,

                Target = (int)target,
                SapProd = sapProd,
                SbScrap = sbScrap,
                PurchasedScrap = purchasedScrap,
                SapGross = sapGross,
                SbScrapRate = sbScrapRate,
                PurchaseScrapRate = purchaseScrapRate,
                SapOae = sapOae,
                DailySapProd = prod,
                SbScrapDetail = scrapByType.Where(x => x.IsPurchaseScrap == false),
                PurchaseScrapDetail = scrapByType.Where(x => x.IsPurchaseScrap == true)
            };

        }

        public async Task<ProductionMorningMeetingDto> GetProductionData(SapResourceParameter @params)
        {
            //load data from db
            var scrapByScrapArea = (await GetScrapDataByScrapAreaFromDb(@params.Start, @params.End, @params.Area).ConfigureAwait(false)).ToList();
            var scrapByDepartment = (await GetScrapDataByDepartmentFromDb(@params.Start, @params.End, @params.Area).ConfigureAwait(false)).ToList();

            var sapProdByArea = (await GetSapProdByAreaFromDb(@params.Start, @params.End, @params.Area).ConfigureAwait(false)).ToList();
            var sapProdByType = (await GetSapProdByTypeFromDb(@params.Start, @params.End, @params.Area).ConfigureAwait(false)).ToList();

            var hxh = (await _productionService.GetHxhProduction(@params.Start, @params.End, @params.Area).ConfigureAwait(false)).ToList();

            var targets = await _fmsb2Repo.GetTargets(@params.Area, @params.Start, @params.End).ConfigureAwait(false);

            //transform data
            var sbScrap = scrapByScrapArea
                            .Where(x => x.IsPurchashedExclude == false)
                            .Where(x => x.ScrapCode != "8888")
                            .GroupBy(x => new { x.Department, x.Area, x.ScrapAreaName, x.IsPurchashedExclude2 })
                            .Select(x => new
                            {
                                x.Key.Department,
                                x.Key.Area,
                                x.Key.ScrapAreaName,
                                x.Key.IsPurchashedExclude2,
                                qty = x.Sum(s => s.Qty)
                            }).ToList();

            var overallScrap = scrapByScrapArea
                                .Where(x => x.ScrapCode != "8888")
                                .GroupBy(x => new { x.Department, x.Area })
                                .Select(x => new
                                {
                                    x.Key.Department,
                                    x.Key.Area,
                                    qty = x.Sum(s => s.Qty)
                                }).ToList();

            var warmersCodes = new List<string> { "8888", "8889" };
            var warmers = scrapByScrapArea
                            .Where(x => warmersCodes.Contains(x.ScrapCode))
                            .GroupBy(x => new { x.Department, x.Area, x.ScrapAreaName, x.ScrapCode, x.ScrapDesc })
                            .Select(x => new
                            {
                                x.Key.Department,
                                x.Key.Area,
                                x.Key.ScrapAreaName,
                                x.Key.ScrapCode,
                                x.Key.ScrapDesc,
                                qty = x.Sum(s => s.Qty)
                            }).ToList();

            //labor hours
            List<SapProdDto> prodForLaborHours;
            List<FinanceLaborHoursView> laborHrs;
            var startDayForLaborHoursIfYesterday = @params.End.AddDays(-6);

            //check if date is yesterday, if yes subtract -6 day from end day and store in a variable
            if (@params.Start.IsYesterday())
            {
                //get data from the db with the new date range
                prodForLaborHours = await _fmsb2Repo.GetProdForLaborHrs(startDayForLaborHoursIfYesterday, @params.End, @params.Area).ConfigureAwait(false);

                //get labor hrs data from db
                laborHrs = await _fmsb2Repo.GetLaborHoursData(startDayForLaborHoursIfYesterday, @params.End, @params.Area).ConfigureAwait(false);
            }
            else
            {
                //use the original db request for prod and scrap
                prodForLaborHours = sapProdByArea;

                //use unmodified date range
                laborHrs = await _fmsb2Repo.GetLaborHoursData(@params.Start, @params.End, @params.Area).ConfigureAwait(false);
            }

            var result = hxh
                            .Select(x =>
                            {
                                var prodByArea = sapProdByArea.Where(s => s.Area == x.Area).ToList();
                                var sbScrapByArea = sbScrap.Where(w => w.Area == x.Area).ToList();
                                var warmersByArea = warmers.Where(w => w.Area == x.Area).ToList();

                                var sapGross = prodByArea.Sum(s => s.Qty) + sbScrapByArea.Sum(w => w.qty); // net + scrap in area
                                var plannedWarmers = warmersByArea.Where(w => w.ScrapCode == "8888").Sum(w => w.qty);
                                var unPlannedWarmers = warmersByArea.Where(w => w.ScrapCode == "8889").Sum(w => w.qty);
                                var totalSbScrap = sbScrapByArea.Sum(w => w.qty);
                                var sapNet = prodByArea.Sum(s => s.Qty);
                                var sapOae = (int) x.Target == 0 ? 0 : (decimal)sapNet / x.Target;
                                var sapColorCode = GetColorCode(targets, "oae", sapOae);
                                var hxhOae = x.Target == 0 ? 0 : (decimal) x.Net / x.Target;
                                var hxhOaeColorCode = GetColorCode(targets, "oae", hxhOae);
                                var sbScrapByCode = GetScrapByCode(scrapByScrapArea, x.Area, true, sapNet);
                                var purchasedScrapByCode = GetScrapByCode(scrapByScrapArea, x.Area, false, sapNet);
                                var deptScrap = GetDepartmentScrap(scrapByDepartment, x.Area, sapNet);
                                var scrapByCodeColorCode = GetColorCode(targets, "scrap", sbScrapByCode.ScrapRate);
                                var ppmhColorCode = GetColorCode(targets, "ppmh",  _fmsb2Repo.GetRollingDaysPPMH(prodForLaborHours, laborHrs, @params.Start, @params.End).PPMH);

                                return new ProductionMorningMeetingDto
                                {
                                    Department = x.Department,
                                    Area = x.Area,
                                    Target = (int)x.Target,
                                    HxhGross = x.Gross,
                                    SapGross = sapGross,

                                    PlannedWarmers = plannedWarmers,
                                    UnPlannedWarmers = unPlannedWarmers,

                                    TotalSbScrap = totalSbScrap,
                                    TotalScrapByDept = overallScrap.Where(w => w.Area == x.Area).Sum(w => w.qty),
                                    SapNet = sapNet,
                                    SapOae = sapOae,
                                    SapOaeColorCode = sapColorCode,
                                    HxHNet = x.Net,
                                    HxhOae = hxhOae,
                                    HxhOaeColorCode = hxhOaeColorCode,
                                    SbScrapByCode = sbScrapByCode,
                                    PurchaseScrapByCode = purchasedScrapByCode,
                                    DepartmentScrap = deptScrap,
                                    SapProductionByType = GetSapProductionByType(sapProdByType, x.Area),
                                    LaborHours = _fmsb2Repo.GetRollingDaysPPMH(prodForLaborHours, laborHrs, @params.Start, @params.End),

                                    ScrapByCodeColorCode = scrapByCodeColorCode,
                                    PpmhColorCode = ppmhColorCode,
                                    Targets = targets
                                };
                    
                            })
                            .FirstOrDefault();

            return result;

        }

        public async Task<DepartmentKpiDto> GetDepartmentKpi(SapResourceParameter @params)
        {
            if (@params.Area == null) throw new ArgumentNullException(nameof(@params.Area));

            var deptHxh = @params.Area.ToLower().Trim() switch
            {
                "foundry cell" => "Foundry",
                "machine line" => "Machining",
                _ => @params.Area
            };

            //get data from db
            var production = await _context.Production2
                               .Where(x => x.ShiftDate >= @params.Start && x.ShiftDate <= @params.End)
                               .Where(x => x.Area.ToLower() == @params.Area.ToLower().Trim())
                               .GroupBy(x => new { x.Area })
                               .Select(x => new
                               {
                                   x.Key.Area,
                                   TotalProd = x.Sum(s => s.QtyProd)
                               })
                               .ToListAsync()
                               .ConfigureAwait(false);

            var scrapData = await _context.Scrap2
                                .Where(x => x.ShiftDate >= @params.Start && x.ShiftDate <= @params.End)
                                .Where(x => x.Area.ToLower() == @params.Area.ToLower().Trim())
                                .Where(x => x.ScrapCode != "8888")
                                .GroupBy(x => new { x.Area, x.ScrapAreaName })
                                .Select(x => new
                                {
                                    x.Key.Area,
                                    x.Key.ScrapAreaName,
                                    TotalScrap = x.Sum(s => s.Qty)
                                })
                                .ToListAsync()
                                .ConfigureAwait(false);

            var hxhTarget = await _productionService.HxHTargetByArea(@params.Start, @params.End, @params.Area).ConfigureAwait(false);
            var scrapAreaCode = await _context.ScrapAreaCode.ToListAsync().ConfigureAwait(false);
            var oaeTarget = ((await _fmsb2Repo.GetTargets(@params.Area, @params.Start.Year, @params.End.Year))
                                    .First(x => x.Year == @params.End.Year && x.MonthNumber == @params.End.Month).OaeTarget) / 100;

            var downtimeData = (await _fmsbMvcRepo.GetDowntime(new DowntimeResourceParameter { Start = @params.Start, End = @params.End }).ConfigureAwait(false));
            downtimeData = downtimeData.Where(x => x.Dept.ToLower().Trim() == deptHxh.ToLower().Trim()).ToList();

            //get line targets for pph to convert downtime minutes to pa
            var lineTarget = (await _fmsbContext.SwotTargetWithDeptId
                                .Where(x => x.DeptName == deptHxh)
                                .ToListAsync()
                                .ConfigureAwait(false))
                                .Select(x => new
                                {
                                    x.DeptName,
                                    x.MachineName,
                                    x.TargetPartsPerHour,
                                    PartsPerMinute = x.TargetPartsPerHour / 60
                                }).ToList();

            //transform data

            var totalDowntimeParts = downtimeData
                                        .GroupBy(x => new { x.Dept, x.Line })
                                        .Select(x => new
                                        {
                                            x.Key.Dept,
                                            x.Key.Line,
                                            Downtime = x.Sum(s => s.DowntimeLoss),
                                            DowntimeParts = lineTarget.Any(l => l.MachineName == x.Key.Line)
                                                                ? lineTarget.First(l => l.MachineName == x.Key.Line).PartsPerMinute * x.Sum(s => s.DowntimeLoss)
                                                                : 0
                                        })
                                        .Sum(x => x.DowntimeParts);

            var totalAreaScrap = scrapData.Sum(x => x.TotalScrap ?? 0);
            var totalProduction = production.Sum(x => x.TotalProd ?? 0);
            var totalTarget = hxhTarget.Sum(x => x.Target);
            var sapGross = totalProduction + totalAreaScrap;

            //rates

            var sapOae = totalTarget == 0 ? 0 : (decimal)totalProduction / (decimal)totalTarget;
            var overallScrapRate = sapGross == 0 ? 0 : (decimal)totalAreaScrap / (decimal)sapGross;
            var downtimeRate = totalTarget == 0 ? 0 : (decimal) (totalDowntimeParts ?? 0) / totalTarget;

            var totalRates = 1 - sapOae - overallScrapRate - downtimeRate;
            var unknownRate = 0m;

            if (totalRates > 1 || totalRates < 0)
            {
                downtimeRate = 1 - sapOae - overallScrapRate;
                unknownRate = 0;
            }
            else
            {
                unknownRate = 1 - sapOae - overallScrapRate - downtimeRate;
            }

            var scrapDetails = scrapData.Select(x => new DepartmentKpiScrapDetailsDto
            {
                ScrapAreaName = x.ScrapAreaName,
                ScrapQty = x.TotalScrap ?? 0,
                ScrapRate = sapGross == 0 ? 0 : (decimal) (x.TotalScrap ?? 0) / sapGross,
                ColorCode = scrapAreaCode.Any(s => s.ScrapAreaName == x.ScrapAreaName)
                                ? scrapAreaCode.First(s => s.ScrapAreaName == x.ScrapAreaName).ColorCode
                                : scrapAreaCode.First(s => s.ScrapAreaName == "Other").ColorCode
            }).ToList();

            var res = new DepartmentKpiDto
            {
                Area = @params.Area,
                TotalAreaScrap = totalAreaScrap,
                TotalProduction = totalProduction,
                Target = totalTarget,
                SapGross = sapGross,
                SapOae = sapOae,
                OaeTarget = oaeTarget,
                OaeColor = sapOae >= oaeTarget ? "#19bc9c" : "#e74d3d",
                OverallScrapRate = overallScrapRate,
                DowntimeRate = downtimeRate,
                UnkownRate = unknownRate,
                ScrapDetails = scrapDetails
            };

            return res;
        }

        public async Task<DepartmentDetailsDto> GetDepartmentDetails(DateTime start, DateTime end, string area)
        {
            if (area == null) throw new ArgumentNullException(nameof(area));

            //get data from db
            var scrapData = (await GetScrapDataByDepartmentFromDb(start, end, area).ConfigureAwait(false)).ToList();

            var prod = await _context.Production2
                                .Where(x => x.ShiftDate >= start && x.ShiftDate <= end)
                                .Where(x => x.Area == area)
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

            var hxh = await _productionService.GetHxhProdByLineAndProgram(start, end, area)
                            .ConfigureAwait(false);

            var lineTargets = await _fmsbContext.SwotTargetWithDeptId.Where(x => x.DeptName == _mapArea.RanameAreaToDepartment(area))
                               .ToListAsync()
                               .ConfigureAwait(false);

            var kpiTarget = await _fmsb2Repo.GetTargets(area, start, end).ConfigureAwait(false);

            //transform data
            var scrap = scrapData.Where(x => x.ScrapCode != "8888").ToList();
            var warmers = scrapData.Where(x => x.ScrapCode == "8888").ToList();

            //get overall total
            var target = hxh.LineDetails.Sum(x => x.Target);
            var sapNet = prod.Sum(x => x.SapNet);
            var totalScrap = scrap.Sum(x => x.Qty);
            var totalSbScrap = scrap.Where(x => x.IsPurchashedExclude == false).Sum(x => x.Qty);
            var totalPurchasedScrap = scrap.Where(x => x.IsPurchashedExclude == true).Sum(x => x.Qty);

            var sapGross = sapNet + totalScrap;
            var totalScrapRate = sapGross == 0 ? 0 : (decimal)totalScrap / (decimal)sapGross;

            var totalSbScrapRate = sapGross == 0 ? 0 : (decimal)totalSbScrap / (decimal)sapGross;
            var totalPurchasedScrapRate = sapGross == 0 ? 0 : (decimal)totalPurchasedScrap / (decimal)sapGross;

            var sapOae = target == 0 ? 0 : (decimal)sapNet / (decimal)target;

            var hxhGross = hxh.LineDetails.Sum(x => x.Gross);
            var hxhNet = (area.ToLower() == "foundry cell" || area.ToLower() == "machine line") ? hxhGross - totalScrap : hxhGross;
            var hxhOae = target == 0 ? 0 : (decimal)hxhNet / (decimal)target;

            var scrapAreaDetails = scrap
                                        .Where(s => s.IsPurchashedExclude == false)
                                        .GroupBy(s => new { s.Area, s.ScrapAreaName, s.IsPurchashedExclude2 })
                                        .Select(s => new ScrapByCodeDetailsDto
                                        {
                                            Area = s.Key.Area,
                                            ScrapType = s.Key.IsPurchashedExclude2,
                                            ScrapAreaName = s.Key.ScrapAreaName,
                                            Qty = s.Sum(s => s.Qty),
                                            SapGross = sapGross,
                                            ScrapRate = sapGross == 0 ? 0 : (decimal)s.Sum(s => s.Qty) / (decimal)sapGross,
                                            Details = scrap
                                                        .Where(d => d.IsPurchashedExclude == false)
                                                        .Where(d => d.ScrapAreaName == s.Key.ScrapAreaName)
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
                                                        .OrderByDescending(d => d.Qty)
                                        }).ToList();

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



            return new DepartmentDetailsDto
            {
                Area = area,
                Target = (int)target,
                SapGross = sapGross,
                OaeTarget = kpiTarget.OaeTarget / 100,
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
                DetailsByLine = GetDepartmentDetailsByLine(scrap, prod, hxh.LineDetails.ToList(), warmers, lineTargets),
                DetailsByProgram = GetDepartmentDetailsByProgram(scrap, prod, hxh.ProgramDetails.ToList()),
                SbScrapDetails = scrapList.Where(s => s.IsPurchashedExclude == false),
                PurchaseScrapDetails = scrapList.Where(s => s.IsPurchashedExclude == true)
            };

        }

        public async Task<IEnumerable<DailyDepartmentKpiDto>> GetDailyKpiChart(DateTime start, DateTime end, string area)
        {
            //get data from db
            var production = await _context.Production2
                               .Where(x => x.ShiftDate >= start && x.ShiftDate <= end)
                               .Where(x => x.Area == area)
                               .GroupBy(x => new { x.ShiftDate, x.Area })
                               .Select(x => new
                               {
                                   x.Key.Area,
                                   x.Key.ShiftDate,
                                   TotalProd = x.Sum(s => s.QtyProd)
                               })
                               .ToListAsync()
                               .ConfigureAwait(false);

            var scrapData = await _context.Scrap2
                                .Where(x => x.ShiftDate >= start && x.ShiftDate <= end)
                                .Where(x => x.Area == area)
                                .Where(x => x.ScrapCode != "8888")
                                .GroupBy(x => new { x.ShiftDate, x.Area })
                                .Select(x => new
                                {
                                    x.Key.Area,
                                    x.Key.ShiftDate,
                                    TotalScrap = x.Sum(s => s.Qty)
                                })
                                .ToListAsync()
                                .ConfigureAwait(false);

            var target = (await _productionService.DailyHxHTargetByArea(start, end, area).ConfigureAwait(false)).ToList();

            //transform data
            var result = production
                            .Select(x => new DailyDepartmentKpiDto
                            {
                                Area = x.Area,
                                ShiftDate = (DateTime)x.ShiftDate,
                                TotalProduction = (int)x.TotalProd,

                                TotalAreaScrap = scrapData.All(s => s.ShiftDate != x.ShiftDate) ? 0
                                                    : (int)scrapData.Where(s => s.ShiftDate == x.ShiftDate).Sum(s => s.TotalScrap),

                                Target = target.All(s => s.ShiftDate != x.ShiftDate) ? 0
                                            : target.Where(s => s.ShiftDate == x.ShiftDate).Sum(s => s.Target)
                            })
                            .Select(x => new DailyDepartmentKpiDto
                            {
                                Area = x.Area,
                                ShiftDate = x.ShiftDate,
                                TotalProduction = x.TotalProduction,
                                TotalAreaScrap = x.TotalAreaScrap,
                                Target = x.Target,
                                SapGross = x.TotalAreaScrap + x.TotalProduction
                            })
                            .Select(x => new DailyDepartmentKpiDto
                            {
                                Area = x.Area,
                                ShiftDate = x.ShiftDate,
                                TotalProduction = x.TotalProduction,
                                TotalAreaScrap = x.TotalAreaScrap,
                                Target = x.Target,
                                SapGross = x.SapGross,

                                SapOae = Math.Round((x.Target == 0 ? 0 : x.TotalProduction / (decimal)x.Target), 2),
                                ScrapRate = Math.Round((x.SapGross == 0 ? 0 : x.TotalAreaScrap / (decimal)x.SapGross), 2),
                                DowntimeRate = Math.Round((
                                                (1 - (x.SapGross == 0 ? 0 : x.TotalAreaScrap / (decimal)x.SapGross)
                                                   - (x.Target == 0 ? 0 : x.TotalProduction / (decimal)x.Target)) < 0
                                                ? 0
                                                : (1
                                                    - (x.SapGross == 0 ? 0 : x.TotalAreaScrap / (decimal)x.SapGross)
                                                    - (x.Target == 0 ? 0 : x.TotalProduction / (decimal)x.Target))
                                                ), 2)
                            })
                            .OrderBy(x => x.ShiftDate)
                            .ToList();

            return result;
        }

        #endregion


        #region Labor Hours

        public async Task<IEnumerable<dynamic>> GetPpmhPerDeptPlantWideVariance(SapResourceParameter @params)
        {
            try
            {
                if (@params.Area == null) throw new ArgumentNullException(nameof(@params.Area));

                var deptForTarget = @params.Area.ToLower().Trim() switch
                {
                    "foundry cell" => "foundry",
                    "machine line" => "machining",
                    "skirt coat" => "skirt coat",
                    _ => @params.Area
                };

                //get data from db run in parallel
                var laborHours = await _fmsb2Repo.GetLaborHoursData(@params.Start, @params.End, @params.Area).ConfigureAwait(false);

                var prod = (await _context.Production2
                                        .Where(x => x.ShiftDate >= @params.Start && x.ShiftDate <= @params.End && x.Area == @params.Area)
                                        .GroupBy(x => new { x.ShiftDate, x.Area })
                                        .Select(x => new
                                        {
                                            x.Key.Area,
                                            x.Key.ShiftDate,
                                            Qty = x.Sum(t => t.QtyProd)
                                        })
                                        .ToListAsync().ConfigureAwait(false))
                                        .Select(x => new
                                        {
                                            x.Area,
                                            x.ShiftDate,
                                            Convert.ToDateTime(x.ShiftDate).Year,
                                            Convert.ToDateTime(x.ShiftDate).Month,
                                            Quarter = Convert.ToDateTime(x.ShiftDate).ToQuarter(),
                                            WeekNumber = Convert.ToDateTime(x.ShiftDate).ToWeekNumber(),
                                            x.Qty
                                        })
                                        .ToList();

                var scrap = (await _context.Scrap2
                                        .Where(x => x.ShiftDate >= @params.Start && x.ShiftDate <= @params.End && x.Area == @params.Area)
                                        .Where(x => x.ScrapCode != "8888")
                                        .GroupBy(x => new { x.ShiftDate, x.Area })
                                        .Select(x => new
                                        {
                                            x.Key.Area,
                                            x.Key.ShiftDate,
                                            Qty = x.Sum(t => t.Qty)
                                        })
                                        .ToListAsync().ConfigureAwait(false))
                                        .Select(x => new
                                        {
                                            x.Area,
                                            x.ShiftDate,
                                            Convert.ToDateTime(x.ShiftDate).Year,
                                            Convert.ToDateTime(x.ShiftDate).Month,
                                            Quarter = Convert.ToDateTime(x.ShiftDate).ToQuarter(),
                                            WeekNumber = Convert.ToDateTime(x.ShiftDate).ToWeekNumber(),
                                            x.Qty
                                        })
                                        .ToList();

                var monthlyTarget = await _fmsbContext.KpiTarget
                                    .Where(x => x.Year >= @params.Start.Year && x.Year <= @params.End.Year)
                                    .Where(x => x.Department.ToLower() == deptForTarget)
                                    .ToListAsync().ConfigureAwait(false);

                var quarterlyTarget = monthlyTarget
                                            .GroupBy(x => new { x.Year, x.Quarter })
                                            .Select(x => new
                                            {
                                                x.Key.Year,
                                                x.Key.Quarter,
                                                LaborHoursTarget = x.Average(t => t.PpmhTarget)
                                            }).ToList();

                //transform data
                var result = prod.GroupBy(x => new { x.Year, x.Quarter })
                .Select(x => new
                {
                    Key = $"{x.Key.Year}-Q{x.Key.Quarter}",
                    x.Key.Year,
                    x.Key.Quarter,
                    Target = quarterlyTarget.First(t => t.Year == x.Key.Year && t.Quarter == x.Key.Quarter).LaborHoursTarget,
                    SapNet = x.Sum(t => t.Qty),
                    SapScrap = scrap.Where(s => s.Year == x.Key.Year && s.Quarter == x.Key.Quarter).Sum(s => s.Qty),
                    SapGross = scrap.Where(s => s.Year == x.Key.Year && s.Quarter == x.Key.Quarter).Sum(s => s.Qty) + x.Sum(t => t.Qty),
                    LaborHours = _fmsb2Repo.GetPPMH((int)x.Sum(t => t.Qty),
                                    laborHours.Where(l => l.Year == x.Key.Year && l.Quarter == x.Key.Quarter).ToList()),

                    MonthDetails = x.GroupBy(m => new { m.Year, m.Quarter, m.Month })
                                    .Select(m => new
                                    {
                                        Key = $"{m.Key.Year}-Q{m.Key.Quarter}-M{m.Key.Month}",
                                        m.Key.Year,
                                        m.Key.Quarter,
                                        m.Key.Month,
                                        Target = monthlyTarget.First(t => t.Year == m.Key.Year && t.MonthNumber == m.Key.Month).PpmhTarget,
                                        SapNet = m.Sum(t => t.Qty),
                                        SapScrap = scrap.Where(s => s.Year == m.Key.Year && s.Quarter == m.Key.Quarter && s.Month == m.Key.Month).Sum(s => s.Qty),
                                        SapGross = (int)scrap.Where(s => s.Year == m.Key.Year && s.Quarter == m.Key.Quarter && s.Month == m.Key.Month).Sum(s => s.Qty) + (int)m.Sum(t => t.Qty),
                                        LaborHours = _fmsb2Repo.GetPPMH((int)m.Sum(t => t.Qty),
                                                        laborHours.Where(l => l.Year == m.Key.Year && l.Quarter == m.Key.Quarter && l.Month == m.Key.Month).ToList()),

                                        WeekDetails = m.GroupBy(w => new { w.Year, w.Quarter, w.Month, w.WeekNumber })
                                                        .Select(w => new
                                                        {
                                                            Key = $"{w.Key.Year}-Q{w.Key.Quarter}-M{w.Key.Month}-W{w.Key.WeekNumber}",
                                                            w.Key.Year,
                                                            w.Key.Quarter,
                                                            w.Key.Month,
                                                            w.Key.WeekNumber,
                                                            SapNet = w.Sum(t => t.Qty),
                                                            SapScrap = scrap.Where(s => s.Year == w.Key.Year && s.Quarter == w.Key.Quarter && s.Month == w.Key.Month && s.WeekNumber == w.Key.WeekNumber).Sum(s => s.Qty),
                                                            SapGross = (int)scrap.Where(s => s.Year == w.Key.Year && s.Quarter == w.Key.Quarter && s.Month == w.Key.Month && s.WeekNumber == w.Key.WeekNumber).Sum(s => s.Qty) + (int)w.Sum(t => t.Qty),
                                                            LaborHours = _fmsb2Repo.GetPPMH((int)w.Sum(t => t.Qty),
                                                                            laborHours.Where(l => l.Year == w.Key.Year && l.Quarter == w.Key.Quarter && l.Month == w.Key.Month && l.WeekNumber == w.Key.WeekNumber).ToList()),
                                                        }).OrderBy(w => w.WeekNumber)

                                    }).OrderBy(m => m.Month)
                })
                .OrderBy(x => x.Year).ThenBy(x => x.Quarter)
                .ToList();

                return result;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

        }

        public async Task<IEnumerable<dynamic>> GetPpmhPerShiftVariance(SapResourceParameter @params)
        {
            try
            {
                if (@params.Area == null) throw new ArgumentNullException(nameof(@params.Area));

                var deptName = @params.Area;
                var deptForTarget = @params.Area;
                switch (@params.Area.ToLower().Trim())
                {
                    case "foundry cell":
                        deptName = "foundry";
                        deptForTarget = "foundry";
                        break;
                    case "machine line":
                        deptName = "machining";
                        deptForTarget = "machining";
                        break;
                    case "skirt coat":
                        deptName = "finishing";
                        deptForTarget = "skirt coat";
                        break;
                }


                //get data from db run in parallel
                var laborHours = await _fmsb2Repo.GetLaborHoursData(@params.Start, @params.End, @params.Area).ConfigureAwait(false);

                var prod = await _context.Production2
                                        .Where(x => x.ShiftDate >= @params.Start && x.ShiftDate <= @params.End && x.Area == @params.Area)
                                        .GroupBy(x => new { x.Shift, x.Area })
                                        .Select(x => new
                                        {
                                            x.Key.Area,
                                            x.Key.Shift,
                                            Qty = x.Sum(t => t.QtyProd)
                                        })
                                        .ToListAsync()
                                        .ConfigureAwait(false);

                var ppmhTarget = await _fmsbContext.KpiTarget
                                    .Where(x => x.Year >= @params.Start.Year && x.Year <= @params.End.Year)
                                    .Where(x => x.MonthNumber >= @params.Start.Month && x.MonthNumber <= @params.End.Month)
                                    .Where(x => x.Department.ToLower() == deptForTarget)
                                    .AverageAsync(x => x.PpmhTarget)
                                    .ConfigureAwait(false);

                var uniqueShifts = prod.Select(x => x.Shift).Distinct().ToList();

                return uniqueShifts.Select(shift => new
                {
                    Area = deptName,
                    Shift = shift,
                    Target = ppmhTarget,
                    SapNet = prod.Where(p => p.Shift == shift).Sum(t => t.Qty),
                    SapScrap = 0,
                    SapGross = 0,
                    LaborHours = _fmsb2Repo.GetPPMH((int)prod.Where(p => p.Shift == shift).Sum(t => t.Qty), laborHours.Where(l => l.Shift2 == shift).ToList()),
                })
                    .Cast<dynamic>()
                    .ToList();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

        }

        public async Task<IEnumerable<dynamic>> GetPlantWidePpmh(SapResourceParameter @params)
        {
            //get data from db
            var p1S = new List<string> { "P1A", "P1F", "P1M" };

            #region DB SAP Net

            var sapNetLessDmax = await _context.Production2
                    .Where(x => x.ShiftDate >= @params.Start && x.ShiftDate <= @params.End)
                    .Where(x => x.Program != "DMAX")
                    .Where(x => x.Material.StartsWith("P1A") || x.Material.StartsWith("P1F") || x.Material.StartsWith("P1M"))
                    .GroupBy(x => new { x.ShiftDate })
                    .Select(x => new
                    {
                        x.Key.ShiftDate,
                        Qty = x.Sum(t => t.QtyProd)
                    })
                    .ToListAsync()
                    .ConfigureAwait(false);

            var dmaxSapNet = await _context.Production2
                                .Where(x => x.ShiftDate >= @params.Start && x.ShiftDate <= @params.End)
                                .Where(x => x.Program == "DMAX")
                                .GroupBy(x => new { x.ShiftDate })
                                .Select(x => new
                                {
                                    x.Key.ShiftDate,
                                    Qty = x.Sum(t => t.QtyProd)
                                })
                                .ToListAsync()
                                .ConfigureAwait(false);

            #endregion

            #region DB Labor Hours

            var plantLaborHours = await _fmsb2Repo
                        .GetPlantLaborHours(@params.Start, @params.End)
                        .ConfigureAwait(false);

            #endregion

            const decimal dmaxConstant = 0.01252m;
            var quarterlyHours = plantLaborHours
                                .GroupBy(x => new { x.Year, x.Quarter })
                                .Select(x => new
                                {
                                    x.Key.Year,
                                    x.Key.Quarter,
                                    Regular = x.Sum(t => t.Regular),
                                    Overtime = x.Sum(t => t.Overtime),
                                    DoubleTime = x.Sum(t => t.DoubleTime),
                                    Orientation = x.Sum(t => t.Orientation),
                                    OverallHours = GetOverallHours(x.Sum(t => t.Regular), x.Sum(t => t.Overtime), x.Sum(t => t.DoubleTime), x.Sum(t => t.Orientation)),

                                    SapNetLessDmax = sapNetLessDmax.Any(d => d.ShiftDate.ToYear() == x.Key.Year && d.ShiftDate.ToQuarter() == x.Key.Quarter)
                                                    ? (decimal)sapNetLessDmax.Where(d => d.ShiftDate.ToYear() == x.Key.Year && d.ShiftDate.ToQuarter() == x.Key.Quarter).Sum(t => t.Qty)
                                                    : 0,

                                    SapNetDmax = dmaxSapNet.Any(d => d.ShiftDate.ToYear() == x.Key.Year && d.ShiftDate.ToQuarter() == x.Key.Quarter)
                                                    ? (decimal)dmaxSapNet.Where(d => d.ShiftDate.ToYear() == x.Key.Year && d.ShiftDate.ToQuarter() == x.Key.Quarter).Sum(t => t.Qty)
                                                    : 0,

                                    MontDetails = x.GroupBy(m => new { m.Year, m.Quarter, m.Month })
                                                    .Select(m => new
                                                    {
                                                        m.Key.Month,
                                                        MonthName = m.Key.Month.ToMonthName(),
                                                        Regular = m.Sum(t => t.Regular),
                                                        Overtime = m.Sum(t => t.Overtime),
                                                        DoubleTime = m.Sum(t => t.DoubleTime),
                                                        Orientation = m.Sum(t => t.Orientation),
                                                        OverallHours = GetOverallHours(m.Sum(t => t.Regular), m.Sum(t => t.Overtime), m.Sum(t => t.DoubleTime), m.Sum(t => t.Orientation)),

                                                        SapNetLessDmax = sapNetLessDmax.Any(d => d.ShiftDate.ToYear() == m.Key.Year && d.ShiftDate.ToQuarter() == m.Key.Quarter && d.ShiftDate.ToMonth() == m.Key.Month)
                                                                        ? (decimal)sapNetLessDmax.Where(d => d.ShiftDate.ToYear() == m.Key.Year && d.ShiftDate.ToQuarter() == m.Key.Quarter && d.ShiftDate.ToMonth() == m.Key.Month).Sum(t => t.Qty)
                                                                        : 0,

                                                        SapNetDmax = dmaxSapNet.Any(d => d.ShiftDate.ToYear() == m.Key.Year && d.ShiftDate.ToQuarter() == m.Key.Quarter && d.ShiftDate.ToMonth() == m.Key.Month)
                                                                        ? (decimal)dmaxSapNet.Where(d => d.ShiftDate.ToYear() == m.Key.Year && d.ShiftDate.ToQuarter() == m.Key.Quarter && d.ShiftDate.ToMonth() == m.Key.Month).Sum(t => t.Qty)
                                                                        : 0,

                                                        WeekDetails = m.GroupBy(w => new { w.WeekNumber })
                                                                        .Select(w => new
                                                                        {
                                                                            w.Key.WeekNumber,
                                                                            Regular = w.Sum(t => t.Regular),
                                                                            Overtime = w.Sum(t => t.Overtime),
                                                                            DoubleTime = w.Sum(t => t.DoubleTime),
                                                                            Orientation = w.Sum(t => t.Orientation),
                                                                            OverallHours = GetOverallHours(w.Sum(t => t.Regular), w.Sum(t => t.Overtime), w.Sum(t => t.DoubleTime), w.Sum(t => t.Orientation)),

                                                                            SapNetLessDmax = sapNetLessDmax.Any(d => d.ShiftDate.ToYear() == m.Key.Year && d.ShiftDate.ToQuarter() == m.Key.Quarter && d.ShiftDate.ToMonth() == m.Key.Month && d.ShiftDate.ToWeekNumber() == w.Key.WeekNumber)
                                                                            ? (decimal)sapNetLessDmax.Where(d => d.ShiftDate.ToYear() == m.Key.Year && d.ShiftDate.ToQuarter() == m.Key.Quarter && d.ShiftDate.ToMonth() == m.Key.Month && d.ShiftDate.ToWeekNumber() == w.Key.WeekNumber).Sum(t => t.Qty)
                                                                            : 0,

                                                                            SapNetDmax = dmaxSapNet.Any(d => d.ShiftDate.ToYear() == m.Key.Year && d.ShiftDate.ToQuarter() == m.Key.Quarter && d.ShiftDate.ToMonth() == m.Key.Month && d.ShiftDate.ToWeekNumber() == w.Key.WeekNumber)
                                                                            ? (decimal)dmaxSapNet.Where(d => d.ShiftDate.ToYear() == m.Key.Year && d.ShiftDate.ToQuarter() == m.Key.Quarter && d.ShiftDate.ToMonth() == m.Key.Month && d.ShiftDate.ToWeekNumber() == w.Key.WeekNumber).Sum(t => t.Qty)
                                                                            : 0,


                                                                        })

                                                    })

                                })
                                .Select(x => new
                                {
                                    x.Year,
                                    x.Quarter,
                                    x.Regular,
                                    x.DoubleTime,
                                    x.Overtime,
                                    x.Orientation,

                                    x.SapNetLessDmax,
                                    x.SapNetDmax,

                                    x.OverallHours,
                                    OverallHoursLessDmax = GetOverallHoursLessDmax(x.OverallHours, x.SapNetDmax, x.SapNetLessDmax),

                                    PPMH = CalculatePlantPpmh(x.OverallHours, x.SapNetDmax, x.SapNetLessDmax),

                                    MonthDetails = x.MontDetails
                                                    .Select(m => new
                                                    {
                                                        m.Month,
                                                        m.Regular,
                                                        m.Overtime,
                                                        m.DoubleTime,
                                                        m.Orientation,

                                                        m.SapNetLessDmax,
                                                        m.SapNetDmax,

                                                        m.OverallHours,
                                                        OverallHoursLessDmax = GetOverallHoursLessDmax(m.OverallHours, m.SapNetDmax, m.SapNetLessDmax),
                                                        PPMH = CalculatePlantPpmh(m.OverallHours, m.SapNetDmax, m.SapNetLessDmax),

                                                        WeekDetails = m.WeekDetails
                                                                        .Select(w => new
                                                                        {
                                                                            w.WeekNumber,
                                                                            w.Regular,
                                                                            w.Overtime,
                                                                            w.DoubleTime,
                                                                            w.Orientation,

                                                                            w.SapNetLessDmax,
                                                                            w.SapNetDmax,

                                                                            w.OverallHours,
                                                                            OverallHoursLessDmax = GetOverallHoursLessDmax(w.OverallHours, w.SapNetDmax, w.SapNetLessDmax),
                                                                            PPMH = CalculatePlantPpmh(w.OverallHours, w.SapNetDmax, w.SapNetLessDmax),
                                                                        })
                                                                        .OrderBy(w => w.WeekNumber)
                                                    }).OrderBy(m => m.Month)
                                })
                                .OrderBy(x => x.Year)
                                .ThenBy(x => x.Quarter)
                                .ToList();


            return quarterlyHours;
        }

        #endregion


        #region Charts

        public MachineMapping GetMappedLineToWorkCenter(string line, string side = "n/a")
        {
            if (side == null) throw new ArgumentNullException(nameof(side));
            if (line == null) throw new ArgumentNullException(nameof(line));

            if (side.ToLower().Trim() == "n/a") side = null;

            var map = _context.MachineMapping.FirstOrDefault(x => x.Line.ToLower().Trim() == line.ToLower().Trim() && x.Side == side);
            return map;
        }

        public async Task<List<MachineMappingDto>> GetWorkCentersByDept(string area)
        {
            var workCentersQry = _context.MachineMapping.AsQueryable();

            var areas = new List<string>();

            switch (area)
            {
                case "foundry cell":
                    areas.Add("foundry cell");
                    areas.Add("heat treat");
                    break;
                case "finishing":
                    areas.Add("anodize");
                    areas.Add("skirt coat");
                    break;
                case "assembly":
                    areas.Add("assembly");
                    areas.Add("hand assembly");
                    break;
                case "machine line":
                    areas.Add("machine line");
                    break;
            }

            workCentersQry = workCentersQry.Where(x => areas.Contains(x.Area.ToLower().Trim()));
            workCentersQry = workCentersQry.Where(x => x.Line != null);

            return await workCentersQry
                                .Select(x => new MachineMappingDto
                                {
                                    WorkCenter = x.Machine,
                                    Area = x.Area,
                                    Line = x.Line,
                                    Side = x.Side ?? "n/a"
                                })
                                .OrderBy(x => x.WorkCenter)
                                .ToListAsync().ConfigureAwait(false);

        }

        #endregion

    }
}
