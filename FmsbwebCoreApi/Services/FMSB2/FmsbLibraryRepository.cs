using FmsbwebCoreApi.Context.Fmsb2;
using FmsbwebCoreApi.Context.SAP;
using FmsbwebCoreApi.Entity.Fmsb2;
using FmsbwebCoreApi.Models.FMSB2;
using FmsbwebCoreApi.Models.SAP;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FmsbwebCoreApi.Services.FMSB2
{
    public class FmsbLibraryRepository : IFmsb2LibraryRepository, IDisposable
    {
        private readonly Fmsb2Context _context;
        private readonly SapContext _sapContext;

        public FmsbLibraryRepository(Fmsb2Context context, SapContext sapContext)
        {
            _context = context ??
                throw new ArgumentNullException(nameof(context));

            _sapContext = sapContext ??
               throw new ArgumentNullException(nameof(sapContext));

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

        public async Task<List<FinanceLaborHoursView>> GetLaborHoursData(DateTime start, DateTime end)
        {
            return await _context.FinanceLaborHoursView
                            .Where(x => x.DateIn >= start && x.DateIn <= end)
                            .ToListAsync();
        }

        public List<FinanceLaborHoursView> TransformLaborHoursData(IEnumerable<FinanceLaborHoursView> data, string dept = "")
        {

            dept = dept.Trim().ToLower();
            if (dept == "assembly")
            {
                return data.Where(x => (x.DeptName == "FINISHING" || x.DeptName == "ASSEMBLY") && x.IsPso == false).ToList();
            }

            if (dept == "machine line")
            {
                return data.Where(x => x.DeptName == "MACHINING" && x.IsPso == false).ToList();
            }

            if (dept == "foundry cell")
            {
                return data.Where(x => x.DeptName == "FOUNDRY" && x.IsPso == false).ToList();
            }

            if (dept == "pso")
            {
                return data.Where(x => x.IsPso == true).ToList();
            }

            if (dept == "inspector")
            {
                var inspector = data.Where(x => x.DeptName == "QUALITY INSPECTORS" && x.IsPso == false);

                var inspectorTemp = inspector.Where(x => x.Type == "Temp");
                var inspectorFulltime = inspector.Where(x => x.Glaccount == 6441120 && x.Type == "Full Time");

                return inspectorTemp.Concat(inspectorFulltime).ToList();
            }

            return new List<FinanceLaborHoursView>();

        }

        public ProductionLaborHoursDto GetLaborHours(List<FinanceLaborHoursView> laborHrs, string dept = "")
        {
            dept = dept.Trim().ToLower();

            //transform data
            var data = TransformLaborHoursData(laborHrs, dept);
            var qualityInspector = TransformLaborHoursData(laborHrs, "inspector");
            var pso = TransformLaborHoursData(laborHrs, "pso");

            decimal? regular_q = 0, overtime_q = 0, doubleTime_q = 0, orientation_q = 0,
                regular_pso = 0, overtime_pso = 0, doubleTime_pso = 0, orientation_pso = 0;

            if (dept == "machine line" || dept == "assembly")
            {
                var qualityInspectorTargetRate = dept == "machine line" ? .34m : .66m;
                regular_q = qualityInspector.Sum(x => x.Regular) * qualityInspectorTargetRate;
                overtime_q = qualityInspector.Sum(x => x.Overtime) * qualityInspectorTargetRate;
                doubleTime_q = qualityInspector.Sum(x => x.DoubleTime) * qualityInspectorTargetRate;
                orientation_q = qualityInspector.Sum(x => x.Orientation) * qualityInspectorTargetRate;

                var psoTargetRate = dept == "machine line" ? .38m : .62m;
                regular_pso = pso.Sum(x => x.Regular) * psoTargetRate;
                overtime_pso = pso.Sum(x => x.Overtime) * psoTargetRate;
                doubleTime_pso = pso.Sum(x => x.DoubleTime) * psoTargetRate;
                orientation_pso = pso.Sum(x => x.Orientation) * psoTargetRate;
            }

            var regular = data.Sum(x => x.Regular);
            var overtime = data.Sum(x => x.Overtime);
            var doubleTime = data.Sum(x => x.DoubleTime);
            var orientation = data.Sum(x => x.Orientation);

            var regularTotal = regular + regular_q + regular_pso;
            var overtimeTotal = overtime + overtime_q + overtime_pso;
            var doubletimeTotal = doubleTime + doubleTime_q + doubleTime_pso;
            var orientationTotal = orientation + orientation_q + orientation_pso;

            var total = regularTotal + overtimeTotal + doubletimeTotal + orientationTotal;

            var details = new List<LaborHoursDetailsByType>
            {

                //regular
                new LaborHoursDetailsByType
                {
                    Type = "Regular",
                    Role = "Inspector",
                    Hours = regular_q
                },

                new LaborHoursDetailsByType
                {
                    Type = "Regular",
                    Role = "PSO",
                    Hours = regular_pso
                },

                new LaborHoursDetailsByType
                {
                    Type = "Regular",
                    Role = "Other",
                    Hours = regular
                },

                //overtime
                new LaborHoursDetailsByType
                {
                    Type = "Overtime",
                    Role = "Inspector",
                    Hours = overtime_q
                },

                new LaborHoursDetailsByType
                {
                    Type = "Overtime",
                    Role = "PSO",
                    Hours = overtime_pso
                },

                new LaborHoursDetailsByType
                {
                    Type = "Overtime",
                    Role = "Other",
                    Hours = overtime
                },

                //doubletime
                new LaborHoursDetailsByType
                {
                    Type = "Double Time",
                    Role = "Inspector",
                    Hours = doubleTime_q
                },

                new LaborHoursDetailsByType
                {
                    Type = "Double Time",
                    Role = "PSO",
                    Hours = doubleTime_pso
                },

                new LaborHoursDetailsByType
                {
                    Type = "Double Time",
                    Role = "Other",
                    Hours = doubleTime
                },

                //orientation
                new LaborHoursDetailsByType
                {
                    Type = "Orientation",
                    Role = "Inspector",
                    Hours = orientation_q
                },

                new LaborHoursDetailsByType
                {
                    Type = "Orientation",
                    Role = "PSO",
                    Hours = orientation_pso
                },

                new LaborHoursDetailsByType
                {
                    Type = "Orientation",
                    Role = "Other",
                    Hours = orientation
                },

                //overall
                new LaborHoursDetailsByType
                {
                    Type = "Overall",
                    Role = "Inspector",
                    Hours = regular_q + overtime_q + doubleTime_q + orientation_q
                },

                new LaborHoursDetailsByType
                {
                    Type = "Overall",
                    Role = "PSO",
                    Hours = regular_pso + overtime_pso + doubleTime_pso + orientation_pso
                },

                new LaborHoursDetailsByType
                {
                    Type = "Overall",
                    Role = "Other",
                    Hours = regular + overtime + doubleTime + orientation
                }
            };

            return new ProductionLaborHoursDto
            {
                Regular = regularTotal,
                Overtime = overtimeTotal,
                DoubleTime = doubletimeTotal,
                Orientation = orientationTotal,
                OverAll = total,

                Details = details,

                InspectorDetails = new LabourHoursDetails
                {
                    Regular = regular_q,
                    Overtime = overtime_q,
                    DoubleTime = doubleTime_q,
                    Orientation = orientation_q,
                    OverAll = regular_q + overtime_q + doubleTime_q + orientation_q
                },

                PSODetails = new LabourHoursDetails
                {
                    Regular = regular_pso,
                    Overtime = overtime_pso,
                    DoubleTime = doubleTime_pso,
                    Orientation = orientation_pso,
                    OverAll = regular_pso + overtime_pso + doubleTime_pso + orientation_pso
                },

                OtherDetails = new LabourHoursDetails
                {
                    Regular = regular,
                    Overtime = overtime,
                    DoubleTime = doubleTime,
                    Orientation = orientation,
                    OverAll = regular + overtime + doubleTime + orientation
                },


            };
        }

        public async Task<ProdScrapForLaborHours> GetProdScrapForLaborHrs(DateTime start, DateTime end, string area)
        {
            var prod = await _sapContext.Production2Summary
                                .Where(x => x.ShiftDate >= start && x.ShiftDate <= end)
                                .Where(x => x.Area == area)
                                .GroupBy(x => new { x.Area })
                                .Select(x => new SapProdDto
                                {
                                    Area = x.Key.Area,
                                    Qty = (int)x.Sum(s => s.Qty)
                                })
                                .ToListAsync();

            var scrap = await _sapContext.Scrap2
                                .Where(x => x.ShiftDate >= start && x.ShiftDate <= end)
                                .Where(x => x.ScrapCode != "8888")
                                .Where(x => x.Area == area)
                                .GroupBy(x => new { x.Area })
                                .Select(x => new Scrap
                                {
                                    Area = x.Key.Area,
                                    Qty = (int)x.Sum(s => s.Qty)
                                })
                                .ToListAsync();

            return new ProdScrapForLaborHours
            {
                Prod = prod,
                Scrap = scrap
            };
        }

        public ProductionLaborHoursDto GetRollingDaysPPMH(
            IEnumerable<SapProdDto> prodData,
            IEnumerable<Scrap> scrapData,
            List<FinanceLaborHoursView> laborHrs,
            DateTime start,
            DateTime end,
            string area)
        {

            if (area == "Skirt Coat")
            {
                return new ProductionLaborHoursDto
                {
                    Regular = null,
                    Overtime = null,
                    DoubleTime = null,
                    Orientation = null,
                    OverAll = null,
                    PPMH = null,
                    SAPGross = null,
                    StartDate = start.ToShortDateString(),
                    EndDate = end.ToShortDateString(),
                    LaborTitle = "",

                    InspectorDetails = null,
                    OtherDetails = null,
                    PSODetails = null
                };
            }

            var yesterday = DateTime.Today.AddDays(-1);
            var title = $"Kronos Hours <b>({start.ToString("M/d/yy")} - {end.ToString("M/d/yy")})</b>";
            if (start == yesterday)
            {
                start = end.AddDays(-6);
                title = $"Last 7 days Kronos Hours <b>({start.ToString("M/d/yy")} - {end.ToString("M/d/yy")})</b>";
            }

            var prod = prodData.Where(x => x.Area.ToLower().Trim() == area.ToLower().Trim()).Sum(x => x.Qty);
            var scrap = scrapData.Where(x => x.Area.ToLower().Trim() == area.ToLower().Trim()).Sum(x => x.Qty);
            var sapGross = prod + scrap;

            var hours = GetLaborHours(laborHrs, area);
            var ppmh = hours.OverAll == 0 ? 0 : sapGross / hours.OverAll;

            return new ProductionLaborHoursDto
            {
                Regular = hours.Regular,
                Overtime = hours.Overtime,
                DoubleTime = hours.DoubleTime,
                Orientation = hours.Orientation,
                OverAll = hours.OverAll,
                PPMH = ppmh,
                SAPGross = sapGross,
                StartDate = start.ToShortDateString(),
                EndDate = end.ToShortDateString(),
                LaborTitle = title,

                Details = hours.Details,

                InspectorDetails = hours.InspectorDetails,
                OtherDetails = hours.OtherDetails,
                PSODetails = hours.PSODetails,
            };

        }

        public async Task<IEnumerable<WeeklyProductionLaborHoursDto>> GetWeeklyProdScrapForLaborHrs(DateTime start, DateTime end, string area)
        {
            var prods = await _sapContext.Production2Summary
                                .Where(x => x.ShiftDate >= start && x.ShiftDate <= end)
                                .Where(x => x.Area == area)
                                .GroupBy(x => new { x.WeeekNumber, x.Area })
                                .Select(x => new SapProdDto
                                {
                                    WeekNumber = (int)x.Key.WeeekNumber,
                                    Area = x.Key.Area,
                                    Qty = (int)x.Sum(s => s.Qty)
                                })
                                .ToListAsync();

            var scraps = await _sapContext.Scrap2
                            .Where(x => x.ShiftDate >= start && x.ShiftDate <= end)
                            .Where(x => x.Area == area)
                            .Where(x => x.ScrapCode != "8888")
                            .GroupBy(x => new { x.WeekNumber, x.Area })
                            .Select(x => new WeeklyScrap
                            {
                                WeekNumber = (int)x.Key.WeekNumber,
                                Area = x.Key.Area,
                                Qty = (int)x.Sum(s => s.Qty)
                            })
                            .ToListAsync();

            var labors = await _context.FinanceLaborHoursView
                            .Where(x => x.DateIn >= start && x.DateIn <= end)
                            .ToListAsync();


            var prodWeeks = prods.Select(x => x.WeekNumber).Distinct();
            var scrapWeeks = scraps.Select(x => x.WeekNumber).Distinct();
            var weeks = prodWeeks.Concat(scrapWeeks).Distinct().OrderBy(x => x);

            var list = new List<WeeklyProductionLaborHoursDto>();
            foreach (var week in weeks)
            {
                var prod = prods.Where(x => x.WeekNumber == week);
                var scrap = scraps.Where(x => x.WeekNumber == week);
                var labor = labors.Where(x => x.WeekNumber == week).ToList();

                var details = GetRollingDaysPPMH(prod, scrap, labor, start, end, area);

                list.Add(new WeeklyProductionLaborHoursDto
                {
                    WeekNumber = week,
                    Details = details
                });

            }

            return list.OrderBy(x => x.WeekNumber).ToList();


        }

        public async Task<IEnumerable<FinanceDailyKpi>> GetFinanceDailyKpi(DateTime date)
        {
            return await _context.FinanceDailyKpi.Where(x => x.Date == date).ToListAsync();
        }

        public async Task<IEnumerable<FinanceDeptFcst>> GetFinanceDeptForecast(int year, int month)
        {
            return await _context.FinanceDeptFcst.Where(x => x.Year == year && x.MonthNum == month).ToListAsync();
        }

        public async Task<IEnumerable<FinanceFlashProjections>> GetFinanceFlashProjections(int year, int month)
        {
            return await _context.FinanceFlashProjections.Where(x => x.Year == year && x.MonthNum == month).ToListAsync();
        }

        public async Task<FinaceKpiDto> GetFinanceKpi(DateTime date)
        {
            return new FinaceKpiDto
            {
                DailyKpi = await GetFinanceDailyKpi(date),
                MonthlyForecast = await GetFinanceDeptForecast(date.Year, date.Month),
                MonthlyFlashProjections = await GetFinanceFlashProjections(date.Year, date.Month)
            };
        }

        public async Task<KpiTarget> GetTargets(string dept, DateTime endDate)
        {
            return await _context.KpiTarget
                            .Where(x => x.Department.ToLower() == dept.ToLower() 
                                    && x.MonthNumber == endDate.Month
                                    && x.Year == endDate.Year).FirstOrDefaultAsync();
        }

        public async Task<List<KpiTarget>> GetTargets(string area, int startYear, int endYear)
        {
            var dept = area;
            switch (area.ToLower())
            {
                case "foundry cell":
                    dept = "Foundry";
                    break;
                case "machine line":
                    dept = "Machining";
                    break;
            }
            return await _context.KpiTarget
                            .Where(x => x.Department.ToLower() == dept.ToLower())
                            .Where(x => x.Year >= startYear && x.Year <= endYear)
                            .ToListAsync();
        }
    }
}
