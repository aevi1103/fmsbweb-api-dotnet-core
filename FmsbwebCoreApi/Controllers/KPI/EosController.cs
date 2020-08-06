using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FmsbwebCoreApi.Entity.Fmsb2;
using FmsbwebCoreApi.Entity.FmsbMvc;
using FmsbwebCoreApi.Models;
using FmsbwebCoreApi.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FmsbwebCoreApi.Controllers.KPI
{
    [Route("api/kpi/[controller]")]
    [ApiController]
    public class EosController : ControllerBase
    {
        private readonly IKpiService _kpiService;
        private readonly IEndOfShiftReportService _endOfShiftReportService;

        public EosController(IKpiService kpiService, IEndOfShiftReportService endOfShiftReportService)
        {
            _kpiService = kpiService ?? throw new ArgumentNullException(nameof(kpiService));
            _endOfShiftReportService = endOfShiftReportService ?? throw new ArgumentNullException(nameof(endOfShiftReportService));
        }

        [HttpGet("{line}",Name = "GetEosData")]
        public async Task<IActionResult> GetEosData(string line, string dept, DateTime shiftDate, string shift)
        {
            try
            {
                var result = await _kpiService.GetEndOfShiftDto(line, dept, shiftDate, shift).ConfigureAwait(false);
                return Ok(result);
            }
            catch (OperationCanceledException e)
            {
                return BadRequest(e.Message);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpGet(Name = "GetEos")]
        public async Task<IActionResult> GetEos(string dept, DateTime shiftDate, string shift)
        {
            try
            {
                var data = await _kpiService.GetEndOfShiftListDto(dept, shiftDate, shift).ConfigureAwait(false);
                var total = await _kpiService.GetOverallEosTotal(data, dept, shiftDate, shift).ConfigureAwait(false);

                return Ok(new
                {
                    data,
                    total
                });
            }
            catch (OperationCanceledException e)
            {
                return BadRequest(e.Message);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPost(Name = "AddOrUpdate")]
        public async Task<IActionResult> AddOrUpdate(EndOfShiftReport data)
        {
            if (data == null) return BadRequest();

            try
            {
                var result = await _endOfShiftReportService.AddOrUpdate(data).ConfigureAwait(false);
                return Ok(result);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }

        }

        [HttpPut(Name = "UpdateEos")]
        public async Task<IActionResult> UpdateEos(EndOfShiftReport data)
        {
            if (data == null) return BadRequest();

            try
            {
                var result = await _endOfShiftReportService.UpdateEos(data).ConfigureAwait(false);
                return Ok(result);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }

        }

        [HttpDelete("{id}", Name = "DeleteEos")]
        public async Task<IActionResult> DeleteEos(int id)
        {
            try
            {
                await _endOfShiftReportService.DeleteEos(id).ConfigureAwait(false);
                return Ok(true);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }

        }
    }
}
