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

            var data = await _repo.GetDowntimeCallbox(resourceParameter);

            return Ok(data);


        }
    }
}
