using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FmsbwebCoreApi.Context.Fmsb2;
using FmsbwebCoreApi.Context.SAP;
using FmsbwebCoreApi.Entity.Fmsb2;
using FmsbwebCoreApi.Entity.SAP;
using FmsbwebCoreApi.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace FmsbwebCoreApi.Repositories
{
    public class LogisticsRepository : ILogisticsRepository
    {
        private readonly SapContext _context;
        private readonly Fmsb2Context _fmsb2Context;

        public LogisticsRepository(SapContext context, Fmsb2Context fmsb2Context)
        {
            _context = context;
            _fmsb2Context = fmsb2Context;
        }

        public async Task<List<SapDumpWithSafetyStock>> GetData(DateTime dateTime)
        {
            var qry = _context.SapDumpWithSafetyStock.AsQueryable();
            qry = qry.Where(x => x.Date == dateTime);

            return await qry
                .AsNoTracking()
                .ToListAsync()
                .ConfigureAwait(false);
        }

        public async Task<SapDumpWithSafetyStock> Insert(SapDumpWithSafetyStock data)
        {
            if (data == null) throw new ArgumentNullException(nameof(data));

            await using var transaction = await _context.Database.BeginTransactionAsync().ConfigureAwait(false);

            try
            {
                await _context.SapDumpWithSafetyStock.AddAsync(data).ConfigureAwait(false);
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

        public async Task RemoveRange(DateTime dateTime)
        {
            var isAny = await _context
                                .SapDumpWithSafetyStock
                                .AsNoTracking()
                                .AnyAsync(x => x.Date == dateTime)
                                .ConfigureAwait(false);

            if (!isAny) return;

            await using var transaction = await _context.Database.BeginTransactionAsync().ConfigureAwait(false);

            try
            {
                var dataToRemove = await _context.SapDumpWithSafetyStock
                    .Where(x => x.Date == dateTime)
                    .ToListAsync()
                    .ConfigureAwait(false);

                _context.SapDumpWithSafetyStock.RemoveRange(dataToRemove);
                await _context.SaveChangesAsync().ConfigureAwait(false);
                await transaction.CommitAsync().ConfigureAwait(false);
            }
            catch (Exception e)
            {
                await transaction.RollbackAsync().ConfigureAwait(false);
                throw new Exception(e.Message);
            }
        }

        public async Task<List<SapDumpNewUnpivotWithUnrestrictedInv>> GetDataUnpivot(DateTime datetime)
        {
            return await _context
                .SapDumpNewUnpivotWithUnrestrictedInv
                .AsNoTracking()
                .Where(x => x.Date == datetime)
                .ToListAsync()
                .ConfigureAwait(false);
        }

        public async Task<List<LogisticsInventoryCostTarget>> GetCostTargets()
        {
            return await _fmsb2Context
                .LogisticsInventoryCostTargets
                .Include(x => x.LogisticsInventoryCostType)
                .AsNoTracking()
                .ToListAsync()
                .ConfigureAwait(false);
        }

        public async Task<LogisticsInventoryCostTarget> AddOrUpdateCostTarget(LogisticsInventoryCostTarget data)
        {
            if (data == null) throw new ArgumentNullException(nameof(data));

            await using var transaction = await _fmsb2Context.Database.BeginTransactionAsync().ConfigureAwait(false);

            try
            {
                _fmsb2Context.Update(data);
                await _fmsb2Context.SaveChangesAsync().ConfigureAwait(false);
                await transaction.CommitAsync().ConfigureAwait(false);
                return data;
            }
            catch (Exception e)
            {
                await transaction.RollbackAsync().ConfigureAwait(false);
                throw new Exception(e.Message);
            }
        }

        public async Task<LogisticsCustomer> AddOrUpdateCustomerComment(LogisticsCustomer data)
        {
            if (data == null) throw new ArgumentNullException(nameof(data));

            await using var transaction = await _fmsb2Context.Database.BeginTransactionAsync().ConfigureAwait(false);

            try
            {
                _fmsb2Context.LogisticsCustomer.Update(data);
                await _fmsb2Context.SaveChangesAsync().ConfigureAwait(false);
                await transaction.CommitAsync().ConfigureAwait(false);
                return data;
            }
            catch (Exception e)
            {
                await transaction.RollbackAsync().ConfigureAwait(false);
                throw new Exception(e.Message);
            }
        }

        public async Task<List<LogisticCustomerName>> GetCustomerName()
        {
            return await _fmsb2Context
                .LogisticCustomerNames
                .AsNoTracking()
                .ToListAsync()
                .ConfigureAwait(false);
        }

        public async Task<List<LogisticsCustomer>> GetCustomerComments(DateTime dateTime)
        {
            var logistics = await _fmsb2Context
                .LogisticsMm
                .AsNoTracking()
                .FirstOrDefaultAsync(x => x.Date == dateTime)
                .ConfigureAwait(false);

            if (logistics == null) return new List<LogisticsCustomer>();
            return await _fmsb2Context
                .LogisticsCustomer
                .AsNoTracking()
                .Where(x => x.LogisticsId == logistics.Id)
                .ToListAsync()
                .ConfigureAwait(false);
        }

        public async Task<List<InvProgramTargets>> GetInventoryProgramTargets()
        {
            return await _context.InvProgramTargets
                .AsNoTracking()
                .ToListAsync()
                .ConfigureAwait(false);
        }

        public async Task<List<LogisticsInventoryCostType>> GetCostTypes()
        {
            return await _fmsb2Context.LogisticsInventoryCostTypes
                .AsNoTracking()
                .ToListAsync()
                .ConfigureAwait(false);
        }
    }
}
