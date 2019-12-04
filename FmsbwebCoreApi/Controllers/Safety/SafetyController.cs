using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using FmsbwebCoreApi.Services.Safety;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FmsbwebCoreApi.Controllers.Safety
{
    [ApiController]
    [Route("api/incidents")]
    public class SafetyController : ControllerBase
    {
        private readonly ISafetyLibraryRepository _safetyLibraryRepository;

        public SafetyController(ISafetyLibraryRepository safetyLibraryRepository)
        {
            _safetyLibraryRepository = safetyLibraryRepository ??
                throw new ArgumentNullException(nameof(safetyLibraryRepository));
        }

        [HttpGet()]
        public IActionResult GetIncents()
        {
            var incidentsFromRepo = _safetyLibraryRepository.GetIncents();
            return Ok(incidentsFromRepo);
        }

        [HttpGet("{id}")]
        public IActionResult GetIncident(int id)
        {
            var incidentFromRepo = _safetyLibraryRepository.GetIncent(id);
            if (incidentFromRepo == null)
            {
                return NotFound();
            }

            return Ok(incidentFromRepo);
        }

    }
}
