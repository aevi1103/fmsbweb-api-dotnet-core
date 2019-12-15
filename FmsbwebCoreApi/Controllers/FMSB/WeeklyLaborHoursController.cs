﻿using FmsbwebCoreApi.ResourceParameters.FMSB;
using FmsbwebCoreApi.Services.FMSB2;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FluentDateTime;

namespace FmsbwebCoreApi.Controllers.FMSB
{
    [ApiController]
    [Route("api/fmsb/weeklylaborhours")]
    public class WeeklyLaborHoursController : ControllerBase
    {
        private readonly IFmsb2LibraryRepository _fmsbLibRepo;
        public WeeklyLaborHoursController(
            IFmsb2LibraryRepository fmsbLibRepo)
        {
            _fmsbLibRepo = fmsbLibRepo ??
                throw new ArgumentNullException(nameof(fmsbLibRepo));
        }

        [HttpGet(Name = "GetWeeklyLaborHours")]
        [HttpHead]
        public async Task<IActionResult> GetWeeklyLaborHours(
            [FromQuery] FmsbResourceParameter resourceParameter)
        {
            if (resourceParameter == null)
            {
                return BadRequest();
            }

            var data = await _fmsbLibRepo.GetWeeklyProdScrapForLaborHrs(
                resourceParameter.Start,
                resourceParameter.End,
                resourceParameter.Area);

            return Ok(data);
        }
    }
}
