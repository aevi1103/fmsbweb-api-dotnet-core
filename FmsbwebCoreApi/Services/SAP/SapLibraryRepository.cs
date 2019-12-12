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

namespace FmsbwebCoreApi.Services.SAP
{
    public class SapLibraryRepository : ISapLibraryRepository, IDisposable
    {

        private readonly SapContext _context;
        private readonly IntranetContext _IntranetContext;
        private readonly Fmsb2Context _fmsbContext;

        private readonly IFmsb2LibraryRepository _fmsb2Repo;

        public SapLibraryRepository(
            SapContext context,
            IntranetContext intranetContext,
            Fmsb2Context fmsbContext,
            IFmsb2LibraryRepository fmsb2Repo)
        {
            _context = context ??
                throw new ArgumentNullException(nameof(context));

            _IntranetContext = intranetContext ??
                throw new ArgumentNullException(nameof(intranetContext));

            _fmsbContext = fmsbContext ??
                throw new ArgumentNullException(nameof(fmsbContext));

            _fmsb2Repo = fmsb2Repo ??
                throw new ArgumentNullException(nameof(fmsb2Repo));
        }

        public IEnumerable<Scrap2Summary2> GetScrap(DateTime start, DateTime end)
        {
            return _context.Scrap2Summary2.Where(x => x.ShiftDate >= start && x.ShiftDate <= end).ToList();
        }

        public IEnumerable<ScrapByCodeDto> GetScrapByCode(List<Models.SAP.Scrap> scrap, string area, bool isSbScrap, int sapNet)
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

            var sapGross = summary.Sum(x => x.Qty) + sapNet;

            var result = summary
                            .GroupBy(x => new { x.Area, x.ScrapAreaName })
                            .Select(x => new ScrapByCodeDto
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

            return result;
        }

        public IEnumerable<DepartmentScrapDto> GetDepartmentScrap(List<Models.SAP.Scrap> scrap, string area, int sapNet)
        {
            var summary = scrap
                            .Where(x => x.ScrapCode != "8888")
                            .Where(x => x.Area == area)
                            .ToList();

            var sapGross = summary.Sum(x => x.Qty) + sapNet;

            var result = summary
                            .GroupBy(x => new { x.Area, x.IsPurchashedExclude2 })
                            .Select(x => new DepartmentScrapDto
                            {
                                Area = x.Key.Area,
                                ScrapType = x.Key.IsPurchashedExclude2,
                                Qty = x.Sum(s => s.Qty),
                                SapGross = sapGross,
                                ScrapRate = sapGross == 0 ? 0 : (decimal)x.Sum(s => s.Qty) / (decimal)sapGross
                            })
                            .ToList();

            return result;

        }

        public IEnumerable<SapProductionByTypeDto> GetSapProductionByType(List<SapProdDto> sapProd, string area)
        {
            switch (area)
            {
                case "Foundry Cell":

                    return sapProd
                            .Where(x => x.SapType == "P5C")
                            .GroupBy(x => new { x.Area, x.SapType })
                            .Select(x => new SapProductionByTypeDto
                            {
                                Area = x.Key.Area,
                                SapType = x.Key.SapType,
                                SapNet = x.Sum(s => s.Qty)
                            })
                            .ToList();

                case "Machine Line":

                    return sapProd
                            .Where(x => x.SapType == "P3M")
                            .GroupBy(x => new { x.Area, x.SapType })
                            .Select(x => new SapProductionByTypeDto
                            {
                                Area = x.Key.Area,
                                SapType = x.Key.SapType,
                                SapNet = x.Sum(s => s.Qty)
                            })
                            .ToList();

                case "Skirt Coat":

                    var fin = new List<string> { "P1F", "P2F" };

                    return sapProd
                            .Where(x => fin.Contains(x.SapType))
                            .GroupBy(x => new { x.Area, x.SapType })
                            .Select(x => new SapProductionByTypeDto
                            {
                                Area = x.Key.Area,
                                SapType = x.Key.SapType,
                                SapNet = x.Sum(s => s.Qty)
                            })
                            .ToList();

                case "Assembly":

                    return sapProd
                            .Where(x => x.SapType == "P1A")
                            .GroupBy(x => new { x.Area, x.SapType })
                            .Select(x => new SapProductionByTypeDto
                            {
                                Area = x.Key.Area,
                                SapType = x.Key.SapType,
                                SapNet = x.Sum(s => s.Qty)
                            })
                            .ToList();

                default:

                    return new List<SapProductionByTypeDto>();
            }
        }

