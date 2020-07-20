using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using FmsbwebCoreApi.Services.Interfaces;

namespace FmsbwebCoreApi.Controllers.SAP
{
    [ApiController]
    [Route("api/sap/workcenters")]
    public class MachineMappingController : ControllerBase
    {
        private readonly ISapLibraryService _sapLibRepo;

        public MachineMappingController(ISapLibraryService sapLibRepo)
        {
            _sapLibRepo = sapLibRepo ??
                throw new ArgumentNullException(nameof(sapLibRepo));
        }

        public async Task<IActionResult> GetWorkCenters(string area)
        {
            if (string.IsNullOrEmpty(area)) return BadRequest();
            var result = await _sapLibRepo.GetWorkCentersByDept(area).ConfigureAwait(false);
            return Ok(result);
        }
    }
}
