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
    [Route("api/ppmh/shift")]
    public class PpmhPerShiftController : Controller
    {
        private readonly ISapLibraryRepository _sapLibRepo;
        public PpmhPerShiftController(
            ISapLibraryRepository sapLibRepo)
        {
            _sapLibRepo = sapLibRepo ??
                throw new ArgumentNullException(nameof(sapLibRepo));
        }

        [HttpGet(Name = "GetPpmhPerShift")]
        [HttpHead]
        public async Task<IActionResult> GetPpmhPerShift(DateTime start, DateTime end, string area)
        {
            try
            {
                var result = await _sapLibRepo.GetPpmhPerShiftVariance(start, end, area).ConfigureAwait(false);
                return Ok(result);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

        }
    }
}