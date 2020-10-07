using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FmsbwebCoreApi.Context.SAP;
using FmsbwebCoreApi.Entity.SAP;
using FmsbwebCoreApi.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace FmsbwebCoreApi.Repositories
{
    public class MachineMappingRepository : IMachineMappingRepository
    {
        private readonly SapContext _sapContext;

        public MachineMappingRepository(SapContext sapContext)
        {
            _sapContext = sapContext ?? throw new ArgumentNullException(nameof(sapContext));
        }

        public async Task<List<MachineMapping>> GetMachines(string area)
        {
            return await _sapContext.MachineMapping.Where(x => x.Area == area).ToListAsync();
        }
    }
}
