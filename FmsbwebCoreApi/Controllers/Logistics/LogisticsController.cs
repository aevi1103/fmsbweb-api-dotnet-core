using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using FmsbwebCoreApi.Models;
using FmsbwebCoreApi.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FmsbwebCoreApi.Controllers.Logistics
{
    [Route("api/[controller]")]
    [ApiController]
    public class LogisticsController : ControllerBase
    {
        private readonly ILogisticsService _logisticsService;

        public LogisticsController(ILogisticsService logisticsService)
        {
            _logisticsService = logisticsService ?? throw new ArgumentNullException(nameof(logisticsService));
        }

        [HttpPost]
        public async Task<ActionResult> UploadTask(
            [FromForm] IFormFile file,
            [FromForm] DateTime date)
        {
            if (file == null) throw new ArgumentNullException(nameof(file));

            try
            {
                await _logisticsService.Save(file, date).ConfigureAwait(false);
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}
