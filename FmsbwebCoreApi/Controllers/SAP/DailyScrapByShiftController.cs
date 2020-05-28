using FmsbwebCoreApi.ResourceParameters.SAP;
using FmsbwebCoreApi.Services.SAP;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FmsbwebCoreApi.Controllers.SAP
{
    [ApiController]
    [EnableCors]
    [Route("api/sap/dailyscrapbyshift")]
    public class DailyScrapByShiftController : ControllerBase
    {
        private readonly ISapLibraryRepository _sapLibRepo;
        public DailyScrapByShiftController(
            ISapLibraryRepository sapLibRepo)
        {
            _sapLibRepo = sapLibRepo ??
                throw new ArgumentNullException(nameof(sapLibRepo));
        }

        [HttpGet(Name = "GetDailyScrapByShift")]
        [HttpHead]
        public async Task<IActionResult> GetDailyScrapByShift(
            [FromQuery] DailyScrapByShiftResourceParameter resourceParameter)
        {
            if (resourceParameter == null)
            {
                return BadRequest();
            }

            var result = await _sapLibRepo.GetDailyScrapByShift(resourceParameter).ConfigureAwait(false);
            var distinctShift = result.Select(x => new { x.Shift, x.ShiftOrder }).Distinct();

            var startDate = result.Min(x => x.ShiftDate);
            var endDate = result.Max(x => x.ShiftDate);


            var result2 = new List<dynamic>();
            var tempStart = resourceParameter.Start;
            while (tempStart <= resourceParameter.End)
            {
                foreach (var shift in distinctShift.OrderBy(x => x.ShiftOrder))
                {
                    var isExist = result.Any(x => x.ShiftDate == tempStart && x.Shift == shift.Shift);
                    if (isExist)
                    {
                        var data = result.First(x => x.ShiftDate == tempStart && x.Shift == shift.Shift);
                        result2.Add(new
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
                        result2.Add(new
                        {
                            ShiftDate = tempStart,
                            shift.Shift,
                            shift.ShiftOrder,
                            resourceParameter.ScrapCode,
                            ScrapDesc = "",
                            Qty = 0
                        });
                    }
                }
                tempStart = tempStart.AddDays(1);
            }


            var shifts = distinctShift.Select(x => new
            {
                shift = x.Shift,
                shiftOrder = x.ShiftOrder,
                dailyScrap = new { 
                    data = result2.Where(s => s.Shift == x.Shift),
                    trendline = Helpers.TrendLine.GetTrendLine(result2.Where(s => s.Shift == x.Shift), "Qty")
                }       
            });

            var res = new
            {
                AllShifts = new
                {
                    trendline = Helpers.TrendLine.GetTrendLine(result2, "Qty"),
                    data = result2
                },
                Shift = shifts
            };

            return Ok(res);
        }
    }
}
