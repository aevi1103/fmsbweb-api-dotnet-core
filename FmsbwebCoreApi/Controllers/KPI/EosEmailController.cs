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
    public class EosEmailController : ControllerBase
    {
        private readonly IKpiService _kpiService;


        public EosEmailController(IKpiService kpiService)
        {
            _kpiService = kpiService ?? throw new ArgumentNullException(nameof(kpiService));
        }

        [HttpGet(Name = "SendEosReport")]
        public async Task<IActionResult> SendEosReport(string dept, DateTime shiftDate, string shift)
        {
            try
            {
                var result = await _kpiService.SendEosReport(dept, shiftDate, shift).ConfigureAwait(false);
                return Ok(result);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}
