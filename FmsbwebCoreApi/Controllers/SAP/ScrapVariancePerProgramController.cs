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
        public async Task<IActionResult> GetScrapVariancePerProgram(DateTime start, DateTime end, string area = "",
            bool isPurchasedScrap = false, bool isPlantTotal = false)
        {
            try
            {
                var result =
                    await _sapLibRepo.GetScrapVariancePerProgram(start, end, area, isPurchasedScrap, isPlantTotal)
                        .ConfigureAwait(false);

                return Ok(result);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

        }
    }
}
