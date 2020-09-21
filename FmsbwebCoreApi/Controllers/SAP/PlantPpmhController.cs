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
    [Route("api/ppmh/plant")]
    public class PlantPpmhController : Controller
    {
        private readonly ISapLibraryService _sapLibRepo;
        public PlantPpmhController(
            ISapLibraryService sapLibRepo)
        {
            _sapLibRepo = sapLibRepo ??
                throw new ArgumentNullException(nameof(sapLibRepo));
        }

        [HttpGet(Name = "GetPlantPpmh")]
        [HttpHead]
        public async Task<IActionResult> GetPlantPpmh([FromQuery] SapResourceParameter @params)
        {
            try
            {
                var result = await _sapLibRepo.GetPlantWidePpmh(@params).ConfigureAwait(false);
                return Ok(result);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

        }
    }
}