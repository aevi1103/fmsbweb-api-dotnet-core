using AutoMapper;
using FmsbwebCoreApi.Helpers;
using FmsbwebCoreApi.Models.Safety.Incident;
using FmsbwebCoreApi.ResourceParameters.Safety;
using FmsbwebCoreApi.Services;
using FmsbwebCoreApi.Services.Safety;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FmsbwebCoreApi.Controllers.Safety
{
    [ApiController]
    [EnableCors]
    [Route("api/safety/monthlyincidentrate")]
    public class MonthlyIncidentRateController : ControllerBase
    {
        private readonly ISafetyLibraryRepository _safetyLibraryRepository;

        public MonthlyIncidentRateController(
            ISafetyLibraryRepository safetyLibraryRepository)
        {
            _safetyLibraryRepository = safetyLibraryRepository ??
                throw new ArgumentNullException(nameof(safetyLibraryRepository));
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
