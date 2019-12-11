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
        public IEnumerable<InventoryStatusDto> InventoryStatus { get; set; }
        public IEnumerable<InventoryCostDto> InventoryCost { get; set; }
        public IEnumerable<CustomerCommentsDto> CustomerComments { get; set; }
        public IEnumerable<InventoryDaysOnHandDto> DaysOnHand { get; set; }
    }
}
