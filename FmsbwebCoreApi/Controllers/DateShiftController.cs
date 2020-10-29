using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DateShiftMethods.Helpers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FmsbwebCoreApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DateShiftController : ControllerBase
    {
        private readonly DateShift _dateShift;

        public DateShiftController(DateShift dateShift)
        {
            _dateShift = dateShift ?? throw new ArgumentNullException(nameof(dateShift));
        }

        [HttpGet("{department}")]
        public IActionResult GetCurrentDateShift(string department)
        {
            var result = _dateShift.GetCurrentDateShift(department);
            return Ok(new
            {
                ShiftDate = result.ShiftDate.ToShortDateString(),
                result.Shift
            });
        }
    }
}
