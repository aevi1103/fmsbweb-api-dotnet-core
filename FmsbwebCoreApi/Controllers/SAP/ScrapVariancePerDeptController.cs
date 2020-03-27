using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FmsbwebCoreApi.Services.SAP;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace FmsbwebCoreApi.Controllers.SAP
{
    [ApiController]
    [EnableCors]
    [Route("api/sap/scrapvarianceperdept")]
    public class ScrapVariancePerDeptController : Controller
    {
        private readonly ISapLibraryRepository _sapLibRepo;
        public ScrapVariancePerDeptController(
            ISapLibraryRepository sapLibRepo)
        {
            _sapLibRepo = sapLibRepo ??
                throw new ArgumentNullException(nameof(sapLibRepo));
        }

        [HttpGet(Name = "GetScrapVariancePerDept")]
        [HttpHead]
        public async Task<IActionResult> GetScrapVariancePerDept(DateTime start, DateTime end, bool isPurchasedScrap = false)
        {
            try
            {
                var result = await _sapLibRepo.GetScrapByDept(start, end, isPurchasedScrap).ConfigureAwait(false);
                return Ok(result);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

        }
    }
}
