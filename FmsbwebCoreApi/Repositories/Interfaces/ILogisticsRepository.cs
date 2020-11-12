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

        Task RemoveRange(DateTime dateTime);

        Task<List<SapDumpNewUnpivot>> GetDataUnpivot(DateTime datetime);
        Task<List<LogisticsInventoryCostTarget>> GetCostTarget();
        Task<LogisticsInventoryCostTarget> AddOrUpdateCostTarget(LogisticsInventoryCostTarget data);
        Task<LogisticsCustomer> AddOrUpdateCustomerComment(LogisticsCustomer data);
        Task<List<LogisticCustomerName>> GetCustomerName();
        Task<List<LogisticsCustomer>> GetCustomerComments(DateTime dateTime);
    }
}
