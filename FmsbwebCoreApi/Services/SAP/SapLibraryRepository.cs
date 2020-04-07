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

namespace FmsbwebCoreApi.Services.SAP
{
    public class SapLibraryRepository : ISapLibraryRepository, IDisposable
    {
        private readonly decimal dmaxHourRate = 0.01252m;
        private readonly SapContext _context;
        private readonly Fmsb2Context _fmsbContext;
        private readonly MapArea _mapArea;

        private readonly IFmsb2LibraryRepository _fmsb2Repo;
        private readonly IIntranetLibraryRepository _intranetRepo;
        private readonly IFmsbMvcLibraryRepository _fmsbMvcRepo;

        public SapLibraryRepository(
            SapContext context,
            Fmsb2Context fmsbContext,
            IFmsb2LibraryRepository fmsb2Repo,
            IFmsbMvcLibraryRepository fmsbMvcRepo,
            IIntranetLibraryRepository intranetRepo)
        {
            _context = context ??
                throw new ArgumentNullException(nameof(context));

            _intranetRepo = intranetRepo ??
                throw new ArgumentNullException(nameof(intranetRepo));

            _fmsbContext = fmsbContext ??
                throw new ArgumentNullException(nameof(fmsbContext));

            _fmsb2Repo = fmsb2Repo ??
                throw new ArgumentNullException(nameof(fmsb2Repo));

            _fmsbMvcRepo = fmsbMvcRepo ??
                throw new ArgumentNullException(nameof(fmsbMvcRepo));

            _mapArea = new MapArea();
        }

        public IEnumerable<Models.SAP.KpiTargets> GetInMemoryKpiTarget()
        {
            var kpis = new List<Models.SAP.KpiTargets>
            {
                //foundry
                new Models.SAP.KpiTargets
                {
                    Area = "Foundry",
                    Kpi = "OAE",
                    Min = .7m,
                    Max = .7m
                },

                new Models.SAP.KpiTargets
                {
                    Area = "Foundry",
                    Kpi = "Scrap",
                    Min = .08m,
                    Max = .08m
                },

                new Models.SAP.KpiTargets
                {
                    Area = "Foundry",
                    Kpi = "PPMH",
                    Min = 75,
                    Max = 75
                },


                //machining
                new Models.SAP.KpiTargets
                {
                    Area = "Machining",
                    Kpi = "OAE",
                    Min = .71m,
                    Max = .71m
                },

                new Models.SAP.KpiTargets
                {
                    Area = "Machining",
                    Kpi = "Scrap",
                    Min = .029m,
                    Max = .029m
                },

                new Models.SAP.KpiTargets
                {
                    Area = "Machining",
                    Kpi = "PPMH",
                    Min = 50,
                    Max = 50
                },

                //skirt coat
                new Models.SAP.KpiTargets
                {
                    Area = "Finishing",
                    Kpi = "OAE",
                    Min = .78m,
                    Max = .78m
                },

                new Models.SAP.KpiTargets
                {
                    Area = "Finishing",
                    Kpi = "Scrap",
                    Min = .075m,
                    Max = .075m
                },

                new Models.SAP.KpiTargets
                {
                    Area = "Finishing",
                    Kpi = "PPMH",
                    Min = 150,
                    Max = 150
                },

                //assy
                new Models.SAP.KpiTargets
                {
                    Area = "Assembly",
                    Kpi = "OAE",
                    Min = .62m,
                    Max = .62m
                },

                new Models.SAP.KpiTargets
                {
                    Area = "Assembly",
                    Kpi = "Scrap",
                    Min = .06m,
                    Max = .06m
                },

                new Models.SAP.KpiTargets
                {
                    Area = "Assembly",
                    Kpi = "PPMH",
                    Min = 54,
                    Max = 54
                }
            };

            return kpis; ;
        }

        public ScrapByCodeDto GetScrapByCode(List<Models.SAP.Scrap> scrap, string area, bool isSbScrap, int sapNet)
        {
            var summary = scrap
                            .Where(x => x.IsPurchashedExclude2 == (isSbScrap ? "SB Scrap" : "Purchased Scrap"))
                            .Where(x => x.ScrapCode != "8888")
                            .AsQueryable();

            if (area == "Foundry Cell")
            {
                summary = summary.Where(x => x.ScrapAreaName.ToLower() == "foundry");
            }

            if (area == "Machine Line")
            {
                summary = summary.Where(x => x.ScrapAreaName.ToLower() == "machining");
            }

            if (area == "Skirt Coat")
            {
                var finScrap = new List<string> { "anodize", "skirt coat" };
                summary = summary.Where(x => finScrap.Contains(x.ScrapAreaName.ToLower()));
            }

            if (area == "Assembly")
            {
                summary = summary.Where(x => x.ScrapAreaName.ToLower() == "assembly");
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

        public DepartmentScrapDto GetDepartmentScrap(List<Models.SAP.Scrap> scrap, string area, int sapNet)
        {
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

        public SapProductionByTypeDto GetSapProductionByType(List<SapProdDto> sapProd, string area)
        {
            var data = new List<SapProdDto>();
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

        public async Task<IEnumerable<Models.SAP.Scrap>> GetScrapDataByScrapAreaFromDb(DateTime start, DateTime end, string area)
        {
            if (area == null) throw new ArgumentNullException(nameof(area));

            var qry = _context.Scrap2Summary2.Where(x => x.ShiftDate >= start && x.ShiftDate <= end).AsQueryable();

            if (area.ToLower().Trim() == "foundry cell")
            {
                qry = qry.Where(x => x.ScrapAreaName.ToLower().Trim() == "foundry");
            }

            if (area.ToLower().Trim() == "machine line")
            {
                qry = qry.Where(x => x.ScrapAreaName.ToLower().Trim() == "machining");
            }

            if (area.ToLower().Trim() == "skirt coat")
            {
                var fin = new List<string> { "anodize", "skirt coat" };
                qry = qry.Where(x => fin.Contains(x.ScrapAreaName.ToLower().Trim()));
            }

            if (area.ToLower().Trim() == "assembly")
            {
                qry = qry.Where(x => x.ScrapAreaName.ToLower().Trim() == "assembly");
            }

            return await qry
                            .Select(x => new Models.SAP.Scrap
                            {
                                Department = x.Department,
                                Area = x.Area,
                                ScrapAreaName = x.ScrapAreaName,
                                ScrapCode = x.ScrapCode,
                                IsPurchashedExclude = (bool)x.IsPurchashedExclude,
                                IsPurchashedExclude2 = x.IsPurchashedExclude2,
                                ScrapDesc = x.ScrapDesc,
                                Qty = (int)x.Qty
                            }).ToListAsync()
                            .ConfigureAwait(false);
        }

        public async Task<IEnumerable<Models.SAP.Scrap>> GetScrapDataByDepartmentFromDb(DateTime start, DateTime end, string area)
        {
            return await _context.Scrap2Summary2
                                .Where(x => x.ShiftDate >= start && x.ShiftDate <= end)
                                .Where(x => x.Area == area)
                                .Select(x => new Models.SAP.Scrap
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
                                }).ToListAsync().ConfigureAwait(false);
        }

        public async Task<IEnumerable<SapProdDto>> GetSapProdByAreaFromDb(DateTime start, DateTime end, string area)
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
                                }).ToListAsync().ConfigureAwait(false);
        }