        public async Task<IEnumerable<ProductionMorningMeetingDto>> GetProductionData(DateTime start, DateTime end)
        {
            //load data from db
            var scrap = await _context.Scrap2Summary2
                            .Where(x => x.ShiftDate >= start && x.ShiftDate <= end)
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

            var hxh = await _IntranetContext.FmsbMasterProdPartsCopyDashboard
                            .Where(x => x.Date >= start && x.Date <= end)
                            .Where(x => x.Area != "Anodize")
                            .GroupBy(x => new { x.Department, x.Area })
                            .Select(x => new
                            {
                                x.Key.Department,
                                x.Key.Area,
                                target = x.Sum(s => s.OeeTarget),
                                gross = x.Sum(s => s.FoundryGross)
                                        + x.Sum(s => s.MachiningGross)
                                        + x.Sum(s => s.AnodGross)
                                        + x.Sum(s => s.ScGross)
                                        + x.Sum(s => s.AssyGross)
                            }).ToListAsync();

            var sapProd = await _context.Production2Summary
                                .Where(x => x.ShiftDate >= start && x.ShiftDate <= end)
                                .GroupBy(x => new { x.Area, sapType = x.Material.Substring(0, 3) })
                                .Select(x => new SapProdDto
                                {
                                    SapType = x.Key.sapType,
                                    Area = x.Key.Area,
                                    Qty = (int)x.Sum(s => s.Qty)
                                }).ToListAsync();

            //transform data
            var sbScrap = scrap
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


            var overallScrap = scrap
                                .Where(x => x.ScrapCode != "8888")
                                .GroupBy(x => new { x.Department, x.Area })
                                .Select(x => new
                                {
                                    x.Key.Department,
                                    x.Key.Area,
                                    qty = x.Sum(s => s.Qty)
                                }).ToList();

            var warmersCodes = new List<string> { "8888", "8889" };
            var warmers = scrap
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
            var prodScrapForLaborHrs = await _fmsb2Repo.GetProdScrapForLaborHrs(start, end);
            var laborHrs = await _fmsb2Repo.GetLaborHoursData(start, end);

            var result = hxh
                            .Select(x => new ProductionMorningMeetingDto
                            {
                                Department = x.Department,
                                Area = x.Area,
                                Target = (int)x.target,

                                HxhGross = x.gross,
                                SapGross = sapProd.Where(s => s.Area == x.Area).Sum(s => s.Qty) + sbScrap.Where(w => w.Area == x.Area).Sum(w => w.qty), //with sb scrap only

                                PlannedWarmers = warmers.Where(w => w.Area == x.Area && w.ScrapCode == "8888").Sum(w => w.qty),
                                UnPlannedWarmers = warmers.Where(w => w.Area == x.Area && w.ScrapCode == "8889").Sum(w => w.qty),
                                TotalSbScrap = sbScrap.Where(w => w.Area == x.Area).Sum(w => w.qty),
                                TotalScrapByDept = overallScrap.Where(w => w.Area == x.Area).Sum(w => w.qty),

                                SapNet = sapProd.Where(s => s.Area == x.Area).Sum(s => s.Qty),
                                SapOae = (int)x.target == 0 ? 0 : sapProd.Where(s => s.Area == x.Area).Sum(s => s.Qty) / x.target,

                                SbScrapByCode = GetScrapByCode(scrap, x.Area, true, sapProd.Where(s => s.Area == x.Area).Sum(s => s.Qty)),
                                PurchaseScrapByCode = GetScrapByCode(scrap, x.Area, false, sapProd.Where(s => s.Area == x.Area).Sum(s => s.Qty)),
                                DepartmentScrap = GetDepartmentScrap(scrap, x.Area, sapProd.Where(s => s.Area == x.Area).Sum(s => s.Qty)),

                                SapProductionByType = GetSapProductionByType(sapProd, x.Area),
                                LaborHours = _fmsb2Repo.GetRollingDaysPPMH(prodScrapForLaborHrs, laborHrs, start, end, x.Area)
                            })
                            .ToList();

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
