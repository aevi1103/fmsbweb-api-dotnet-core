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
using FmsbwebCoreApi.Services;
using FmsbwebCoreApi.Models;
using Microsoft.Net.Http.Headers;
using System.Dynamic;
using Marvin.Cache.Headers;
using Microsoft.AspNetCore.Cors;

namespace FmsbwebCoreApi.Controllers.Safety
{
    [ApiController]
    [EnableCors]
    [Route("api/safety/incidents")]
    //[ResponseCache(CacheProfileName = "240SecCacheProfile")]
    public class IncidentsController : ControllerBase
    {
        private readonly ISafetyLibraryRepository _safetyLibraryRepository;
        private readonly IMapper _mapper;
        private readonly IPropertyMappingService _propertyMappingService;
        private readonly IPropertyCheckerService _propertyCheckerService;

        public IncidentsController(
            ISafetyLibraryRepository safetyLibraryRepository,
            IMapper mapper,
            IPropertyMappingService propertyMappingService,
            IPropertyCheckerService propertyCheckerService)
        {
            _safetyLibraryRepository = safetyLibraryRepository ??
                throw new ArgumentNullException(nameof(safetyLibraryRepository));

            _mapper = mapper ??
                throw new ArgumentNullException(nameof(mapper));

            _propertyMappingService = propertyMappingService ??
                throw new ArgumentNullException(nameof(propertyMappingService));

            _propertyCheckerService = propertyCheckerService ??
                throw new ArgumentNullException(nameof(propertyCheckerService));

        }

        //list of accept headers
        [Produces(
            "application/json",
            "application/xml",
            "application/vnd.fmsbweb.hateoas+json",
            "application/vnd.fmsbweb.incident.full+json",
            "application/vnd.fmsbweb.incident.full.hateoas+json",
            "application/vnd.fmsbweb.incident.friendly+json",
            "application/vnd.fmsbweb.incident.friendly.hateoas+json"
            )]
        [HttpGet(Name = "GetIncents")]
        [HttpHead]
        //[HttpCacheExpiration(CacheLocation = CacheLocation.Public, MaxAge = 1000)]
        //[HttpCacheValidation(MustRevalidate = false)]
        public IActionResult GetIncents(
            [FromQuery] IncidentsResourceParameter incidentsResourceParameter,
            [FromHeader(Name = "Accept")] string mediaType)
        {
            if (incidentsResourceParameter == null) throw new ArgumentNullException(nameof(incidentsResourceParameter));

            //checks if valid media type
            if (!MediaTypeHeaderValue.TryParse(mediaType, out MediaTypeHeaderValue parsedMediaType))
            {
                return BadRequest();
            }

            if (!_propertyMappingService.ValidMappingExistsFor<IncidentDto, Incidence>(incidentsResourceParameter.OrderBy))
            {
                return BadRequest();
            }

            if (!_propertyCheckerService.TypeHasProperties<IncidentDto>(incidentsResourceParameter.Fields))
            {
                return BadRequest();
            }

            var incidentsFromRepo = _safetyLibraryRepository.GetIncents(incidentsResourceParameter);

            var paginationMetaData = new
            {
                totalCount = incidentsFromRepo.TotalCount,
                pageSize = incidentsFromRepo.PageSize,
                currentPage = incidentsFromRepo.CurrentPage,
                totalPages = incidentsFromRepo.TotalPages
            };

            Response.Headers.Add("X-Pagination",
                JsonSerializer.Serialize(paginationMetaData));

            //check if media type include hateoas
            var includeLinks = parsedMediaType.SubTypeWithoutSuffix.EndsWith("hateoas", StringComparison.InvariantCultureIgnoreCase);
            IEnumerable<LinkDto> links = new List<LinkDto>();

            if (includeLinks)
            {
                links = CreateLinksForIncidents(incidentsResourceParameter, incidentsFromRepo.HasNext, incidentsFromRepo.HasPrevious);
            }

            var primaryMediaType = includeLinks
                ? parsedMediaType.SubTypeWithoutSuffix.Substring(0, parsedMediaType.SubTypeWithoutSuffix.Length - 8) //remove '.hateoas' in the accept header
                : parsedMediaType.SubTypeWithoutSuffix;

            var resourceToReturn = new List<ExpandoObject>();

            //full incidents representation
            if (primaryMediaType == "vnd.fmsbweb.incident.full")
            {
                resourceToReturn = _mapper.Map<IEnumerable<IncidentFullDto>>(incidentsFromRepo).ShapeData(incidentsResourceParameter.Fields).ToList();    
            } else
            {
                resourceToReturn = _mapper.Map<IEnumerable<IncidentDto>>(incidentsFromRepo).ShapeData(incidentsResourceParameter.Fields).ToList();
            }

            if (!includeLinks)
            {
                return Ok(resourceToReturn);
            }
            else
            {
                var resourceToReturnWithLinks = resourceToReturn.Select(incident =>
                {
                    var incidentAsDictionary = incident as IDictionary<string, object>;
                    var incidentLinks = CreateLinksForIncident((int)incidentAsDictionary["Id"], null);
                    incidentAsDictionary.Add("links", incidentLinks);
                    return incidentAsDictionary;
                });

                return Ok(new
                {
                    value = resourceToReturnWithLinks,
                    links
                });
            }


        }

