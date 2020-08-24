using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FmsbwebCoreApi.Context.QualityCheckSheets;
using FmsbwebCoreApi.Entity.Master;
using FmsbwebCoreApi.Entity.QualityCheckSheets;
using FmsbwebCoreApi.Repositories.Interfaces;
using FmsbwebCoreApi.Repositories.Interfaces.QualityCheckSheets;
using Microsoft.EntityFrameworkCore;

namespace FmsbwebCoreApi.Repositories.QualityCheckSheets
{
    public class MachineRepository : IMachineRepository
    {
        private readonly QualityCheckSheetsContext _context;

        public MachineRepository(QualityCheckSheetsContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public IEnumerable<Machine> GetMachines()
        {
            return _context.Machines.AsNoTracking().Include(x => x.Line).ToList();
        }

        public IQueryable<Machine> Query()
        {
            return _context.Machines.AsNoTracking();
        }

        public Machine Query(int id)
        {
            return _context.Machines.AsNoTracking().Include(x => x.Line).FirstOrDefault(x => x.MachineId == id);
        }

        public Task<List<Machine>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Machine> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<Machine> Create(Machine data)
        {
            if (data == null) throw new ArgumentNullException(nameof(data));
            await using var transaction = await _context.Database.BeginTransactionAsync().ConfigureAwait(false);
            try
            {
                await _context.Machines.AddAsync(data).ConfigureAwait(false);
                await _context.SaveChangesAsync().ConfigureAwait(false);
                await transaction.CommitAsync().ConfigureAwait(false);
                return data;
            }
            catch (Exception e)
            {
                await transaction.RollbackAsync().ConfigureAwait(false);
                throw new Exception(e.Message);
            }
        }

        public async Task<Machine> Update(Machine data)
        {
            if (data == null) throw new ArgumentNullException(nameof(data));
            await using var transaction = await _context.Database.BeginTransactionAsync().ConfigureAwait(false);
            try
            {
                _context.Machines.Update(data);
                await _context.SaveChangesAsync().ConfigureAwait(false);
                await transaction.CommitAsync().ConfigureAwait(false);
                return data;
            }
            catch (Exception e)
            {
                await transaction.RollbackAsync().ConfigureAwait(false);
                throw new Exception(e.Message);
            }
        }

        public async Task<bool> Delete(int id)
        {
            await using var transaction = await _context.Database.BeginTransactionAsync().ConfigureAwait(false);
            try
            {
                _context.Machines.Remove(new Machine { MachineId = id});
                await _context.SaveChangesAsync().ConfigureAwait(false);
                await transaction.CommitAsync().ConfigureAwait(false);
                return true;
            }
            catch (Exception e)
            {
                await transaction.RollbackAsync().ConfigureAwait(false);
                throw new Exception(e.Message);
            }
        }


    }
}
