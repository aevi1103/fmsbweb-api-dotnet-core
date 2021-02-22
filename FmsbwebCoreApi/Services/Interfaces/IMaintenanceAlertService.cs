using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FmsbwebCoreApi.Repositories.Interfaces;
using FmsbwebCoreApi.ResourceParameters;

namespace FmsbwebCoreApi.Services.Interfaces
{
    public interface IMaintenanceAlertService : IMaintenanceAlertRepository
    {
        Task<dynamic> GetMeanTimeBeforeBreakDown(MaintenanceAlertResourceParameter parameter);
    }
}
