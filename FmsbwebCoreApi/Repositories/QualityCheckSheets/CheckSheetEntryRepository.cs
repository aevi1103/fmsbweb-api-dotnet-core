using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FmsbwebCoreApi.Context.QualityCheckSheets;
using FmsbwebCoreApi.Entity.QualityCheckSheets;
using FmsbwebCoreApi.Repositories.Interfaces.QualityCheckSheets;
using Microsoft.EntityFrameworkCore;

namespace FmsbwebCoreApi.Repositories.QualityCheckSheets
{
    public class CheckSheetEntryRepository : ICheckSheetEntryRepository
    {
        private readonly QualityCheckSheetsContext _context;

        public CheckSheetEntryRepository(QualityCheckSheetsContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public IQueryable<CheckSheetEntry> Query()
        {
            return _context.CheckSheetEntries;
        }

        public CheckSheetEntry Query(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<CheckSheetEntry>> GetAll()
        {
            throw new NotImplementedException();
        }

        public async Task<CheckSheetEntry> GetById(int id)
        {
            return await _context.CheckSheetEntries.Include(x => x.Rechecks)
                    .FirstOrDefaultAsync(x => x.CheckSheetEntryId == id);
        }

        public async Task<CheckSheetEntry> Create(CheckSheetEntry data)
        {
            if (data == null) throw new ArgumentNullException(nameof(data));
            await using var transaction = await _context.Database.BeginTransactionAsync().ConfigureAwait(false);
            try
            {
                await _context.CheckSheetEntries.AddAsync(data).ConfigureAwait(false);
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

        public async Task<CheckSheetEntry> Update(CheckSheetEntry data)
        {
            if (data == null) throw new ArgumentNullException(nameof(data));
            await using var transaction = await _context.Database.BeginTransactionAsync().ConfigureAwait(false);
            try
            {
                _context.CheckSheetEntries.Update(data);
                await _context.SaveChangesAsync().ConfigureAwait(false);
                await transaction.CommitAsync().ConfigureAwait(false);
                return await _context.CheckSheetEntries.Include(x => x.Rechecks)
                        .FirstOrDefaultAsync(x => x.CheckSheetEntryId == data.CheckSheetEntryId);
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
                _context.CheckSheetEntries.Remove(new CheckSheetEntry { CharacteristicId = id });
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

        public async Task<CheckSheetEntry> IsExist(CheckSheetEntry data)
        {
            var result = await _context.CheckSheetEntries
                .AsNoTracking()
                .FirstOrDefaultAsync(x =>
                    x.CharacteristicId == data.CharacteristicId &&
                    x.Part == data.Part &&
                    x.Frequency == data.Frequency &&
                    x.CheckSheetId == data.CheckSheetId &&
                    x.SubMachineId == data.SubMachineId)
                .ConfigureAwait(false);

            return result;

        }

        public async Task<CheckSheetEntry> UpdateValueFromReCheck(ReCheck data)
        {
            var checkSheetEntry = await GetById(data.CheckSheetEntryId);
            checkSheetEntry.Value = data.Value;
            checkSheetEntry.ValueBool = data.ValueBool;
            checkSheetEntry.TimeStamp = DateTime.Now;
            await _context.SaveChangesAsync();
            return checkSheetEntry;
        }
    }
}
