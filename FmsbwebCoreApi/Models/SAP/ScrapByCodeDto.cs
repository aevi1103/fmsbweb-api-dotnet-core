using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FmsbwebCoreApi.Models.SAP
{
    public class ScrapByCodeDto
    {
        public string Area { get; set; }
        public string ScrapType { get; set; } //SB or Purchase
        public string ScrapAreaName { get; set; } //fs, ms, anod, sc, assy
        public int Qty { get; set; }
        public int SapGross { get; set; } // Sap net + total scrap by code
        public decimal ScrapRate { get; set; }
    }
}
