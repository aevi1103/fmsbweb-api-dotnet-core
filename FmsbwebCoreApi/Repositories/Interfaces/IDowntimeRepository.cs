using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FmsbwebCoreApi.Entity.Iconics;
using FmsbwebCoreApi.ResourceParameters;

namespace FmsbwebCoreApi.Repositories.Interfaces
{
    public interface IDowntimeRepository
    {
        IQueryable<KepserverMachineDowntime> GetPlcDowntimeQueryable(PlcDowntimeResourceParameter resourceParameter);
    }
}
