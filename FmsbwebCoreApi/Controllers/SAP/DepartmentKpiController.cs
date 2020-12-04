using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FmsbwebCoreApi.ResourceParameters.SAP;
using FmsbwebCoreApi.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace FmsbwebCoreApi.Controllers.SAP
{
    [ApiController]
    [Route("api/sap/deptkpi")]
    public class DepartmentKpiController : Controller
    {
        private readonly ISapLibraryService _sapLibRepo;
        public DepartmentKpiController(
            ISapLibraryService sapLibRepo)
        {
            _sapLibRepo = sapLibRepo ??
                throw new ArgumentNullException(nameof(sapLibRepo));
        }

        [HttpGet(Name = "GetDeptKpi")]
        [HttpHead]
        public async Task<IActionResult> GetDeptKpi([FromQuery] SapResourceParameter @params)
        {
            try
            {
                if (@params.Area == "Plant") return Ok(null);

                var data = await _sapLibRepo.GetDepartmentKpi(@params).ConfigureAwait(false);
                return Ok(data);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}