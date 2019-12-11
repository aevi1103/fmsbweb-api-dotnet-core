using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FmsbwebCoreApi.Models.Logistics
{
    public class InventoryCostDto
    {
        public int Sort { get; set; }
        public DateTime Date { get; set; }
        public string Category { get; set; }
        public decimal Cost { get; set; }
        public double Target { get; set; }
    }
}
