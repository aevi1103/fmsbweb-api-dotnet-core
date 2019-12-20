using FmsbwebCoreApi.Context.Intranet;
using FmsbwebCoreApi.Models.Intranet;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FmsbwebCoreApi.Services.Intranet
{
    public class IntranetLibraryRepository : IIntranetLibraryRepository, IDisposable
    {

        private readonly IntranetContext _context;


        public IntranetLibraryRepository(
            IntranetContext context)
        {
            _context = context ??
                throw new ArgumentNullException(nameof(context));
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public async Task<IEnumerable<HxhProductionDto>> GetHxhProduction(DateTime start, DateTime end, string area)
        {
            return await _context.FmsbMasterProdPartsCopyDashboard
                            .Where(x => x.Date >= start && x.Date <= end)
                            .Where(x => x.Area == area)
                            //.Where(x => x.Area != "Anodize")
                            .GroupBy(x => new { x.Department, x.Area })
                            .Select(x => new HxhProductionDto
                            {
                                Department = x.Key.Department,
                                Area = x.Key.Area,
                                Target = x.Sum(s => s.OeeTarget),
                                Gross = x.Sum(s => s.FoundryGross)
                                        + x.Sum(s => s.MachiningGross)
                                        + x.Sum(s => s.AnodGross)
                                        + x.Sum(s => s.ScGross)
                                        + x.Sum(s => s.AssyGross)
                            }).ToListAsync();
        }

        public async Task<HxhProductionByLineAndProgramDto> GetHxhProdByLineAndProgram(DateTime start, DateTime end, string area)
        {
            var data = await _context.FmsbMasterProdPartsCopyDashboardProgram
                            .Where(x => x.Date >= start && x.Date <= end)
                            .Where(x => x.Area == area)
                            //.Where(x => x.Area != "Anodize")
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
                            }).ToListAsync();

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

        public async Task<IEnumerable<DailyHxHTargetDto>> DailyHxHTargetByArea(DateTime start, DateTime end, string area)
        {
            return await _context.FmsbMasterProdPartsCopyDashboard
                            .Where(x => x.Date >= start && x.Date <= end)
                            .Where(x => x.Area == area)
                            .GroupBy(x => new { x.Area, x.Date })
                            .Select(x => new DailyHxHTargetDto
                            {
                                Area = x.Key.Area,
                                ShiftDate = (DateTime)x.Key.Date,
                                Target = (int)x.Sum(s => s.OeeTarget)
                            }).ToListAsync();
        }
        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                // dispose resources when needed
            }
        }
    }
}
