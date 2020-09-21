using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using ClosedXML.Excel;
using FmsbwebCoreApi.Models.SAP;
using FmsbwebCoreApi.ResourceParameters.SAP;
using FmsbwebCoreApi.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FmsbwebCoreApi.Controllers.Exports
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExportsController : ControllerBase
    {
        private readonly IExportService _exportService;

        public ExportsController(IExportService exportService)
        {
            _exportService = exportService ?? throw new ArgumentNullException(nameof(exportService));
        }

        [HttpGet]
        [Route("department/details")]
        public async Task<IActionResult> DepartmentDetails([FromQuery] SapResourceParameter resourceParameter)
        {
            try
            {
                var result = await _exportService.DownloadDepartmentWorkCenters(resourceParameter);
                return File(result.Content, result.ContentType, result.FileName);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpGet]
        [Route("department")]
        public async Task<IActionResult> Department([FromQuery] SapResourceParameter resourceParameter)
        {
            try
            {
                var result = await _exportService.DownloadDepartmentKpi(resourceParameter);
                return File(result.Content, result.ContentType, result.FileName);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpGet]
        [Route("performance/level/0")]
        public async Task<IActionResult> PerformanceLevel0([FromQuery] SapResourceParameter resourceParameter)
        {
            try
            {
                var result = await _exportService.DownloadPerformanceLevel0(resourceParameter);
                return File(result.Content, result.ContentType, result.FileName);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpGet]
        [Route("performance/level/2")]
        public async Task<IActionResult> PerformanceLevel2([FromQuery] SapResourceParameter resourceParameter)
        {
            try
            {
                var result = await _exportService.DownloadPerformanceLevel2(resourceParameter);
                return File(result.Content, result.ContentType, result.FileName);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}
