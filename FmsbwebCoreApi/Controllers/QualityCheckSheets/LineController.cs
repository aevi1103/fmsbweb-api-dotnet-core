using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FmsbwebCoreApi.Context.QualityCheckSheets;
using Microsoft.AspNet.OData;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FmsbwebCoreApi.Controllers.QualityCheckSheets
{
    [Route("api/quality/checkSheets/[controller]")]
    [ApiController]
    public class LineController : ControllerBase
    {
        private readonly QualityCheckSheetsContext _context;

        public LineController(QualityCheckSheetsContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        [EnableQuery]
        public IActionResult Get()
        {
            return Ok(_context.Lines.Include(x => x.Machines));
        }
    }
}
