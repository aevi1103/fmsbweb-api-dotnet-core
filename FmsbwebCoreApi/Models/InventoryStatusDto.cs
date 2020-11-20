using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FmsbwebCoreApi.Models
{
    public class InventoryStatusDto
    {
        public DateTime? Date { get; set; }
        public string Sloc { get; set; }
        public int SlocOrder { get; set; }
        public decimal Qty { get; set; }
        public string Comments { get; set; }
    }
}
