using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FmsbwebCoreApi.Context.SAP;
using FmsbwebCoreApi.Context.Intranet;
using FmsbwebCoreApi.Entity.SAP;
using FmsbwebCoreApi.Entity.Intranet;
using FmsbwebCoreApi.Context.Fmsb2;
using FmsbwebCoreApi.Models.SAP;
using Microsoft.EntityFrameworkCore;
using FmsbwebCoreApi.Services.FMSB2;
using FmsbwebCoreApi.Services.Intranet;
using FmsbwebCoreApi.Helpers;
using FmsbwebCoreApi.Entity.Fmsb2;

namespace FmsbwebCoreApi.Services.SAP
{
    public class SapLibraryRepository : ISapLibraryRepository, IDisposable
    {

        private readonly SapContext _context;
        //private readonly IntranetContext _IntranetContext;
        private readonly Fmsb2Context _fmsbContext;

        private readonly IFmsb2LibraryRepository _fmsb2Repo;
        private readonly IIntranetLibraryRepository _intranetRepo;

        public SapLibraryRepository(
            SapContext context,
            IntranetContext intranetContext,
            Fmsb2Context fmsbContext,
            IFmsb2LibraryRepository fmsb2Repo,
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
        }

        public IEnumerable<Models.SAP.KpiTargets> GetInMemoryKpiTarget(string area, string type)
        {
            var kpis = new List<Models.SAP.KpiTargets>
            {
                new Models.SAP.KpiTargets
                {
                    Area = "Foundry",
                    Kpi = "OAE",
                    Min = .65m,
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
                    Min = 65,
                    Max = 75
                },

                new Models.SAP.KpiTargets
                {
                    Area = "Machining",
                    Kpi = "OAE",
                    Min = .6m,
                    Max = .7m
                },

                new Models.SAP.KpiTargets
                {
                    Area = "Machining",
                    Kpi = "Scrap",
                    Min = .05m,
                    Max = .05m
                },

                new Models.SAP.KpiTargets
                {
                    Area = "Machining",
                    Kpi = "PPMH",
                    Min = 40,
                    Max = 50
                },

                new Models.SAP.KpiTargets
                {
                    Area = "Finishing",
                    Kpi = "OAE",
                    Min = .4m,
                    Max = .55m
                },

                new Models.SAP.KpiTargets
                {
                    Area = "Finishing",
                    Kpi = "Scrap",
                    Min = .035m,
                    Max = .035m
                },

                new Models.SAP.KpiTargets
                {
                    Area = "Finishing",
                    Kpi = "PPMH",
                    Min = 40,
                    Max = 46
                },

                new Models.SAP.KpiTargets
                {
                    Area = "Assembly",
                    Kpi = "OAE",
                    Min = .4m,
                    Max = .55m
                },

                new Models.SAP.KpiTargets
                {
                    Area = "Assembly",
                    Kpi = "Scrap",
                    Min = .035m,
                    Max = .035m
                },

                new Models.SAP.KpiTargets
                {
                    Area = "Assembly",
                    Kpi = "PPMH",
                    Min = 40,
                    Max = 46
                }
            };

            return kpis;
        }

