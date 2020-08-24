using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FmsbwebCoreApi.Context.QualityCheckSheets;
using FmsbwebCoreApi.Entity.QualityCheckSheets;
using FmsbwebCoreApi.Repositories.Interfaces;
using FmsbwebCoreApi.Repositories.Interfaces.QualityCheckSheets;
using Microsoft.EntityFrameworkCore;

namespace FmsbwebCoreApi.Repositories.QualityCheckSheets
{
    public class SubMachineRepository : ISubMachineRepository
    {
        private readonly QualityCheckSheetsContext _context;

        public SubMachineRepository(QualityCheckSheetsContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public IQueryable<SubMachine> Query()
        {
            return _context.SubMachines.AsNoTracking();
        }

        public SubMachine Query(int id)
        {
            return _context.SubMachines.AsNoTracking().Include(x => x.Machine).FirstOrDefault(x => x.SubMachineId == id);
        }

        public Task<List<SubMachine>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<SubMachine> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<SubMachine> Create(SubMachine data)
        {
            if (data == null) throw new ArgumentNullException(nameof(data));
            await using var transaction = await _context.Database.BeginTransactionAsync().ConfigureAwait(false);
            try
            {
                await _context.SubMachines.AddAsync(data).ConfigureAwait(false);
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

        public async Task<SubMachine> Update(SubMachine data)
        {
            if (data == null) throw new ArgumentNullException(nameof(data));
            await using var transaction = await _context.Database.BeginTransactionAsync().ConfigureAwait(false);
            try
            {
                _context.SubMachines.Update(data);
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
                _context.SubMachines.Remove(new SubMachine { SubMachineId = id});
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
