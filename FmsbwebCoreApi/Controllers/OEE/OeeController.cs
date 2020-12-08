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

        public OeeController(FmsbOeeContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        [EnableQuery]
        [Route("lines")]
        public IActionResult GetGroups()
        {
            try
            {
                return Ok(_context.OeeLines.AsNoTracking());
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
                return Ok(_context.OeeLines.AsNoTracking().FirstOrDefault(x => x.OeeLineId == id));
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw new Exception(e.Message);
            }
        }

        /*
         * Need to pass timestamp value when updating to prevent concurrency exception
         */
        [HttpPost]
        public async Task<IActionResult> Update(OeeResourceParameter resourceParameter)
        {
            if (resourceParameter == null) return BadRequest(new ArgumentException("Resource parameter is empty!"));

            await using var transaction = await _context.Database.BeginTransactionAsync().ConfigureAwait(false);
            try
            {
                var record = _context.Oee.Update(new Oee
                {
                    OeeLineId = resourceParameter.OeeLineId,
                    OeeId = resourceParameter.OeeId == null ? Guid.Empty : new Guid(resourceParameter.OeeId.ToString()),
                    Timestamp = resourceParameter.Timestamp,
                    EndDateTime = resourceParameter.EndDateTime,
                    DateModified = DateTime.Now
                });

                await _context.SaveChangesAsync().ConfigureAwait(false);
                await transaction.CommitAsync().ConfigureAwait(false);

                var entity = await _context.Oee
                    .Include(x => x.OeeLine)
                    .FirstOrDefaultAsync(x => x.OeeLineId == record.Entity.OeeLineId && x.EndDateTime == null)
                    .ConfigureAwait(false);

                return Ok(entity);
            }
            catch (Exception e)
            {
                await transaction.RollbackAsync().ConfigureAwait(false);
                return BadRequest(e.Message);
            }
        }


        [EnableQuery]
        public IActionResult Get()
        {
            try
            {
                return Ok(_context.Oee.Include(x => x.OeeLine).AsNoTracking());
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw new Exception(e.Message);
            }
        }

    }
}
