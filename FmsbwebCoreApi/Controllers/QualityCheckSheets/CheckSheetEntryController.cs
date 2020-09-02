using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FmsbwebCoreApi.Entity.QualityCheckSheets;
using FmsbwebCoreApi.Services.Interfaces.QualityCheckSheets;
using Microsoft.AspNet.OData;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FmsbwebCoreApi.Controllers.QualityCheckSheets
{
    [Route("api/quality/checkSheets/[controller]")]
    [ApiController]
    public class CheckSheetEntryController : ControllerBase
    {
        private readonly ICheckSheetEntryService _service;

        public CheckSheetEntryController(ICheckSheetEntryService service)
        {
            _service = service ?? throw new ArgumentNullException(nameof(service));
        }

        [EnableQuery]
        public IActionResult Get()
        {
            return Ok(_service.Query());
        }

        [HttpPost]
        public async Task<IActionResult> Post(CheckSheetEntry data)
        {
            if (data == null)
                return BadRequest();

            try
            {
                var result = await _service.AddOrUpdate(data).ConfigureAwait(false);
                return Ok(result);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [Route("initialRecheck")]
        [HttpPost]
        public async Task<IActionResult> AddInitialReCheck(ReCheck data)
        {
            try
            {
                var result = await _service.AddInitialReCheck(data);
                return Ok(result);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}
