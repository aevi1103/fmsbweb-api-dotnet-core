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
    [Route("api/sap/scrapvariancepershift")]
    public class ScrapVariancePerShiftController : Controller
    {
        private readonly ISapLibraryRepository _sapLibRepo;
        public ScrapVariancePerShiftController(
            ISapLibraryRepository sapLibRepo)
        {
            _sapLibRepo = sapLibRepo ??
                throw new ArgumentNullException(nameof(sapLibRepo));
        }

        [HttpGet(Name = "GetScrapVariancePerShift")]
        [HttpHead]
        public async Task<IActionResult> GetScrapVariancePerShift(DateTime start, DateTime end, string area = "", bool isPurchasedScrap = false)
        {
            try
            {
                var data = await _sapLibRepo.GetScrapByShift(start, end, area, isPurchasedScrap).ConfigureAwait(false);
                return Ok(data);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

        }
    }
}