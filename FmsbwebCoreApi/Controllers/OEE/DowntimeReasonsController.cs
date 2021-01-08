using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FmsbwebCoreApi.Context.FmsbOee;
using FmsbwebCoreApi.Entity.FmsbOee;
using FmsbwebCoreApi.Enums;
using FmsbwebCoreApi.ResourceParameters;
using Microsoft.AspNet.OData;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FmsbwebCoreApi.Controllers.OEE
{
    [Route("api/[controller]")]
    [ApiController]
    public class DowntimeReasonsController : ControllerBase
    {
        private readonly FmsbOeeContext _context;

        public DowntimeReasonsController(FmsbOeeContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        [EnableQuery]
        [Route("primary")]
        public IActionResult GetPrimaryReason()
        {
            try
            {
                return Ok(_context.PrimaryReasons.AsNoTracking());
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw new Exception(e.Message);
            }
        }

        [EnableQuery]
        [Route("secondary")]
        public IActionResult GetSecondaryReason()
        {
            try
            {
                return Ok(_context.SecondaryReasons.AsNoTracking());
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw new Exception(e.Message);
            }
        }

        [EnableQuery]
        public IActionResult GetList()
        {
            try
            {
                return Ok(_context
                    .DowntimeEvents
                    .Include(x => x.Machine)
                    .Include(x => x.Machine.MachineGroup)
                    .Include(x => x.SecondaryReason.PrimaryReason)
                    .Include(x => x.SecondaryReason)
                    .Include(x => x.Oee)
                    .AsNoTracking());
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw new Exception(e.Message);
            }
        }

        [HttpPost]
        public async Task<IActionResult> Update(DowntimeInputResourceParameter resourceParameter)
        {
            if (resourceParameter == null) throw new ArgumentNullException(nameof(resourceParameter));

            await using var transaction = await _context.Database.BeginTransactionAsync().ConfigureAwait(false);
            try
            {
                var record = _context.DowntimeEvents.Update(new DowntimeEvent
                {
                    DowntimeEventId = resourceParameter.DowntimeId,
                    DowntimeEventType = resourceParameter.PlannedDowntime ? DowntimeEventType.Planned : DowntimeEventType.Unplanned,
                    MachineId = resourceParameter.MachineId,
                    SecondaryReasonId = resourceParameter.SecondaryReasonId,
                    Downtime = resourceParameter.Downtime,
                    Comment = resourceParameter.Comment,
                    DateModified = DateTime.Now,
                    OeeId = resourceParameter.OeeId,
                    Timestamp = resourceParameter.Timestamp
                });

                await _context.SaveChangesAsync().ConfigureAwait(false);
                await transaction.CommitAsync().ConfigureAwait(false);

                return Ok(record.Entity);
            }
            catch (Exception e)
            {
                await transaction.RollbackAsync().ConfigureAwait(false);
                throw new Exception(e.Message);
            }
        }

        [HttpDelete]
        [Route("{id}")]
        public async Task<IActionResult> Delete(Guid id, [FromQuery] byte[] timestamp)
        {

            await using var transaction = await _context.Database.BeginTransactionAsync().ConfigureAwait(false);
            try
            {
                var record = _context.DowntimeEvents.Remove(new DowntimeEvent
                {
                    DowntimeEventId = id,
                    Timestamp = timestamp
                });

                await _context.SaveChangesAsync().ConfigureAwait(false);
                await transaction.CommitAsync().ConfigureAwait(false);

                return Ok(record.Entity);
            }
            catch (Exception e)
            {
                await transaction.RollbackAsync().ConfigureAwait(false);
                throw new Exception(e.Message);
            }
        }
    }
}
