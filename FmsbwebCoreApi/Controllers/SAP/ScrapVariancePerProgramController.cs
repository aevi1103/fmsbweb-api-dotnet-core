using FmsbwebCoreApi.Services.SAP;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FmsbwebCoreApi.Controllers.SAP
{
    [ApiController]
    [EnableCors]
    [Route("api/sap/scrapvarianceperprogram")]
    public class ScrapVariancePerProgramController : ControllerBase
    {
        private readonly ISapLibraryRepository _sapLibRepo;
        public ScrapVariancePerProgramController(
            ISapLibraryRepository sapLibRepo)
        {
            _sapLibRepo = sapLibRepo ??
                throw new ArgumentNullException(nameof(sapLibRepo));
        }

        [HttpGet(Name = "GetScrapVariancePerProgram")]
        [HttpHead]
        public async Task<IActionResult> GetScrapVariancePerProgram(DateTime start, DateTime end, string area = "", 
            bool isPurchasedScrap = false, bool isPlantTotal = false)
        {
            try
            {
                var areas = new List<string> { "Foundry Cell", "Machine Line", "Skirt Coat", "Assembly" };
                if (!isPlantTotal)
                {
                    areas = areas.Where(x => x.ToLower().Trim() == area.ToLower().Trim()).ToList();
                }

                var list = new List<dynamic>();

                foreach (var a in areas)
                {
                    var details = await _sapLibRepo.GetScrapByProgram(start, end, a, isPurchasedScrap);
                    var rec = new
                    {
                        ScrapType = a == "Foundry Cell"
                                        ? "Foundry"
                                        : a == "Machine Line"
                                            ? "Machining"
                                            : a == "Skirt Coat"
                                                ? "Finishing"
                                                : a,
                        Details = details
                    };
                    list.Add(rec);
                }

                return Ok(list);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
            
        }
    }
}
