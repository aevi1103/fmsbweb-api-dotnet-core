using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FmsbwebCoreApi.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FmsbwebCoreApi.Controllers.KPI
{
    [Route("api/kpi/[controller]")]
    [ApiController]
    public class EosEmailController : ControllerBase
    {
        private readonly IKpiService _kpiService;


        public EosEmailController(IKpiService kpiService)
        {
            _kpiService = kpiService ?? throw new ArgumentNullException(nameof(kpiService));
        }

        private string EosErrorMsg(string dept) =>
            $"No data available for {dept} department, Please enter data before sending the EOS report!";

        [HttpGet(Name = "SendEosReport")]
        public async Task<IActionResult> SendEosReport(string dept, DateTime shiftDate, string shift)
        {
            try
            {
                dept = dept.ToLower();
                if (dept != "anodize" && dept != "skirt coat" && dept != "assembly")
                    return Ok(await _kpiService.SendEosReport(dept, shiftDate, shift).ConfigureAwait(false));

                var anodize = await _kpiService.GetEndOfShiftListDto("Anodize", shiftDate, shift).ConfigureAwait(false);
                var sc = await _kpiService.GetEndOfShiftListDto("Skirt Coat", shiftDate, shift).ConfigureAwait(false);
                var assembly = await _kpiService.GetEndOfShiftListDto("Assembly", shiftDate, shift).ConfigureAwait(false);

                //if (!anodize.Any()) throw new OperationCanceledException(EosErrorMsg("Anodize"));
                //if (!sc.Any()) throw new OperationCanceledException(EosErrorMsg("Skirt Coat"));
                if (!assembly.Any()) throw new OperationCanceledException(EosErrorMsg("Assembly"));

                if (anodize.Any())
                {
                    await _kpiService.SendEosReport(anodize, "Anodize", shiftDate, shift).ConfigureAwait(false);
                }

                if (sc.Any())
                {
                    await _kpiService.SendEosReport(sc, "Skirt Coat", shiftDate, shift).ConfigureAwait(false);
                }

                if (assembly.Any())
                {
                    await _kpiService.SendEosReport(assembly, "Assembly", shiftDate, shift).ConfigureAwait(false);
                }

                return Ok(true);

            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}
