using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FmsbwebCoreApi.Entity.Fmsb2;
using FmsbwebCoreApi.Entity.SAP;

namespace FmsbwebCoreApi.Repositories.Interfaces
{
    public interface ILogisticsRepository
    {
        Task<List<SapDumpWithSafetyStock>> GetData(DateTime dateTime);
        Task<SapDumpWithSafetyStock> Insert(SapDumpWithSafetyStock data);
        Task<List<SapDumpNewUnpivotWithUnrestrictedInv>> GetDataUnpivot(DateTime datetime);
        Task<List<LogisticsInventoryCostType>> GetCostTypes();
        Task<List<LogisticCustomerName>> GetCustomerName();
        Task<List<InvProgramTargets>> GetInventoryProgramTargets();
        Task<List<LogisticsInventoryCostTarget>> GetCostTargets();
        Task<LogisticsInventoryCostTarget> AddOrUpdateCostTarget(LogisticsInventoryCostTarget data);
        Task DeleteCostTarget(int id);
        Task<LogisticsCustomer> AddOrUpdateCustomerComment(LogisticsCustomer data, DateTime dateTime);
        Task<List<LogisticsCustomer>> GetCustomerComments(DateTime dateTime);
        Task DeleteCustomerComment(int id);
        Task<List<LogisticsInventoryLocation>> GetInventoryLocations();

        Task<List<SapProdOrders>> GetProductionOrders(string workCenter);
        Task<List<string>> GetProductionOrderWorkCenters();

        Task<List<InvProgramTargets>> GetProgramSlocInventoryTargets();
        Task<InvProgramTargets> UpdateProgramSlocInventoryTargets(InvProgramTargets data);
        Task DeleteProgramSlocInventoryTargets(int id);
        Task<List<string>> GetDistinctPrograms();
        Task<List<string>> GetDistinctSloc();
        Task<List<StockSafetyDays>> GetStockSafetyDays();
        Task<StockSafetyDays> UpdateStockSafetyDay(StockSafetyDays data);
        Task<StockSafetyDays> DeleteStockSafetyDay(StockSafetyDays data);
    }
}
