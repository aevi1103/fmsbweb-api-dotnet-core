using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FmsbwebCoreApi.Entity.SAP;

namespace FmsbwebCoreApi.Repositories.Interfaces
{
    public interface IMachineMappingRepository
    {
        Task<List<MachineMapping>> GetMachines(string area);
    }
}
