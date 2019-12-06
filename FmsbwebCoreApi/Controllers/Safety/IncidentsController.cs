using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AutoMapper;

using FmsbwebCoreApi.Services.Safety;
using FmsbwebCoreApi.Models.Safety.Incident;
using FmsbwebCoreApi.ResourceParameters.Safety;
using FmsbwebCoreApi.Entity.Safety;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using FmsbwebCoreApi.Helpers;
using System.Text.Json;

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

        [HttpGet(Name = "GetIncents")]
        [HttpHead]
        public ActionResult<IEnumerable<IncidentDto>> GetIncents([FromQuery] IncidentsResourceParameter incidentsResourceParameter)
        {
            var incidentsFromRepo = _safetyLibraryRepository.GetIncents(incidentsResourceParameter);

            var previousPageLink = incidentsFromRepo.HasPrevious ?
                                    CreateIncidentResourceUri(incidentsResourceParameter, ResourceUriType.PreviousPage) : null;

            var nextPageLink = incidentsFromRepo.HasNext ?
                                    CreateIncidentResourceUri(incidentsResourceParameter, ResourceUriType.NextPage) : null;

            var paginationMetaData = new
            {
                totalCount = incidentsFromRepo.TotalCount,
                pageSize = incidentsFromRepo.PageSize,
                currentPage = incidentsFromRepo.CurrentPage,
                totalPages = incidentsFromRepo.TotalPages,
                previousPageLink,
                nextPageLink
            };

            Response.Headers.Add("X-Pagination",
                JsonSerializer.Serialize(paginationMetaData));

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
            if (incident == null)
            {
                return BadRequest();
            }

            var incidentEntity = _mapper.Map<Incidence>(incident);
            _safetyLibraryRepository.AddIncident(incidentEntity);
            _safetyLibraryRepository.Save();

            var incidentToReturn = _mapper.Map<IncidentDto>(incidentEntity);
            return CreatedAtRoute("GetIncident", new { id = incidentToReturn.Id }, incidentToReturn);
        }

        //PUT updates all fields, so if the client pass a incomplete payload the values will set to its default value
        [HttpPut("{id}")]
        public ActionResult UpdateIncident(int id, IncidentForUpdateDto incident)
        {
            if (incident == null)
            {
                return BadRequest();
            }

            var incidentFromRepo = _safetyLibraryRepository.GetIncent(id);

            //map the entity to a incidentforupdatedto
            //apply the udpated field values to that dto
            //map then dto back to entity
            _mapper.Map(incident, incidentFromRepo);
            _safetyLibraryRepository.UpdateIncident(incidentFromRepo);
            _safetyLibraryRepository.Save();
            return NoContent();
        }

        [HttpPatch("{id}")]
        public ActionResult PartiallyUpdateIncident(int id, JsonPatchDocument<IncidentForUpdateDto> patchDocument)
        {
            if (patchDocument == null)
            {
                return BadRequest();
            }

            var incidentFromRepo = _safetyLibraryRepository.GetIncent(id);

            var incidentToPatch = _mapper.Map<IncidentForUpdateDto>(incidentFromRepo); //map incidentFromRepo to IncidentForUpdateDto

            //add validation
            patchDocument.ApplyTo(incidentToPatch, ModelState);

            if (!TryValidateModel(incidentToPatch))
            {
                return ValidationProblem(ModelState);
            };

            _mapper.Map(incidentToPatch, incidentFromRepo);
            _safetyLibraryRepository.UpdateIncident(incidentFromRepo);
            _safetyLibraryRepository.Save();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public ActionResult DeleteIncident(int id)
        {
            var incidentFromRepo = _safetyLibraryRepository.GetIncent(id);

            if (incidentFromRepo == null)
            {
                return NotFound();
            }

            _safetyLibraryRepository.DeleteIncident(incidentFromRepo);
            _safetyLibraryRepository.Save();

            return NoContent();
        }

        [HttpOptions]
        public IActionResult GetIncidentOptions()
        {
            Response.Headers.Add("Allow", "GET,OPTIONS,POST");
            return Ok();
        }

        public override ActionResult ValidationProblem(
            [ActionResultObjectValue] ModelStateDictionary modelStateDictionary)
        {
            var options = HttpContext.RequestServices
                .GetRequiredService<IOptions<ApiBehaviorOptions>>();
            return (ActionResult)options.Value.InvalidModelStateResponseFactory(ControllerContext);
        }

        private string CreateIncidentResourceUri(
            IncidentsResourceParameter incidentResourceParameters,
            ResourceUriType type)
        {
            switch (type)
            {
                case ResourceUriType.PreviousPage:

                    return Url.Link("GetIncents",
                        new
                        {
                            pageNumber = incidentResourceParameters.PageNumber - 1,
                            pageSize = incidentResourceParameters.PageSize,
                            dept = incidentResourceParameters.Dept,
                            searchQuery = incidentResourceParameters.SearchQuery
                        });

                case ResourceUriType.NextPage:

                    return Url.Link("GetIncents",
                        new
                        {
                            pageNumber = incidentResourceParameters.PageNumber + 1,
                            pageSize = incidentResourceParameters.PageSize,
                            dept = incidentResourceParameters.Dept,
                            searchQuery = incidentResourceParameters.SearchQuery
                        });

                default:

                    return Url.Link("GetIncents",
                        new
                        {
                            pageNumber = incidentResourceParameters.PageNumber,
                            pageSize = incidentResourceParameters.PageSize,
                            dept = incidentResourceParameters.Dept,
                            searchQuery = incidentResourceParameters.SearchQuery
                        });
            }
        }
    }
}
