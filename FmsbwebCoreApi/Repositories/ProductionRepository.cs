using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FmsbwebCoreApi.Context.Fmsb2;
using FmsbwebCoreApi.Context.Intranet;
using FmsbwebCoreApi.Context.SAP;
using FmsbwebCoreApi.Entity.Fmsb2;
using FmsbwebCoreApi.Entity.Intranet;
using FmsbwebCoreApi.Entity.SAP;
using FmsbwebCoreApi.Models.FMSB2;
using FmsbwebCoreApi.Models.Intranet;
using FmsbwebCoreApi.Repositories.Interfaces;
using FmsbwebCoreApi.ResourceParameters;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.EntityFrameworkCore;

namespace FmsbwebCoreApi.Repositories
{
    public class ProductionRepository : IProductionRepository
    {
        private readonly SapContext _context;
        private readonly IntranetContext _intranetContext;
        private readonly Fmsb2Context _fmsb2Context;

        public ProductionRepository(SapContext context, IntranetContext intranetContext, Fmsb2Context fmsb2Context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
            _intranetContext = intranetContext ?? throw new ArgumentNullException(nameof(intranetContext));
            _fmsb2Context = fmsb2Context ?? throw new ArgumentNullException(nameof(fmsb2Context));
        }

        /// <summary>
        /// Get SAP Production
        /// </summary>
        /// <param name="resourceParameter"></param>
        /// <returns></returns>
        public IQueryable<Production2> GetProductionQueryable(ProductionResourceParameter resourceParameter)
        {
            if (resourceParameter == null) throw new ArgumentNullException(nameof(resourceParameter));

            var qry = _context.Production2.AsNoTracking()
                .Where(x => x.ShiftDate >= resourceParameter.StartDate && x.ShiftDate <= resourceParameter.EndDate)
                .AsQueryable();

            if (!string.IsNullOrEmpty(resourceParameter.Area))
                qry = qry.Where(x => x.Area == resourceParameter.Area);

            if (!string.IsNullOrEmpty(resourceParameter.Line))
                qry = qry.Where(x => x.MachineHxh == resourceParameter.Line);

            if (!string.IsNullOrEmpty(resourceParameter.Shift))
                qry = qry.Where(x => x.Shift == resourceParameter.Shift);

            if (!string.IsNullOrEmpty(resourceParameter.WorkCenter))
                qry = qry.Where(x => x.WorkCenter.ToLower() == resourceParameter.WorkCenter.ToLower().Trim());

            if (resourceParameter.WorkCenters.Any())
                qry = qry.Where(x => resourceParameter.WorkCenters.Contains(x.WorkCenter));

            if (resourceParameter.MachinesHxh.Any())
                qry = qry.Where(x => resourceParameter.MachinesHxh.Contains(x.MachineHxh));

            if (resourceParameter.Lines.Any())
                qry = qry.Where(x => resourceParameter.Lines.Contains(x.Line));

            return qry;

        }

        /// <summary>
        /// Get Hourly Production
        /// </summary>
        /// <param name="resourceParameter"></param>
        /// <returns></returns>
        public async Task<List<HxHProdDto>> GetHxHProduction(ProductionResourceParameter resourceParameter)
        {
            var qry = _fmsb2Context.HxHProd.AsNoTracking().Where(x =>
                    x.ShiftDate >= resourceParameter.StartDate &&
                    x.ShiftDate <= resourceParameter.EndDate)
                .AsQueryable();

            if (!string.IsNullOrEmpty(resourceParameter.Area))
                qry = qry.Where(x => x.Area.ToLower() == resourceParameter.Area.ToLower().Trim());

            if (!string.IsNullOrEmpty(resourceParameter.Line))
                qry = qry.Where(x => x.Line.ToLower() == resourceParameter.Line.ToLower().Trim());

            if (!string.IsNullOrEmpty(resourceParameter.Shift))
                qry = qry.Where(x => x.Shift.ToLower() == resourceParameter.Shift.ToLower().Trim());

            // x.Line => A2
            if (resourceParameter.MachinesHxh.Any())
                qry = qry.Where(x => resourceParameter.MachinesHxh.Contains(x.Line));

            // x.MachineName => Assembly 2
            if (resourceParameter.Lines.Any())
                qry = qry.Where(x => resourceParameter.Lines.Contains(x.MachineName));

            var result = await qry.ToListAsync();
            return result.Select(x => new HxHProdDto
            {
                DeptId = x.DeptId,
                Area = x.Area,
                DeptName = x.DeptName,
                MachineId = x.MachineId,
                MachineName = x.MachineName, // Assembly 2
                Line = x.Line ?? "", // A2
                Hour = x.Hour,
                Program = x.Program ?? "",
                Production = x.Production,
                CellSide = x.CellSide,
                Target = Math.Round(x.Target),
                Shift = x.Shift,
                ShiftDate = x.ShiftDate
            }).ToList();
        }

        /// <summary>
        /// Get Machining EOS Production
        /// </summary>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <param name="shift"></param>
        /// <returns></returns>
        public async Task<List<HxHProdDto>> GetMachiningEosProduction(DateTime start, DateTime end, string shift = "")
        {
            shift = (shift ?? "").ToLower().Trim();
            var result = await _intranetContext.EolvsEosView
                .Where(x => x.ShiftDate >= start && x.ShiftDate <= end
                            && x.Shift.ToLower().Contains(shift))
                .ToListAsync()
                .ConfigureAwait(false);

            return result.Select(x => new HxHProdDto
            {
                Area = "Machine Line",
                DeptName = "Machining",
                MachineName = $"Line {x.Line}",
                Line = x.Line.ToString(),
                Program = x.Program,
                PartNumber = x.Part,
                Target = Math.Round(x.Target),
                Gross = x.Gross,
                ShiftDate = x.ShiftDate,
                Shift = x.Shift
            }).ToList();
        }

    }
}
