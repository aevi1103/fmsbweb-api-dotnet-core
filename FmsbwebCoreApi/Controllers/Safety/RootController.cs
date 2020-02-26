using FmsbwebCoreApi.Models;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FmsbwebCoreApi.Controllers.Safety
{
    [ApiController]
    [EnableCors]
    [Route("api/safety")]
    public class RootController : ControllerBase
    {
        [HttpGet(Name = "GetRoot")]
        public IActionResult GetRoot()
        {
            var links = new List<LinkDto>();

            links.Add(
                new LinkDto(Url.Link("GetRoot", new { }),
                "self",
                "GET"
                ));

            links.Add(
                new LinkDto(Url.Link("GetIncents", new { }),
                "get_incidents",
                "GET"
                ));

            links.Add(
                new LinkDto(Url.Link("CreateIncident", new { }),
                "add_incident",
                "POST"
                ));

            return Ok(links);
        }
    }
}
