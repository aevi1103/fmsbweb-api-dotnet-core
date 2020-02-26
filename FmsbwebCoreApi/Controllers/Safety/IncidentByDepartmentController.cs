using AutoMapper;
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
    [Route("api/safety/incidentbydepartment")]
    public class IncidentByDepartmentController : ControllerBase
    {
        private readonly ISafetyLibraryRepository _safetyLibraryRepository;

        public IncidentByDepartmentController(
            ISafetyLibraryRepository safetyLibraryRepository)
        {
            _safetyLibraryRepository = safetyLibraryRepository ??
                throw new ArgumentNullException(nameof(safetyLibraryRepository));
        }

        [HttpGet(Name = "GetIncidentByDepartment")]
        [HttpHead]
        public IActionResult GetIncidentByDepartment(
            [FromQuery] IncidentByDepartmentResouceParameter resourceparameter)
        {
            if (resourceparameter == null)
            {
                return BadRequest();
            }

            var incidentByDepartment = _safetyLibraryRepository.GetIncidedentsByDepartment(
                                            resourceparameter.Start, resourceparameter.End);

            return Ok(incidentByDepartment);
        }
    }
}
