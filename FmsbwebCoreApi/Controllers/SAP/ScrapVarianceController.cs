using FmsbwebCoreApi.Services.FMSB2;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FmsbwebCoreApi.ResourceParameters.SAP;
using FmsbwebCoreApi.Services.Interfaces;

namespace FmsbwebCoreApi.Controllers.SAP
{
    [ApiController]
    [EnableCors]
    [Route("api/sap/scrapvariance")]
    public class ScrapVarianceController : ControllerBase
    {
        private readonly ISapLibraryService _sapLibService;
        public ScrapVarianceController(ISapLibraryService sapLibService)
        {
            _sapLibService = sapLibService ?? throw new ArgumentNullException(nameof(sapLibService));
        }

        [HttpGet(Name = "GetScrapVariance")]
        [HttpHead]
        public async Task<IActionResult> GetScrapVariance([FromQuery] SapResourceParameter @params)
        {

            return Ok(await _sapLibService.GetScrapVariance(@params));

        }
    }
}
