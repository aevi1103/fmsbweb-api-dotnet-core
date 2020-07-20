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
        private readonly ISapLibraryService _sapLibRepo;
        public DailyScrapByShiftController(
            ISapLibraryService sapLibRepo)
        {
            _sapLibRepo = sapLibRepo ??
                throw new ArgumentNullException(nameof(sapLibRepo));
        }

        [HttpGet(Name = "GetDailyScrapByShift")]
        [HttpHead]
        public async Task<IActionResult> GetDailyScrapByShift(
            [FromQuery] DailyScrapByShiftResourceParameter resourceParameter)
        {
            if (resourceParameter == null) return BadRequest();

            try
            {
                return Ok(await _sapLibRepo.GetDailyScrapByShift(resourceParameter).ConfigureAwait(false));
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }

        }
    }
}