        public async Task<IEnumerable<SapProdDto>> GetSapProdByTypeFromDb(DateTime start, DateTime end, string area)
        {
            if (area == null) throw new ArgumentNullException(nameof(area));

            var qry = _context
                        .Production2Summary
                        .Where(x => x.ShiftDate >= start && x.ShiftDate <= end)

                        .AsQueryable();

            if (area.ToLower().Trim() == "foundry cell")
            {
                qry = qry.Where(x => x.Type.ToLower().Trim() == "p5c");
            }

            if (area.ToLower().Trim() == "machine line")
            {
                qry = qry.Where(x => x.Type.ToLower().Trim() == "p3m");
            }

            if (area.ToLower().Trim() == "skirt coat")
            {
                var fin = new List<string> { "p1f", "p2f" };
                qry = qry.Where(x => fin.Contains(x.Type.ToLower().Trim()));
            }

            if (area.ToLower().Trim() == "assembly")
            {
                qry = qry.Where(x => x.Type.ToLower().Trim() == "p1a");
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

        public string GetColorCode(KpiTarget targets, string type, decimal? value)
        {
            targets = targets ?? throw new ArgumentNullException(nameof(targets));

            var black = "#262626";
            if (value == null) return black;
            if (targets == null) return black;

            var red = "#FF4136";
            var green = "#19A974";

            switch (type)
            {
                case "oae":

                    if (value <= targets.OaeTarget / 100)
                    {
                        return red;
                    }
                    else
                    {
                        return green;
                    }

                case "scrap":

                    if (value <= targets.ScrapRateTarget / 100)
                    {
                        return green;
                    }
                    else
                    {
                        return red;
                    }

                case "ppmh":

                    if (value <= targets.PpmhTarget)
                    {
                        return red;
                    }
                    else
                    {
                        return green;
                    }

                case "downtime":

                    if (value <= targets.DowntimeRateTarget / 100)
                    {
                        return red;
                    }
                    else
                    {
                        return green;
                    }
            }

            return black;
        }

        public async Task<ProductionMorningMeetingDto> GetProductionData(DateTime start, DateTime end, string area)
        {
            //load data from db
            var scrapByScrapArea = (await GetScrapDataByScrapAreaFromDb(start, end, area).ConfigureAwait(false)).ToList();
            var scrapByDepartment = (await GetScrapDataByDepartmentFromDb(start, end, area).ConfigureAwait(false)).ToList();

            var sapProdByArea = (await GetSapProdByAreaFromDb(start, end, area).ConfigureAwait(false)).ToList();
            var sapProdByType = (await GetSapProdByTypeFromDb(start, end, area).ConfigureAwait(false)).ToList();

            var hxh = (await _intranetRepo.GetHxhProduction(start, end, area).ConfigureAwait(false)).ToList();

            var targets = await _fmsb2Repo.GetTargets(area, start, end).ConfigureAwait(false);

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
            var prodForLaborHours = new List<SapProdDto>();
            var laborHrs = new List<FinanceLaborHoursView>();
            var startDayForLaborHorsIfYesterday = end.AddDays(-6);
            if (start.IsYesterday()) //check if date is yesterday, if yes subtract -6 day from end day and store in a variable
            {
                //get data from the db with the new date range
                prodForLaborHours = await _fmsb2Repo.GetProdForLaborHrs(startDayForLaborHorsIfYesterday, end, area).ConfigureAwait(false);

                //get labor hrs data from db
                laborHrs = await _fmsb2Repo.GetLaborHoursData(startDayForLaborHorsIfYesterday, end, area).ConfigureAwait(false);
            }
            else
            {
                //use the original db request for prod and scrap
                prodForLaborHours = sapProdByArea;

                //use unmodified date range
                laborHrs = await _fmsb2Repo.GetLaborHoursData(start, end, area).ConfigureAwait(false);
            }

            var result = hxh
                            .Select(x => new ProductionMorningMeetingDto
                            {
                                Department = x.Department,
                                Area = x.Area,
                                Target = (int)x.Target,

                                HxhGross = x.Gross,
                                SapGross = sapProdByArea.Where(s => s.Area == x.Area).Sum(s => s.Qty)
                                            + sbScrap.Where(w => w.Area == x.Area).Sum(w => w.qty), //with sb scrap only

                                PlannedWarmers = warmers.Where(w => w.Area == x.Area && w.ScrapCode == "8888").Sum(w => w.qty),
                                UnPlannedWarmers = warmers.Where(w => w.Area == x.Area && w.ScrapCode == "8889").Sum(w => w.qty),
                                TotalSbScrap = sbScrap.Where(w => w.Area == x.Area).Sum(w => w.qty),
                                TotalScrapByDept = overallScrap.Where(w => w.Area == x.Area).Sum(w => w.qty),

                                SapNet = sapProdByArea.Where(s => s.Area == x.Area).Sum(s => s.Qty),
                                SapOae = (int)x.Target == 0 ? 0 : sapProdByArea.Where(s => s.Area == x.Area).Sum(s => s.Qty) / x.Target,
                                SapOaeColorCode = GetColorCode(targets, "oae",
                                                    (int)x.Target == 0 ? 0 : sapProdByArea.Where(s => s.Area == x.Area).Sum(s => s.Qty) / x.Target),

                                HxHNet = x.Gross - ((x.Area.ToLower() == "foundry cell" || x.Area.ToLower() == "machine line")
                                                    ? scrapByDepartment.Where(s => s.ScrapCode != "8888").Sum(s => s.Qty)
                                                    : 0),

                                HxhOae = x.Target == 0 ? 0 : (decimal)(x.Gross - ((x.Area.ToLower() == "foundry cell" || x.Area.ToLower() == "foundry cell")
                                                                ? scrapByDepartment.Where(s => s.ScrapCode != "8888").Sum(s => s.Qty)
                                                                : 0))
                                                            / (decimal)x.Target,

                                HxhOaeColorCode = GetColorCode(targets, "oae",
                                                        (x.Target == 0 ? 0 : (decimal)(x.Gross - ((x.Area.ToLower() == "foundry cell" || x.Area.ToLower() == "foundry cell")
                                                            ? scrapByDepartment.Where(s => s.ScrapCode != "8888").Sum(s => s.Qty)
                                                            : 0))
                                                        / (decimal)x.Target)),

                                SbScrapByCode = GetScrapByCode(scrapByScrapArea, x.Area, true, sapProdByArea.Where(s => s.Area == x.Area).Sum(s => s.Qty)),
                                PurchaseScrapByCode = GetScrapByCode(scrapByScrapArea, x.Area, false, sapProdByArea.Where(s => s.Area == x.Area).Sum(s => s.Qty)),
                                DepartmentScrap = GetDepartmentScrap(scrapByDepartment, x.Area, sapProdByArea.Where(s => s.Area == x.Area).Sum(s => s.Qty)),

                                SapProductionByType = GetSapProductionByType(sapProdByType, x.Area),

                                LaborHours = _fmsb2Repo.GetRollingDaysPPMH(prodForLaborHours, laborHrs, start, end),


                                ScrapByCodeColorCode = GetColorCode(targets, "scrap",
                                                            GetScrapByCode(scrapByScrapArea, x.Area, true, sapProdByArea.Where(s => s.Area == x.Area).Sum(s => s.Qty)).ScrapRate),
                                PpmhColorCode = GetColorCode(targets, "ppmh",
                                                   _fmsb2Repo.GetRollingDaysPPMH(prodForLaborHours, laborHrs, start, end).PPMH),

                                Targets = targets

                            })
                            .FirstOrDefault();

            return result;

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

        public async Task<IEnumerable<DailyScrapByShiftDateDto>> GetDailyScrapRateByCode(DateTime start, DateTime end, string area, bool isPurchasedScrap = false)
        {
            try
            {
                var production = await _context.Production2
                                .Where(x => x.ShiftDate >= start && x.ShiftDate <= end)
                                .Where(x => x.Area == area)
                                .GroupBy(x => new { x.ShiftDate })
                                .Select(x => new
                                {
                                    x.Key.ShiftDate,
                                    TotalProd = x.Sum(s => s.QtyProd)
                                })
                                .ToListAsync().ConfigureAwait(false);


                var finScrap = new List<string> { "anodize", "skirt coat" };

                var scrapData = await _context.Scrap2
                                    .Where(x => x.ShiftDate >= start && x.ShiftDate <= end)
                                    .Where(x => x.ScrapCode != "8888")
                                    .Where(x => x.IsPurchashedExclude == isPurchasedScrap)
                                    .Where(x => area.ToLower() == "skirt coat" ? (finScrap.Contains(x.ScrapAreaName.ToLower())) : (x.ScrapAreaName == _mapArea.RanameAreaToDepartment(area)))
                                    .GroupBy(x => new { x.ShiftDate })
                                    .Select(x => new
                                    {
                                        x.Key.ShiftDate,
                                        TotalScrap = x.Sum(s => s.Qty)
                                    })
                                    .ToListAsync().ConfigureAwait(false);

                var data = scrapData
                            .Select(x => new DailyScrapByShiftDateDto
                            {
                                ShiftDate = (DateTime)x.ShiftDate,
                                TotalScrap = (int)x.TotalScrap,
                                SapNet = (int)production.Where(p => p.ShiftDate == x.ShiftDate).Sum(p => p.TotalProd),
                                SapGross = production.Any(p => p.ShiftDate == x.ShiftDate)
                                            ? (int)production.Where(p => p.ShiftDate == x.ShiftDate).Sum(p => p.TotalProd) + (int)x.TotalScrap
                                            : 0,

                                ScrapRate = (production.Any(p => p.ShiftDate == x.ShiftDate)
                                            ? production.Where(p => p.ShiftDate == x.ShiftDate).Sum(p => p.TotalProd) + (int)x.TotalScrap
                                            : 0) == 0

                                            ? null

                                            : x.TotalScrap / (production.Any(p => p.ShiftDate == x.ShiftDate)
                                                ? production.Where(p => p.ShiftDate == x.ShiftDate).Sum(p => p.TotalProd) + (decimal)x.TotalScrap
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
                               .ToListAsync().ConfigureAwait(false);

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
                                .ToListAsync().ConfigureAwait(false);

            var target = await _intranetRepo.DailyHxHTargetByArea(start, end, area).ConfigureAwait(false);

            //transform data
            var result = production
                            .Select(x => new DailyDepartmentKpiDto
                            {
                                Area = x.Area,
                                ShiftDate = (DateTime)x.ShiftDate,
                                TotalProduction = (int)x.TotalProd,

                                TotalAreaScrap = !scrapData.Any(s => s.ShiftDate == x.ShiftDate)
                                                    ? 0
                                                    : (int)scrapData.Where(s => s.ShiftDate == x.ShiftDate).Sum(s => s.TotalScrap),

                                Target = !target.Any(s => s.ShiftDate == x.ShiftDate)
                                            ? 0
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

        public async Task<GetSapProdAndScrapDto> GetSapProdAndScrap(DateTime start, DateTime end, string area)
        {
            //get data from db
            var prod = _context.Production2
                            .Where(x => x.ShiftDate >= start && x.ShiftDate <= end)
                            .Where(x => x.Area == area)
                            .GroupBy(x => new { x.ShiftDate, x.Area })
                            .Select(x => new DailySapProdDto
                            {
                                ShiftDate = (DateTime)x.Key.ShiftDate,
                                Area = x.Key.Area,
                                Qty = (int)x.Sum(s => s.QtyProd)
                            })
                            .OrderBy(x => x.ShiftDate)
                            .ToList();

            var scrap = _context.Scrap2
                            .Where(x => x.ShiftDate >= start && x.ShiftDate <= end)
                            .Where(x => x.ScrapAreaName == _mapArea.RanameAreaToDepartment(area))
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
                                IsPurchaseScrap = (bool)x.Key.IsPurchashedExclude,
                                ScrapType = x.Key.IsPurchashedExclude2,
                                Qty = (int)x.Sum(s => s.Qty)
                            })
                            .OrderByDescending(x => x.Qty)
                            .ToList();

            var targets = (await _intranetRepo.GetHxhProduction(start, end, area).ConfigureAwait(false)).ToList();

            //transform data ScrapByCodeDetailsDto

            var target = targets.Sum(x => x.Target);
            var sapProd = prod.Sum(x => x.Qty);
            var sbScrap = scrap.Where(x => x.IsPurchaseScrap == false).Sum(x => x.Qty);
            var purchasedScrap = scrap.Where(x => x.IsPurchaseScrap == true).Sum(x => x.Qty);

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
                                        Area = area,
                                        ScrapAreaName = sb.Key.ScrapAreaName,
                                        ScrapCode = d.Key.ScrapCode,
                                        ScrapDesc = d.Key.ScrapDesc,
                                        Qty = d.Sum(t => t.Qty)
                                    }).OrderByDescending(d => d.Qty)
                    })
                    .OrderByDescending(sb => sb.Qty);

            return new GetSapProdAndScrapDto
            {
                StartDate = start,
                EndDate = end,

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

        public IEnumerable<ProductionByLineDto> GetDepartmentDetailsByLine(
            IEnumerable<Models.SAP.Scrap> scrap,
            IEnumerable<SapProdDetailDto> prod,
            IEnumerable<HxHProductionByLineDto> hxh,
            IEnumerable<Models.SAP.Scrap> warmers,
            IEnumerable<SwotTargetWithDeptId> lineTargets)
        {

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

            var sbScrap = scrapByLine.Where(x => x.IsPurchashedExclude == false);
            var purchasedScrap = scrapByLine.Where(x => x.IsPurchashedExclude == true);

            var afScrap = scrapByLine
                            .Where(x => x.IsPurchashedExclude == false)
                            .Where(x => x.ScrapAreaName == "Anodize" || x.ScrapAreaName == "Skirt Coat" || x.ScrapAreaName == "Assembly");

            //details
            var result = distinctLines.Select(line => new ProductionByLineDto
            {
                Department = hxh.Any(x => x.Line == line) ? hxh.Where(x => x.Line == line).First().Department : "",
                Area = hxh.Any(x => x.Line == line) ? hxh.Where(x => x.Line == line).First().Area : "",
                Line = line,
                Target = hxh.Any(x => x.Line == line) ? (int)hxh.Where(x => x.Line == line).First().Target : 0,

                OaeTarget = targets.Any(x => x.Line == line) ? (decimal)targets.Where(x => x.Line == line).First().OaeTarget : 0,
                FoundryScrapRateTarget = targets.Any(x => x.Line == line) ? (decimal)targets.Where(x => x.Line == line).First().FoundryScrapTarget : 0,
                MachiningScrapRateTarget = targets.Any(x => x.Line == line) ? (decimal)targets.Where(x => x.Line == line).First().MachineScrapTarget : 0,
                AfScrapRateTarget = targets.Any(x => x.Line == line) ? (decimal)targets.Where(x => x.Line == line).First().AfScrapTarget : 0,

                HxHGross = hxh.Any(x => x.Line == line) ? (int)hxh.Where(x => x.Line == line).First().Gross : 0,

                SapNet = prod.Any(x => x.Line == line) ? prod.Where(x => x.Line == line).Sum(s => s.SapNet) : 0,
                SapNetDetails = prod.Any(x => x.Line == line) ? prod.Where(x => x.Line == line).OrderBy(x => x.DateScanned).ToList() : new List<SapProdDetailDto>(),

                TotalScrap = scrapByLine.Any(x => x.Line == line) ? scrapByLine.Where(x => x.Line == line).Sum(s => s.Qty) : 0,
                TotalSbScrap = sbScrap.Any(x => x.Line == line) ? sbScrap.Where(x => x.Line == line).Sum(s => s.Qty) : 0,
                TotalPurchaseScrap = purchasedScrap.Any(x => x.Line == line) ? purchasedScrap.Where(x => x.Line == line).Sum(s => s.Qty) : 0,

                TotalAfScrap = afScrap.Any(x => x.Line == line) ? afScrap.Where(x => x.Line == line).Sum(s => s.Qty) : 0,

                TotalWarmers = warmersByLine.Any(x => x.Line == line) ? warmersByLine.Where(x => x.Line == line).Sum(s => s.Qty) : 0,

                SbScrapDetails = sbScrap.Any(x => x.Line == line) ? sbScrap.Where(x => x.Line == line).ToList() : new List<Models.SAP.Scrap>(),
                PurchaseScrapDetails = purchasedScrap.Any(x => x.Line == line) ? purchasedScrap.Where(x => x.Line == line).ToList() : new List<Models.SAP.Scrap>()
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

        public IEnumerable<ProductionByProgramDto> GetDepartmentDetailsByProgram(
            IEnumerable<Models.SAP.Scrap> scrap,
            IEnumerable<SapProdDetailDto> prod,
            IEnumerable<HxhProductionByProgramDto> hxh)
        {
            //distinct program
            var scrapProgram = scrap.Select(x => x.Program).Distinct();
            var sapProdProgram = prod.Select(x => x.Program).Distinct();
            var hxhProgram = hxh.Select(x => x.Program).Distinct();
            var distinctProgram = (scrapProgram.Concat(sapProdProgram).Concat(hxhProgram)).Distinct();

            //transform data
            var scrapByProgram = scrap
                                .GroupBy(x => new { x.Department, x.Area, x.Program, x.ScrapAreaName, x.ScrapCode, x.ScrapDesc, x.IsPurchashedExclude, x.IsPurchashedExclude2 })
                                .Select(x => new Models.SAP.Scrap
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

            var sbScrap = scrapByProgram.Where(x => x.IsPurchashedExclude == false);
            var purchasedScrap = scrapByProgram.Where(x => x.IsPurchashedExclude == true);

            //details
            var result = distinctProgram.Select(program => new ProductionByProgramDto
            {
                Department = hxh.Any(x => x.Program == program) ? hxh.Where(x => x.Program == program).First().Department : "",
                Area = hxh.Any(x => x.Program == program) ? hxh.Where(x => x.Program == program).First().Area : "",
                Program = program,
                Target = hxh.Any(x => x.Program == program) ? (int)hxh.Where(x => x.Program == program).First().Target : 0,

                HxHGross = hxh.Any(x => x.Program == program) ? (int)hxh.Where(x => x.Program == program).First().Gross : 0,

                SapNet = prod.Any(x => x.Program == program) ? prod.Where(x => x.Program == program).Sum(s => s.SapNet) : 0,
                SapNetDetails = prod.Any(x => x.Program == program) ? prod.Where(x => x.Program == program).OrderBy(x => x.DateScanned).ToList() : new List<SapProdDetailDto>(),

                TotalScrap = scrapByProgram.Any(x => x.Program == program) ? scrapByProgram.Where(x => x.Program == program).Sum(s => s.Qty) : 0,
                TotalSbScrap = sbScrap.Any(x => x.Program == program) ? sbScrap.Where(x => x.Program == program).Sum(s => s.Qty) : 0,
                TotalPurchaseScrap = purchasedScrap.Any(x => x.Program == program) ? purchasedScrap.Where(x => x.Program == program).Sum(s => s.Qty) : 0,

                SbScrapDetails = sbScrap.Any(x => x.Program == program) ? sbScrap.Where(x => x.Program == program).ToList() : new List<Models.SAP.Scrap>(),
                PurchaseScrapDetails = purchasedScrap.Any(x => x.Program == program) ? purchasedScrap.Where(x => x.Program == program).ToList() : new List<Models.SAP.Scrap>(),
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

        public async Task<DepartmentDetailsDto> GetDepartmentDetails(DateTime start, DateTime end, string area)
        {
            if (area == null) throw new ArgumentNullException(nameof(area));

            //get data from db
            var scrapData = await GetScrapDataByDepartmentFromDb(start, end, area).ConfigureAwait(false);

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

            var hxh = await _intranetRepo.GetHxhProdByLineAndProgram(start, end, area)
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
                                                        .Select(d => new Models.SAP.Scrap
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
                            .Select(x => new Models.SAP.Scrap
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

                DetailsByLine = GetDepartmentDetailsByLine(scrap, prod, hxh.LineDetails, warmers, lineTargets),
                DetailsByProgram = GetDepartmentDetailsByProgram(scrap, prod, hxh.ProgramDetails),

                SbScrapDetails = scrapList.Where(s => s.IsPurchashedExclude == false),
                PurchaseScrapDetails = scrapList.Where(s => s.IsPurchashedExclude == true)
            };

        }

        public int MapShiftToShiftOrder(string shift)
        {
            switch (shift)
            {
                case "A":
                    return 1;
                case "C":
                    return 2;
                case "B":
                    return 1;
                case "D":
                    return 2;
                case "3":
                    return 1;
                case "1":
                    return 2;
                case "2":
                    return 3;
                default:
                    return 0;
            }
        }

        public async Task<IEnumerable<DailyScrapByShiftDto>> GetDailyScrapByShift(DailyScrapByShiftResourceParameter resourceParams)
        {
            if (resourceParams == null) throw new ArgumentNullException(nameof(resourceParams));

            var qry = _context.Scrap2Summary2
                                .Where(x => x.ShiftDate >= resourceParams.Start && x.ShiftDate <= resourceParams.End)
                                .Where(x => x.Area.ToLower() == resourceParams.Area.ToLower())
                                .Where(x => x.IsPurchashedExclude2.ToLower() == resourceParams.ScrapType.ToLower())
                                .Where(x => x.ScrapCode == resourceParams.ScrapCode)
                                .AsQueryable();

            if (!string.IsNullOrWhiteSpace(resourceParams.Line))
            {
                qry = qry.Where(x => x.MachineHxh.ToLower().Trim() == resourceParams.Line.ToLower().Trim());
            }

            if (!string.IsNullOrWhiteSpace(resourceParams.Program))
            {
                qry = qry.Where(x => x.Program.ToLower().Trim() == resourceParams.Program.ToLower().Trim());
            }

            var data = (await qry.ToListAsync().ConfigureAwait(false))
                                .GroupBy(x => new { x.ShiftDate, x.Shift, x.ScrapCode, x.ScrapDesc })
                                .Select(x => new DailyScrapByShiftDto
                                {
                                    ShiftDate = (DateTime)x.Key.ShiftDate,
                                    Shift = x.Key.Shift,
                                    ShiftOrder = MapShiftToShiftOrder(x.Key.Shift),
                                    ScrapCode = x.Key.ScrapCode,
                                    ScrapDesc = x.Key.ScrapDesc,
                                    Qty = (int)x.Sum(s => s.Qty)
                                })
                                .OrderBy(x => x.ShiftDate)
                                .ThenBy(x => x.ShiftOrder)
                                .ToList();

            return data;
        }

        public MachineMapping GetMappedLineToWorkCenter(string line, string side = "n/a")
        {
            if (side == null) throw new ArgumentNullException(nameof(side));
            if (line == null) throw new ArgumentNullException(nameof(line));

            side = side.ToLower().Trim();
            if (side == "n/a")
            {
                side = null;
            }
            var map = _context.MachineMapping.Where(x => x.Line.ToLower().Trim() == line.ToLower().Trim() && x.Side == side).FirstOrDefault();
            return map;
        }

        public async Task<List<MachineMappingDto>> GetWorkcentersByDept(string area)
        {
            var workcentersQry = _context.MachineMapping.AsQueryable();

            var areas = new List<string>();

            if (area == "foundry cell")
            {
                areas.Add("foundry cell");
                areas.Add("heat treat");
            }

            if (area == "finishing")
            {
                areas.Add("anodize");
                areas.Add("skirt coat");
            }

            if (area == "assembly")
            {
                areas.Add("assembly");
                areas.Add("hand assembly");
            }

            if (area == "machine line")
            {
                areas.Add("machine line");
            }

            workcentersQry = workcentersQry.Where(x => areas.Contains(x.Area.ToLower().Trim()));
            workcentersQry = workcentersQry.Where(x => x.Line != null);

            var workcenters = await workcentersQry
                                .Select(x => new MachineMappingDto
                                {
                                    WorkCenter = x.Machine,
                                    Area = x.Area,
                                    Line = x.Line,
                                    Side = x.Side == null ? "n/a" : x.Side
                                })
                                .OrderBy(x => x.WorkCenter)
                                .ToListAsync().ConfigureAwait(false);

            return workcenters;

        }

        public async Task<IEnumerable<dynamic>> GetScrapByProgram(DateTime start, DateTime end, string area, bool isPurchasedScrap = false)
        {
            try
            {
                var productionByProgram = await _context.Production2
                                .Where(x => x.ShiftDate >= start && x.ShiftDate <= end)
                                .Where(x => x.Area == area)
                                .GroupBy(x => new { x.Program })
                                .Select(x => new
                                {
                                    x.Key.Program,
                                    TotalProd = x.Sum(s => s.QtyProd)
                                })
                                .ToListAsync().ConfigureAwait(false);

                var finScrap = new List<string> { "anodize", "skirt coat" };

                var scrap = await _context.Scrap2
                                    .Where(x => x.ShiftDate >= start && x.ShiftDate <= end)
                                    .Where(x => x.ScrapCode != "8888")
                                    .Where(x => x.IsPurchashedExclude == isPurchasedScrap)
                                    .Where(x => area.ToLower() == "skirt coat" ? (finScrap.Contains(x.ScrapAreaName.ToLower())) : (x.ScrapAreaName == _mapArea.RanameAreaToDepartment(area)))
                                    .GroupBy(x => new { x.Program, x.Area, x.ScrapAreaName, x.MachineHxh })
                                    .Select(x => new
                                    {
                                        x.Key.Program,
                                        x.Key.Area,
                                        x.Key.ScrapAreaName,
                                        x.Key.MachineHxh,
                                        Qty = x.Sum(s => s.Qty),

                                    })
                                    .ToListAsync().ConfigureAwait(false);

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
                                                    ? scrapByProgram.Where(s => s.Program == x.Program).First().AreaDetails.ToList()
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

                if (isPurchasedScrap)
                {
                    return result;
                }
                else
                {
                    return result.Where(x => x.ScrapRate < 1);
                }

            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

        }

        public async Task<IEnumerable<dynamic>> GetScrapByShift(DateTime start, DateTime end, string area, bool isPurchasedScrap = false)
        {
            try
            {
                var prodByShift = await _context.Production2
                                .Where(x => x.ShiftDate >= start && x.ShiftDate <= end)
                                .Where(x => x.Area == area)
                                .GroupBy(x => new { x.Shift })
                                .Select(x => new
                                {
                                    x.Key.Shift,
                                    TotalProd = x.Sum(s => s.QtyProd)
                                })
                                .ToListAsync().ConfigureAwait(false);


                var scrap = await _context.Scrap2
                                    .Where(x => x.ShiftDate >= start && x.ShiftDate <= end)
                                    .Where(x => x.ScrapCode != "8888")
                                    .Where(x => x.IsPurchashedExclude == isPurchasedScrap)
                                    .Where(x => x.Area == area)
                                    .GroupBy(x => new { x.Area, x.Shift, x.ScrapAreaName, x.MachineHxh })
                                    .Select(x => new
                                    {
                                        x.Key.Area,
                                        x.Key.Shift,
                                        x.Key.ScrapAreaName,
                                        x.Key.MachineHxh,
                                        Qty = x.Sum(s => s.Qty),

                                    })
                                    .ToListAsync().ConfigureAwait(false);

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
                                                ? (int)prodByShift.Where(n => n.Shift == x.Shift).Sum(n => n.TotalProd)
                                                : 0,

                                    Qty = scrapByShift.Any(s => s.Shift == x.Shift)
                                            ? (int)scrapByShift.Where(s => s.Shift == x.Shift).Sum(s => s.Qty)
                                            : 0,

                                    SapGross = (prodByShift.Any(n => n.Shift == x.Shift)
                                                ? (int)prodByShift.Where(n => n.Shift == x.Shift).Sum(n => n.TotalProd)
                                                : 0)
                                                +
                                                (scrapByShift.Any(s => s.Shift == x.Shift)
                                                ? (int)scrapByShift.Where(s => s.Shift == x.Shift).Sum(s => s.Qty)
                                                : 0),

                                    scrapAreaNameDetails = scrapByShift.Any(s => s.Shift == x.Shift)
                                                            ? scrapByShift.Where(s => s.Shift == x.Shift).First().ScrapAreaName.ToList()
                                                            : null,
                                })
                                .Select(x => new
                                {
                                    key = $"{area.Replace(" ", "_")}-{x.Shift.Replace(" ", "_")}",
                                    x.Shift,
                                    x.SapNet,
                                    x.Qty,
                                    x.SapGross,
                                    ScrapRate = x.SapGross == 0 ? 0 : (decimal)x.Qty / x.SapGross,
                                    scrapAreaNameDetails = x.scrapAreaNameDetails
                                                        .Select(a => new
                                                        {
                                                            key = $"{area.Replace(" ", "_")}-{x.Shift.Replace(" ", "_")}_{a.ScrapAreaName.Replace(" ", "_")}",
                                                            x.Shift,
                                                            a.ScrapAreaName,
                                                            a.Qty,
                                                            ScrapRate = x.SapGross == 0 ? 0 : (decimal)a.Qty / x.SapGross,
                                                            LineDetails = a.LineDetals
                                                                            .Select(l => new
                                                                            {
                                                                                key = $"{area.Replace(" ", "_")}-{x.Shift.Replace(" ", "_")}_{a.ScrapAreaName.Replace(" ", "_")}_{l.Line.Replace(" ", "_")}",
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

                if (isPurchasedScrap)
                {
                    return result;
                }
                else
                {
                    return result.Where(x => x.ScrapRate < 1);
                }

            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public async Task<IEnumerable<dynamic>> GetScrapByDept(DateTime startDate, DateTime endDate, bool isPurchasedScrap = false)
        {
            try
            {
                var prod = await _context.Production2
                                .Where(x => x.ShiftDate >= startDate && x.ShiftDate <= endDate)
                                .GroupBy(x => new { x.Area })
                                .Select(x => new
                                {
                                    x.Key.Area,
                                    TotalProd = x.Sum(s => s.QtyProd)
                                })
                                .ToListAsync().ConfigureAwait(false);

                var scrap = await _context.Scrap2
                                    .Where(x => x.ShiftDate >= startDate && x.ShiftDate <= endDate)
                                    .Where(x => x.ScrapCode != "8888")
                                    .Where(x => x.IsPurchashedExclude == isPurchasedScrap)
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
                                                                Qty = (int)a.Sum(t => t.Qty),
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
                                                ? (int)prod.Where(n => n.Area == x.Area).Sum(n => n.TotalProd)
                                                : 0,

                                    Qty = scrap.Any(s => s.Area == x.Area)
                                            ? (int)scrap.Where(s => s.Area == x.Area).Sum(s => s.Qty)
                                            : 0,

                                    SapGross = (prod.Any(n => n.Area == x.Area)
                                                ? (int)prod.Where(n => n.Area == x.Area).Sum(n => n.TotalProd)
                                                : 0)
                                                +
                                                (scrap.Any(s => s.Area == x.Area)
                                                ? (int)scrap.Where(s => s.Area == x.Area).Sum(s => s.Qty)
                                                : 0),

                                    ScrapAreaNameDetails = scrapByArea.Any(s => s.Area == x.Area)
                                                    ? scrapByArea.Where(s => s.Area == x.Area).First().ScrapAreaNameDetails.ToList()
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
                                                                                }).OrderByDescending(x => x.ScrapRate)
                                                            })
                                                            .OrderByDescending(a => a.ScrapRate)
                                                            .ToList()

                                }).OrderByDescending(x => x.ScrapRate).ToList();

                if (isPurchasedScrap)
                {
                    return result;
                }
                else
                {
                    return result.Where(x => x.ScrapRate < 1);
                }

            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }


        public async Task<IEnumerable<dynamic>> GetPpmhPerDeptPlantWideVariance(DateTime start, DateTime end, string area)
        {
            try
            {
                if (area == null) throw new ArgumentNullException(nameof(area));

                var deptName = area;
                var deptForTarget = area;
                switch (area.ToLower().Trim())
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
                var laborHours = await _fmsb2Repo.GetLaborHoursData(start, end, area).ConfigureAwait(false);

                var prod = (await _context.Production2
                                        .Where(x => x.ShiftDate >= start && x.ShiftDate <= end && x.Area == area)
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
                                        .Where(x => x.ShiftDate >= start && x.ShiftDate <= end && x.Area == area)
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
                                    .Where(x => x.Year >= start.Year && x.Year <= end.Year)
                                    .Where(x => x.Department.ToLower() == deptForTarget)
                                    .ToListAsync().ConfigureAwait(false);

                var quarterlyTarget = monthlyTarget
                                            .GroupBy(x => new { x.Quarter, x.Year })
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
                    Target = quarterlyTarget.Where(t => t.Year == x.Key.Year && t.Quarter == x.Key.Quarter).First().LaborHoursTarget,
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
                                        Target = monthlyTarget.Where(t => t.Year == m.Key.Year && t.MonthNumber == m.Key.Month).First().PpmhTarget,
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

        public async Task<IEnumerable<dynamic>> GetPpmhPerShiftVariance(DateTime start, DateTime end, string area)
        {
            try
            {
                if (area == null) throw new ArgumentNullException(nameof(area));

                var deptName = area;
                var deptForTarget = area;
                switch (area.ToLower().Trim())
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
                var laborHours = await _fmsb2Repo.GetLaborHoursData(start, end, area).ConfigureAwait(false);

                var prod = await _context.Production2
                                        .Where(x => x.ShiftDate >= start && x.ShiftDate <= end && x.Area == area)
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
                                    .Where(x => x.Year >= start.Year && x.Year <= end.Year)
                                    .Where(x => x.MonthNumber >= start.Month && x.MonthNumber <= end.Month)
                                    .Where(x => x.Department.ToLower() == deptForTarget)
                                    .AverageAsync(x => x.PpmhTarget)
                                    .ConfigureAwait(false);

                var uniqueShifts = prod.Select(x => x.Shift).Distinct().ToList();
                var list = new List<dynamic>();

                foreach (var shift in uniqueShifts)
                {
                    var rec = new
                    {
                        Area = deptName,
                        Shift = shift,
                        Target = ppmhTarget,
                        SapNet = prod.Where(p => p.Shift == shift).Sum(t => t.Qty),
                        SapScrap = 0,
                        SapGross = 0,
                        LaborHours = _fmsb2Repo.GetPPMH((int)prod.Where(p => p.Shift == shift).Sum(t => t.Qty),
                                        laborHours.Where(l => l.Shift2 == shift).ToList()),

                    };
                    list.Add(rec);

                }

                return list;
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

                var scrapTypeName = area;

                switch (area)
                {
                    case "Foundry Cell":
                        scrapTypeName = "Foundry";
                        break;

                    case "Machine Line":
                        scrapTypeName = "Machining";
                        break;

                    case "Skirt Coat":
                        scrapTypeName = "Finishing";
                        break;
                }

                var scrapData = await GetDailyScrapRateByCode(start, end, area, isPurchasedScrap).ConfigureAwait(false);
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
                                        .GroupBy(x => new { x.Quarter, x.Year })
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
                                    Target = quarterlyTarget.Where(k => k.Quarter == x.Key.Quarter && k.Year == x.Key.Year).First().AvgScrapRateTargetDecimal,
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
                                                        Target = monthlyTarget.Where(k => k.MonthNumber == m.Key.Month && k.Year == x.Key.Year).First().ScrapRateTargetDecimal,
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

        public async Task<DepartmentKpiDto> GetDepartmentKpi(DateTime start, DateTime end, string area)
        {
            if (area == null) throw new ArgumentNullException(nameof(area));

            var deptHxh = area;
            switch (area.ToLower().Trim())
            {
                case "foundry cell":
                    deptHxh = "Foundry";
                    break;
                case "machine line":
                    deptHxh = "Machining";
                    break;
            }

            //get data from db
            var production = await _context.Production2
                               .Where(x => x.ShiftDate >= start && x.ShiftDate <= end)
                               .Where(x => x.Area.ToLower() == area.ToLower().Trim())
                               .GroupBy(x => new { x.Area })
                               .Select(x => new
                               {
                                   x.Key.Area,
                                   TotalProd = x.Sum(s => s.QtyProd)
                               })
                               .ToListAsync()
                               .ConfigureAwait(false);

            var scrapDataQry = _context.Scrap2.AsQueryable();

            var scrapData = await _context.Scrap2
                                .Where(x => x.ShiftDate >= start && x.ShiftDate <= end)
                                .Where(x => x.Area.ToLower() == area.ToLower().Trim())
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

            var hxhTarget = await _intranetRepo.HxHTargetByArea(start, end, area).ConfigureAwait(false);
            var scrapAreaCode = await _context.ScrapAreaCode.ToListAsync().ConfigureAwait(false);
            var oaeTarget = ((await _fmsb2Repo.GetTargets(area, start.Year, end.Year).ConfigureAwait(false))
                                .Where(x => x.Year == end.Year && x.MonthNumber == end.Month).First().OaeTarget) / 100;

            var downtimeData = (await _fmsbMvcRepo.GetDowntime(new DowntimeResourceParameter { Start = start, End = end }).ConfigureAwait(false));
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
                                                                ? lineTarget.Where(l => l.MachineName == x.Key.Line).First().PartsPerMinute * x.Sum(s => s.DowntimeLoss)
                                                                : 0
                                        })
                                        .Sum(x => x.DowntimeParts);

            var totalAreaScrap = (int)scrapData.Sum(x => x.TotalScrap);
            var totalProdcution = (int)production.Sum(x => x.TotalProd);
            var totalTarget = hxhTarget.Sum(x => x.Target);
            var sapGross = totalProdcution + totalAreaScrap;

            //rates

            var sapOae = totalTarget == 0 ? 0 : (decimal)totalProdcution / (decimal)totalTarget;
            var overallScrapRate = sapGross == 0 ? 0 : (decimal)totalAreaScrap / (decimal)sapGross;
            var downtimeRate = totalTarget == 0 ? 0 : (decimal)totalDowntimeParts / totalTarget;

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
                ScrapQty = (int)x.TotalScrap,
                ScrapRate = sapGross == 0 ? 0 : (decimal)x.TotalScrap / sapGross,
                ColorCode = scrapAreaCode.Any(s => s.ScrapAreaName == x.ScrapAreaName)
                                ? scrapAreaCode.Where(s => s.ScrapAreaName == x.ScrapAreaName).First().ColorCode
                                : scrapAreaCode.Where(s => s.ScrapAreaName == "Other").First().ColorCode
            }).ToList();

            var res = new DepartmentKpiDto
            {
                Area = area,
                TotalAreaScrap = totalAreaScrap,
                TotalProduction = totalProdcution,
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

        public async Task<IEnumerable<dynamic>> GetPlantWidePpmh(DateTime startDate, DateTime endDate)
        {
            //todo: ask Hannes is the ppmh calculation for Plant PPMH is SAP net / Hours

            //get data from db
            var p1s = new List<string> { "P1A", "P1F", "P1M" };

            #region DB SAP Net

            var sapNetLessDmax = await _context.Production2
                    .Where(x => x.ShiftDate >= startDate && x.ShiftDate <= endDate)
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
                                .Where(x => x.ShiftDate >= startDate && x.ShiftDate <= endDate)
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
                        .GetPlantLaborHours(startDate, endDate)
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

                                    sapNetLessDmax = sapNetLessDmax.Any(d => d.ShiftDate.ToYear() == x.Key.Year && d.ShiftDate.ToQuarter() == x.Key.Quarter)
                                                    ? (decimal)sapNetLessDmax.Where(d => d.ShiftDate.ToYear() == x.Key.Year && d.ShiftDate.ToQuarter() == x.Key.Quarter).Sum(t => t.Qty)
                                                    : 0,

                                    sapNetDmax = dmaxSapNet.Any(d => d.ShiftDate.ToYear() == x.Key.Year && d.ShiftDate.ToQuarter() == x.Key.Quarter)
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

                                                        sapNetLessDmax = sapNetLessDmax.Any(d => d.ShiftDate.ToYear() == m.Key.Year && d.ShiftDate.ToQuarter() == m.Key.Quarter && d.ShiftDate.ToMonth() == m.Key.Month)
                                                                        ? (decimal)sapNetLessDmax.Where(d => d.ShiftDate.ToYear() == m.Key.Year && d.ShiftDate.ToQuarter() == m.Key.Quarter && d.ShiftDate.ToMonth() == m.Key.Month).Sum(t => t.Qty)
                                                                        : 0,

                                                        sapNetDmax = dmaxSapNet.Any(d => d.ShiftDate.ToYear() == m.Key.Year && d.ShiftDate.ToQuarter() == m.Key.Quarter && d.ShiftDate.ToMonth() == m.Key.Month)
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

                                                                            sapNetLessDmax = sapNetLessDmax.Any(d => d.ShiftDate.ToYear() == m.Key.Year && d.ShiftDate.ToQuarter() == m.Key.Quarter && d.ShiftDate.ToMonth() == m.Key.Month && d.ShiftDate.ToWeekNumber() == w.Key.WeekNumber)
                                                                            ? (decimal)sapNetLessDmax.Where(d => d.ShiftDate.ToYear() == m.Key.Year && d.ShiftDate.ToQuarter() == m.Key.Quarter && d.ShiftDate.ToMonth() == m.Key.Month && d.ShiftDate.ToWeekNumber() == w.Key.WeekNumber).Sum(t => t.Qty)
                                                                            : 0,

                                                                            sapNetDmax = dmaxSapNet.Any(d => d.ShiftDate.ToYear() == m.Key.Year && d.ShiftDate.ToQuarter() == m.Key.Quarter && d.ShiftDate.ToMonth() == m.Key.Month && d.ShiftDate.ToWeekNumber() == w.Key.WeekNumber)
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
                                    x.Overtime,
                                    x.Orientation,

                                    x.sapNetLessDmax,
                                    x.sapNetDmax,

                                    x.OverallHours,
                                    OverallHoursLessDmax = GetOverallHoursLessDmax(x.OverallHours, x.sapNetDmax, x.sapNetLessDmax),

                                    PPMH = CalculatePlantPpmh(x.OverallHours, x.sapNetDmax, x.sapNetLessDmax),

                                    MonthDetails = x.MontDetails
                                                    .Select(m => new
                                                    {
                                                        m.Month,
                                                        m.Regular,
                                                        m.Overtime,
                                                        m.DoubleTime,
                                                        m.Orientation,

                                                        m.sapNetLessDmax,
                                                        m.sapNetDmax,

                                                        m.OverallHours,
                                                        OverallHoursLessDmax = GetOverallHoursLessDmax(m.OverallHours, m.sapNetDmax, m.sapNetLessDmax),
                                                        PPMH = CalculatePlantPpmh(m.OverallHours, m.sapNetDmax, m.sapNetLessDmax),

                                                        WeekDetails = m.WeekDetails
                                                                        .Select(w => new
                                                                        {
                                                                            w.WeekNumber,
                                                                            w.Regular,
                                                                            w.Overtime,
                                                                            w.DoubleTime,
                                                                            w.Orientation,

                                                                            w.sapNetLessDmax,
                                                                            w.sapNetDmax,

                                                                            w.OverallHours,
                                                                            OverallHoursLessDmax = GetOverallHoursLessDmax(w.OverallHours, w.sapNetDmax, w.sapNetLessDmax),
                                                                            PPMH = CalculatePlantPpmh(w.OverallHours, w.sapNetDmax, w.sapNetLessDmax),
                                                                        })
                                                                        .OrderBy(w => w.WeekNumber)
                                                    }).OrderBy(m => m.Month)
                                })
                                .OrderBy(x => x.Year)
                                .ThenBy(x => x.Quarter)
                                .ToList();


            return quarterlyHours;
        }

        public decimal? CalculatePlantPpmh(decimal? overallHours, decimal? sapNetDmax, decimal sapNetLessDmax)
        {
            var dmaxHours = sapNetLessDmax == 0 ? 0 : sapNetDmax * dmaxHourRate / sapNetLessDmax;
            var hours = overallHours - dmaxHours;
            return hours == 0 ? 0 : sapNetLessDmax / hours;
        }

        public decimal? GetOverallHours(decimal? regular, decimal? overtime, decimal? doubleTime, decimal? orientation)
        {
            return regular + overtime + doubleTime + orientation;
        }

        public decimal? GetOverallHoursLessDmax(decimal? overallHours, decimal? sapNetDmax, decimal? sapNetLessDmax)
        {
            var dmaxHours = sapNetLessDmax == 0 ? 0 : sapNetDmax * dmaxHourRate / sapNetLessDmax;
            return overallHours - dmaxHours;
        }

        public async Task<IEnumerable<dynamic>> GetDailyScrapByCodeByShift(DateTime startDate, DateTime endDate, string scrapCode, bool isPurchasedScrap = false, bool isTotalScrap = false)
        {
            var scrapQry = _context.Scrap2.AsQueryable();
            scrapQry = scrapQry.Where(x => x.ShiftDate >= startDate && x.ShiftDate <= endDate);

            if (isTotalScrap)
            {
                scrapQry = scrapQry.Where(x => x.IsPurchashedExclude == isPurchasedScrap);
            }
            else
            {
                scrapQry = scrapQry.Where(x => x.ScrapCode == scrapCode);
            }

            var data = await scrapQry
                            .GroupBy(x => new { x.ShiftDate, x.Shift, x.ScrapCode, x.ScrapDesc })
                            .Select(x => new
                            {
                                x.Key.ShiftDate,
                                x.Key.Shift,
                                //ShiftOrder = MapShiftToShiftOrder(x.Key.Shift),
                                x.Key.ScrapCode,
                                x.Key.ScrapDesc,
                                Qty = x.Sum(t => t.Qty)
                            })
                            .OrderBy(x => x.ShiftDate)
                            //.ThenBy(x => x.ShiftOrder)
                            .ToListAsync()
                            .ConfigureAwait(false);

            return data;

        }
    }
}