        //list of accept headers
        [Produces(
            "application/json",
            "application/xml",
            "application/vnd.fmsbweb.hateoas+json",
            "application/vnd.fmsbweb.incident.full+json",
            "application/vnd.fmsbweb.incident.full.hateoas+json",
            "application/vnd.fmsbweb.incident.friendly+json",
            "application/vnd.fmsbweb.incident.friendly.hateoas+json"
            )]
        [HttpGet("{id}", Name = "GetIncident")]
        public ActionResult<IncidentDto> GetIncident(int id, string fields, [FromHeader(Name = "Accept")] string mediaType)
        {
            //checks if valid media type
            if (!MediaTypeHeaderValue.TryParse(mediaType, out MediaTypeHeaderValue parsedMediaType))
            {
                return BadRequest();
            }

            var incidentFromRepo = _safetyLibraryRepository.GetIncent(id);
            if (incidentFromRepo == null)
            {
                return NotFound();
            }

            if (!_propertyCheckerService.TypeHasProperties<IncidentDto>(fields))
            {
                return BadRequest();
            }

            //check if media type include hateoas
            var includeLinks = parsedMediaType.SubTypeWithoutSuffix.EndsWith("hateoas", StringComparison.InvariantCultureIgnoreCase);
            IEnumerable<LinkDto> links = new List<LinkDto>();

            if (includeLinks)
            {
                links = CreateLinksForIncident(id, fields); //store links in a variable if harteoas exist
            }

            var primaryMediaType = includeLinks
                ? parsedMediaType.SubTypeWithoutSuffix.Substring(0, parsedMediaType.SubTypeWithoutSuffix.Length - 8) //remove '.hateoas' in the accept header
                : parsedMediaType.SubTypeWithoutSuffix;

            //full incident representation
            if (primaryMediaType == "vnd.fmsbweb.incident.full")
            {
                var fullResourceToReturn = _mapper.Map<IncidentFullDto>(incidentFromRepo).ShapeData(fields) as IDictionary<string, object>;
                if (includeLinks)
                {
                    fullResourceToReturn.Add("links", links);
                }

                return Ok(fullResourceToReturn);
            }

            //friendy representaion
            var friendlyResourceToReturn = _mapper.Map<IncidentDto>(incidentFromRepo).ShapeData(fields) as IDictionary<string, object>;
            if (includeLinks)
            {
                friendlyResourceToReturn.Add("links", links);
            }

            return Ok(friendlyResourceToReturn);

        }

        [HttpPost(Name = "CreateIncident")]
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

