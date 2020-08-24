using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FmsbwebCoreApi.Context.QualityCheckSheets;
using FmsbwebCoreApi.Controllers.QualityCheckSheets;
using FmsbwebCoreApi.Entity.QualityCheckSheets;
using FmsbwebCoreApi.Repositories.Interfaces.QualityCheckSheets;
using Microsoft.EntityFrameworkCore;

namespace FmsbwebCoreApi.Repositories.QualityCheckSheets
{
    public class CheckSheetRepository : ICheckSheetRepository
    {
        private readonly QualityCheckSheetsContext _context;

        public CheckSheetRepository(QualityCheckSheetsContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public IQueryable<CheckSheet> Query()
        {
            return _context.CheckSheets.AsNoTracking();
        }

        public CheckSheet Query(int id)
        {
            return _context.CheckSheets.AsNoTracking()
                .Include(x => x.ControlMethod)
                .Include(x => x.Line)
                .Include(x => x.OrganizationPart)
                .FirstOrDefault(x => x.CheckSheetId == id);
        }

        public Task<List<CheckSheet>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<CheckSheet> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<CheckSheet> Create(CheckSheet data)
        {
            if (data == null) throw new ArgumentNullException(nameof(data));
            await using var transaction = await _context.Database.BeginTransactionAsync().ConfigureAwait(false);
            try
            {
                await _context.CheckSheets.AddAsync(data).ConfigureAwait(false);
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

        public async Task<CheckSheet> Update(CheckSheet data)
        {
            if (data == null) throw new ArgumentNullException(nameof(data));
            await using var transaction = await _context.Database.BeginTransactionAsync().ConfigureAwait(false);
            try
            {
                _context.CheckSheets.Update(data);
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
                _context.CheckSheets.Remove(new CheckSheet { CheckSheetId = id });
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

        public async Task<CheckSheet> IsExist(CheckSheet data)
        {
            return await _context.CheckSheets.AsNoTracking()
                        .FirstOrDefaultAsync(x => x.ControlMethodId == data.ControlMethodId &&
                                            x.LineId == data.LineId &&
                                            x.OrganizationPartId == data.OrganizationPartId &&
                                            x.ShiftDate == data.ShiftDate &&
                                            x.Shift == data.Shift)
                        .ConfigureAwait(false);
        }
    }
}
