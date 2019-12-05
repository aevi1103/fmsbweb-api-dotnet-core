using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using FmsbwebCoreApi.Services.Safety;
using FmsbwebCoreApi.Models.Safety;
using AutoMapper;
using FmsbwebCoreApi.ResourceParameters.Safety;
using FmsbwebCoreApi.Entity.Safety;

namespace FmsbwebCoreApi.Controllers.Safety
{
    [ApiController]
    [Route("api/incidents")]
    public class IncidentsController : ControllerBase
    {
        private readonly ISafetyLibraryRepository _safetyLibraryRepository;
        private readonly IMapper _mapper;

        public IncidentsController(ISafetyLibraryRepository safetyLibraryRepository,
            IMapper mapper)
        {
            _safetyLibraryRepository = safetyLibraryRepository ??
                throw new ArgumentNullException(nameof(safetyLibraryRepository));

            _mapper = mapper ??
                throw new ArgumentNullException(nameof(mapper));
        }

        [HttpGet()]
        [HttpHead]
        public ActionResult<IEnumerable<IncidentDto>> GetIncents([FromQuery] IncidentsResourceParameter incidentsResourceParameter)
        {
            var incidentsFromRepo = _safetyLibraryRepository.GetIncents(incidentsResourceParameter);
            return Ok(_mapper.Map<IEnumerable<IncidentDto>>(incidentsFromRepo));
        }

        [HttpGet("{id}", Name = "GetIncident")]
        public ActionResult<IncidentDto> GetIncident(int id)
        {
            var incidentFromRepo = _safetyLibraryRepository.GetIncent(id);
            if (incidentFromRepo == null)
            {
                return NotFound();
            }

            return Ok(_mapper.Map<IncidentDto>(incidentFromRepo));
        }

        [HttpPost]
        public ActionResult<IncidentDto> CreateIncident(IncidentForCreationDto incident)
        {
            var incidentEntity = _mapper.Map<Incidence>(incident);
            _safetyLibraryRepository.AddIncident(incidentEntity);
            _safetyLibraryRepository.Save();

            var incidentToReturn = _mapper.Map<IncidentDto>(incidentEntity);
            return CreatedAtRoute("GetIncident", new { id = incidentToReturn.Id }, incidentToReturn);
        }
    }
}
