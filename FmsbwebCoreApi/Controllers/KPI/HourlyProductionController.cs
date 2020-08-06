using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FmsbwebCoreApi.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FmsbwebCoreApi.Controllers.KPI
{
    [Route("api/kpi/[controller]")]
    [ApiController]
    public class HourlyProductionController : ControllerBase
    {
        private readonly IKpiService _kpiService;

        public HourlyProductionController(IKpiService kpiService)
        {
            _kpiService = kpiService ?? throw new ArgumentNullException(nameof(kpiService));
        }

        [HttpGet("{dept}", Name = "GetHourlyProd")]
        public async Task<IActionResult> GetHourlyProd(string dept, DateTime shiftDate, string shift)
        {
            try
            {
                var result = await _kpiService.GetHourlyProduction(dept, shiftDate, shift).ConfigureAwait(false);
                return Ok(result);
            }
            catch (OperationCanceledException e)
            {
                return BadRequest(e.Message);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}