        public IEnumerable<Scrap2Summary2> GetScrap(DateTime start, DateTime end)
        {
            return _context.Scrap2Summary2.Where(x => x.ShiftDate >= start && x.ShiftDate <= end).ToList();
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
                                SapGross = sapGross, // add sap net + tot
                                ScrapRate = sapGross == 0 ? 0 : (decimal)x.Sum(s => s.Qty) / (decimal)sapGross
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
                            }).ToListAsync();
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
                                    ScrapAreaName = x.ScrapAreaName,
                                    ScrapCode = x.ScrapCode,
                                    IsPurchashedExclude = (bool)x.IsPurchashedExclude,
                                    IsPurchashedExclude2 = x.IsPurchashedExclude2,
                                    ScrapDesc = x.ScrapDesc,
                                    Qty = (int)x.Qty
                                }).ToListAsync();
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
                                }).ToListAsync();
        }

        public async Task<IEnumerable<SapProdDto>> GetSapProdByTypeFromDb(DateTime start, DateTime end, string area)
        {
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
                            }).ToListAsync();
        }

        public string GetColorCode(string area, string type, decimal? value)
        {
            if (value == null)
            {
                return "#262626";
            }

            var targets = GetInMemoryKpiTarget(area, type).FirstOrDefault();

            var red = "#FF4136";
            var yellow = "#FFB700";
            var green = "#19A974";

            if (type == "oae" || type == "ppmh")
            {
                if (value < targets.Min)
                {
                    return red;
                }
                else if (value >= targets.Min && value <= targets.Max)
                {
                    return yellow;
                }
                else
                {
                    return green;
                }
            }

            if (type == "scrap")
            {
                if (value < targets.Min)
                {
                    return green;
                }
                else if (value >= targets.Min && value <= targets.Max)
                {
                    return yellow;
                }
                else
                {
                    return red;
                }
            }

            return "#262626";
        }

        public async Task<ProductionMorningMeetingDto> GetProductionData(DateTime start, DateTime end, string area)
        {
            //load data from db
            var scrapByScrapArea = (await GetScrapDataByScrapAreaFromDb(start, end, area)).ToList();
            var scrapByDepartment = (await GetScrapDataByDepartmentFromDb(start, end, area)).ToList();

            var sapProdByArea = (await GetSapProdByAreaFromDb(start, end, area)).ToList();
            var sapProdByType = (await GetSapProdByTypeFromDb(start, end, area)).ToList();

            var hxh = (await _intranetRepo.GetHxhProduction(start, end, area)).ToList();

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
            var scrapForLaborHours = new List<Models.SAP.Scrap>();
            var laborHrs = new List<FinanceLaborHoursView>();
            var startDayForLaborHorsIfYesterday = end.AddDays(-6);
            if (start.IsYesterday()) //check if date is yesterday, if yes subtract -6 day from end day and store in a variable
            {
                //get data from the db with the new date range
                var prodScrapForLaborHrs = await _fmsb2Repo.GetProdScrapForLaborHrs(startDayForLaborHorsIfYesterday, end, area);
                prodForLaborHours = prodScrapForLaborHrs.Prod.ToList();
                scrapForLaborHours = prodScrapForLaborHrs.Scrap.ToList();

                //get labor hrs data from db
                laborHrs = await _fmsb2Repo.GetLaborHoursData(startDayForLaborHorsIfYesterday, end);
            }
            else
            {
                //use the original db request for prod and scrap
                prodForLaborHours = sapProdByArea;
                scrapForLaborHours = scrapByDepartment;

                //use unmodified date range
                laborHrs = await _fmsb2Repo.GetLaborHoursData(start, end);
            }

            var result = hxh
                            .Select(x => new ProductionMorningMeetingDto
                            {
                                Department = x.Department,
                                Area = x.Area,
                                Target = (int)x.Target,

                                HxhGross = x.Gross,
                                SapGross = sapProdByArea.Where(s => s.Area == x.Area).Sum(s => s.Qty) + sbScrap.Where(w => w.Area == x.Area).Sum(w => w.qty), //with sb scrap only

                                PlannedWarmers = warmers.Where(w => w.Area == x.Area && w.ScrapCode == "8888").Sum(w => w.qty),
                                UnPlannedWarmers = warmers.Where(w => w.Area == x.Area && w.ScrapCode == "8889").Sum(w => w.qty),
                                TotalSbScrap = sbScrap.Where(w => w.Area == x.Area).Sum(w => w.qty),
                                TotalScrapByDept = overallScrap.Where(w => w.Area == x.Area).Sum(w => w.qty),

                                SapNet = sapProdByArea.Where(s => s.Area == x.Area).Sum(s => s.Qty),
                                SapOae = (int)x.Target == 0 ? 0 : sapProdByArea.Where(s => s.Area == x.Area).Sum(s => s.Qty) / x.Target,

                                SbScrapByCode = GetScrapByCode(scrapByScrapArea, x.Area, true, sapProdByArea.Where(s => s.Area == x.Area).Sum(s => s.Qty)),
                                PurchaseScrapByCode = GetScrapByCode(scrapByScrapArea, x.Area, false, sapProdByArea.Where(s => s.Area == x.Area).Sum(s => s.Qty)),
                                DepartmentScrap = GetDepartmentScrap(scrapByDepartment, x.Area, sapProdByArea.Where(s => s.Area == x.Area).Sum(s => s.Qty)),

                                SapProductionByType = GetSapProductionByType(sapProdByType, x.Area),

                                LaborHours = _fmsb2Repo.GetRollingDaysPPMH(prodForLaborHours, scrapForLaborHours, laborHrs, start, end, x.Area),

                                SapOaeColorCode = GetColorCode(x.Area, "oae", (int)x.Target == 0 ? 0 : sapProdByArea.Where(s => s.Area == x.Area).Sum(s => s.Qty) / x.Target),
                                ScrapByCodeColorCode = GetColorCode(x.Area, "scrap",
                                                        GetScrapByCode(scrapByScrapArea, x.Area, true, sapProdByArea.Where(s => s.Area == x.Area).Sum(s => s.Qty)).ScrapRate
                                                        ),
                                PpmhColorCode = GetColorCode(x.Area, "ppmh",
                                                        _fmsb2Repo.GetRollingDaysPPMH(prodForLaborHours, scrapForLaborHours, laborHrs, start, end, x.Area).PPMH
                                                        ),

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
    }
}
