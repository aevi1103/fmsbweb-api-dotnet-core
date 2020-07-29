using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FmsbwebCoreApi.Context.SAP;
using FmsbwebCoreApi.Entity.Fmsb2;
using FmsbwebCoreApi.Entity.SAP;
using FmsbwebCoreApi.Repositories.Interfaces;
using FmsbwebCoreApi.ResourceParameters;
using Microsoft.EntityFrameworkCore;

namespace FmsbwebCoreApi.Repositories
{
    public class ScrapRepository : IScrapRepository
    {
        private readonly SapContext _context;
        private const string WarmerScrapCode = "8888";

        public ScrapRepository(SapContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public IQueryable<Scrap2> GetScrap2Queryable(ScrapResourceParameter resourceParameter, bool excludeWarmers = true)
        {
            if (resourceParameter == null) throw new ArgumentNullException(nameof(resourceParameter));

            var qry = _context.Scrap2
                .Where(x => x.ShiftDate >= resourceParameter.StartDate && x.ShiftDate <= resourceParameter.EndDate)
                .AsQueryable();

            if (excludeWarmers)
                qry = qry.Where(x => x.ScrapCode != WarmerScrapCode);

            if (resourceParameter.IsPurchasedScrap != null)
                qry = qry.Where(x => x.IsPurchashedExclude == resourceParameter.IsPurchasedScrap);

            if (!string.IsNullOrEmpty(resourceParameter.Area))
                qry = qry.Where(x => x.Area == resourceParameter.Area);

            if (!string.IsNullOrEmpty(resourceParameter.ScrapCode))
                qry = qry.Where(x => x.ScrapCode == resourceParameter.ScrapCode);

            if (!string.IsNullOrEmpty(resourceParameter.Department))
                qry = qry.Where(x => x.Department == resourceParameter.Department);

            if (!string.IsNullOrEmpty(resourceParameter.Line)) 
                qry = qry.Where(x => x.MachineHxh.ToLower().Trim() == resourceParameter.Line.ToLower().Trim());

            if (!string.IsNullOrEmpty(resourceParameter.Program))
                qry = qry.Where(x => x.Program.ToLower().Trim() == resourceParameter.Program.ToLower().Trim());

            if (!string.IsNullOrEmpty(resourceParameter.Shift))
                qry = qry.Where(x => x.Shift == resourceParameter.Shift);

            if (resourceParameter.WorkCenters.Count > 0)
                qry = qry.Where(x => resourceParameter.WorkCenters.Contains(x.WorkCenter));

            return qry;
        }
    }
}
