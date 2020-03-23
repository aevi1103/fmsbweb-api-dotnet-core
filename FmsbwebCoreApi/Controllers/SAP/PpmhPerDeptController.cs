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
    [Route("api/ppmh/ppmhperdept")]
    public class PpmhPerDeptController : ControllerBase
    {
        private readonly ISapLibraryRepository _sapLibRepo;
        public PpmhPerDeptController(
            ISapLibraryRepository sapLibRepo)
        {
            _sapLibRepo = sapLibRepo ??
                throw new ArgumentNullException(nameof(sapLibRepo));
        }

        [HttpGet(Name = "GetPpmhPerDept")]
        [HttpHead]
        public async Task<IActionResult> GetPpmhPerDept(DateTime start, DateTime end, string area)
        {
            try
            {
                var result = await _sapLibRepo.GetPpmhPerDeptPlantWideVariance(start, end, area);
                return Ok(result);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }

        }
    }
}
