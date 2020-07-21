using FmsbwebCoreApi.ResourceParameters.SAP;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FmsbwebCoreApi.Services.Interfaces;

namespace FmsbwebCoreApi.Controllers.SAP
{
    [ApiController]
    [EnableCors]
    [Route("api/sap/dailykpi")]
    public class DailyKpiController : ControllerBase
    {
        private readonly IKpiService _kpiService;

        public DailyKpiController(IKpiService kpiService)
        {
            _kpiService = kpiService ?? throw new ArgumentNullException(nameof(kpiService));
        }

        [HttpGet(Name = "GetDailyKpi")]
        [HttpHead]
        public async Task<IActionResult> GetDailyKpi([FromQuery] SapResouceParameter resourceParameter)
        {
            if (resourceParameter == null) return BadRequest();

            var prodData = await _kpiService.GetDailyKpiChart(
                    resourceParameter.Start,
                    resourceParameter.End,
                    resourceParameter.Area)
                .ConfigureAwait(false);

            if (prodData == null) throw new ArgumentNullException(nameof(prodData));

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
