using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FmsbwebCoreApi.Context.Fmsb2;
using FmsbwebCoreApi.Context.Intranet;
using FmsbwebCoreApi.Entity.Fmsb2;
using FmsbwebCoreApi.Models.Intranet;
using FmsbwebCoreApi.Repositories.Interfaces;
using FmsbwebCoreApi.Services;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.EntityFrameworkCore;

namespace FmsbwebCoreApi.Repositories
{
    public class KpiTargetRepository : IKpiTargetRepository
    {
        private readonly IntranetContext _context;
        private readonly Fmsb2Context _fmsb2Context;

        public KpiTargetRepository(IntranetContext context, Fmsb2Context fmsb2Context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
            _fmsb2Context = fmsb2Context ?? throw new ArgumentNullException(nameof(fmsb2Context));
        }

        public async Task<IEnumerable<DailyHxHTargetDto>> DailyHxHTargetByArea(DateTime startDateTime, DateTime endDateTime, string area)
        {
            return await _context.FmsbMasterProdPartsCopyDashboard
                .Where(x => x.Date >= startDateTime && x.Date <= endDateTime)
                .Where(x => x.Area == area)
                .GroupBy(x => new { x.Area, x.Date })
                .Select(x => new DailyHxHTargetDto
                {
                    Area = x.Key.Area,
                    ShiftDate = (DateTime)x.Key.Date,
                    Target = (int)x.Sum(s => s.OeeTarget)
                })
                .ToListAsync()
                .ConfigureAwait(false);
        }

        public async Task<List<SwotTargetWithDeptId>> GetLineTargets(string dept)
        {
            return await _fmsb2Context.SwotTargetWithDeptId.Where(x => x.DeptName == dept)
                .ToListAsync()
                .ConfigureAwait(false);
        }

        public async Task<KpiTarget> GetDepartmentTargets(string dept, string area, DateTime startDateTime, DateTime endDateTime)
        {
            var data = await _fmsb2Context.KpiTarget
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
