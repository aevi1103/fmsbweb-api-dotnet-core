using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FmsbwebCoreApi.Context.Intranet;
using FmsbwebCoreApi.Context.SAP;
using FmsbwebCoreApi.Entity.SAP;
using FmsbwebCoreApi.Models.Intranet;
using FmsbwebCoreApi.Repositories.Interfaces;
using FmsbwebCoreApi.ResourceParameters;
using Microsoft.EntityFrameworkCore;

namespace FmsbwebCoreApi.Repositories
{
    public class ProductionRepository : IProductionRepository
    {
        private readonly SapContext _context;
        private readonly IntranetContext _intranetContext;

        public ProductionRepository(SapContext context, IntranetContext intranetContext)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
            _intranetContext = intranetContext ?? throw new ArgumentNullException(nameof(intranetContext));
        }

        public IQueryable<Production2> GetProductionQueryable(ProductionResourceParameter resourceParameter)
        {
            if (resourceParameter == null) throw new ArgumentNullException(nameof(resourceParameter));

            var qry = _context.Production2
                .Where(x => x.ShiftDate >= resourceParameter.StartDate && x.ShiftDate <= resourceParameter.EndDate)
                .AsQueryable();

            if (!string.IsNullOrEmpty(resourceParameter.Area))
            {
                qry = qry.Where(x => x.Area == resourceParameter.Area);
            }

            return qry;

        }

        public async Task<HxhProductionByLineAndProgramDto> GetHxhProdByLineAndProgram(ProductionResourceParameter resourceParameter)
        {
            var data = await _intranetContext.FmsbMasterProdPartsCopyDashboardProgram
                            .Where(x => x.Date >= resourceParameter.StartDate && x.Date <= resourceParameter.EndDate && x.Area == resourceParameter.Area)
                            .GroupBy(x => new { x.Department, x.Area, x.Line, x.Programs })
                            .Select(x => new
                            {
                                x.Key.Department,
                                x.Key.Area,
                                x.Key.Line,
                                Program = x.Key.Programs,
                                Target = x.Sum(s => s.OeeTarget),
                                Gross = x.Sum(s => s.FoundryGross)
                                        + x.Sum(s => s.MachiningGross)
                                        + x.Sum(s => s.AnodGross)
                                        + x.Sum(s => s.ScGross)
                                        + x.Sum(s => s.AssyGross)
                            })
                            .ToListAsync()
                            .ConfigureAwait(false);

            var lines = data.GroupBy(x => new { x.Department, x.Area, x.Line })
                            .Select(x => new HxHProductionByLineDto
                            {
                                Department = x.Key.Department,
                                Area = x.Key.Area,
                                Line = x.Key.Line,
                                Target = x.Sum(s => s.Target),
                                Gross = x.Sum(s => s.Gross)
                            })
                            .ToList();

            var program = data.GroupBy(x => new { x.Department, x.Area, x.Program })
                            .Select(x => new HxhProductionByProgramDto
                            {
                                Department = x.Key.Department,
                                Area = x.Key.Area,
                                Program = x.Key.Program,
                                Target = x.Sum(s => s.Target),
                                Gross = x.Sum(s => s.Gross)
                            })
                            .ToList();

            return new HxhProductionByLineAndProgramDto
            {
                LineDetails = lines,
                ProgramDetails = program
            };
        }
    }
}
