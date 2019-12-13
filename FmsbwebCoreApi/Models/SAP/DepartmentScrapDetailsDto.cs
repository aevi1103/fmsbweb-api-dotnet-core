using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FmsbwebCoreApi.Models.SAP
{
    public class DepartmentScrapDetailsDto
    {
        public string Area { get; set; }
        public string ScrapType { get; set; }
        public int Qty { get; set; }
        public int SapGross { get; set; } // total dept scrap + sap net
        public decimal ScrapRate { get; set; }
    }
}
