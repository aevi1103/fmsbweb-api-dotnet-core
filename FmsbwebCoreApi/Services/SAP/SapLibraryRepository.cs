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
using FmsbwebCoreApi.Models.Intranet;

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

        public string MapAreaTopScrapArea(string area)
        {
            switch (area.ToLower().Trim())
            {
                case "foundry cell":
                    return "foundry";
                case "machine line":
                    return "machining";
                default:
                    return area;
            }
        }
        public IEnumerable<Models.SAP.KpiTargets> GetInMemoryKpiTarget()
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
                    Min = 50,
                    Max = 50
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
                    Min = 50,
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
                    Min = 50,
                    Max = 50
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
                    Min = 50,
                    Max = 50
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
                                    Line = x.MachineHxh,
                                    Program = x.Program,
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
                                .Where(x => x.MachineHxh != "A10") //remove per ryan boyle
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
                        .Where(x => x.MachineHxh != "A10") //remove per ryan boyle
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
            var black = "#262626";

            if (value == null)
            {
                return black;
            }

            if (area.ToLower().Trim() == "foundry cell")
            {
                area = "foundry";
            }

            if (area.ToLower().Trim() == "machine line")
            {
                area = "machining";
            }

            if (area.ToLower().Trim() == "skirt coat")
            {
                area = "finishing";
            }

            var targets = GetInMemoryKpiTarget().Where(x => x.Area.ToLower().Trim() == area.ToLower().Trim() && x.Kpi.ToLower().Trim() == type.ToLower().Trim()).FirstOrDefault();

            if (targets == null)
            {
                return black;
            }

            var red = "#FF4136";
            var yellow = "#FFB700";
            var green = "#19A974";

            if (type == "oae" || type == "ppmh")
            {
                if (value <= targets.Min)
                {
                    return red;
                }
                else if (value > targets.Min && value < targets.Max)
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
                if (value <= targets.Min)
                {
                    return green;
                }
                else if (value > targets.Min && value < targets.Max)
                {
                    return yellow;
                }
                else
                {
                    return red;
                }
            }

            return black;
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
                                SapOaeColorCode = GetColorCode(x.Area, "oae", (int)x.Target == 0 ? 0 : sapProdByArea.Where(s => s.Area == x.Area).Sum(s => s.Qty) / x.Target),

                                HxHNet = x.Gross - ((x.Area.ToLower() == "foundry cell" || x.Area.ToLower() == "machine line")
                                                    ? scrapByDepartment.Where(s => s.ScrapCode != "8888").Sum(s => s.Qty)
                                                    : 0),

                                HxhOae = x.Target == 0 ? 0 : (decimal)(x.Gross - ((x.Area.ToLower() == "foundry cell" || x.Area.ToLower() == "foundry cell")
                                                                ? scrapByDepartment.Where(s => s.ScrapCode != "8888").Sum(s => s.Qty)
                                                                : 0))
                                                            / (decimal)x.Target,

                                SbScrapByCode = GetScrapByCode(scrapByScrapArea, x.Area, true, sapProdByArea.Where(s => s.Area == x.Area).Sum(s => s.Qty)),
                                PurchaseScrapByCode = GetScrapByCode(scrapByScrapArea, x.Area, false, sapProdByArea.Where(s => s.Area == x.Area).Sum(s => s.Qty)),
                                DepartmentScrap = GetDepartmentScrap(scrapByDepartment, x.Area, sapProdByArea.Where(s => s.Area == x.Area).Sum(s => s.Qty)),

                                SapProductionByType = GetSapProductionByType(sapProdByType, x.Area),

                                LaborHours = _fmsb2Repo.GetRollingDaysPPMH(prodForLaborHours, scrapForLaborHours, laborHrs, start, end, x.Area),


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

        public async Task<IEnumerable<DailyScrapByShiftDateDto>> GetDailyScrapRateByCode(DateTime start, DateTime end, string area)
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
                                .ToListAsync();

            var scrapData = await _context.Scrap2
                                .Where(x => x.ShiftDate >= start && x.ShiftDate <= end)
                                .Where(x => x.ScrapAreaName == MapAreaTopScrapArea(area))
                                .Where(x => x.ScrapCode != "8888")
                                .Where(x => x.IsPurchashedExclude == false)
                                .GroupBy(x => new { x.ShiftDate, x.ScrapAreaName })
                                .Select(x => new
                                {
                                    x.Key.ScrapAreaName,
                                    x.Key.ShiftDate,
                                    TotalScrap = x.Sum(s => s.Qty)
                                })
                                .ToListAsync();

            var data = scrapData
                        .Select(x => new DailyScrapByShiftDateDto
                        {
                            ScrapArea = x.ScrapAreaName,
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
                        .OrderBy(x => x.ShiftDate)
                        .ToList();

            return data;
        }

        public async Task<IEnumerable<DepartmentKpiDto>> GetDailyKpiChart(DateTime start, DateTime end, string area)
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
                               .ToListAsync();

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
                                .ToListAsync();

            var target = await _intranetRepo.DailyHxHTargetByArea(start, end, area);

            //transform data
            var result = production
                            .Select(x => new DepartmentKpiDto
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
                            .Select(x => new DepartmentKpiDto
                            {
                                Area = x.Area,
                                ShiftDate = x.ShiftDate,
                                TotalProduction = x.TotalProduction,
                                TotalAreaScrap = x.TotalAreaScrap,
                                Target = x.Target,
                                SapGross = x.TotalAreaScrap + x.TotalProduction
                            })
                            .Select(x => new DepartmentKpiDto
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
                            .Where(x => x.ScrapAreaName == MapAreaTopScrapArea(area))
                            .Where(x => x.ScrapCode != "8888")
                            .GroupBy(x => new
                            {
                                x.ScrapAreaName,
                                x.Area,
                                x.IsPurchashedExclude,
                                x.IsPurchashedExclude2
                            })
                            .Select(x => new ScrapByCodeDetailsDto
                            {
                                Area = x.Key.Area,
                                ScrapType = x.Key.IsPurchashedExclude2,
                                ScrapAreaName = x.Key.ScrapAreaName,
                                IsPurchaseScrap = (bool)x.Key.IsPurchashedExclude,
                                Qty = (int)x.Sum(s => s.Qty)
                            })
                            .OrderByDescending(x => x.Qty)
                            .ToList();

            var targets = (await _intranetRepo.GetHxhProduction(start, end, area)).ToList();

            //transform data
            var sbScrapList = scrap.Where(x => x.IsPurchaseScrap == false).OrderByDescending(x => x.Qty).ToList();
            var purchaseScrapList = scrap.Where(x => x.IsPurchaseScrap == true).OrderByDescending(x => x.Qty).ToList();

            var target = targets.Sum(x => x.Target);
            var sapProd = prod.Sum(x => x.Qty);
            var sbScrap = sbScrapList.Sum(x => x.Qty);
            var purchasedScrap = purchaseScrapList.Sum(x => x.Qty);

            var sapGross = sapProd + sbScrap;
            var sbScrapRate = sapGross == 0 ? 0 : sbScrap / (decimal)sapGross;
            var purchaseScrapRate = sapGross == 0 ? 0 : purchasedScrap / (decimal)sapGross;
            var sapOae = target == 0 ? 0 : sapProd / target;

            return new GetSapProdAndScrapDto
            {
                Target = (int)target,
                SapProd = sapProd,
                SbScrap = sbScrap,
                PurchasedScrap = purchasedScrap,
                SapGross = sapGross,
                SbScrapRate = sbScrapRate,
                PurchaseScrapRate = purchaseScrapRate,
                SapOae = sapOae,
                DailySapProd = prod,
                SbScrapDetail = sbScrapList
                                    .Select(x => new ScrapByCodeDetailsDto
                                    {
                                        Area = x.Area,
                                        ScrapType = x.ScrapType,
                                        ScrapAreaName = x.ScrapAreaName,
                                        IsPurchaseScrap = x.IsPurchaseScrap,
                                        Qty = x.Qty,
                                        SapGross = sapProd + x.Qty,
                                        ScrapRate = (sapProd + x.Qty) == 0 ? 0 : (decimal)x.Qty / (decimal)(sapProd + x.Qty)
                                    }),
                PurchaseScrapDetail = purchaseScrapList
            };

        }

        public IEnumerable<ProductionByLineDto> GetDepartmentDetailsByLine(
            IEnumerable<Models.SAP.Scrap> scrap,
            IEnumerable<SapProdDetailDto> prod,
            IEnumerable<HxHProductionByLineDto> hxh)
        {

            //distinct lines
            var scrapLines = scrap.Select(x => x.Line).Distinct();
            var sapProdLine = prod.Select(x => x.Line).Distinct();
            var hxhLine = hxh.Select(x => x.Line).Distinct();
            var distinctLines = (scrapLines.Concat(sapProdLine).Concat(hxhLine)).Distinct();

            //transform data
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

            var sbScrap = scrapByLine.Where(x => x.IsPurchashedExclude == false);
            var purchasedScrap = scrapByLine.Where(x => x.IsPurchashedExclude == true);

            //details
            var result = distinctLines.Select(line => new ProductionByLineDto
            {
                Department = hxh.Any(x => x.Line == line) ? hxh.Where(x => x.Line == line).First().Department : "",
                Area = hxh.Any(x => x.Line == line) ? hxh.Where(x => x.Line == line).First().Area : "",
                Line = line,
                Target = hxh.Any(x => x.Line == line) ? (int)hxh.Where(x => x.Line == line).First().Target : 0,

                HxHGross = hxh.Any(x => x.Line == line) ? (int)hxh.Where(x => x.Line == line).First().Gross : 0,

                SapNet = prod.Any(x => x.Line == line) ? prod.Where(x => x.Line == line).Sum(s => s.SapNet) : 0,
                SapNetDetails = prod.Any(x => x.Line == line) ? prod.Where(x => x.Line == line).OrderBy(x => x.DateScanned).ToList() : new List<SapProdDetailDto>(),

                TotalScrap = scrapByLine.Any(x => x.Line == line) ? scrapByLine.Where(x => x.Line == line).Sum(s => s.Qty) : 0,
                TotalSbScrap = sbScrap.Any(x => x.Line == line) ? sbScrap.Where(x => x.Line == line).Sum(s => s.Qty) : 0,
                TotalPurchaseScrap = purchasedScrap.Any(x => x.Line == line) ? purchasedScrap.Where(x => x.Line == line).Sum(s => s.Qty) : 0,
                SbScrapDetails = sbScrap.Any(x => x.Line == line) ? sbScrap.Where(x => x.Line == line).ToList() : new List<Models.SAP.Scrap>(),
                PurchaseScrapDetails = purchasedScrap.Any(x => x.Line == line) ? purchasedScrap.Where(x => x.Line == line).ToList() : new List<Models.SAP.Scrap>(),
            })
            .Select(x => new ProductionByLineDto
            {
                Department = x.Department,
                Area = x.Area,
                Line = x.Line,
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

                TotalSbScrapRate = (x.SapNet + x.TotalScrap) == 0 ? 0 : (decimal)x.TotalScrap / (decimal)(x.SapNet + x.TotalScrap),
                TotalScrapRate = (x.SapNet + x.TotalScrap) == 0 ? 0 : (decimal)x.TotalSbScrap / (decimal)(x.SapNet + x.TotalScrap),
                TotalPurchaseScrapRate = (x.SapNet + x.TotalScrap) == 0 ? 0 : (decimal)x.TotalPurchaseScrapRate / (decimal)(x.SapNet + x.TotalScrap),

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

                TotalSbScrapRate = (x.SapNet + x.TotalScrap) == 0 ? 0 : (decimal)x.TotalScrap / (decimal)(x.SapNet + x.TotalScrap),
                TotalScrapRate = (x.SapNet + x.TotalScrap) == 0 ? 0 : (decimal)x.TotalSbScrap / (decimal)(x.SapNet + x.TotalScrap),
                TotalPurchaseScrapRate = (x.SapNet + x.TotalScrap) == 0 ? 0 : (decimal)x.TotalPurchaseScrapRate / (decimal)(x.SapNet + x.TotalScrap),

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
            //get data from db
            var scrap = (await GetScrapDataByDepartmentFromDb(start, end, area)).Where(x => x.ScrapCode != "8888").ToList();

            var prod = await _context.Production2
                                .Where(x => x.ShiftDate >= start && x.ShiftDate <= end)
                                .Where(x => x.Area == area)
                                .Where(x => x.MachineHxh != "A10") //remove per ryan boyle
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
                                .ToListAsync();

            var hxh = await _intranetRepo.GetHxhProdByLineAndProgram(start, end, area);

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

                DetailsByLine = GetDepartmentDetailsByLine(scrap, prod, hxh.LineDetails),
                DetailsByProgram = GetDepartmentDetailsByProgram(scrap, prod, hxh.ProgramDetails),

                SbScrapDetails = scrapList.Where(s => s.IsPurchashedExclude == false),
                PurchaseScrapDetails = scrapList.Where(s => s.IsPurchashedExclude == true)
            };

        }
    }
}
