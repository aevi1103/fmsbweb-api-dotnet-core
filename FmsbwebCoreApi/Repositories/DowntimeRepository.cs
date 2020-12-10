using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FmsbwebCoreApi.Context.Iconics;
using FmsbwebCoreApi.Entity.Iconics;
using FmsbwebCoreApi.Repositories.Interfaces;
using FmsbwebCoreApi.ResourceParameters;
using Microsoft.EntityFrameworkCore;

namespace FmsbwebCoreApi.Repositories
{
    public class DowntimeRepository : IDowntimeRepository
    {
        private readonly IconicsContext _context;

        public DowntimeRepository(IconicsContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public IQueryable<KepserverMachineDowntime> GetPlcDowntimeQueryable(PlcDowntimeResourceParameter resourceParameter)
        {
            if (resourceParameter == null) throw new ArgumentNullException(nameof(resourceParameter));

            var qry = _context.KepserverMachineDowntimes
                .AsNoTracking()
                .Where(x => x.TimeStamp >= resourceParameter.StartDate && x.TimeStamp <= resourceParameter.EndDate)
                .Where(x => x.DowntimeMinutes > 0)
                .AsQueryable();

            if (!string.IsNullOrEmpty(resourceParameter.TagName))
                qry = qry.Where(x => x.TagName == resourceParameter.TagName);

            if (!string.IsNullOrEmpty(resourceParameter.Line))
                qry = qry.Where(x => x.TagName.Contains(resourceParameter.Line.ToLower().Trim()));

            return qry;
        }
    }
}
