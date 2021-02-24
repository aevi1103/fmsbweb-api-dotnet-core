using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FmsbwebCoreApi.Entity.Overtime;

namespace FmsbwebCoreApi.Repositories.Interfaces
{
    public interface IOvertimeRepository
    {
        Task<List<Employee>> GetEmployees();
        Task<List<Overtime>> GetOvertime(int year);
        Task<Overtime> AddOrUpdate(Overtime overtime);
        Task<Overtime> Delete(int id);
    }
}
