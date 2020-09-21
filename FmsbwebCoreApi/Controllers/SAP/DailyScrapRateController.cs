using FmsbwebCoreApi.ResourceParameters.SAP;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using FmsbwebCoreApi.Services.Interfaces;

namespace FmsbwebCoreApi.Controllers.SAP
{
    [ApiController]
    [EnableCors]
    [Route("api/sap/dailyscraprate")]
    public class DailyScrapRateController : ControllerBase
    {
        private readonly IScrapService _scrapService;
        private readonly IProductionService _productionService;

        public DailyScrapRateController(IScrapService scrapService, IProductionService productionService)
        {
            _scrapService = scrapService ?? throw new ArgumentNullException(nameof(scrapService));
            _productionService = productionService ?? throw new ArgumentNullException(nameof(productionService));
        }

        [HttpGet(Name = "GetDailyScrapRate")]
        [HttpHead]
        public async Task<IActionResult> GetDailyScrapRate([FromQuery] SapResourceParameter resourceParameter)
        {
            if (resourceParameter == null)
                return BadRequest();

            var prodData = await _scrapService.GetDailyScrapRate(
                resourceParameter.Start,
                resourceParameter.End,
                resourceParameter.Area,
                _productionService)
                .ConfigureAwait(false);

            return Ok(prodData);
        }
    }
}
