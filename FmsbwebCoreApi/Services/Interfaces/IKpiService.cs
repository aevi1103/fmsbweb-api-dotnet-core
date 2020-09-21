using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FmsbwebCoreApi.Entity.Fmsb2;
using FmsbwebCoreApi.Models;
using FmsbwebCoreApi.Models.Intranet;
using FmsbwebCoreApi.Models.SAP;
using FmsbwebCoreApi.ResourceParameters.SAP;

namespace FmsbwebCoreApi.Services.Interfaces
{
    public interface IKpiService
    {
        Task<List<DailyDepartmentKpiDto>> GetDailyKpiChart(DateTime startDateTime, DateTime endDateTime, string area);
        Task<DepartmentDetailsDto> GetDepartmentDetails(SapResourceParameter parameters);
        Task<EndOfShiftDto> GetEndOfShiftDto(string line, string area, DateTime shiftDate, string shift);
        Task<List<EndOfShiftDto>> GetEndOfShiftListDto(string dept, DateTime shiftDate, string shift);
        Task<bool> SendEosReport(string dept, DateTime shiftDate, string shift);
        Task<bool> SendEosReport(List<EndOfShiftDto> data, string dept, DateTime shiftDate, string shift);
        Task<EndOfShiftDto> GetOverallEosTotal(List<EndOfShiftDto> data, string dept, DateTime shiftDate, string shift);
        Task<dynamic> GetHourlyProduction(string dept, DateTime shiftDate, string shift);
    }
}
