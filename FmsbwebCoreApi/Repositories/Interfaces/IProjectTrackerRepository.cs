using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FmsbwebCoreApi.Entity.Fmsb2;
using FmsbwebCoreApi.Enums;
using FmsbwebCoreApi.ResourceParameters;

namespace FmsbwebCoreApi.Repositories.Interfaces
{
    public interface IProjectTrackerRepository
    {
        Task<ProjectTracker> AddOrUpdate(ProjectTracker data);
        Task<ProjectTracker> Delete(int id);
    }
}
