using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FmsbwebCoreApi.ResourceParameters;
using FmsbwebCoreApi.Services;
using FmsbwebCoreApi.Services.Interfaces;

namespace FmsbwebCoreApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MaintenanceAlertController : Controller
    {
        private readonly IMaintenanceAlertService _service;

        public MaintenanceAlertController(IMaintenanceAlertService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> Get([FromQuery] MaintenanceAlertResourceParameter parameter)
        {
            try
            {
                var data = await _service.GetMeanTimeBeforeBreakDown(parameter).ConfigureAwait(false);
                return Ok(data);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
            
        }
    }
}
