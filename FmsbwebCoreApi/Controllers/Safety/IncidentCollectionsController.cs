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
using FmsbwebCoreApi.Helpers;
using FmsbwebCoreApi.Models.Safety.Incident;
using Microsoft.AspNetCore.Cors;

namespace FmsbwebCoreApi.Controllers.Safety
{
    [ApiController]
    [EnableCors]
    [Route("api/safety/incidentscollections")]
    public class IncidentCollectionsController : ControllerBase
    {
        private readonly ISafetyLibraryRepository _safetyLibraryRepository;
        private readonly IMapper _mapper;

        public IncidentCollectionsController(ISafetyLibraryRepository safetyLibraryRepository,
            IMapper mapper)
        {
            _safetyLibraryRepository = safetyLibraryRepository ??
                throw new ArgumentNullException(nameof(safetyLibraryRepository));

            _mapper = mapper ??
                throw new ArgumentNullException(nameof(mapper));
        }

        [HttpGet("({ids})", Name = "GetIncidentCollection")]
        public IActionResult GetIncidentCollection(
            [FromRoute]
            [ModelBinder(BinderType = typeof(ArrayModelBinder))] IEnumerable<int> ids)
        {
            if (ids == null)
            {
                return BadRequest();
            }

            var incidentEntities = _safetyLibraryRepository.GetIncents(ids);

            if (ids.Count() != incidentEntities.Count())
            {
                return BadRequest();
            }

            var incidentCollectionToReturn = _mapper.Map<IEnumerable<IncidentDto>>(incidentEntities);
            return Ok(incidentCollectionToReturn);
        
        }

        [HttpPost]
        public ActionResult<IEnumerable<IncidentDto>> CreateIncidentCollection(IEnumerable<IncidentForCreationDto> incidentCollections)
        {
            if (incidentCollections == null || incidentCollections.Count() == 0)
            {
                return BadRequest();
            }

            var incidentEntities = _mapper.Map<IEnumerable<Incidence>>(incidentCollections);
            _safetyLibraryRepository.AddIncidentCollection(incidentEntities);
            _safetyLibraryRepository.Save();

            var incidentCollectionToReturn = _mapper.Map<IEnumerable<IncidentDto>>(incidentEntities);
            var idsAsString = string.Join(",", incidentCollectionToReturn.Select(x => x.Id));

            return CreatedAtRoute("GetIncidentCollection",
                new { ids = idsAsString },
                incidentCollectionToReturn);

        }
    }
}
