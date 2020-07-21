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

        public DailyScrapRateController(IScrapService scrapService)
        {
            _scrapService = scrapService ?? throw new ArgumentNullException(nameof(scrapService));
        }

        [HttpGet(Name = "GetDailyScrapRate")]
        [HttpHead]
        public async Task<IActionResult> GetDailyScrapRate(
            [FromQuery] SapResouceParameter resourceParameter)
        {
            if (resourceParameter == null)
                return BadRequest();

            var prodData = await _scrapService.GetDailyScrapRate(
                resourceParameter.Start,
                resourceParameter.End,
                resourceParameter.Area).ConfigureAwait(false);

            return Ok(prodData);
        }
    }
}
