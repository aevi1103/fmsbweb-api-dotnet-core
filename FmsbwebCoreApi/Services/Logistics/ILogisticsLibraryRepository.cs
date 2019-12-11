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

        List<SapDumpNewView> GetInventory(DateTime start, DateTime end);
        List<LogisticsCommentDto> GetLogisticsComments(DateTime start, DateTime end);
        List<string> GetDmaxParts();
        List<RawMatInv> GetRawMaterialsInventory(DateTime start, DateTime end);
        List<LogisticsDollarsDto> GetLogisticsDollars(DateTime start, DateTime end);

        IEnumerable<InventoryStatusDto> GetInventoryStatus(
                List<SapDumpNewView> inventoryData,
                List<string> dmax,
                List<LogisticsCommentDto> logiticsComments);
        IEnumerable<InventoryCostDto> GetInventoryCost(
            List<SapDumpNewView> data,
            List<RawMatInv> rawMatData,
            List<LogisticsDollarsDto> dollarsData,
            List<string> dmax);
        IEnumerable<CustomerCommentsDto> GetCustomerComments(DateTime start, DateTime end);

        DaysOnHandColorCode DaysOnHandStatusColor(decimal daysOnHand, int InvQty);
        IEnumerable<InventoryDaysOnHandDto> GetInventoryDaysOnHand(DateTime start, DateTime end);

        StockStatusDto GetStockStatus(DateTime start, DateTime end);
    }
}
