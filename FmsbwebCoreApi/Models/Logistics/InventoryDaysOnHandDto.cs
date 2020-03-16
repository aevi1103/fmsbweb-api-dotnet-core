using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FmsbwebCoreApi.Models.Logistics
{
    public class InventoryDaysOnHandDto
    {
        public DateTime Date { get; set; }
        public int Sort { get; set; }
        public string Program { get; set; }
        public string Material { get; set; }
        public int TotalUnreistrictedQty { get; set; }
        public int FinGoodIn0300 { get; set; }
        public int SafetyStock { get; set; }
        public int AvgShipDay { get; set; }
        public decimal DaysOnHand { get; set; }
        public DaysOnHandColorCode ColorCode { get; set; } = new DaysOnHandColorCode();
    }
}
