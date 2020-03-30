using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FmsbwebCoreApi.Services.FmsbMvc;
using FmsbwebCoreApi.ResourceParameters.FMSB;
using System.Globalization;

namespace FmsbwebCoreApi.Controllers.FMSB
{
    [ApiController]
    [EnableCors]
    [Route("api/fmsb/downtime")]
    public class DowntimeController : ControllerBase
    {
        private readonly IFmsbMvcLibraryRepository _repo;
        public DowntimeController(
            IFmsbMvcLibraryRepository libRepo)
        {
            _repo = libRepo ??
                throw new ArgumentNullException(nameof(libRepo));
        }

        [HttpGet(Name = "GetDowntime")]
        [HttpHead]
        public async Task<IActionResult> GetDowntime([FromQuery] DowntimeResourceParameter resourceParameter)
        {
            if (resourceParameter == null) return BadRequest();

            try
            {
                var data = await _repo.GetDowntime(resourceParameter).ConfigureAwait(false);
                var categories = data.Select(x => new { Dept = x.Dept.ToUpper() }).Distinct().OrderBy(x => x.Dept.ToUpper()).ToList();
                var series = data.Select(x => new { x.Shift }).Distinct().OrderBy(x => x.Shift).ToList();

                var chartData = series
                            .Select(s => new
                            {
                                seriesname = s.Shift,
                                data = categories
                                        .Select(x => new
                                        {
                                            Dept = x.Dept.ToUpper(),
                                            TotalDowntime = data.Any(v => v.Dept.ToUpper() == x.Dept.ToUpper() && v.Shift == s.Shift)
                                                    ? data.Where(v => v.Dept.ToUpper() == x.Dept.ToUpper() && v.Shift == s.Shift).Sum(v => v.DowntimeLoss)
                                                    : 0,
                                            ownerDetails = data.Where(o => o.Dept.ToUpper() == x.Dept.ToUpper() && o.Shift == s.Shift)
                                                                .GroupBy(o => new { o.Type, o.TypeColor })
                                                                .Select(o => new
                                                                {
                                                                    o.Key.Type,
                                                                    o.Key.TypeColor,
                                                                    TotalDowntime = o.Sum(t => t.DowntimeLoss),
                                                                    LineDetails = o.GroupBy(l => new { l.Line, l.Machine })
                                                                                    .Select(l => new
                                                                                    {
                                                                                        Line = l.Key.Machine.ToLower() != l.Key.Line.ToLower() ? $"{l.Key.Machine} ({l.Key.Line})" : l.Key.Machine,
                                                                                        o.Key.TypeColor,
                                                                                        TotalDowntime = l.Sum(t => t.DowntimeLoss),
                                                                                        Reason2Details = l.GroupBy(r => new { r.Reason2 })
                                                                                                            .Select(r => new
                                                                                                            {
                                                                                                                r.Key.Reason2,
                                                                                                                o.Key.TypeColor,
                                                                                                                TotalDowntime = r.Sum(t => t.DowntimeLoss),
                                                                                                                DailyDetails = r.GroupBy(d => new { d.ShifDate })
                                                                                                                                .Select(d => new
                                                                                                                                {
                                                                                                                                    d.Key.ShifDate,
                                                                                                                                    o.Key.TypeColor,
                                                                                                                                    TotalDowntime = d.Sum(t => t.DowntimeLoss)
                                                                                                                                })
                                                                                                                                .OrderBy(d => d.ShifDate)
                                                                                                            })
                                                                                                            .OrderByDescending(r => r.TotalDowntime)
                                                                                    }).OrderByDescending(l => l.TotalDowntime)
                                                                }).OrderByDescending(o => o.TotalDowntime)
                                        })
                            });


                return Ok(new
                {
                    categories,
                    chartData
                });
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
