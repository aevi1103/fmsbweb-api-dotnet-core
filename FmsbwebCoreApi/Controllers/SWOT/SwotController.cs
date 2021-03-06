﻿using System;
using System.Threading.Tasks;
using FmsbwebCoreApi.ResourceParameters;
using FmsbwebCoreApi.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace FmsbwebCoreApi.Controllers.SWOT
{
    [Route("api/[controller]")]
    [ApiController]
    public class SwotController : ControllerBase
    {
        private readonly ISwotService _swotService;

        public SwotController(ISwotService swotService)
        {
            _swotService = swotService ?? throw new ArgumentNullException(nameof(swotService));
        }

        [HttpGet]
        public async Task<IActionResult> GetData([FromQuery] SwotResourceParameter parameter)
        {
            var result = await _swotService.GetCharts(parameter).ConfigureAwait(false);
            return Ok(result);
        }

        [Route("hxh")]
        [HttpGet]
        public async Task<IActionResult> GetHxHData([FromQuery] SwotResourceParameter parameter)
        {
            var result = await _swotService.GetProductionDashboardCharts(parameter).ConfigureAwait(false);
            return Ok(result);
        }

        [Route("lines/{dept}")]
        [HttpGet]
        public async Task<IActionResult> GetLine(string dept)
        {
            if (dept == null) return BadRequest("Department parameter is missing.");

            var result = await _swotService.GetLines(dept).ConfigureAwait(false);
            return Ok(result);
        }

    }
}
