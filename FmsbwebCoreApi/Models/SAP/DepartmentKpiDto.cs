using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FmsbwebCoreApi.Models.SAP
{
    public class DepartmentKpiDto
    {
        public string Area { get; set; }
        public int TotalAreaScrap { get; set; }
        public int TotalProduction { get; set; }
        public int Target { get; set; }
        public int SapGross { get; set; }
        public decimal SapOae { get; set; }
        public string OaeColor { get; set; }
        public decimal OaeTarget { get; set; }
        public decimal OverallScrapRate { get; set; }
        public decimal DowntimeRate { get; set; }
        public decimal UnkownRate { get; set; }
        public List<DepartmentKpiScrapDetailsDto> ScrapDetails { get; set; }
    }
}
