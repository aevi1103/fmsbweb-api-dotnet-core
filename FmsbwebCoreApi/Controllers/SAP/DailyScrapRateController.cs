using FmsbwebCoreApi.ResourceParameters.SAP;
using FmsbwebCoreApi.Services.SAP;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FmsbwebCoreApi.Controllers.SAP
{
    [ApiController]
    [EnableCors]
    [Route("api/sap/dailyscraprate")]
    public class DailyScrapRateController : ControllerBase
    {
        private readonly ISapLibraryRepository _sapLibRepo;
        public DailyScrapRateController(
            ISapLibraryRepository sapLibRepo)
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

            var prodData = await _sapLibRepo.GetDailyScrapRateByCode(
                resourceParameter.Start,
                resourceParameter.End,
                resourceParameter.Area);

            return Ok(prodData);
        }
    }
}
