using AutoMapper;
using FmsbwebCoreApi.ResourceParameters.Safety;
using FmsbwebCoreApi.Services;
using FmsbwebCoreApi.Services.Safety;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FmsbwebCoreApi.Controllers.Safety
{
    [ApiController]
    [Route("api/safety/incidentbydepartment")]
    public class IncidentByDepartmentController : ControllerBase
    {
        private readonly ISafetyLibraryRepository _safetyLibraryRepository;
        private readonly IMapper _mapper;
        private readonly IPropertyMappingService _propertyMappingService;
        private readonly IPropertyCheckerService _propertyCheckerService;

        public IncidentByDepartmentController(
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

        [HttpGet(Name = "GetIncidentByDepartment")]
        [HttpHead]
        public IActionResult GetIncidentByDepartment(
            [FromQuery] IncidentByDepartmentResouceParameter resourceparameter)
        {
            var incidentByDepartment = _safetyLibraryRepository.GetIncidedentsByDepartment(
                                            resourceparameter.Start, resourceparameter.End);

            return Ok(incidentByDepartment);
        }
    }
}
