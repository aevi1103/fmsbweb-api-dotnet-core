using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FmsbwebCoreApi.Context.FmsbOee;
using FmsbwebCoreApi.Context.Iconics;
using FmsbwebCoreApi.Entity.FmsbOee;
using FmsbwebCoreApi.Entity.Iconics;
using FmsbwebCoreApi.Enums;
using FmsbwebCoreApi.Repositories.Interfaces;
using FmsbwebCoreApi.ResourceParameters;
using Microsoft.EntityFrameworkCore;

namespace FmsbwebCoreApi.Repositories
{
    public class DowntimeRepository : IDowntimeRepository
    {
        private readonly IconicsContext _context;
        private readonly FmsbOeeContext _fmsbOeeContext;

        public DowntimeRepository(IconicsContext context, FmsbOeeContext fmsbOeeContext)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
            _fmsbOeeContext = fmsbOeeContext ?? throw new ArgumentNullException(nameof(fmsbOeeContext));
        }

        public IQueryable<KepserverMachineDowntime> GetPlcDowntimeQueryable(DowntimeResourceParameter resourceParameter)
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

        public IQueryable<DowntimeEvent> GetDowntimeEvents(DowntimeResourceParameter resourceParameter)
        {
            if (resourceParameter == null) throw new ArgumentNullException(nameof(resourceParameter));

            var qry = _fmsbOeeContext
                .DowntimeEvents
                .AsNoTracking()
                .AsQueryable();

            if (resourceParameter.OeeId != Guid.Empty)
                qry = qry.Where(x => x.OeeId == resourceParameter.OeeId);

            if (resourceParameter.DowntimeEventType != DowntimeEventType.None)
                qry = qry.Where(x => x.DowntimeEventType == resourceParameter.DowntimeEventType);

            return qry;
        }

        public string GetAssemblyMachineName(string assemblyTagName)
        {
            var tag = assemblyTagName.Trim().ToLower();
            if (tag.Contains("m1")) return "Ringer";
            if (tag.Contains("ring")) return "Ringer";

            if (tag.Contains("m2")) return "Vision";
            if (tag.Contains("m3")) return "PRAM";
            if (tag.Contains("packout")) return "PACKOUT";
            if (tag.Contains("a9_rod_cell")) return "Rod Cell";

            return "N/A";
        }
    }
}
