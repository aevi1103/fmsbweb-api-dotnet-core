using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FmsbwebCoreApi.Services.SAP;
using Microsoft.AspNetCore.Mvc;

namespace FmsbwebCoreApi.Controllers.SAP
{
    [ApiController]
    [Route("api/sap/deptkpi")]
    public class DepartmentKpiController : Controller
    {
        private readonly ISapLibraryRepository _sapLibRepo;
        public DepartmentKpiController(
            ISapLibraryRepository sapLibRepo)
        {
            _sapLibRepo = sapLibRepo ??
                throw new ArgumentNullException(nameof(sapLibRepo));
        }

        [HttpGet(Name = "GetDeptKpi")]
        [HttpHead]
        public async Task<IActionResult> GetDeptKpi(DateTime start, DateTime end, string area)
        {
            try
            {
                var data = await _sapLibRepo.GetDepartmentKpi(start, end, area).ConfigureAwait(false);
                return Ok(data);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}