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

            var shifts = distinctShift.Select(x => new
            {
                shift = x.Shift,
                shiftOrder = x.ShiftOrder,
                dailyScrap = result.Where(s => s.Shift == x.Shift)
            });

            var res = new
            {
                AllShifts = result,
                Shift = shifts
            };

            return Ok(res);
        }
    }
}
