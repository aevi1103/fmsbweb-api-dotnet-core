﻿using FmsbwebCoreApi.ResourceParameters.Finance;
using FmsbwebCoreApi.Services.FMSB2;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FmsbwebCoreApi.Controllers.Finance
{
    [ApiController]
    [EnableCors]
    [Route("api/finance/kpi")]
    public class FinanceController : ControllerBase
    {
        private readonly IFmsb2LibraryRepository _fmsbLibRepo;
        public FinanceController(
                IFmsb2LibraryRepository fmsbLibRepo)
        {
            _fmsbLibRepo = fmsbLibRepo ??
                throw new ArgumentNullException(nameof(fmsbLibRepo));
        }

        [HttpGet(Name = "GetFinanceKpi")]
        [HttpHead]
        public async Task<IActionResult> GetFinanceKpi(
            [FromQuery] FiananceResourceParameter resourceParameter)
        {
            if (resourceParameter == null)
            {
                return BadRequest();
            }

            var data = await _fmsbLibRepo.GetFinanceKpi(resourceParameter.Date).ConfigureAwait(false);

            return Ok(data);
        }
    }
}
