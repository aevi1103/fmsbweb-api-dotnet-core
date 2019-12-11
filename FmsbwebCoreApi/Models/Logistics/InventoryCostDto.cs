using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FmsbwebCoreApi.Models.Logistics
{
    public class InventoryCostDto
    {
        public DateTime Date { get; set; }
        public string Category { get; set; }
        public double Actual { get; set; }
        public double Target { get; set; }
    }
}
