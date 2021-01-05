using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FmsbwebCoreApi.Entity.FmsbOee;
using FmsbwebCoreApi.Entity.Iconics;
using FmsbwebCoreApi.ResourceParameters;

namespace FmsbwebCoreApi.Repositories.Interfaces
{
    public interface IDowntimeRepository
    {
        IQueryable<KepserverMachineDowntime> GetPlcDowntimeQueryable(DowntimeResourceParameter resourceParameter);
        IQueryable<DowntimeEvent> GetDowntimeEvents(DowntimeResourceParameter resourceParameter);
        string GetAssemblyMachineName(string assemblyTagName);
    }
}
