﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FmsbwebCoreApi.Context.QualityCheckSheets;
using Microsoft.AspNet.OData;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FmsbwebCoreApi.Controllers.QualityCheckSheets
{
    [Route("api/quality/checkSheets/[controller]")]
    [ApiController]
    public class DisplayAsController : ControllerBase
    {
        private readonly QualityCheckSheetsContext _context;

        public DisplayAsController(QualityCheckSheetsContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        [EnableQuery]
        public IActionResult Get()
        {
            return Ok(_context.DisplayAs);
        }
    }
}
