using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FmsbwebCoreApi.Models.SAP
{
    public class ProductionMorningMeetingDto
    {
        public string Department { get; set; }
        public string Area { get; set; }
        public int Target { get; set; }
        public int HxhGross { get; set; }
        public int SapGross { get; set; }
        public int PlannedWarmers { get; set; }
        public int UnPlannedWarmers { get; set; }
        public int TotalSbScrap { get; set; }
        public int TotalScrapByDept { get; set; } // SB + Purchase
        public int SapNet { get; set; }
        public int HxHNet { get; set; }
        public decimal SapOae { get; set; }
        public decimal HxhOae { get; set; }
        public IEnumerable<ScrapByCodeDto> SbScrapByCode { get; set; }
        public IEnumerable<ScrapByCodeDto> PurchaseScrapByCode { get; set; }
        public IEnumerable<DepartmentScrapDto> DepartmentScrap { get; set; }
    }
}
