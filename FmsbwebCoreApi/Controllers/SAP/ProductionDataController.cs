﻿using FmsbwebCoreApi.ResourceParameters.SAP;
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
        private readonly ISapLibraryService _sapLibRepo;
        public ProductionDataController(
            ISapLibraryService sapLibRepo)
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

            if (string.IsNullOrWhiteSpace(resourceParameter.Area))
            {
                return BadRequest();
            }

            var prodData = await _sapLibRepo.GetProductionData(
                resourceParameter.Start,
                resourceParameter.End,
                resourceParameter.Area).ConfigureAwait(false);

            return Ok(prodData);
        }
    }
}
