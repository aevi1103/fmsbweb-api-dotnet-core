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
using FluentDateTime;
using DateShiftLib.Extensions;

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
                            .ToListAsync().ConfigureAwait(false);
        }

        public async Task<List<FinanceLaborHoursView>> GetLaborHoursData(DateTime start, DateTime end, string area)
        {
            var dept = area?.Trim().ToLower() switch
            {
                "foundry cell" => "FOUNDRY",
                "machine line" => "MACHINING",
                "skirt coat" => "FINISHING",
                "assembly" => "ASSEMBLY",
                _ => area
            };

            return await _context.FinanceLaborHoursView
                            .Where(x => x.DateIn >= start && x.DateIn <= end)
                            .Where(x => x.DeptName == dept)
                            .ToListAsync()
                            .ConfigureAwait(false);
        }

        public List<FinanceLaborHoursView> TransformLaborHoursData(IEnumerable<FinanceLaborHoursView> data, string dept = "")
        {
            if (dept == null) throw new ArgumentNullException(nameof(dept));

            dept = dept.Trim().ToLower();

            if (dept == "foundry cell") return data.Where(x => x.DeptName == "FOUNDRY" && x.IsPso == false).ToList();
            if (dept == "machine line") return data.Where(x => x.DeptName == "MACHINING" && x.IsPso == false).ToList();
            if (dept == "skirt coat") return data.Where(x => (x.DeptName == "FINISHING") && x.IsPso == false).ToList();
            if (dept == "assembly") return data.Where(x => (x.DeptName == "ASSEMBLY") && x.IsPso == false).ToList();

            if (dept == "pso") return data.Where(x => x.IsPso == true).ToList();

            if (dept == "inspector")
            {
                var inspector = data.Where(x => x.DeptName == "QUALITY INSPECTORS" && x.IsPso == false);

                var inspectorTemp = inspector.Where(x => x.Type == "Temp");
                var inspectorFulltime = inspector.Where(x => x.Glaccount == 6441120 && x.Type == "Full Time");

                return inspectorTemp.Concat(inspectorFulltime).ToList();
            }

            return new List<FinanceLaborHoursView>();

        }

        public ProductionLaborHoursDto GetLaborHours(List<FinanceLaborHoursView> laborHours)
        {
            var regular = laborHours.Sum(x => x.Regular);
            var overtime = laborHours.Sum(x => x.Overtime);
            var doubleTime = laborHours.Sum(x => x.DoubleTime);
            var orientation = laborHours.Sum(x => x.Orientation);

            return new ProductionLaborHoursDto
            {
                Regular = regular,
                Overtime = overtime,
                DoubleTime = doubleTime,
                Orientation = orientation,
                OverAll = regular + overtime + doubleTime + orientation,
            };
        }

        public async Task<List<SapProdDto>> GetProdForLaborHrs(DateTime start, DateTime end, string area)
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
                                .ToListAsync()
                                .ConfigureAwait(false);

            return prod;
        }

        public ProductionLaborHoursDto GetRollingDaysPPMH(
            IEnumerable<SapProdDto> prodData,
            List<FinanceLaborHoursView> laborHrs,
            DateTime start,
            DateTime end)
        {

            var yesterday = DateTime.Today.AddDays(-1);
            var title = $"Kronos Hours <b>({start.ToString("M/d/yy")} - {end.ToString("M/d/yy")})</b>";
            if (start == yesterday)
            {
                start = end.AddDays(-6);
                title = $"Last 7 days Kronos Hours <b>({start.ToString("M/d/yy")} - {end.ToString("M/d/yy")})</b>";
            }

            var sapNet = prodData.Sum(x => x.Qty);
            var hours = GetLaborHours(laborHrs);
            var ppmh = hours.OverAll == 0 ? 0 : sapNet / hours.OverAll;

            return new ProductionLaborHoursDto
            {
                Regular = hours.Regular,
                Overtime = hours.Overtime,
                DoubleTime = hours.DoubleTime,
                Orientation = hours.Orientation,
                OverAll = hours.OverAll,
                PPMH = ppmh,
                SAPGross = 0,
                SapNet = sapNet,
                StartDate = start.ToShortDateString(),
                EndDate = end.ToShortDateString(),
                LaborTitle = title,

                Details = hours.Details,

                InspectorDetails = hours.InspectorDetails,
                OtherDetails = hours.OtherDetails,
                PSODetails = hours.PSODetails,
            };

        }

        public ProductionLaborHoursDto GetPPMH(int sapNet, List<FinanceLaborHoursView> laborHrs)
        {
            var hours = GetLaborHours(laborHrs);
            var ppmh = hours.OverAll == 0 ? 0 : sapNet / hours.OverAll;

            return new ProductionLaborHoursDto
            {
                Regular = hours.Regular,
                Overtime = hours.Overtime,
                DoubleTime = hours.DoubleTime,
                Orientation = hours.Orientation,
                OverAll = hours.OverAll,

                PPMH = ppmh,
                SAPGross = 0,
                SapNet = sapNet,
                Details = hours.Details,

                InspectorDetails = hours.InspectorDetails,
                OtherDetails = hours.OtherDetails,
                PSODetails = hours.PSODetails,
            };

        }

        public async Task<IEnumerable<WeeklyProductionLaborHoursDto>> GetWeeklyProdScrapForLaborHrs(DateTime start, DateTime end, string area)
        {
            try
            {
                var prods = await _sapContext.Production2Summary
                    .Where(x => x.ShiftDate >= start && x.ShiftDate <= end)
                    .Where(x => x.Area == area)
                    .GroupBy(x => new { x.WeeekNumber, x.Area, x.Year })
                    .Select(x => new SapProdDto
                    {
                        WeekNumber = (int)x.Key.WeeekNumber,
                        Year = (int)x.Key.Year,
                        Area = x.Key.Area,
                        Qty = (int)x.Sum(s => s.Qty)
                    })
                    .ToListAsync().ConfigureAwait(false);

                var scraps = await _sapContext.Scrap2
                                .Where(x => x.ShiftDate >= start && x.ShiftDate <= end)
                                .Where(x => x.Area == area)
                                .Where(x => x.ScrapCode != "8888")
                                .GroupBy(x => new { x.WeekNumber, x.Area, x.Year })
                                .Select(x => new WeeklyScrap
                                {
                                    WeekNumber = (int)x.Key.WeekNumber,
                                    Year = (int)x.Key.Year,
                                    Area = x.Key.Area,
                                    Qty = (int)x.Sum(s => s.Qty)
                                })
                                .ToListAsync()
                                .ConfigureAwait(false);

                var labors = await GetLaborHoursData(start, end, area).ConfigureAwait(false);


                var prodWeeks = prods.Select(x => new { x.WeekNumber, x.Year }).Distinct();
                var scrapWeeks = scraps.Select(x => new { x.WeekNumber, x.Year }).Distinct();
                var weeks = prodWeeks.Concat(scrapWeeks).Distinct().OrderBy(x => x.Year).ThenBy(x => x.WeekNumber);

                var list = (from week in weeks

                let prod = prods.Where(x => x.WeekNumber == week.WeekNumber && x.Year == week.Year)
                let scrap = scraps.Where(x => x.WeekNumber == week.WeekNumber && x.Year == week.Year)
                let labor = labors.Where(x => x.WeekNumber == week.WeekNumber && x.Year == week.Year).ToList()
                let details = GetRollingDaysPPMH(prod, labor, start, end)
                let startOfWeek = Convert.ToDateTime(labor.Min(x => x.DateIn)).FirstDayOfWeek()
                let endOfWeek = Convert.ToDateTime(labor.Max(x => x.DateIn)).LastDayOfWeek()

                select new WeeklyProductionLaborHoursDto
                {
                    WeekStart = startOfWeek,
                    WeekEnd = endOfWeek,
                    WeekNumber = week.WeekNumber,
                    Year = week.Year,
                    Details = details
                }).ToList();

                return list.OrderBy(x => x.Year).ThenBy(x => x.WeekNumber).ToList();
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }

        public async Task<dynamic> GetOvertimePercentage(string dept, DateTime start, DateTime end)
        {
            var hoursData = await GetLaborHoursData(start, end, dept).ConfigureAwait(false);

            #region Overtime Percent Per Dept

            var listOfQuarter = new List<dynamic>();
            var startOfQuarter = start;

            while (startOfQuarter <= end)
            {
                var endOfQuarter = startOfQuarter.EndOfQuarter();

                var quarterHours = hoursData.Where(x => x.DateIn >= startOfQuarter && x.DateIn <= endOfQuarter).ToList();
                var quarterData = GetLaborHours(quarterHours);

                var listOfMonths = new List<dynamic>();
                var monthStart = startOfQuarter;
                while (monthStart <= endOfQuarter)
                {
                    var monthEnd = monthStart.EndOfMonth();

                    var monthHours = hoursData.Where(x => x.DateIn >= monthStart && x.DateIn <= monthEnd).ToList();
                    var monthData = GetLaborHours(monthHours);

                    var monthRecord = new
                    {
                        StartDate = monthStart,
                        EndDate = monthEnd,
                        MonthName = monthStart.ToMonthName(),
                        Year = startOfQuarter.Year,
                        OverallHours = monthData.OverAll,
                        OvertimeHours = monthData.Overtime,
                        OvertimePercentage = monthData.OverAll == 0 ? 0 : (decimal)monthData.Overtime / (decimal)monthData.OverAll,
                        //data = monthData
                    };

                    monthStart = monthEnd.AddDays(1);
                    listOfMonths.Add(monthRecord);
                }

                var rec = new
                {
                    Dept = dept,
                    StartDate = startOfQuarter,
                    EndDate = endOfQuarter,
                    Quarter = startOfQuarter.ToQuarter(),
                    Year = startOfQuarter.Year,
                    OverallHours = quarterData.OverAll,
                    OvertimeHours = quarterData.Overtime,
                    OvertimePercentage = quarterData.OverAll == 0 ? 0 : (decimal)quarterData.Overtime / (decimal)quarterData.OverAll,
                    //data = quarterData,
                    MonthDetails = listOfMonths
                };

                listOfQuarter.Add(rec);

                startOfQuarter = endOfQuarter.AddDays(1);
            }

            #endregion

            #region Overtime Percent Per Shift 

            var uniqueShifts = hoursData.Select(x => x.Shift2).Distinct();
            var shiftSummary = (from shift in uniqueShifts
                let shiftData = GetLaborHours(hoursData.Where(x => x.Shift2 == shift).ToList())
                select new
                {
                    Shift = shift,
                    OverallHours = shiftData.OverAll,
                    OvertimeHours = shiftData.Overtime,
                    OvertimePercentage = shiftData.OverAll == 0 
                                            ? 0 
                                            : (decimal) shiftData.Overtime / (decimal) shiftData.OverAll,
                }).Cast<dynamic>()
                .ToList();

            shiftSummary = shiftSummary.OrderByDescending(x => x.OvertimePercentage).ToList();

            #endregion

            return new
            {
                quarterSummary = listOfQuarter,
                shiftSummary
            };

        }

        public async Task<IEnumerable<FinanceDailyKpi>> GetFinanceDailyKpi(DateTime date)
        {
            return await _context.FinanceDailyKpi.Where(x => x.Date == date).ToListAsync().ConfigureAwait(false);
        }

        public async Task<IEnumerable<FinanceDeptFcst>> GetFinanceDeptForecast(int year, int month)
        {
            return await _context.FinanceDeptFcst.Where(x => x.Year == year && x.MonthNum == month).ToListAsync().ConfigureAwait(false);
        }

        public async Task<IEnumerable<FinanceFlashProjections>> GetFinanceFlashProjections(int year, int month)
        {
            return await _context.FinanceFlashProjections.Where(x => x.Year == year && x.MonthNum == month).ToListAsync().ConfigureAwait(false);
        }

        public async Task<FinaceKpiDto> GetFinanceKpi(DateTime date)
        {
            return new FinaceKpiDto
            {
                DailyKpi = await GetFinanceDailyKpi(date).ConfigureAwait(false),
                MonthlyForecast = await GetFinanceDeptForecast(date.Year, date.Month).ConfigureAwait(false),
                MonthlyFlashProjections = await GetFinanceFlashProjections(date.Year, date.Month).ConfigureAwait(false)
            };
        }

        public async Task<KpiTarget> GetTargets(string area, DateTime endDate)
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
                            .Where(x => x.Department.ToLower() == dept.ToLower()
                                    && x.MonthNumber == endDate.Month
                                    && x.Year == endDate.Year).FirstOrDefaultAsync().ConfigureAwait(false);
        }

        public async Task<List<KpiTarget>> GetTargets(string area, int startYear, int endYear)
        {
            if (area == null) throw new ArgumentNullException(nameof(area));
            area = area.ToLower();
            var dept = area switch
            {
                "foundry cell" => "Foundry",
                "machine line" => "Machining",
                _ => area
            };
            return await _context.KpiTarget
                            .Where(x => x.Department.ToLower() == dept.ToLower())
                            .Where(x => x.Year >= startYear && x.Year <= endYear)
                            .ToListAsync().ConfigureAwait(false);
        }

        public async Task<KpiTarget> GetTargets(string area, DateTime startDate, DateTime endDate)
        {
            if (area == null) throw new ArgumentNullException(nameof(area));
            area = area.ToLower();
            var dept = area switch
            {
                "foundry cell" => "Foundry",
                "machine line" => "Machining",
                _ => area
            };

            var data = await _context.KpiTarget
                            .Where(x => x.Department.ToLower() == dept.ToLower())
                            .Where(x => x.Year >= startDate.Year && x.Year == endDate.Year)
                            .ToListAsync()
                            .ConfigureAwait(false);

            data = data.Where(x => x.MonthNumber >= startDate.Month && x.MonthNumber <= endDate.Month).ToList();

            if (data.Count > 0)
            {
                return new KpiTarget
                {
                    Department = area,
                    OaeTarget = data.Average(x => x.OaeTarget),
                    ScrapRateTarget = data.Average(x => x.ScrapRateTarget),
                    PpmhTarget = data.Average(x => x.PpmhTarget),
                    DowntimeRateTarget = data.Average(x => x.DowntimeRateTarget),
                };
            }

            return new KpiTarget
            {
                Department = area,
                OaeTarget = 0,
                ScrapRateTarget = 0,
                PpmhTarget = 0,
                DowntimeRateTarget = 0,
            };

        }

        public async Task<List<FinanceLaborHoursView>> GetPlantLaborHours(DateTime startDate, DateTime endDate)
        {
            var data =  await GetLaborHoursData(startDate, endDate).ConfigureAwait(false);

            var foundry = data.Where(x => x.DeptName == "FOUNDRY" && x.IsPso == false).ToList();
            var mach = data.Where(x => x.DeptName == "MACHINING" && x.IsPso == false).ToList();
            var fin = data.Where(x => x.DeptName == "FINISHING" && x.IsPso == false).ToList();
            var assy = data.Where(x => x.DeptName == "ASSEMBLY" && x.IsPso == false).ToList();

            var hours = foundry
                        .Concat(mach)
                        .Concat(fin)
                        .Concat(assy)
                        .ToList();

            return hours;

        }
    }
}
