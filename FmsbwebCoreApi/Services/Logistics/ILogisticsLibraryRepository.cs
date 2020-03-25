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

        Task<List<SapDumpNewView>> GetInventory(DateTime startDate, DateTime endDate);
        Task<List<LogisticsCommentDto>> GetLogisticsComments(DateTime startDate, DateTime endDate);
        List<string> GetDmaxParts();
        Task<List<RawMatInv>> GetRawMaterialsInventory(DateTime startDate, DateTime endDate);
        Task<List<LogisticsDollarsDto>> GetLogisticsDollars(DateTime startDate, DateTime endDate);

        IEnumerable<InventoryStatusDto> GetInventoryStatus(
                List<SapDumpNewView> inventoryData,
                List<string> dmax,
                List<LogisticsCommentDto> logiticsComments);
        IEnumerable<InventoryCostDto> GetInventoryCost(
            List<SapDumpNewView> data,
            List<RawMatInv> rawMatData,
            List<LogisticsDollarsDto> dollarsData,
            List<string> dmax);
        Task<IEnumerable<CustomerCommentsDto>> GetCustomerComments(DateTime startDate, DateTime endDate);

        DaysOnHandColorCode DaysOnHandStatusColor(decimal daysOnHand, int InvQty);
        Task<IEnumerable<InventoryDaysOnHandDto>> GetInventoryDaysOnHand(DateTime startDate, DateTime endDate);

        Task<StockStatusDto> GetStockStatus(DateTime startDate, DateTime endDate);
    }
}
