using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FmsbwebCoreApi.Entity.QualityCheckSheets;
using FmsbwebCoreApi.Models.QualityCheckSheets;
using FmsbwebCoreApi.Services.Interfaces.QualityCheckSheets;
using Microsoft.AspNet.OData;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FmsbwebCoreApi.Controllers.QualityCheckSheets
{
    [Route("api/quality/checkSheets/[controller]")]
    [ApiController]
    public class CheckSheetController : ControllerBase
    {
        private readonly ICheckSheetService _service;

        public CheckSheetController(ICheckSheetService service)
        {
            _service = service ?? throw new ArgumentNullException(nameof(service));
        }

        [EnableQuery(MaxExpansionDepth = 10)]
        public IActionResult Get()
        {
            return Ok(_service.Query());
        }

        [Route("{id}")]
        [EnableQuery]
        public IActionResult Get(int id)
        {
            return Ok(_service.Query(id));
        }

        [HttpPost]
        public async Task<IActionResult> Login(CheckSheetDto data)
        {
            if (data == null)
                return BadRequest();

            try
            {
                var result = await _service.Login(data).ConfigureAwait(false);
                return Ok(result);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}
