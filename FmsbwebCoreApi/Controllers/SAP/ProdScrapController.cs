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
    [Route("api/sap/prodscrap")]
    public class ProdScrapController : ControllerBase
    {
        private readonly ISapLibraryService _sapLibRepo;
        public ProdScrapController(
            ISapLibraryService sapLibRepo)
        {
            _sapLibRepo = sapLibRepo ??
                throw new ArgumentNullException(nameof(sapLibRepo));
        }

        [HttpGet(Name = "GetProdScrap")]
        [HttpHead]
        public async Task<IActionResult> GetProdScrap([FromQuery] SapResourceParameter @params)
        {
            if (@params == null)
            {
                return BadRequest();
            }

            var prodData = await _sapLibRepo.GetSapProdAndScrap(@params).ConfigureAwait(false);

            return Ok(prodData);
        }
    }
}
