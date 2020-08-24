using System;
using System.Linq;
using System.Threading.Tasks;
using FmsbwebCoreApi.Context.QualityCheckSheets;
using FmsbwebCoreApi.Entity.QualityCheckSheets;
using FmsbwebCoreApi.Services.Interfaces.QualityCheckSheets;
using Microsoft.AspNet.OData;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FmsbwebCoreApi.Controllers.QualityCheckSheets
{
    [Route("api/quality/checkSheets/[controller]")]
    [ApiController]
    public class MachineController : ControllerBase
    {
        private readonly IMachineService _service;

        public MachineController(IMachineService service)
        {
            _service = service ?? throw new ArgumentNullException(nameof(service));
        }

        [EnableQuery]
        public IActionResult Get()
        {
            return Ok(_service.Query());
        }

        [HttpGet("{id}")]
        [EnableQuery]
        public IActionResult Get(int id)
        {
            return Ok(_service.Query(id));
        }

        [HttpPost]
        public async Task<IActionResult> CreateMachine(Machine data)
        {
            if (data == null)
                return BadRequest();

            try
            {
                var result = await _service.Create(data).ConfigureAwait(false);
                return Ok(result);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPut]
        public async Task<IActionResult> PutMachine(Machine data)
        {
            if (data == null)
                return BadRequest();

            try
            {
                var result = await _service.Update(data).ConfigureAwait(false);
                return Ok(result);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMachine(int id)
        {
            try
            {
                var result = await _service.Delete(id).ConfigureAwait(false);
                return Ok(result);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}
