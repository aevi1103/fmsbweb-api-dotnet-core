using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FmsbwebCoreApi.Context.Intranet;
using FmsbwebCoreApi.Entity.Intranet;
using FmsbwebCoreApi.Entity.QualityCheckSheets;
using Microsoft.AspNet.OData;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FmsbwebCoreApi.Controllers.Machining
{
    [Route("api/machining/[controller]")]
    [ApiController]
    public class ManningController : ControllerBase
    {
        private readonly IntranetContext _context;

        public ManningController(IntranetContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        [EnableQuery]
        public IActionResult Get()
        {
            return Ok(_context.EolManning);
        }

        [Route("eos/{id}")]
        [EnableQuery]
        public IActionResult Get(int id)
        {
            var result = _context.EolManning
                .Include(x => x.EolvsEos)
                .Include(x => x.OperatorJob)
                .Include(x => x.Operator)
                .FirstOrDefault(x => x.EolvsEosId == id);

            if (result == null) return BadRequest("No data available");
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> Post(EolManning data)
        {
            if (data == null)
                return BadRequest();

            try
            {
                _context.EolManning.Update(data);
                await _context.SaveChangesAsync();
                return Ok(data);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [Route("collection")]
        [HttpPost]
        public async Task<IActionResult> Post(List<EolManning> data)
        {
            if (data == null)
                return BadRequest();

            try
            {
                var eosId = data.FirstOrDefault()?.EolvsEosId;

                var ids = data.Select(x => x.EolManningId);
                var recordsToDelete = _context.EolManning.Where(x => !ids.Contains(x.EolManningId));

                _context.EolManning.RemoveRange(recordsToDelete);
                _context.EolManning.UpdateRange(data);

                await _context.SaveChangesAsync();
                return Ok(data);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}
