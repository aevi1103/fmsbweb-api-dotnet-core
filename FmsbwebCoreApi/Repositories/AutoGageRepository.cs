using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FmsbwebCoreApi.Context.AutoGage;
using FmsbwebCoreApi.Entity.AutoGage;
using FmsbwebCoreApi.Models;
using FmsbwebCoreApi.Repositories.Interfaces;
using FmsbwebCoreApi.ResourceParameters;
using Microsoft.EntityFrameworkCore;

namespace FmsbwebCoreApi.Repositories
{
    public class AutoGageRepository : IAutoGageRepository
    {
        private readonly AutoGageContext _context;

        public AutoGageRepository(AutoGageContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }
         
        public async Task<List<AutoGageScrapDto>> GetAutoGageScrapData(AutoGageResourceParameters parameters)
        {
            var qry = _context.AutoGage2View
                .Where(x => x.ShiftDate >= parameters.StartDate && x.ShiftDate <= parameters.EndDate
                    && x.IsPassed == false 
                    && x.RegageStatus == 2
                    && x.DefectOnly != "")
                .AsQueryable();
            
            if (!string.IsNullOrEmpty(parameters.Shift))
                qry = qry.Where(x => x.Shift == parameters.Shift);

            if (!string.IsNullOrEmpty(parameters.Line))
                qry = qry.Where(x => x.Line.ToString() == parameters.Line);

            return await qry.Select(x => new AutoGageScrapDto
            {
                Part = x.Part2,
                DateTime = x.DateTime,
                ShiftDate = x.ShiftDate,
                Shift = x.Shift,
                Line = x.Line,
                Defect = x.DefectOnly
            })
                .ToListAsync()
                .ConfigureAwait(false);
        }
    }
}
