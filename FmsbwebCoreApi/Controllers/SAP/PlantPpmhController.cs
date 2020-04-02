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
    [Route("api/ppmh/plant")]
    public class PlantPpmhController : Controller
    {
        private readonly ISapLibraryRepository _sapLibRepo;
        public PlantPpmhController(
            ISapLibraryRepository sapLibRepo)
        {
            _sapLibRepo = sapLibRepo ??
                throw new ArgumentNullException(nameof(sapLibRepo));
        }

        [HttpGet(Name = "GetPlantPpmh")]
        [HttpHead]
        public async Task<IActionResult> GetPlantPpmh(DateTime start, DateTime end)
        {
            try
            {
                var result = await _sapLibRepo.GetPlantWidePpmh(start, end).ConfigureAwait(false);
                return Ok(result);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

        }
    }
}