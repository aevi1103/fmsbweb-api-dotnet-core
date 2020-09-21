using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FmsbwebCoreApi.ResourceParameters.SAP;
using FmsbwebCoreApi.Services.Interfaces;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace FmsbwebCoreApi.Controllers.SAP
{
    [ApiController]
    [EnableCors]
    [Route("api/sap/scrapvarianceperdept")]
    public class ScrapVariancePerDeptController : Controller
    {
        private readonly ISapLibraryService _sapLibRepo;
        public ScrapVariancePerDeptController(
            ISapLibraryService sapLibRepo)
        {
            _sapLibRepo = sapLibRepo ??
                throw new ArgumentNullException(nameof(sapLibRepo));
        }

        [HttpGet(Name = "GetScrapVariancePerDept")]
        [HttpHead]
        public async Task<IActionResult> GetScrapVariancePerDept([FromQuery] SapResourceParameter @params)
        {
            try
            {
                var result = await _sapLibRepo.GetScrapByDept(@params).ConfigureAwait(false);
                return Ok(result);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

        }
    }
}
