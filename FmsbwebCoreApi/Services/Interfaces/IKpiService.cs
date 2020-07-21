using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FmsbwebCoreApi.Models.SAP;

namespace FmsbwebCoreApi.Services.Interfaces
{
    public interface IKpiService
    {
        Task<List<DailyDepartmentKpiDto>> GetDailyKpiChart(DateTime startDateTime, DateTime endDateTime, string area);
        Task<DepartmentDetailsDto> GetDepartmentDetails(DateTime start, DateTime end, string area);
    }
}
