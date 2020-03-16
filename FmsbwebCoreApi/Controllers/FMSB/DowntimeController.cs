using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FmsbwebCoreApi.Services.FmsbMvc;
using FmsbwebCoreApi.ResourceParameters.FMSB;

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
            if (resourceParameter == null)
            {
                return BadRequest();
            }

            try
            {
                var data = await _repo.GetDowntime(resourceParameter);

                var chart = data.GroupBy(x => new { x.Dept })
                                .Select(x => new
                                {
                                    x.Key.Dept,
                                    TotalDowntime = x.Sum(s => s.DowntimeLoss),
                                    Count = x.Count(),
                                    ShiftDetails = x.GroupBy(s => new { s.Shift })
                                                    .Select(s => new
                                                    {
                                                        s.Key.Shift,
                                                        TotalDowntime = s.Sum(o => o.DowntimeLoss),
                                                        Count = s.Count(),
                                                        OwnerDetails = s.GroupBy(o => new { o.Type })
                                                                        .Select(o => new
                                                                        {
                                                                            o.Key.Type,
                                                                            TotalDowntime = o.Sum(l => l.DowntimeLoss),
                                                                            Count = o.Count(),
                                                                            LineDetails = o.GroupBy(l => new { l.Line })
                                                                                            .Select(l => new
                                                                                            {
                                                                                                l.Key.Line,
                                                                                                TotalDowntime = l.Sum(l => l.DowntimeLoss),
                                                                                                Details = l
                                                                                            }).OrderByDescending(l => l.TotalDowntime)
                                                                        }).OrderByDescending(o => o.TotalDowntime)
                                                    }).OrderByDescending(s => s.TotalDowntime)
                                })
                                .OrderByDescending(x => x.TotalDowntime)
                                .ToList();


                return Ok(chart);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}
