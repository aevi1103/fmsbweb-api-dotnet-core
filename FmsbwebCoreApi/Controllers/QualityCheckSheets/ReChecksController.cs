using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FmsbwebCoreApi.Entity.QualityCheckSheets;
using FmsbwebCoreApi.Services.Interfaces.QualityCheckSheets;
using FmsbwebCoreApi.Services.QualityCheckSheets;
using Microsoft.AspNet.OData;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FmsbwebCoreApi.Controllers.QualityCheckSheets
{
    [Route("api/quality/checkSheets/[controller]")]
    [ApiController]
    public class ReChecksController : ControllerBase
    {
        private readonly IReCheckService _service;
        private readonly ICheckSheetEntryService _checkSheetEntryService;

        public ReChecksController(IReCheckService service, ICheckSheetEntryService checkSheetEntryService)
        {
            _service = service ?? throw new ArgumentNullException(nameof(service));
            _checkSheetEntryService = checkSheetEntryService ?? throw new ArgumentNullException(nameof(checkSheetEntryService));
        }
        [EnableQuery]
        public IActionResult Get()
        {
            return Ok(_service.Query());
        }

        [HttpPost]
        public async Task<IActionResult> Post(ReCheck data)
        {
            if (data == null)
                return BadRequest();

            try
            {
                await _service.Update(data);
                var latestRecheck = await _service.GetLatestRecheck(data.CheckSheetEntryId);
                var result = await _checkSheetEntryService.UpdateValueFromReCheck(latestRecheck);
                return Ok(new
                {
                    reCheck = data,
                    checkSheetEntry = result
                });
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [Route("{id}")]
        [HttpDelete]
        public async Task<IActionResult> Post(int id)
        {
            try
            {
                var reCheck = await _service.GetByIdNoTracking(id);
                await _service.Delete(id);
                var latestRecheck = await _service.GetLatestRecheck(reCheck.CheckSheetEntryId);
                var result = await _checkSheetEntryService.UpdateValueFromReCheck(latestRecheck);
                return Ok(new
                {
                    reCheck,
                    checkSheetEntry = result
                });

            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}
