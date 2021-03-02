using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DocumentFormat.OpenXml.Office2010.Drawing;
using FmsbwebCoreApi.Context.Safety;
using FmsbwebCoreApi.Models;
using FmsbwebCoreApi.ResourceParameters;
using FmsbwebCoreApi.Services.Interfaces;
using Microsoft.AspNet.OData;
using Microsoft.EntityFrameworkCore;

namespace FmsbwebCoreApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SafetyController : Controller
    {
        private readonly SafetyContext _context;
        private readonly ISafetyService _service;

        public SafetyController(SafetyContext context, ISafetyService service)
        {
            _context = context;
            _service = service;
        }

        [HttpGet]
        [EnableQuery]
        public IActionResult Index()
        {
            var qry = _context.Incidences
                .Include(x => x.BodyPart)
                .Include(x => x.Injury)
                .AsQueryable();

            return Ok(qry);
        }

        [Route("charts")]
        [HttpGet]
        public async Task<IActionResult> GetChartsData([FromQuery] SafetyResourceParameter parameter)
        {
            try
            {
                var data = await _service.GetChartsData(parameter).ConfigureAwait(false);
                return Ok(data);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpGet]
        [Route("departments")]
        [EnableQuery]
        public IActionResult GetDepartments()
        {
            var qry = _context.Depts.AsQueryable();
            return Ok(qry);
        }

        [HttpGet]
        [Route("bodyParts")]
        [EnableQuery]
        public IActionResult GetBodyParts()
        {
            var qry = _context.BodyParts.AsQueryable();
            return Ok(qry);
        }

        [HttpGet]
        [Route("Injuries")]
        [EnableQuery]
        public IActionResult GetInjuries()
        {
            var qry = _context.Injuries.AsQueryable();
            return Ok(qry);
        }

        [HttpGet]
        [Route("status")]
        [EnableQuery]
        public IActionResult GetStatus()
        {
            var qry = _context.InjuryStats.AsQueryable();
            return Ok(qry);
        }

        [HttpPost]
        public async Task<IActionResult> AddOrUpdate(SafetyIncidenceDto resourceParameter)
        {
            try
            {
                var data = await _service.AddOrUpdate(resourceParameter).ConfigureAwait(false);
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
