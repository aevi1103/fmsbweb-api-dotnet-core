using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FmsbwebCoreApi.Entity.Overtime;
using FmsbwebCoreApi.ResourceParameters;
using FmsbwebCoreApi.Services.Interfaces;

namespace FmsbwebCoreApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OvertimeController : Controller
    {
        private readonly IOvertimeService _service;

        public OvertimeController(IOvertimeService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> Get([FromQuery] OvertimeResourceParameter parameter)
        {

            try
            {
                var data = await _service
                    .GetOvertimeTotalHours(parameter)
                    .ConfigureAwait(false);

                return Ok(data);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPost]
        public async Task<IActionResult> AddOrUpdate(OvertimePostDto data)
        {
            if (data == null) throw new ArgumentNullException(nameof(data));

            try
            {
                var result = await _service.AddOrUpdate(new Overtime
                {
                    OvertimeId = data.OvertimeId,
                    Date = data.Date,
                    TypeName = data.TypeName,
                    ClockNumber = data.ClockNumber,
                    Comment = data.Comment,
                    Hours = data.Hours,
                    ModifiedDate = data.ModifiedDate
                }).ConfigureAwait(false);

                return Ok(result);
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
