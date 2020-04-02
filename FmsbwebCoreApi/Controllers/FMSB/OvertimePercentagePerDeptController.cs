using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FmsbwebCoreApi.Helpers;
using FmsbwebCoreApi.Services.FMSB2;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using FluentDateTime;

namespace FmsbwebCoreApi.Controllers.FMSB
{
    [ApiController]
    [EnableCors]
    [Route("api/fmsb/overtimeperdept")]
    public class OvertimePercentagePerDeptController : Controller
    {
        private readonly IFmsb2LibraryRepository _fmsbLibRepo;
        public OvertimePercentagePerDeptController(
            IFmsb2LibraryRepository fmsbLibRepo)
        {
            _fmsbLibRepo = fmsbLibRepo ??
                throw new ArgumentNullException(nameof(fmsbLibRepo));
        }


        [HttpGet(Name = "GetOvertimePercentPerDept")]
        [HttpHead]
        public async Task<IActionResult> GetOvertimePercentPerDept(string dept, DateTime start, DateTime end)
        {
            try
            {
                var hoursData = await _fmsbLibRepo.GetLaborHoursData(start, end, dept).ConfigureAwait(false);

                #region Overtime Percent Per Dept

                var listOfQuarter = new List<dynamic>();
                var startOfQuarter = start;

                while (startOfQuarter <= end)
                {
                    var endOfQuarter = startOfQuarter.EndOfQuarter();

                    var quarterHours = hoursData.Where(x => x.DateIn >= startOfQuarter && x.DateIn <= endOfQuarter).ToList();
                    var quarterData = _fmsbLibRepo.GetLaborHours(quarterHours);

                    var listOfMonths = new List<dynamic>();
                    var monthStart = startOfQuarter;
                    while (monthStart <= endOfQuarter)
                    {
                        var monthEnd = monthStart.EndOfMonth();

                        var monthHours = hoursData.Where(x => x.DateIn >= monthStart && x.DateIn <= monthEnd).ToList();
                        var monthData = _fmsbLibRepo.GetLaborHours(monthHours);

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
                var shiftSummary = new List<dynamic>();
                foreach (var shift in uniqueShifts)
                {
                    var shiftData = _fmsbLibRepo.GetLaborHours(hoursData.Where(x => x.Shift2 == shift).ToList());
                    var rec = new
                    {
                        Shift = shift,
                        OverallHours = shiftData.OverAll,
                        OvertimeHours = shiftData.Overtime,
                        OvertimePercentage = shiftData.OverAll == 0 ? 0 : (decimal)shiftData.Overtime / (decimal)shiftData.OverAll,
                    };
                    shiftSummary.Add(rec);
                };


                shiftSummary = shiftSummary.OrderByDescending(x => x.OvertimePercentage).ToList();

                #endregion

                var res = new
                {
                    quarterSummary = listOfQuarter,
                    shiftSummary
                };

                return Ok(res);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

        }
    }
}