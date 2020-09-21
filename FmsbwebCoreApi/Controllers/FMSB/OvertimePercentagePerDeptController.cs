using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FmsbwebCoreApi.Helpers;
using FmsbwebCoreApi.Services.FMSB2;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using FluentDateTime;

namespace FmsbwebCoreApi.Controllers.FMSB
{
    [ApiController]
    [EnableCors]
    [Route("api/fmsb/overtimeperdept")]
    public class OvertimePercentagePerDeptController : Controller
    {
        private readonly IFmsb2LibraryRepository _fmsbLibRepo;
        public OvertimePercentagePerDeptController(IFmsb2LibraryRepository fmsbLibRepo)
        {
            _fmsbLibRepo = fmsbLibRepo ??
                throw new ArgumentNullException(nameof(fmsbLibRepo));
        }


        [HttpGet(Name = "GetOvertimePercentPerDept")]
        [HttpHead]
        public async Task<IActionResult> GetOvertimePercentPerDept(string dept, DateTime start, DateTime end)
        {
            try
            {
                return Ok(await _fmsbLibRepo.GetOvertimePercentage(dept, start, end));
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

        }
    }
}