using FmsbwebCoreApi.ResourceParameters.SAP;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using FmsbwebCoreApi.Services.Interfaces;

namespace FmsbwebCoreApi.Controllers.SAP
{
    [ApiController]
    [EnableCors]
    [Route("api/sap/departmentdetails")]
    public class DepartmentDetailsController : ControllerBase
    {
        private readonly IKpiService _kpiService;
        public DepartmentDetailsController(IKpiService kpiService)
        {
            _kpiService = kpiService ?? throw new ArgumentNullException(nameof(kpiService));
        }

        [HttpGet(Name = "GetDepartmentDetails")]
        [HttpHead]
        public async Task<IActionResult> GetDepartmentDetails(
            [FromQuery] SapResouceParameter resourceParameter)
        {
            if (resourceParameter == null)
            {
                return BadRequest();
            }

            var prodData = await _kpiService.GetDepartmentDetails(
                                    resourceParameter.Start,
                                    resourceParameter.End,
                                    resourceParameter.Area).ConfigureAwait(false);

            return Ok(prodData);
        }
    }
}
