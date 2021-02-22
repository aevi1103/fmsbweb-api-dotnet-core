using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FmsbwebCoreApi.Context.FmsbMvc;
using FmsbwebCoreApi.Entity.FmsbMvc;
using FmsbwebCoreApi.Migrations.FmsbMvc;
using FmsbwebCoreApi.Repositories.Interfaces;
using FmsbwebCoreApi.ResourceParameters;
using Microsoft.EntityFrameworkCore;

namespace FmsbwebCoreApi.Repositories
{
    public class MaintenanceAlertRepository : IMaintenanceAlertRepository
    {
        private readonly FmsbMvcContext _context;

        public MaintenanceAlertRepository(FmsbMvcContext context)
        {
            _context = context;
        }

        public async Task<List<MaintenanceAlert>> GetMaintenanceJobs(MaintenanceAlertResourceParameter parameters)
        {
            var data = await _context.MaintenanceAlert
                .Include(x => x.Machine)
                .Include(x => x.SubMachine)
                .Where(x => x.RequestDateTime.Date >= parameters.StartDate && x.RequestDateTime.Date <= parameters.EndDate)
                .ToListAsync()
                .ConfigureAwait(false);

            return data;
        }
    }
}
