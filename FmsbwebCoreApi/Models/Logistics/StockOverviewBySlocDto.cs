using FmsbwebCoreApi.Entity.SAP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FmsbwebCoreApi.Models.Logistics
{
    public class StockOverviewBySlocDto
    {
        public int SlocOrder { get; set; }
        public string Sloc { get; set; }
        public string SlocName { get; set; }
        public string Program { get; set; }
        public int Stock { get; set; }
    }
}
