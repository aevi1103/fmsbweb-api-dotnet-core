using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FmsbwebCoreApi.Context.FmsbMvc;
using FmsbwebCoreApi.Entity.FmsbMvc;
using FmsbwebCoreApi.ResourceParameters.FMSB;
using Microsoft.EntityFrameworkCore;

namespace FmsbwebCoreApi.Services.FmsbMvc
{
    public class FmsbMvcLibraryRepository : IFmsbMvcLibraryRepository, IDisposable
    {
        private readonly FmsbMvcContext _context;

        public FmsbMvcLibraryRepository(FmsbMvcContext context)
        {
            _context = context ??
                throw new ArgumentNullException(nameof(context));

        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                // dispose resources when needed
            }
        }

        public async Task<List<OverallCallbox>> GetDowntimeCallbox(DowntimeResourceParameter parameter)
        {
            var data = await _context.OverallCallbox
                        .Where(x => x.RequestDateTime >= parameter.Start && x.RequestDateTime <= parameter.End)
                        .Where(x => x.Department.Contains(parameter.Dept))
                        .Where(x => x.Line.Contains(parameter.Line))
                        .ToListAsync();

            return data;
        }
    }
}
