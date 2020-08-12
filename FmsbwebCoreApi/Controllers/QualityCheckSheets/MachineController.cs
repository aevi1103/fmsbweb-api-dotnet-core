using System;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using FmsbwebCoreApi.Context.QualityCheckSheets;
using FmsbwebCoreApi.Entity.QualityCheckSheets;
using FmsbwebCoreApi.Services.Interfaces.QualityCheckSheets;
using Microsoft.AspNet.OData;
using Microsoft.AspNetCore.Mvc;

namespace FmsbwebCoreApi.Controllers.QualityCheckSheets
{
    [Route("api/quality/checkSheets/[controller]")]
    [ApiController]
    public class MachineController : ControllerBase
    {
        private readonly QualityCheckSheetsContext _context;
        private readonly IMachineService _service;

        public MachineController(QualityCheckSheetsContext context, IMachineService service)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
            _service = service ?? throw new ArgumentNullException(nameof(service));
        }

        [EnableQuery]
        public IActionResult Get()
        {
            return Ok(_context.Machines);
        }

        [HttpGet("{id}")]
        [EnableQuery]
        public IActionResult Get(int id)
        {
            var result = _context.Machines.Include(x => x.Line).Where(x => x.MachineId == id);
            return Ok(result);
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
