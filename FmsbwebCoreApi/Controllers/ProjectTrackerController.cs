using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.Threading.Tasks;
using FmsbwebCoreApi.Context.Fmsb2;
using FmsbwebCoreApi.Entity.Fmsb2;
using FmsbwebCoreApi.Enums;
using FmsbwebCoreApi.Services.Interfaces;
using Microsoft.AspNet.OData;
using Microsoft.EntityFrameworkCore;

namespace FmsbwebCoreApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectTrackerController : Controller
    {
        private readonly IProjectTrackerService _service;
        private readonly Fmsb2Context _context;

        public ProjectTrackerController(IProjectTrackerService service, Fmsb2Context context)
        {
            _service = service;
            _context = context;
        }

        [HttpGet]
        [EnableQuery]
        public IActionResult Get()
        {
            try
            {
                var data = _context
                    .ProjectTracker
                    .Include(x => x.CreateHxH)
                    .Include(x => x.CreateHxH.HxhOpsClockNum)
                    .Include(x => x.CreateHxH.Department)
                    .Include(x => x.CreateHxH.Machines)
                    .AsQueryable();
                return Ok(data);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }

        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] ProjectTracker parameters)
        {
            try
            {
                var data = await _service.AddOrUpdate(parameters).ConfigureAwait(false);
                return Ok(data);
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
                var data = await _service.Delete(id).ConfigureAwait(false);
                return Ok(data);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}
