using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FmsbwebCoreApi.Entity.Fmsb2;
using FmsbwebCoreApi.Models.Intranet;

namespace FmsbwebCoreApi.Repositories.Interfaces
{
    public interface IKpiTargetRepository
    {
        Task<List<SwotTargetWithDeptId>> GetLineTargets(string dept);
        Task<SwotTargetWithDeptId> GetSwotTarget(string line);
        Task<List<SwotTargetWithDeptId>> GetSwotTargets(string dept);
        Task<List<SwotTargetWithDeptId>> GetSwotTargets(List<string> machines);
        decimal GetScrapTarget(SwotTargetWithDeptId data, string line);
        Task<KpiTarget> GetDepartmentTargets(string dept, string area, DateTime startDateTime, DateTime endDateTime);
    }
}
