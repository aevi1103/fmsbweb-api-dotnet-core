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
    [Route("api/sap/scrapvarianceperprogram")]
    public class ScrapVariancePerProgramController : ControllerBase
    {
        private readonly ISapLibraryRepository _sapLibRepo;
        public ScrapVariancePerProgramController(
            ISapLibraryRepository sapLibRepo)
        {
            _sapLibRepo = sapLibRepo ??
                throw new ArgumentNullException(nameof(sapLibRepo));
        }

        [HttpGet(Name = "GetScrapVariancePerProgram")]
        [HttpHead]
        public async Task<IActionResult> GetScrapVariancePerProgram(DateTime start, DateTime end, string area = "", bool isPurchasedScrap = false)
        {
            try
            {
                var result = await _sapLibRepo.GetScrapByProgram(start, end, area, isPurchasedScrap);
                return Ok(result);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
            
        }
    }
}
