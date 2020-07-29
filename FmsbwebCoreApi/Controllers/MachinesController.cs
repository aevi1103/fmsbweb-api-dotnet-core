using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FmsbwebCoreApi.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FmsbwebCoreApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MachinesController : ControllerBase
    {
        private readonly IDataAccessUtilityService _dataAccessUtilityService;

        public MachinesController(IDataAccessUtilityService dataAccessUtilityService)
        {
            _dataAccessUtilityService = dataAccessUtilityService ?? throw new ArgumentNullException(nameof(dataAccessUtilityService));
        }

        [HttpGet("{departmentId}", Name = "GetMachines")]
        [HttpHead]
        public async Task<IActionResult> GetMachines(int departmentId)
        {
            try
            {
                var data = await _dataAccessUtilityService.GetMachines(departmentId, true).ConfigureAwait(false);
                var result = data.Select(x => new
                {
                    Id = x.MachineId,
                    Machine = x.MachineName,
                    x.DeptId,
                    x.DeptName,
                    x.MachineMapper,
                    x.LineNumber,
                    Line = x.Line2
                });
                return Ok(result);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}
