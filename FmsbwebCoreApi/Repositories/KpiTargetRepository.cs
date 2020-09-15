using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FmsbwebCoreApi.Context.Fmsb2;
using FmsbwebCoreApi.Context.Intranet;
using FmsbwebCoreApi.Entity.Fmsb2;
using FmsbwebCoreApi.Models.Intranet;
using FmsbwebCoreApi.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace FmsbwebCoreApi.Repositories
{
    public class KpiTargetRepository : IKpiTargetRepository
    {
        private readonly Fmsb2Context _fmsb2Context;

        public KpiTargetRepository(Fmsb2Context fmsb2Context)
        {
            _fmsb2Context = fmsb2Context ?? throw new ArgumentNullException(nameof(fmsb2Context));
        }

        public async Task<List<SwotTargetWithDeptId>> GetLineTargets(string dept)
        {
            return await _fmsb2Context.SwotTargetWithDeptId.AsNoTracking().Where(x => x.DeptName == dept)
                .ToListAsync()
                .ConfigureAwait(false);
        }

        public async Task<SwotTargetWithDeptId> GetSwotTarget(string line)
        {
            return await _fmsb2Context.SwotTargetWithDeptId.AsNoTracking().FirstOrDefaultAsync(x => x.Line2 == line).ConfigureAwait(false);
        }

        public async Task<List<SwotTargetWithDeptId>> GetSwotTargets(string dept)
        {
            return await _fmsb2Context.SwotTargetWithDeptId.AsNoTracking().Where(x => x.DeptName == dept).ToListAsync().ConfigureAwait(false);
        }

        public async Task<List<SwotTargetWithDeptId>> GetSwotTargets(List<string> machines)
        {
            return await _fmsb2Context.SwotTargetWithDeptId.AsNoTracking().Where(x => machines.Contains(x.Line2)).ToListAsync().ConfigureAwait(false);
        }

        public decimal GetScrapTarget(SwotTargetWithDeptId data, string scrapType)
        {
            switch (scrapType)
            {
                case "Foundry":
                    return data.FoundryScrapTarget;
                case "Machining":
                    return data.MachineScrapTarget;
                case "Anodize":
                case "Skirt Coat":
                case "Assembly":
                    return data.AfScrapTarget;
            }

            return 0;

        }

        public async Task<KpiTarget> GetDepartmentTargets(string dept, string area, DateTime startDateTime, DateTime endDateTime)
        {

            var data = await _fmsb2Context.KpiTarget.AsNoTracking()
                .Where(x => x.Department.ToLower() == dept.ToLower() 
                            && x.Year >= startDateTime.Year && x.Year == endDateTime.Year 
                            && x.MonthNumber >= startDateTime.Month 
                            && x.MonthNumber <= endDateTime.Month)
                .ToListAsync()
                .ConfigureAwait(false);

            return new KpiTarget
            {
                Department = area,
                OaeTarget = data.Average(x => x.OaeTarget),
                ScrapRateTarget = data.Average(x => x.ScrapRateTarget),
                PpmhTarget = data.Average(x => x.PpmhTarget),
                DowntimeRateTarget = data.Average(x => x.DowntimeRateTarget),
            };
        }


    }
}
