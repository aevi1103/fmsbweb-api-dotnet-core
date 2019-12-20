using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FmsbwebCoreApi.Models.SAP
{
    public class ProductionDetailsDto
    {
        public string Department { get; set; }
        public string Area { get; set; }
        public int Target { get; set; }

        public int SapGross { get; set; }
        public int SapNet { get; set; }
        public decimal SapOae { get; set; }
        public IEnumerable<SapProdDetailDto> SapNetDetails { get; set; } = new List<SapProdDetailDto>();

        public int HxHGross { get; set; }
        public int HxHNet { get; set; }
        public decimal HxHOae { get; set; }

        public int TotalScrap { get; set; }
        public int TotalSbScrap { get; set; }
        public int TotalPurchaseScrap { get; set; }

        public decimal TotalScrapRate { get; set; }
        public decimal TotalSbScrapRate { get; set; }
        public decimal TotalPurchaseScrapRate { get; set; }

        public IEnumerable<Scrap> SbScrapDetails { get; set; } = new List<Scrap>();
        public IEnumerable<Scrap> PurchaseScrapDetails { get; set; } = new List<Scrap>();

        public IEnumerable<ScrapByCodeDetailsDto> SbScrapAreaDetails { get; set; } = new List<ScrapByCodeDetailsDto>();
    }
}
