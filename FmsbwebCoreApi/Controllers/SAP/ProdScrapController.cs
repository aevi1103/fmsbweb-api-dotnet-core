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
    [Route("api/sap/prodscrap")]
    public class ProdScrapController : ControllerBase
    {
        private readonly ISapLibraryRepository _sapLibRepo;
        public ProdScrapController(
            ISapLibraryRepository sapLibRepo)
        {
            _sapLibRepo = sapLibRepo ??
                throw new ArgumentNullException(nameof(sapLibRepo));
        }

        [HttpGet(Name = "GetProdScrap")]
        [HttpHead]
        public async Task<IActionResult> GetProdScrap(
            [FromQuery] SapResouceParameter resourceParameter)
        {
            if (resourceParameter == null)
            {
                return BadRequest();
            }

            var prodData = await _sapLibRepo.GetSapProdAndScrap(
                                    resourceParameter.Start,
                                    resourceParameter.End,
                                    resourceParameter.Area);

            return Ok(prodData);
        }
    }
}
