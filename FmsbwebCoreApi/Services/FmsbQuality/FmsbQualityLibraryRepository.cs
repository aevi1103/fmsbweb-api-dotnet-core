using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FmsbwebCoreApi.Entity.FmsbQuality;
using FmsbwebCoreApi.Models.FmsbQuality;

using FmsbwebCoreApi.Context.FmsbQuality;
using FmsbwebCoreApi.Context.Master;
using Microsoft.EntityFrameworkCore;

namespace FmsbwebCoreApi.Services.FmsbQuality
{
    public class FmsbQualityLibraryRepository : IFmsbQualityLibraryRepository, IDisposable
    {

        private readonly fmsbQualityContext _context;
        private readonly masterContext _masterContext;

        public FmsbQualityLibraryRepository(fmsbQualityContext context, masterContext masterContext)
        {
            _context = context ??
                throw new ArgumentNullException(nameof(context));

            _masterContext = masterContext ??
                throw new ArgumentNullException(nameof(masterContext));
        }

        public async Task<IEnumerable<CustomerComplaint>> GetListCustomerComplaint(DateTime start, DateTime end)
        {
            return await _context.CustomerComplaint.Where(x => x.Date >= start && x.Date <= end).OrderBy(x => x.Date).ToListAsync().ConfigureAwait(false);
        }

        public async Task<IEnumerable<MrrViewDto>> GetListMrr(DateTime start, DateTime end)
        {
            return await _masterContext.Mrrview
                            .Where(x => x.IncidentDate >= start && x.IncidentDate <= end)
                            .Where(x => x.Status == "Open")
                            .GroupBy(x => new { x.Catagory })
                            .Select(x => new MrrViewDto
                            {
                                Category = x.Key.Catagory.Trim(),
                                Qty = (int)x.Sum(s => s.Quantity)
                            })
                            .OrderBy(x => x.Qty)
                            .ToListAsync().ConfigureAwait(false);
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
    }
}
