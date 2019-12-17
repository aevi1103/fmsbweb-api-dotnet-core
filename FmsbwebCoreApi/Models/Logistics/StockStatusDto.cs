using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FmsbwebCoreApi.Models.Logistics
{
    public class StockStatusDto
    {
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public IEnumerable<InventoryStatusDto> InventoryStatus { get; set; } = new List<InventoryStatusDto>();
        public IEnumerable<InventoryCostDto> InventoryCost { get; set; } = new List<InventoryCostDto>();
        public IEnumerable<CustomerCommentsDto> CustomerComments { get; set; } = new List<CustomerCommentsDto>();
        public IEnumerable<InventoryDaysOnHandDto> DaysOnHand { get; set; } = new List<InventoryDaysOnHandDto>();
    }
}
