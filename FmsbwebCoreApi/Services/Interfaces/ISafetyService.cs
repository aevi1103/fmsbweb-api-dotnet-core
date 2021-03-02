using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FmsbwebCoreApi.Entity.Safety;
using FmsbwebCoreApi.Models;
using FmsbwebCoreApi.ResourceParameters;

namespace FmsbwebCoreApi.Services.Interfaces
{
    public interface ISafetyService
    {
        Task<Incidence> AddOrUpdate(SafetyIncidenceDto resourceParameter);
        Task<Incidence> Delete(int id);
        Task<dynamic> GetChartsData(SafetyResourceParameter parameter);
    }
}
