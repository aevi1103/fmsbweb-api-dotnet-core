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
    [Route("api/ppmh/shift")]
    public class PpmhPerShiftController : Controller
    {
        private readonly ISapLibraryService _sapLibRepo;
        public PpmhPerShiftController(
            ISapLibraryService sapLibRepo)
        {
            _sapLibRepo = sapLibRepo ??
                throw new ArgumentNullException(nameof(sapLibRepo));
        }

        [HttpGet(Name = "GetPpmhPerShift")]
        [HttpHead]
        public async Task<IActionResult> GetPpmhPerShift([FromQuery] SapResourceParameter @params)
        {
            try
            {
                var result = await _sapLibRepo.GetPpmhPerShiftVariance(@params).ConfigureAwait(false);
                return Ok(result);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

        }
    }
}