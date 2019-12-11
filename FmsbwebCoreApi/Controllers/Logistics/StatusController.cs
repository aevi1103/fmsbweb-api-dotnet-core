using FmsbwebCoreApi.ResourceParameters.Logistics;
using FmsbwebCoreApi.Services.Logistics;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FmsbwebCoreApi.Controllers.Logistics
{
    [ApiController]
    [Route("api/logistics/status")]
    public class StatusController : ControllerBase
    {
        private readonly ILogisticsLibraryRepository _logisticsLibRepo;
        public StatusController(
            ILogisticsLibraryRepository logisticsLibRepo)
        {
            _logisticsLibRepo = logisticsLibRepo ??
                throw new ArgumentNullException(nameof(logisticsLibRepo));
        }

        [HttpGet(Name = "GetStatus")]
        [HttpHead]
        public IActionResult GetStatus(
                [FromQuery] StockOverviewResouceParameter resourceParameter)
        {
            if (resourceParameter == null)
            {
                return BadRequest();
            }

            var inventoryStatus = _logisticsLibRepo
                                    .GetStockStatus(resourceParameter.Start.AddDays(1), resourceParameter.End.AddDays(1));

            return Ok(inventoryStatus);
        }
    }
}
