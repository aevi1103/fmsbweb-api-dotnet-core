using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FmsbwebCoreApi.Entity.QualityCheckSheets;
using FmsbwebCoreApi.Models.QualityCheckSheets;
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

        private async Task<CheckSheetEntry> GetCheckSheetEntry(int controlId, ReCheck latestRecheck)
        {
            return controlId == 1
                //if control id is 1 or CS, then update the value of check sheet entry from the latest recheck
                ? await _checkSheetEntryService.UpdateValueFromReCheck( latestRecheck)
                //else get the current check entry object
                : await _checkSheetEntryService.GetById(latestRecheck.CheckSheetEntryId); 
        }

        [HttpPost]
        public async Task<IActionResult> Post(ReCheck data)
        {
            if (data == null)
                return BadRequest();

            try
            {

                ReCheck latestRecheck;
                CheckSheetEntry checkSheetEntry;
                int controlId;

                switch (data.Value)
                {
                    case null when data.ValueBool == null && data.ReCheckId == 0:

                        return Ok(new CheckSheetResultDto
                        {
                            Status = 0,
                            StatusText = "Null entry",
                            Result = null
                        });

                    case null when data.ValueBool == null && data.ReCheckId > 0:

                        //get the recheck object as readonly
                        var reCheck = await _service.GetByIdNoTracking(data.ReCheckId); 

                        //delete object
                        await _service.Delete(data.ReCheckId); 

                        //get the latest rechecks after delete, if null get the initial recheck object
                        latestRecheck = await _service.GetLatestRecheck(reCheck.CheckSheetEntryId) ?? reCheck;

                        //get the control id
                        controlId = reCheck.CheckSheetEntry.CheckSheet.ControlMethodId; 
                        checkSheetEntry = await GetCheckSheetEntry(controlId, latestRecheck);

                        return Ok(new CheckSheetResultDto
                        {
                            Status = 1,
                            StatusText = "Delete",
                            Result = new
                            {
                                reCheck = data,
                                checkSheetEntry
                            }
                        });

                    default:

                        await _service.Update(data);
                        latestRecheck = await _service.GetLatestRecheck(data.CheckSheetEntryId);
                        controlId = latestRecheck.CheckSheetEntry.CheckSheet.ControlMethodId;
                        checkSheetEntry = await GetCheckSheetEntry(controlId, latestRecheck);

                        return Ok(new CheckSheetResultDto
                        {
                            Status = 2,
                            StatusText = "Add/Update",
                            Result = new
                            {
                                reCheck = data,
                                checkSheetEntry
                            }
                        });

                }

            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [Route("{id}")]
        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                var reCheck = await _service.GetByIdNoTracking(id);
                await _service.Delete(id);
                var latestRecheck = await _service.GetLatestRecheck(reCheck.CheckSheetEntryId);
                var controlId = latestRecheck.CheckSheetEntry.CheckSheet.ControlMethodId;
                var checkSheetEntry = await GetCheckSheetEntry(controlId, latestRecheck);

                return Ok(new CheckSheetResultDto
                {
                    Status = 1,
                    StatusText = "Delete",
                    Result = new
                    {
                        reCheck,
                        checkSheetEntry
                    }
                });

            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}
