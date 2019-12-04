using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FmsbwebCoreApi.Context.Safety;
using FmsbwebCoreApi.Entity.Safety;

namespace FmsbwebCoreApi.Services.Safety
{
    public class SafetyLibraryRepository : ISafetyLibraryRepository, IDisposable
    {
        private readonly SafetyContext _context;

        public SafetyLibraryRepository(SafetyContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public IEnumerable<Incidence> GetIncents()
        {
            return _context.Incidence.ToList<Incidence>();
        }

        public Incidence GetIncent(int id)
        {
            if (string.IsNullOrEmpty(id.ToString()))
            {
                throw new ArgumentNullException(nameof(id));
            }
            return _context.Incidence.FirstOrDefault(x => x.Id == id);
        }

        public bool IncidentExists(int id)
        {
            if (string.IsNullOrEmpty(id.ToString()))
            {
                throw new ArgumentNullException(nameof(id));
            }

            return _context.Incidence.Any(x => x.Id == id);
        }

        public bool Save()
        {
            return (_context.SaveChanges() >= 0);
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
