using FmsbwebCoreApi.ResourceParameters.SAP;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FmsbwebCoreApi.Services.Interfaces;

namespace FmsbwebCoreApi.Controllers.SAP
{
    [ApiController]
    [EnableCors]
    [Route("api/sap/dailyscrapbyshift")]
    public class DailyScrapByShiftController : ControllerBase
    {
        private readonly IScrapService _scrapService;

        public DailyScrapByShiftController(IScrapService scrapService)
        {
            _scrapService = scrapService ?? throw new ArgumentNullException(nameof(scrapService));
        }

        [HttpGet(Name = "GetDailyScrapByShift")]
        [HttpHead]
        public async Task<IActionResult> GetDailyScrapByShift([FromQuery] DailyScrapByShiftResourceParameter resourceParameter)
        {
            return resourceParameter == null 
                ? BadRequest() 
                : (IActionResult) Ok(await _scrapService.GetDailyScrapByShift(resourceParameter).ConfigureAwait(false));
        }
    }
}
