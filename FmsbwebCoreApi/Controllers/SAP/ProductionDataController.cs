using FmsbwebCoreApi.ResourceParameters.SAP;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using FmsbwebCoreApi.Services.Interfaces;

namespace FmsbwebCoreApi.Controllers.SAP
{
    [ApiController]
    [EnableCors]
    [Route("api/sap/productiondata")]
    public class ProductionDataController : ControllerBase
    {
        private readonly ISapLibraryService _sapLibService;
        public ProductionDataController(ISapLibraryService sapLibService)
        {
            _sapLibService = sapLibService ?? throw new ArgumentNullException(nameof(sapLibService));
        }

        [HttpGet(Name = "GetProductionData")]
        [HttpHead]
        public async Task<IActionResult> GetProductionData([FromQuery] SapResourceParameter @params)
        {
            if (@params == null)
            {
                return BadRequest();
            }

            if (string.IsNullOrWhiteSpace(@params.Area))
            {
                return BadRequest();
            }

            var prodData = await _sapLibService.GetProductionData(@params).ConfigureAwait(false);

            return Ok(prodData);
        }
    }
}
