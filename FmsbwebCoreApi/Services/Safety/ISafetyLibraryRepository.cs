using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using FmsbwebCoreApi.Entity.Safety;

namespace FmsbwebCoreApi.Services.Safety
{
    public interface ISafetyLibraryRepository
    {
        IEnumerable<Incidence> GetIncents();
        Incidence GetIncent(int Id);
        bool IncidentExists(int Id);
    }
}
