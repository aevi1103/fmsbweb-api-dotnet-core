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
            return Ok(await _repo.GetDowntimeByOwner(resourceParameter));
        }
    }
}