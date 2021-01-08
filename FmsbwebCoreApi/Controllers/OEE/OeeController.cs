using System;
using System.Collections.Generic;
using System.IO.Packaging;
using System.Linq;
using System.Threading.Tasks;
using FmsbwebCoreApi.Context.FmsbOee;
using FmsbwebCoreApi.Context.Iconics;
using FmsbwebCoreApi.Entity.FmsbOee;
using FmsbwebCoreApi.Hubs.Counter;
using FmsbwebCoreApi.Hubs.Downtime;
using FmsbwebCoreApi.Hubs.Scrap;
using FmsbwebCoreApi.ResourceParameters;
using FmsbwebCoreApi.Services.Interfaces;
using Microsoft.AspNet.OData;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;

namespace FmsbwebCoreApi.Controllers.OEE
{
    [Route("api/[controller]")]
    [ApiController]
    public class OeeController : ControllerBase
    {
        private readonly FmsbOeeContext _context;
        private readonly IOeeService _oeeService;

        public OeeController(FmsbOeeContext context, IOeeService oeeService)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
            _oeeService = oeeService ?? throw new ArgumentNullException(nameof(oeeService));
        }

        [EnableQuery]
        [Route("lines")]
        public IActionResult GetGroups()
        {
            try
            {
                return Ok(_context.Lines.AsNoTracking());
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw new Exception(e.Message);
            }
        }

        [EnableQuery]
        [Route("lines/{id}")]
        public IActionResult GetGroups(Guid id)
        {
            try
            {
                return Ok(_context
                    .Lines
                    .Include(x => x.MachineGroups)
                    .AsNoTracking()
                    .FirstOrDefault(x => x.LineId == id));
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw new Exception(e.Message);
            }
        }

        private async Task AddClockNumber(Guid oeeId, int clockNumber)
        {
            await _context.ClockNumbers.AddAsync(new ClockNumber
            {
                OeeId = oeeId,
                Clock = clockNumber,
                DateModified = DateTime.Now
            }).ConfigureAwait(false);

            await _context.SaveChangesAsync().ConfigureAwait(false);
        }

        /*
         * Need to pass timestamp value when updating to prevent concurrency exception
         */
        [HttpPost]
        public async Task<IActionResult> Update(OeeResourceParameter resourceParameter)
        {
            if (resourceParameter == null) return BadRequest(new ArgumentException("Resource parameter is empty!"));
            try
            {
                var entity = await UpdateEntry(resourceParameter).ConfigureAwait(false);
                var oee = await _oeeService.GetOee(entity.LineId).ConfigureAwait(false);
                return Ok(oee);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }


        [EnableQuery]
        public IActionResult Get()
        {
            try
            {
                return Ok(_context.Oee.Include(x => x.Line).AsNoTracking());
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw new Exception(e.Message);
            }
        }

        [Route("summary")]
        [HttpGet]
        public async Task<IActionResult> GetSummary([FromQuery] Guid lineId)
        {
            try
            {
                var oee = await _oeeService.GetOee(lineId).ConfigureAwait(false);
                return Ok(oee);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        private async Task<Oee> UpdateEntry(OeeResourceParameter resourceParameter)
        {
            if (resourceParameter == null) throw new ArgumentNullException(nameof(resourceParameter));

            await using var transaction = await _context.Database.BeginTransactionAsync().ConfigureAwait(false);
            try
            {
                var record = _context.Oee.Update(new Oee
                {
                    LineId = resourceParameter.LineId,
                    OeeId = new Guid(resourceParameter.OeeId.ToString()),
                    Timestamp = resourceParameter.Timestamp,
                    EndDateTime = resourceParameter.EndDateTime,
                    DateModified = DateTime.Now
                });

                await _context.SaveChangesAsync().ConfigureAwait(false);

                if (resourceParameter.OeeId == Guid.Empty)
                    await AddClockNumber(record.Entity.OeeId, resourceParameter.ClockNumber).ConfigureAwait(false);

                await transaction.CommitAsync().ConfigureAwait(false);

                return record.Entity;
            }
            catch (Exception e)
            {
                await transaction.RollbackAsync().ConfigureAwait(false);
                throw new Exception(e.Message);
            }
        }

    }
}
