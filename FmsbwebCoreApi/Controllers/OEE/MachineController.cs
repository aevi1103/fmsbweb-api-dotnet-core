using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FmsbwebCoreApi.Context.FmsbOee;
using Microsoft.AspNet.OData;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FmsbwebCoreApi.Controllers.OEE
{
    [Route("api/[controller]")]
    [ApiController]
    public class MachineController : ControllerBase
    {
        private readonly FmsbOeeContext _context;

        public MachineController(FmsbOeeContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }


        [EnableQuery]
        public IActionResult GetMachines()
        {
            try
            {
                return Ok(_context.Machines.AsNoTracking());
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw new Exception(e.Message);
            }
        }
    }
}