            var links = CreateLinksForIncident(incidentToReturn.Id, null);
            var linkedResourceToReturn = incidentToReturn.ShapeData(null) as IDictionary<string, object>;
            linkedResourceToReturn.Add("links", links);

            return CreatedAtRoute("GetIncident", new { id = linkedResourceToReturn["Id"] }, linkedResourceToReturn);
        }

        //PUT updates all fields, so if the client pass a incomplete payload the values will set to its default value
        [HttpPut("{id}", Name = "UpdateIncident")]
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

        [HttpPatch("{id}", Name = "PartiallyUpdateIncident")]
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

        [HttpDelete("{id}", Name = "DeleteIncident")]
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

            var p = incidentResourceParameters;

            switch (type)
            {
                case ResourceUriType.PreviousPage:

                    return Url.Link("GetIncents",
                        new
                        {
                            fields = p.Fields,
                            orderBy = p.OrderBy,
                            pageNumber = p.PageNumber - 1,
                            pageSize = p.PageSize,
                            dept = p.Dept,
                            searchQuery = p.SearchQuery
                        });

                case ResourceUriType.NextPage:

                    return Url.Link("GetIncents",
                        new
                        {
                            fields = p.Fields,
                            orderBy = p.OrderBy,
                            pageNumber = p.PageNumber + 1,
                            pageSize = p.PageSize,
                            dept = p.Dept,
                            searchQuery = p.SearchQuery
                        });

                case ResourceUriType.Current:
                default:

                    return Url.Link("GetIncents",
                        new
                        {

                            orderBy = p.OrderBy,
                            pageNumber = p.PageNumber,
                            pageSize = p.PageSize,
                            dept = p.Dept,
                            searchQuery = p.SearchQuery
                        });
            }
        }

        private IEnumerable<LinkDto> CreateLinksForIncident(int id, string fields)
        {
            var links = new List<LinkDto>();

            if (string.IsNullOrWhiteSpace(fields))
            {
                links.Add(
                    new LinkDto(Url.Link("GetIncident", new { id }),
                    "self",
                    "GET"
                    ));
            }
            else
            {
                links.Add(
                    new LinkDto(Url.Link("GetIncident", new { id, fields }),
                    "self",
                    "GET"
                    ));
            }

            links.Add(
                new LinkDto(Url.Link("UpdateIncident", new { id }),
                "update_incident",
                "PUT"
                ));

            links.Add(
                new LinkDto(Url.Link("PartiallyUpdateIncident", new { id }),
                "partially_update_incident",
                "PATCH"
                ));

            links.Add(
                new LinkDto(Url.Link("DeleteIncident", new { id }),
                "delete_incident",
                "DELETE"
                ));


            links.Add(
                new LinkDto(Url.Link("CreateAttachmentForIncident", new { id }),
                "add_attachment_for_incident",
                "POST"
                ));

            links.Add(
                new LinkDto(Url.Link("GetAtachmentsForIncident", new { id }),
                "get_attachments_for_incident",
                "GET"
                ));

            return links;
        }

        private IEnumerable<LinkDto> CreateLinksForIncidents(IncidentsResourceParameter incidentResourceParameters, bool hasNext, bool hasPrevious)
        {
            var links = new List<LinkDto>
            {
                //self
                new LinkDto(CreateIncidentResourceUri(incidentResourceParameters, ResourceUriType.Current),
                "self",
                "GET"
                )
            };

            if (hasNext)
            {
                links.Add(
                    new LinkDto(CreateIncidentResourceUri(incidentResourceParameters, ResourceUriType.NextPage),
                    "next_page",
                    "GET"
                    ));
            }


            if (hasPrevious)
            {
                links.Add(
                    new LinkDto(CreateIncidentResourceUri(incidentResourceParameters, ResourceUriType.PreviousPage),
                    "previous_page",
                    "GET"
                    ));
            }

            return links;
        }
    }
}
