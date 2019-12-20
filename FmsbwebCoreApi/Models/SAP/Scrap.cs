using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FmsbwebCoreApi.Models.SAP
{
    public class Scrap
    {
        public string Department { get; set; }
        public string Area { get; set; }
        public string Line { get; set; } = "";
        public string Program { get; set; } = "";
        public string ScrapAreaName { get; set; }       
        public bool IsPurchashedExclude { get; set; }
        public string IsPurchashedExclude2 { get; set; }
        public string ScrapCode { get; set; }
        public string ScrapDesc { get; set; }
        public int Qty { get; set; }
    }
}
