using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FmsbwebCoreApi.Entity.Fmsb2;
using FmsbwebCoreApi.Entity.Master;
using FmsbwebCoreApi.Entity.SAP;

namespace FmsbwebCoreApi.Services.Interfaces
{
    public interface IUtilityService
    {
        int MapShiftToShiftOrder(string shift);
        string MapAreaToDepartment(string area);
        string MapDepartmentToArea(string dept);
        List<string> GetAssemblyFinishingScrapAreaNames();
        string CreateHourByHourUrl(CreateHxHview hxh, Machines machine);
        string CreateHourByHourUrl(CreateHxHview hxh, MachineMapping machine);
        decimal CalculatePpmh(int gross, int? manning);
    }
}
