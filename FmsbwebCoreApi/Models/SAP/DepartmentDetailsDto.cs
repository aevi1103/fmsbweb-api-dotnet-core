using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FmsbwebCoreApi.Models.SAP
{
    public class DepartmentDetailsDto
    {
        public string Area { get; set; }
        public int Target { get; set; }
        public decimal OaeTarget { get; set; }

        public int SapGross { get; set; }
        public int SapNet { get; set; }
        public decimal SapOae { get; set; }

        public int HxhGross { get; set; }
        public int HxHNet { get; set; }
        public decimal HxHOae { get; set; }

        public int TotalScrap { get; set; }
        public int TotalSbScrap { get; set; }
        public int TotalPurchaseScrap { get; set; }

        public decimal TotalScrapRate { get; set; }
        public decimal TotalSbScrapRate { get; set; }
        public decimal TotalPurchaseScrapRate { get; set; }

        public IEnumerable<ProductionByLineDto> DetailsByLine { get; set; } = new List<ProductionByLineDto>();
        public IEnumerable<ProductionByProgramDto> DetailsByProgram { get; set; } = new List<ProductionByProgramDto>();

        public IEnumerable<Scrap> SbScrapDetails { get; set; } = new List<Scrap>(); 
        public IEnumerable<Scrap> PurchaseScrapDetails { get; set; } = new List<Scrap>();

        public IEnumerable<ScrapByCodeDetailsDto> SbScrapAreaDetails { get; set; } = new List<ScrapByCodeDetailsDto>();
    }
}
