﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FmsbwebCoreApi.Context.Intranet;
using FmsbwebCoreApi.Entity.Intranet;
using Microsoft.AspNet.OData;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FmsbwebCoreApi.Controllers.Machining
{
    [Route("api/machining/[controller]")]
    [ApiController]
    public class OperatorJobController : ControllerBase
    {
        private readonly IntranetContext _context;

        public OperatorJobController(IntranetContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        [EnableQuery]
        public IActionResult Get()
        {
            return Ok(_context.OperatorJobs);
        }

        [HttpPost]
        public async Task<IActionResult> Post(OperatorJob data)
        {
            if (data == null)
                return BadRequest();

            try
            {
                _context.OperatorJobs.Update(data);
                await _context.SaveChangesAsync();
                return Ok(data);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}
