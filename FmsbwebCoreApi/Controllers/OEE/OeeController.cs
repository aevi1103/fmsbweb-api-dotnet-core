using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FmsbwebCoreApi.Context.Iconics;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FmsbwebCoreApi.Controllers.OEE
{
    [Route("api/[controller]")]
    [ApiController]
    public class OeeController : ControllerBase
    {
        private readonly IconicsContext _context;

        public OeeController(IconicsContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        [HttpGet]
        [Route("groups")]
        public async Task<ActionResult> GetGroups()
        {
            try
            {
                var data = await _context.KepServerTagNameGroups
                    .AsNoTracking()
                    .ToListAsync()
                    .ConfigureAwait(false);

                return Ok(data);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw new Exception(e.Message);
            }
        }

        [HttpGet]
        [Route("groups/{department}")]
        public async Task<ActionResult> GetGroups(string department)
        {
            try
            {
                var data = await _context.KepServerTagNameGroups
                    .Where(x => x.Department.ToLower() == department.ToLower().Trim())
                    .ToListAsync()
                    .ConfigureAwait(false);

                return Ok(data);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw new Exception(e.Message);
            }
        }
    }
}
