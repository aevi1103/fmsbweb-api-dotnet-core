using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FmsbwebCoreApi.Entity.QualityCheckSheets;
using FmsbwebCoreApi.Models.QualityCheckSheets;
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
                switch (data.Value)
                {
                    case null when data.ValueBool == null && data.CheckSheetEntryId == 0:
                        return Ok(new CheckSheetResultDto
                        {
                            Status = 0,
                            StatusText = "Null entry",
                            Result = data
                        });
                    case null when data.ValueBool == null && data.CheckSheetEntryId > 0:
                        await _service.Delete(data.CheckSheetEntryId);
                        return Ok(new CheckSheetResultDto
                        {
                            Status = 1,
                            StatusText = "Delete",
                            Result = data
                        });
                    default:
                        return Ok(new CheckSheetResultDto
                        {
                            Status = 2,
                            StatusText = "Add/Update",
                            Result = await _service.Update(data).ConfigureAwait(false)
                        });
                }
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
