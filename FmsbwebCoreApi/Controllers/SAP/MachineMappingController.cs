using FmsbwebCoreApi.Services.SAP;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace FmsbwebCoreApi.Controllers.SAP
{
    [ApiController]
    [Route("api/sap/workcenters")]
    public class MachineMappingController : ControllerBase
    {
        private readonly ISapLibraryRepository _sapLibRepo;

        public MachineMappingController(ISapLibraryRepository sapLibRepo)
        {
            _sapLibRepo = sapLibRepo ??
                throw new ArgumentNullException(nameof(sapLibRepo));
        }

        public async Task<IActionResult> GetWorkCenters(string area)
        {
            if (string.IsNullOrEmpty(area)) return BadRequest();
            var result = await _sapLibRepo.GetWorkcentersByDept(area).ConfigureAwait(false);
            return Ok(result);
        }
    }
}
