﻿using FmsbwebCoreApi.ResourceParameters.SAP;
using FmsbwebCoreApi.Services.SAP;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FmsbwebCoreApi.Controllers.SAP
{
    [ApiController]
    [Route("api/sap/departmentdetails")]
    public class DepartmentDetailsController : ControllerBase
    {
        private readonly ISapLibraryRepository _sapLibRepo;
        public DepartmentDetailsController(
            ISapLibraryRepository sapLibRepo)
        {
            _sapLibRepo = sapLibRepo ??
                throw new ArgumentNullException(nameof(sapLibRepo));
        }

        [HttpGet(Name = "GetDepartmentDetails")]
        [HttpHead]
        public async Task<IActionResult> GetDepartmentDetails(
            [FromQuery] SapResouceParameter resourceParameter)
        {
            if (resourceParameter == null)
            {
                return BadRequest();
            }

            var prodData = await _sapLibRepo.GetDepartmentDetails(
                                    resourceParameter.Start,
                                    resourceParameter.End,
                                    resourceParameter.Area);

            return Ok(prodData);
        }
    }
}