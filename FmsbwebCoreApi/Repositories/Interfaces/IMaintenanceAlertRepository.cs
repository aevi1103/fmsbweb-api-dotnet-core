using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FmsbwebCoreApi.Entity.FmsbMvc;
using FmsbwebCoreApi.ResourceParameters;

namespace FmsbwebCoreApi.Repositories.Interfaces
{
    public interface IMaintenanceAlertRepository
    {
        Task<List<MaintenanceAlert>> GetMaintenanceJobs(MaintenanceAlertResourceParameter parameters);
    }
}
