using FmsbwebCoreApi.ResourceParameters.Logistics;
using FmsbwebCoreApi.Services.Logistics;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;

namespace FmsbwebCoreApi.Controllers.Logistics
{
    [ApiController]
    [EnableCors]
    [Route("api/logistics/stockoverviewbysloc")]
    public class StockOverviewBySlocController : ControllerBase
    {
        private readonly ILogisticsLibraryRepository _logisticsLibRepo;
        public StockOverviewBySlocController(
            ILogisticsLibraryRepository logisticsLibRepo)
        {
            _logisticsLibRepo = logisticsLibRepo ??
                throw new ArgumentNullException(nameof(logisticsLibRepo));
        }

        [HttpGet(Name = "GetStockOverviewBySloc")]
        [HttpHead]
        public IActionResult GetStockOverviewBySloc(
    [FromQuery] StockOverviewResouceParameter resourceParameter)
        {
            if (resourceParameter == null)
            {
                return BadRequest();
            }

            var stockOverviewBySlocFromRepo = _logisticsLibRepo.GetStockOverviewBySloc(resourceParameter.Date).OrderBy(x => x.SlocOrder);

            var categories = stockOverviewBySlocFromRepo
                                .Select(x => new { x.SlocOrder, x.SlocName, x.Sloc, category = $"{x.SlocName} ({x.Sloc})" })
                                .OrderBy(x => x.SlocOrder)
                                .Distinct();
                                
            var series = stockOverviewBySlocFromRepo.Select(x => x.Program).Distinct();

            var resourceToReturn = new
            {
                resourceParameter.Date,
                categories,
                data = stockOverviewBySlocFromRepo
            };

            return Ok(resourceToReturn);
        }
    }
}
