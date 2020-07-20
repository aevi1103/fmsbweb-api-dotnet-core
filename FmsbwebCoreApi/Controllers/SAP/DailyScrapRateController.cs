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
        private readonly ISapLibraryService _sapLibRepo;
        public DailyScrapRateController(
            ISapLibraryService sapLibRepo)
        {
            _sapLibRepo = sapLibRepo ??
                throw new ArgumentNullException(nameof(sapLibRepo));
        }

        [HttpGet(Name = "GetDailyScrapRate")]
        [HttpHead]
        public async Task<IActionResult> GetDailyScrapRate(
            [FromQuery] SapResouceParameter resourceParameter)
        {
            if (resourceParameter == null)
            {
                return BadRequest();
            }

            var prodData = await _sapLibRepo.GetDailyScrapRate(
                resourceParameter.Start,
                resourceParameter.End,
                resourceParameter.Area).ConfigureAwait(false);

            return Ok(prodData);
        }
    }
}
