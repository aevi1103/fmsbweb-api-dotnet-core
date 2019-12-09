using AutoMapper;
using FmsbwebCoreApi.Helpers;
using FmsbwebCoreApi.Models.Safety.Incident;
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
    [Route("api/safety/monthlyincidentrate")]
    public class MonthlyIncidentRateController : ControllerBase
    {
        private readonly ISafetyLibraryRepository _safetyLibraryRepository;
        private readonly IMapper _mapper;
        private readonly IPropertyMappingService _propertyMappingService;
        private readonly IPropertyCheckerService _propertyCheckerService;

        public MonthlyIncidentRateController(
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

        [HttpGet(Name = "GetMonthlyIncidentRate")]
        [HttpHead]
        public IActionResult GetMonthlyIncidentRate(
            [FromQuery] MonthlyIncidentResouceParameter resourceparameter)
        {
            var monthlyIncidentsFromRepo = _safetyLibraryRepository.GetMonthlyIncidentRate(
                                            resourceparameter.Start, resourceparameter.End).ToList();

            var ytd = new MonthlyIncidentRateDto
            {
                MonthNumber = 13,
                Month = "YTD",
                NumberOfRecordable = monthlyIncidentsFromRepo.Sum(x => x.NumberOfRecordable),
                ManHours = monthlyIncidentsFromRepo.Sum(x => x.ManHours),
                IncidentRate = new SafetyFormula().CalculateIncidentRates(
                                            monthlyIncidentsFromRepo.Sum(x => x.NumberOfRecordable),
                                            monthlyIncidentsFromRepo.Sum(x => x.ManHours))
            };

            monthlyIncidentsFromRepo.Add(ytd);

            return Ok(monthlyIncidentsFromRepo);
        }
    }
}
