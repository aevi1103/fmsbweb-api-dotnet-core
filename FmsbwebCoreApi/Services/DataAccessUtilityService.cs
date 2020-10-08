using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using FmsbwebCoreApi.Context.Fmsb2;
using FmsbwebCoreApi.Context.SAP;
using FmsbwebCoreApi.Entity.Fmsb2;
using FmsbwebCoreApi.Entity.SAP;
using FmsbwebCoreApi.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace FmsbwebCoreApi.Services
{
    public class DataAccessUtilityService : IDataAccessUtilityService
    {
        private readonly Fmsb2Context _fmsb2Context;
        private readonly SapContext _sapContext;

        public DataAccessUtilityService(Fmsb2Context fmsb2Context, SapContext sapContext)
        {
            _fmsb2Context = fmsb2Context ?? throw new ArgumentNullException(nameof(fmsb2Context));
            _sapContext = sapContext ?? throw new ArgumentNullException(nameof(sapContext));
        }

        public async Task<Machines> GetMachine(Machines filter)
        {
            if (filter == null) throw new ArgumentNullException(nameof(filter));

            var machine = _fmsb2Context.Machines.AsNoTracking().AsQueryable();

            if (!string.IsNullOrEmpty(filter.MachineName))
                return await machine.FirstOrDefaultAsync(x => x.MachineName == filter.MachineName).ConfigureAwait(false);

            if (!string.IsNullOrEmpty(filter.MachineMapper))
                return await machine.FirstOrDefaultAsync(x => x.MachineMapper == filter.MachineMapper).ConfigureAwait(false);

            if (!string.IsNullOrEmpty(filter.LineNumber.ToString()))
                return await machine.FirstOrDefaultAsync(x => x.LineNumber == filter.LineNumber).ConfigureAwait(false);

            if (!string.IsNullOrEmpty(filter.Line2))
                return await machine.FirstOrDefaultAsync(x => x.Line2 == filter.Line2).ConfigureAwait(false);

            return null;
        }

        public async Task<List<MachineList>> GetMachines(int deptId, bool showAllAfMachine = false)
        {
            var qry = _fmsb2Context.MachineList.AsNoTracking().Where(x => x.LineNumber != null).AsQueryable();

            qry = showAllAfMachine 
                ? qry.Where(x => x.DeptId >= 4 && x.DeptId <= 6) 
                : qry.Where(x => x.DeptId == deptId);

            return await qry.ToListAsync().ConfigureAwait(false);
        }

        public async Task<List<MachineMapping>> GetMachines(List<int> machineIds)
        {
            var machineIdsStr = machineIds.Select(x => x.ToString()).ToList();
            var machines = await _sapContext.MachineMapping.Where(x => machineIdsStr.Contains(x.MachineId.ToString()))
                .ToListAsync()
                .ConfigureAwait(false);

            return machines;
        }

        public async Task<CreateHxHview> GerHourByHour(DateTime shiftDate, int machineId, string shift)
        {
            return await _fmsb2Context.CreateHxHview.AsNoTracking()
                .FirstOrDefaultAsync(x => x.Shiftdate == shiftDate && x.Shift == shift && x.Machineid == machineId)
                .ConfigureAwait(false);
        }

        public async Task<Department> GetDepartment(string dept)
        {
            return await _fmsb2Context.Department
                .AsNoTracking()
                .FirstOrDefaultAsync(x => x.DeptName.ToLower() == dept.ToLower())
                .ConfigureAwait(false);
        }

        public async Task<List<CreateHxHview>> GetHxHs(DateTime shiftDate, string shift, int deptId)
        {
            return await _fmsb2Context.CreateHxHview.AsNoTracking()
                .Where(x => x.Shiftdate == shiftDate && x.Shift == shift && x.Deptid == deptId)
                .ToListAsync()
                .ConfigureAwait(false);
        }

        public async Task<List<CreateHxHview>> GetHxHs(DateTime shiftDate, string shift, List<int> machineIds)
        {
            var machineIdsStr = machineIds.Select(x => x.ToString()).ToList();

            var qry = _fmsb2Context.CreateHxHview.AsNoTracking()
                .Where(x => x.Shiftdate == shiftDate 
                            && x.Shift == shift
                            && machineIdsStr.Contains(x.Machineid.ToString()))
                .AsQueryable();

            return await qry.ToListAsync().ConfigureAwait(false);
        }

        public async Task<List<CreateHxHview>> GetHxHs(DateTime shiftDate, List<int> machineIds)
        {
            var machineIdsStr = machineIds.Select(x => x.ToString()).ToList();

            var qry = _fmsb2Context.CreateHxHview.AsNoTracking()
                .Where(x => x.Shiftdate == shiftDate
                            && machineIdsStr.Contains(x.Machineid.ToString()))
                .AsQueryable();

            return await qry.ToListAsync().ConfigureAwait(false);
        }
    }
}
