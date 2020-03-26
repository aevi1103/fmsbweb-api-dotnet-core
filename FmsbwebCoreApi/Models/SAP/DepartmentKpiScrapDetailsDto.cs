using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FmsbwebCoreApi.Models.SAP
{
    public class DepartmentKpiScrapDetailsDto
    {
        public string ScrapAreaName { get; set; }
        public int ScrapQty { get; set; }
        public decimal ScrapRate { get; set; }
        public string ColorCode { get; set; }
    }
}
