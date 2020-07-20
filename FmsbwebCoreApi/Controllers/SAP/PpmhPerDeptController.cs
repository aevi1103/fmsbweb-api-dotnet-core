﻿using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using FmsbwebCoreApi.Services.Interfaces;

namespace FmsbwebCoreApi.Controllers.SAP
{
    [ApiController]
    [EnableCors]
    [Route("api/ppmh/ppmhperdept")]
    public class PpmhPerDeptController : ControllerBase
    {
        private readonly ISapLibraryService _sapLibRepo;
        public PpmhPerDeptController(
            ISapLibraryService sapLibRepo)
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
                var result = await _sapLibRepo.GetPpmhPerDeptPlantWideVariance(start, end, area).ConfigureAwait(false);
                return Ok(result);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

        }
    }
}
