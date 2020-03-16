using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FmsbwebCoreApi.Models.Logistics
{
    public class InventoryStatusDto
    {
        public int Sort { get; set; }
        public DateTime? Date { get; set; }
        public string Category { get; set; }
        public decimal Total { get; set; }
        public decimal AvgDays { get; set; }
        public string Comments { get; set; }
    }
}
