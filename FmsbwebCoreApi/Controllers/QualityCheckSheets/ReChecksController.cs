using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FmsbwebCoreApi.Entity.QualityCheckSheets;
using FmsbwebCoreApi.Services.Interfaces.QualityCheckSheets;
using FmsbwebCoreApi.Services.QualityCheckSheets;
using Microsoft.AspNet.OData;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FmsbwebCoreApi.Controllers.QualityCheckSheets
{
    [Route("api/quality/checkSheets/[controller]")]
    [ApiController]
    public class ReChecksController : ControllerBase
    {
        private readonly IReCheckService _service;

        public ReChecksController(IReCheckService service)
        {
            _service = service ?? throw new ArgumentNullException(nameof(service));
        }
        [EnableQuery]
        public IActionResult Get()
        {
            return Ok(_service.Query());
        }

        [HttpPost]
        public async Task<IActionResult> Post(ReCheck data)
        {
            if (data == null)
                return BadRequest();

            try
            {
                var result = await _service.Update(data);
                return Ok(result);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}
