using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FmsbwebCoreApi.ResourceParameters.SAP;
using FmsbwebCoreApi.Services.SAP;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace FmsbwebCoreApi.Controllers.SAP
{
    [ApiController]
    [EnableCors]
    [Route("api/sap/dailyscrapbycodebyshift")]
    public class DailyScrapByCodeByShiftController : Controller
    {
        private readonly ISapLibraryRepository _sapLibRepo;
        public DailyScrapByCodeByShiftController(
            ISapLibraryRepository sapLibRepo)
        {
            _sapLibRepo = sapLibRepo ??
                throw new ArgumentNullException(nameof(sapLibRepo));
        }

        [HttpGet(Name = "GetDailyScrapByCodeByShift")]
        [HttpHead]
        public async Task<IActionResult> GetDailyScrapByCodeByShift([FromQuery] DailyScrapByCodeByShiftResourceParameter resourceParameter)
        {

            resourceParameter = resourceParameter ?? throw new ArgumentNullException(nameof(resourceParameter));

            var data = await _sapLibRepo.GetDailyScrapByCodeByShift(resourceParameter.Start, resourceParameter.End, resourceParameter.ScrapCode,
                resourceParameter.IsPurchasedScrap, resourceParameter.IsTotalScrap).ConfigureAwait(false);

            return Ok(data);
        }
    }
}