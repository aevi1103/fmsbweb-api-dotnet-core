using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FmsbwebCoreApi.Context.Intranet;
using Microsoft.AspNet.OData;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FmsbwebCoreApi.Controllers.Machining
{
    [Route("api/machining/[controller]")]
    [ApiController]
    public class EosController : ControllerBase
    {
        private readonly IntranetContext _context;

        public EosController(IntranetContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        [EnableQuery]
        public IActionResult Get()
        {
            return Ok(_context.EolvsEos);
        }

        [Route("{id}")]
        [EnableQuery]
        public IActionResult Get(int id)
        {
            var result = _context.EolvsEos
                                    .Include(x => x.EolManning)
                                    .FirstOrDefault(x => x.EolvsEosId == id);
            if (result == null) return BadRequest("No data available");
            return Ok(result);
        }
    }
}
