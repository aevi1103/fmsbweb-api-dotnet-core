using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FmsbwebCoreApi.Models.SAP;
using NUnit.Framework.Constraints;

namespace FmsbwebCoreApi.Models
{
    public class EndOfShiftDto
    {
        public int Id { get; set; }
        public string Department { get; set; }
        public string Area { get; set; }
        public string Line { get; set; }
        public int MachineId { get; set; }
        public DateTime ShiftDate { get; set; }
        public string Shift { get; set; }
        public decimal Target { get; set; }
        public decimal OaeTarget { get; set; }
        public decimal AfScrapRateTarget { get; set; }
        public decimal OverallScrapRateTarget { get; set; }
        public decimal PpmhTarget { get; set; }
        public int HxHGross { get; set; }
        public int HxHNet { get; set; }
        public decimal HxHOae { get; set; }
        public int PlcCounter { get; set; }
        public int SapGross { get; set; }
        public int SapNet { get; set; }
        public decimal SapOae { get; set; }
        public int TotalSbScrap { get; set; }
        public int TotalPurchaseScrap { get; set; }
        public int TotalAfScrap { get; set; }
        public int TotalScrap { get; set; }
        public decimal TotalSbScrapRate { get; set; }
        public decimal TotalPurchaseScrapRate { get; set; }
        public decimal TotalAfScrapRate { get; set; }
        public decimal TotalScrapRate { get; set; }
        public List<EndOfShiftScrapDetailDto> SbScrapDetails { get; set; } = new List<EndOfShiftScrapDetailDto>();
        public List<Scrap> SbScrapDefects { get; set; } = new List<Scrap>();
        public List<Scrap> PurchasedScrapDefects { get; set; } = new List<Scrap>();
        public List<Scrap> AfScrapDefects { get; set; } = new List<Scrap>();
        public List<Scrap> TotalScrapDefects { get; set; } = new List<Scrap>();
        public List<SapProdDetailDto> ProductionDetails { get; set; }
        public string ScrapComment { get; set; }
        public string DowntimeComment { get; set; }
        public int? Manning { get; set; }
        public decimal Ppmh { get; set; }
        public string HxHUrl { get; set; }

    }
}
