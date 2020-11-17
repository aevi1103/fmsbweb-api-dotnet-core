using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using FmsbwebCoreApi.Entity.Fmsb2;
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
        [Route("upload")]
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

        [Route("stat")]
        public async Task<ActionResult> GetLogisticsStatus(DateTime dateTime)
        {
            try
            {
                var data = await _logisticsService.GetLogisticsStatus(dateTime).ConfigureAwait(false);
                return Ok(data);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [Route("cost/types")]
        public async Task<ActionResult> GetLogisticsCostTypes()
        {
            try
            {
                var data = await _logisticsService
                    .GetCostTypes()
                    .ConfigureAwait(false);

                return Ok(data);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [Route("cost/targets")]
        public async Task<ActionResult> GetCostTargets()
        {
            try
            {
                var data = await _logisticsService
                    .GetCostTargets()
                    .ConfigureAwait(false);

                return Ok(data);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPost]
        [Route("cost/targets")]
        public async Task<ActionResult> PostTarget(LogisticsInventoryCostTarget data)
        {
            var result = await _logisticsService.AddOrUpdateCostTarget(data).ConfigureAwait(false);
            return Ok(result);
        }
    }
}
