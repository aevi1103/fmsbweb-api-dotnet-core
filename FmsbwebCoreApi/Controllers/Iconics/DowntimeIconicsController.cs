using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FmsbwebCoreApi.ResourceParameters.FMSB;
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
        public async Task<IActionResult> GetDowntimeIconics([FromQuery] DowntimeResourceParameter @params)
        {
            var initialDate = @params.Start.AddDays(-7);
            @params.End = @params.End.AddDays(1);
            @params.Dept = @params.Dept == "Plant" ? "" : @params.Dept;

            var data = await _repo.GetDowntimeIconics(
                initialDate,
                @params.End,
                @params.Dept,
                @params.MinDowntimeEvent,
                @params.MaxDowntimeEvent)
            .ConfigureAwait(false);

            var spreadHours = _repo.SpreadHours(data.ToList())
                .Where(x => x.StartStamp >= @params.Start && x.StartStamp <= @params.End);

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