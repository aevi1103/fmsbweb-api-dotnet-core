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
        Task<IEnumerable<DailyHxHTargetDto>> DailyHxHTargetByArea(DateTime startDateTime, DateTime endDateTime, string area);
        Task<List<SwotTargetWithDeptId>> GetLineTargets(string dept);
        Task<KpiTarget> GetDepartmentTargets(string dept, string area, DateTime startDateTime, DateTime endDateTime);
    }
}
