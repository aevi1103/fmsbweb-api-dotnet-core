using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FmsbwebCoreApi.ResourceParameters.FMSB;
using FmsbwebCoreApi.Services.FmsbMvc;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace FmsbwebCoreApi.Controllers.FMSB
{
    [ApiController]
    [EnableCors]
    [Route("api/fmsb/downtimebyowner")]
    public class DowntimeByOwnerController : Controller
    {
        private readonly IFmsbMvcLibraryRepository _repo;
        public DowntimeByOwnerController(
            IFmsbMvcLibraryRepository libRepo)
        {
            _repo = libRepo ??
                throw new ArgumentNullException(nameof(libRepo));
        }

        [HttpGet(Name = "GetDowntimeByOwner")]
        [HttpHead]
        public async Task<IActionResult> GetDowntimeByOwner([FromQuery] DowntimeResourceParameter resourceParameter)
        {
            if (resourceParameter == null) return BadRequest();

            var data = await _repo.GetDowntime(resourceParameter).ConfigureAwait(false);

            var res = data
                        .Where(x => x.DowntimeLoss > 0)
                        .GroupBy(x => new { x.Type })
                        .Select(x => new
                        {
                            x.Key.Type,
                            DowntimeLoss = x.Sum(t => t.DowntimeLoss),
                            LineDetails = x.GroupBy(l => new { l.Line })
                                            .Select(l => new
                                            {
                                                x.Key.Type,
                                                l.Key.Line,
                                                MachineLine = l.Key.Line,
                                                DowntimeLoss = l.Sum(t => t.DowntimeLoss),
                                                MahcineDetails = l.GroupBy(m => new { m.Machine })
                                                                    .Select(m => new
                                                                    {
                                                                        x.Key.Type,
                                                                        l.Key.Line,
                                                                        m.Key.Machine,
                                                                        DowntimeLoss = m.Sum(t => t.DowntimeLoss),
                                                                        ReasonDetails = m.GroupBy(r => new { r.Reason2 })
                                                                                            .Select(r => new
                                                                                            {
                                                                                                x.Key.Type,
                                                                                                l.Key.Line,
                                                                                                m.Key.Machine,
                                                                                                r.Key.Reason2,
                                                                                                DowntimeLoss = r.Sum(t => t.DowntimeLoss),
                                                                                            }).Take(10).OrderByDescending(r => r.DowntimeLoss)
                                                                    }).OrderByDescending(m => m.DowntimeLoss)
                                            }).OrderByDescending(l => l.DowntimeLoss)
                        })
                        .OrderByDescending(x => x.DowntimeLoss)
                        .ToList();

            return Ok(res);
        }
    }
}