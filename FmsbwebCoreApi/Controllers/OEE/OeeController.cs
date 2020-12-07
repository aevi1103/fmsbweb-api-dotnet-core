using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FmsbwebCoreApi.Context.Iconics;
using FmsbwebCoreApi.Hubs.Counter;
using FmsbwebCoreApi.Hubs.Downtime;
using FmsbwebCoreApi.Hubs.Scrap;
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
        private readonly IconicsContext _context;
        private readonly IHubContext<CounterHub> _counterHubContext;
        private readonly IHubContext<ScrapHub> _scrapHubContext;
        private readonly IHubContext<DowntimeHub> _downtimeHubContext;

        public OeeController(
            IconicsContext context,
            IHubContext<CounterHub> counterHubContext,
            IHubContext<ScrapHub> scrapHubContext,
            IHubContext<DowntimeHub> downtimeHubContext)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
            _counterHubContext = counterHubContext ?? throw new ArgumentNullException(nameof(counterHubContext));
            _scrapHubContext = scrapHubContext ?? throw new ArgumentNullException(nameof(scrapHubContext));
            _downtimeHubContext = downtimeHubContext ?? throw new ArgumentNullException(nameof(downtimeHubContext));
        }

        [HttpGet]
        [Route("groups")]
        public async Task<ActionResult> GetGroups()
        {
            try
            {
                var data = await _context.KepServerTagNameGroups
                    .AsNoTracking()
                    .ToListAsync()
                    .ConfigureAwait(false);

                return Ok(data);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw new Exception(e.Message);
            }
        }

        [HttpGet]
        [Route("groups/{department}")]
        public async Task<ActionResult> GetGroups(string department)
        {
            try
            {
                var data = await _context.KepServerTagNameGroups
                    .Where(x => x.Department.ToLower() == department.ToLower().Trim())
                    .OrderBy(x => x.GroupName)
                    .ToListAsync()
                    .ConfigureAwait(false);

                return Ok(data);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw new Exception(e.Message);
            }
        }

        [HttpGet]
        [Route("group/{guid}")] 
        public async Task<ActionResult> GetGroup(Guid guid)
        {
            try
            {
                var data = await _context.KepServerTagNameGroups
                    .FirstOrDefaultAsync(x => x.KepServerTagNameGroupId == guid)
                    .ConfigureAwait(false);

                //await AddToGroup(data.TagName, Guid.NewGuid().ToString()).ConfigureAwait(false);

                return Ok(data);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw new Exception(e.Message);
            }
        }


    }
}
