using FmsbwebCoreApi.ResourceParameters.Logistics;
using FmsbwebCoreApi.Services.Logistics;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FmsbwebCoreApi.Controllers.Logistics
{
    [ApiController]
    [EnableCors]
    [Route("api/logistics/stockoverview")]
    public class StockOverviewController : ControllerBase
    {
        private readonly ILogisticsLibraryRepository _logisticsLibRepo;
        public StockOverviewController(
            ILogisticsLibraryRepository logisticsLibRepo)
        {
            _logisticsLibRepo = logisticsLibRepo ??
                throw new ArgumentNullException(nameof(logisticsLibRepo));
        }

        [HttpGet(Name = "GetStockOverview")]
        [HttpHead]
        public IActionResult GetStockOverview(
            [FromQuery] StockOverviewResouceParameter resourceParameter)
        {
            if (resourceParameter == null)
            {
                return BadRequest();
            }

            var stockOverviewFromRepo = _logisticsLibRepo.GetStockOverview(resourceParameter.Date);
            var targets = _logisticsLibRepo.GetProgramTargets();

            var result = new
            {
                targets,
                data = stockOverviewFromRepo
            };

            return Ok(result);
        }
    }
}
