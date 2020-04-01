using FmsbwebCoreApi.Entity.Fmsb2;
using FmsbwebCoreApi.Models.FMSB2;
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
        public ScrapByCodeDto SbScrapByCode { get; set; } = new ScrapByCodeDto();
        public ScrapByCodeDto PurchaseScrapByCode { get; set; } = new ScrapByCodeDto();
        public DepartmentScrapDto DepartmentScrap { get; set; } = new DepartmentScrapDto();
        public SapProductionByTypeDto SapProductionByType { get; set; } = new SapProductionByTypeDto();
        public ProductionLaborHoursDto LaborHours { get; set; } = new ProductionLaborHoursDto();

        public string SapOaeColorCode { get; set; }
        public string HxhOaeColorCode { get; set; }
        public string ScrapByCodeColorCode { get; set; }
        public string PpmhColorCode { get; set; }

        public KpiTarget Targets { get; set; }
    }
}
