using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FmsbwebCoreApi.Services.Iconics;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace FmsbwebCoreApi.Controllers.Iconics
{
    [ApiController]
    [EnableCors]
    [Route("api/iconics/downtimeiconics")]
    public class DowntimeIconicsController : Controller
    {
        private readonly IIconicsLibraryRepository _repo;
        public DowntimeIconicsController(IIconicsLibraryRepository libRepo)
        {
            _repo = libRepo ??
                throw new ArgumentNullException(nameof(libRepo));
        }

        [HttpGet(Name = "GetDowntimeIconics")]
        [HttpHead]
        public async Task<IActionResult> GetDowntimeIconics(DateTime start, DateTime end, int minDowntimeEvent = 10, int? maxDowntimeEvent = null, string dept = "")
        {
            var initialDate = start.AddDays(-7);
            end = end.AddDays(1);
            dept = dept == "Plant" ? "" : dept;

            var data = await _repo.GetDowntimeIconics(initialDate, end, dept, minDowntimeEvent, maxDowntimeEvent).ConfigureAwait(false);
            var spreadHours = _repo.SpreadHours(data.ToList()).Where(x => x.StartStamp >= start && x.StartStamp <= end);

            var result = spreadHours.GroupBy(x => new { x.Dept, x.Line })
                            .Select(x => new
                            {
                                Line = x.Key.Dept == "Machining" ? $"Line {x.Key.Line}" : $"{x.Key.Dept} {x.Key.Line}",
                                TotalDowntime = Math.Round(x.Sum(t => t.Downtime), 0),
                                MachineDetails = x.GroupBy(m => new { m.MachineName })
                                                    .Select(m => new
                                                    {
                                                        m.Key.MachineName,
                                                        TotalDowntime = Math.Round(m.Sum(t => t.Downtime), 0),
                                                    }).OrderByDescending(m => m.TotalDowntime)
                            })
                            .OrderByDescending(x => x.TotalDowntime)
                            .ToList();

            return Ok(result);
        }
    }
}