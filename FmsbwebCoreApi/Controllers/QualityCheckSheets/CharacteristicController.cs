using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using FmsbwebCoreApi.Context.QualityCheckSheets;
using FmsbwebCoreApi.Entity.QualityCheckSheets;
using FmsbwebCoreApi.Services.Interfaces.QualityCheckSheets;
using Microsoft.AspNet.OData;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FmsbwebCoreApi.Controllers.QualityCheckSheets
{
    [Route("api/quality/checkSheets/[controller]")]
    [ApiController]
    public class CharacteristicController : ControllerBase
    {
        private readonly QualityCheckSheetsContext _context;
        private readonly ICharacteristicService _service;

        public CharacteristicController(QualityCheckSheetsContext context, ICharacteristicService service)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
            _service = service ?? throw new ArgumentNullException(nameof(service));
        }

        [EnableQuery]
        public IActionResult Get()
        {
            return Ok(_context.Characteristics);
        }

        [HttpGet("{id}")]
        [EnableQuery]
        public IActionResult Get(int id)
        {
            var result = _context.Characteristics
                .Include(x => x.ControlMethod)
                .Include(x => x.MachineId)
                .Include(x => x.OrganizationPart)
                .Include(x => x.DisplayAs)
                .Where(x => x.MachineId == id);
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> CreateMachine(Characteristic data)
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
        public async Task<IActionResult> PutMachine(Characteristic data)
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
