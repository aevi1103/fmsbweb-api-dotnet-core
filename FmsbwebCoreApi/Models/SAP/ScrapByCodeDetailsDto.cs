using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FmsbwebCoreApi.Models.SAP
{
    public class ScrapByCodeDetailsDto
    {
        public string Area { get; set; }
        public string ScrapType { get; set; } //SB or Purchase
        public bool? IsPurchaseScrap { get; set; }
        public string ScrapAreaName { get; set; } //fs, ms, anod, sc, assy
        public int Qty { get; set; }
        public int SapGross { get; set; } // Sap net + total scrap by code
        public decimal ScrapRate { get; set; }
        public IEnumerable<Scrap> Details { get; set; } = new List<Scrap>();
    }
}
