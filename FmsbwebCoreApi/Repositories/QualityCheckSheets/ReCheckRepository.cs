using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FmsbwebCoreApi.Context.QualityCheckSheets;
using FmsbwebCoreApi.Entity.QualityCheckSheets;
using FmsbwebCoreApi.Repositories.Interfaces.QualityCheckSheets;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.EntityFrameworkCore;

namespace FmsbwebCoreApi.Repositories.QualityCheckSheets
{
    public class ReCheckRepository : IReCheckRepository
    {
        private readonly QualityCheckSheetsContext _context;

        public ReCheckRepository(QualityCheckSheetsContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public IQueryable<ReCheck> Query()
        {
            return _context.ReChecks;
        }

        public ReCheck Query(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<ReCheck>> GetAll()
        {
            throw new NotImplementedException();
        }

        public async Task<ReCheck> GetById(int id)
        {
            return await _context.ReChecks.FindAsync(id);
        }

        public async Task<ReCheck> GetByIdNoTracking(int id)
        {
            return await _context.ReChecks.AsNoTracking().FirstOrDefaultAsync(x => x.ReCheckId == id);
        }

        public async Task<ReCheck> Create(ReCheck data)
        {
            if (data == null) throw new ArgumentNullException(nameof(data));
            await using var transaction = await _context.Database.BeginTransactionAsync().ConfigureAwait(false);
            try
            {
                await _context.ReChecks.AddAsync(data).ConfigureAwait(false);
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

        public async Task<ReCheck> Update(ReCheck data)
        {
            if (data == null) throw new ArgumentNullException(nameof(data));
            await using var transaction = await _context.Database.BeginTransactionAsync().ConfigureAwait(false);
            try
            {
                _context.ReChecks.Update(data);
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
                _context.ReChecks.Remove(new ReCheck { ReCheckId = id });
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

        public async Task<bool> HasInitialReCheck(int checkSheetEntryId)
        {
            return await _context.ReChecks.AsNoTracking().AnyAsync(x => x.IsInitialValue && x.CheckSheetEntryId == checkSheetEntryId);
        }

        public async Task<ReCheck> GetLatestRecheck(int checkSheetEntryId)
        {
            return await _context.ReChecks
                .Include(x => x.CheckSheetEntry)
                .Include(x => x.CheckSheetEntry.CheckSheet)
                .Where(x => x.CheckSheetEntryId == checkSheetEntryId)
                .OrderByDescending(x => x.ReCheckId)
                .Take(1)
                .FirstOrDefaultAsync();

        }


    }
}
