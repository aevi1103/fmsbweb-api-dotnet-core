using System;
using System.Threading.Tasks;
using FmsbwebCoreApi.ResourceParameters.SAP;
using FmsbwebCoreApi.Services.Interfaces;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace FmsbwebCoreApi.Controllers.SAP
{
    [ApiController]
    [EnableCors]
    [Route("api/sap/scrapvariancepershift")]
    public class ScrapVariancePerShiftController : Controller
    {
        private readonly ISapLibraryService _sapLibRepo;
        public ScrapVariancePerShiftController(
            ISapLibraryService sapLibRepo)
        {
            _sapLibRepo = sapLibRepo ??
                throw new ArgumentNullException(nameof(sapLibRepo));
        }

        [HttpGet(Name = "GetScrapVariancePerShift")]
        [HttpHead]
        public async Task<IActionResult> GetScrapVariancePerShift([FromQuery] SapResourceParameter @params)
        {
            try
            {
                var data = await _sapLibRepo.GetScrapByShift(@params).ConfigureAwait(false);

                return Ok(data);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

        }
    }
}