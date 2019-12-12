using FmsbwebCoreApi.ResourceParameters.SAP;
using FmsbwebCoreApi.Services.SAP;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FmsbwebCoreApi.Controllers.SAP
{
    [ApiController]
    [Route("api/sap/productiondata")]
    public class ProductionDataController : ControllerBase
    {
        private readonly ISapLibraryRepository _sapLibRepo;
        public ProductionDataController(
            ISapLibraryRepository sapLibRepo)
        {
            _sapLibRepo = sapLibRepo ??
                throw new ArgumentNullException(nameof(sapLibRepo));
        }

        [HttpGet(Name = "GetProductionData")]
        [HttpHead]
        public async Task<IActionResult> GetProductionData(
        [FromQuery] SapResouceParameter resourceParameter)
        {
            if (resourceParameter == null)
            {
                return BadRequest();
            }

            var prodData = await _sapLibRepo.GetProductionData(resourceParameter.Start, resourceParameter.End);

            return Ok(prodData);
        }
    }
}
