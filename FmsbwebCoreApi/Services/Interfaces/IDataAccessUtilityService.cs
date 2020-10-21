using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FmsbwebCoreApi.Entity.Fmsb2;
using FmsbwebCoreApi.Entity.SAP;

namespace FmsbwebCoreApi.Services.Interfaces
{
    public interface IDataAccessUtilityService
    {
        Task<Machines> GetMachine(Machines filter);
        Task<List<MachineList>> GetMachines(int deptId, bool showAllAfMachine = false);
        Task<List<MachineMapping>> GetMachines(List<int> machineIds);
        Task<CreateHxHview> GerHourByHour(DateTime shiftDate, int machineId, string shift);
        Task<Department> GetDepartment(string dept);
        Task<List<CreateHxHview>> GetHxHs(DateTime shiftDate, string shift, int deptId);
        Task<List<CreateHxHview>> GetHxHs(DateTime shiftDate, string shift, List<int> machineIds);
        Task<List<CreateHxHview>> GetHxHs(DateTime startShiftDate, DateTime endShiftDate, List<int> machineIds);
    }
}
