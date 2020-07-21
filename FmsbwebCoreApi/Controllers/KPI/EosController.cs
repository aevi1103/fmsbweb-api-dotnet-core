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
    public class EosController : ControllerBase
    {
        private readonly IKpiService _kpiService;

        public EosController(IKpiService kpiService)
        {
            _kpiService = kpiService ?? throw new ArgumentNullException(nameof(kpiService));
        }

        [HttpGet(Name = "GetEosData")]
        [HttpHead]
        public async Task<IActionResult> GetEosData(string line, string area, DateTime shiftDate, string shift)
        {
            var result = await _kpiService.GetEndOfShiftDto(line, area, shiftDate, shift).ConfigureAwait(false);
            return Ok(result);
        }
    }
}
