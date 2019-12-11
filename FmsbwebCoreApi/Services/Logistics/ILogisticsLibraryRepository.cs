using FmsbwebCoreApi.Models.Logistics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using FmsbwebCoreApi.Entity.SAP;

namespace FmsbwebCoreApi.Services.Logistics
{
    public interface ILogisticsLibraryRepository
    {
        IEnumerable<GetStockOverviewDto> GetStockOverview(DateTime date);
        IEnumerable<InvProgramTargets> GetProgramTargets();
        IEnumerable<StockOverviewBySlocDto> GetStockOverviewBySloc(DateTime date);

        IEnumerable<SapDumpNewView> GetInventory(DateTime start, DateTime end);
        IEnumerable<LogisticsCommentDto> GetLogisticsComments(DateTime start, DateTime end);
        IEnumerable<string> GetDmaxParts();
        IEnumerable<RawMatInv> GetRawMaterialsInventory(List<string> dmax, DateTime start, DateTime end);
        IEnumerable<LogisticsDollarsDto> GetLogisticsDollars(DateTime start, DateTime end);

        IEnumerable<InventoryStatusDto> GetInventoryStatus(
                List<SapDumpNewView> data,
                List<string> dmax,
                List<LogisticsCommentDto> logiticsComments);
        IEnumerable<InventoryCostDto> GetInventoryCost(List<SapDumpNewView> data, DateTime start, DateTime end);
        IEnumerable<CustomerCommentsDto> GetCustomerComments(DateTime start, DateTime end);

        StockStatusDto GetStockStatus(DateTime start, DateTime end);
    }
}
