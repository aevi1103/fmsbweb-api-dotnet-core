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

        public async Task DeleteCostTarget(int id)
        {
            await using var transaction = await _fmsb2Context.Database.BeginTransactionAsync().ConfigureAwait(false);

            try
            {
                _fmsb2Context.LogisticsInventoryCostTargets.Remove(new LogisticsInventoryCostTarget {LogisticsInventoryCostTargetId = id});
                await _fmsb2Context.SaveChangesAsync().ConfigureAwait(false);
                await transaction.CommitAsync().ConfigureAwait(false);
            }
            catch (Exception e)
            {
                await transaction.RollbackAsync().ConfigureAwait(false);
                throw new Exception(e.Message);
            }
        }

        public async Task<LogisticsCustomer> AddOrUpdateCustomerComment(LogisticsCustomer data, DateTime dateTime)
        {
            if (data == null) throw new ArgumentNullException(nameof(data));

            await using var transaction = await _fmsb2Context.Database.BeginTransactionAsync().ConfigureAwait(false);

            try
            {
                var logistics = await _fmsb2Context
                    .LogisticsMm
                    .AsNoTracking()
                    .FirstOrDefaultAsync(x => x.Date == dateTime)
                    .ConfigureAwait(false);

                if (logistics == null)
                {
                    logistics = new LogisticsMm
                    {
                        Date = dateTime,
                        ModifiedDate = DateTime.Now
                    };

                    await _fmsb2Context.LogisticsMm.AddAsync(logistics).ConfigureAwait(false);
                    await _fmsb2Context.SaveChangesAsync().ConfigureAwait(false);

                    data.LogisticsId = logistics.Id;
                }

                if (data.LogisticsId == 0)
                    data.LogisticsId = logistics.Id;

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
                .OrderBy(x => x.LogisticCustomerNameId)
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
                .OrderByDescending(x => x.Comment)
                .ToListAsync()
                .ConfigureAwait(false);
        }

        public async Task DeleteCustomerComment(int id)
        {
            await using var transaction = await _fmsb2Context.Database.BeginTransactionAsync().ConfigureAwait(false);

            try
            {
                _fmsb2Context.LogisticsCustomer.Remove(new LogisticsCustomer { Id = id });
                await _fmsb2Context.SaveChangesAsync().ConfigureAwait(false);
                await transaction.CommitAsync().ConfigureAwait(false);
            }
            catch (Exception e)
            {
                await transaction.RollbackAsync().ConfigureAwait(false);
                throw new Exception(e.Message);
            }
        }

        public async Task<List<LogisticsInventoryLocation>> GetInventoryLocations()
        {
            return await _fmsb2Context.LogisticsInventoryLocations.ToListAsync().ConfigureAwait(false);
        }

        public async Task<List<SapProdOrders>> GetProductionOrders(string workCenter)
        {
            return await _context.SapProdOrders
                    .AsNoTracking()
                    .Where(x => x.WorkCenter.ToLower() == workCenter.ToLower().Trim() && !string.IsNullOrEmpty(x.ActStartDateExecution))
                    .ToListAsync()
                    .ConfigureAwait(false);
        }

        public async Task<List<string>> GetProductionOrderWorkCenters()
        {
            return await _context.SapProdOrders.Select(x => x.WorkCenter).Distinct().OrderBy(x => x).ToListAsync()
                .ConfigureAwait(false);
        }

        public async Task<List<InvProgramTargets>> GetProgramSlocInventoryTargets()
        {
            return await _context.InvProgramTargets
                .AsNoTracking()
                .OrderBy(x => x.Program)
                .ThenBy(x => x.Sloc)
                .ToListAsync()
                .ConfigureAwait(false);
        }

        public async Task<InvProgramTargets> UpdateProgramSlocInventoryTargets(InvProgramTargets data)
        {
            if (data == null) throw new ArgumentNullException(nameof(data));

            await using var transaction = await _fmsb2Context.Database.BeginTransactionAsync().ConfigureAwait(false);

            try
            {
                if (data.Id == 0)
                {
                    var isExist = await _context.InvProgramTargets
                        .AnyAsync(x => x.Program == data.Program && x.Sloc == data.Sloc)
                        .ConfigureAwait(false);

                    if (isExist)
                        throw new OperationCanceledException($"{data.Program} in {data.Sloc} already exist in the database! Please update the record instead.");
                }

                _context.InvProgramTargets.Update(data);
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

        public async Task DeleteProgramSlocInventoryTargets(int id)
        {
            await using var transaction = await _fmsb2Context.Database.BeginTransactionAsync().ConfigureAwait(false);

            try
            {
                _context.InvProgramTargets.Remove(new InvProgramTargets { Id = id});
                await _context.SaveChangesAsync().ConfigureAwait(false);
                await transaction.CommitAsync().ConfigureAwait(false);
            }
            catch (Exception e)
            {
                await transaction.RollbackAsync().ConfigureAwait(false);
                throw new Exception(e.Message);
            }
        }

        public async Task<List<string>> GetDistinctPrograms()
        {
            return await _context.SapDumpWithSafetyStock
                .Select(x => x.Program)
                .Distinct()
                .Where(x => !string.IsNullOrEmpty(x))
                .OrderBy(x => x)
                .ToListAsync()
                .ConfigureAwait(false);
        }

        public async Task<List<string>> GetDistinctSloc()
        {
            return await _context.SapDumpNewUnpivot
                .Select(x => x.Location)
                .Distinct()
                .Where(x => !string.IsNullOrEmpty(x))
                .OrderBy(x => x)
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

        public async Task<List<StockSafetyDays>> GetStockSafetyDays()
        {
            return await _fmsb2Context.StockSafetyDays.ToListAsync().ConfigureAwait(false);
        }

        public async Task<StockSafetyDays> UpdateStockSafetyDay(StockSafetyDays data)
        {
            await using var transaction = await _fmsb2Context.Database.BeginTransactionAsync().ConfigureAwait(false);
            try
            {
                _fmsb2Context.StockSafetyDays.Update(data);
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

        public async Task<StockSafetyDays> DeleteStockSafetyDay(StockSafetyDays data)
        {
            _fmsb2Context.StockSafetyDays.Remove(data);
            await _fmsb2Context.SaveChangesAsync().ConfigureAwait(false);
            return data;
        }
    }
}
