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
    [Route("api/sap/scrapvarianceperprogram")]
    public class ScrapVariancePerProgramController : ControllerBase
    {
        private readonly ISapLibraryService _sapLibRepo;
        public ScrapVariancePerProgramController(
            ISapLibraryService sapLibRepo)
        {
            _sapLibRepo = sapLibRepo ??
                throw new ArgumentNullException(nameof(sapLibRepo));
        }

        [HttpGet(Name = "GetScrapVariancePerProgram")]
        [HttpHead]
        public async Task<IActionResult> GetScrapVariancePerProgram([FromQuery] SapResourceParameter @params)
        {
            try
            {
                var result = await _sapLibRepo.GetScrapVariancePerProgram(@params).ConfigureAwait(false);
                return Ok(result);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

        }
    }
}
