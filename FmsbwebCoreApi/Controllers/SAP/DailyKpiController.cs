using FmsbwebCoreApi.ResourceParameters.SAP;
using FmsbwebCoreApi.Services.SAP;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FmsbwebCoreApi.Controllers.SAP
{
    [ApiController]
    [Route("api/sap/dailykpi")]
    public class DailyKpiController : ControllerBase
    {
        private readonly ISapLibraryRepository _sapLibRepo;
        public DailyKpiController(
            ISapLibraryRepository sapLibRepo)
        {
            _sapLibRepo = sapLibRepo ??
                throw new ArgumentNullException(nameof(sapLibRepo));
        }

        [HttpGet(Name = "GetDailyKpi")]
        [HttpHead]
        public async Task<IActionResult> GetDailyKpi(
            [FromQuery] SapResouceParameter resourceParameter)
        {
            if (resourceParameter == null)
            {
                return BadRequest();
            }

            var prodData = await _sapLibRepo.GetDailyKpiChart(
                                    resourceParameter.Start,
                                    resourceParameter.End,
                                    resourceParameter.Area);


            var category = prodData.Select(x => x.ShiftDate.ToShortDateString()).Distinct();
            var series = new List<string> { "OAE %", "Downtime %", "Scrap % by Dept" };

            var result = new
            {
                categories = category,
                series,
                data = prodData
            };

            return Ok(result);
        }
    }
}
