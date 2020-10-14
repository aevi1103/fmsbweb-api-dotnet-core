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
            var excludeLines = new List<string>()
            {
                "A1", "A10", "Cell 3","10", "Line 10", "Assembly 10"
            };

            return await _sapContext
                .MachineMapping
                .AsNoTracking()
                .Where(x => x.Area == area)
                .Where(x => x.Line != null)
                .Where(x => !excludeLines.Contains(x.Line))
                .ToListAsync();
        }
    }
}
