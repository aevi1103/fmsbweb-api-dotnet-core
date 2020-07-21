using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NUnit.Framework.Constraints;

namespace FmsbwebCoreApi.Models
{
    public class EndOfShiftDto
    {
        public string Department { get; set; }
        public string Area { get; set; }
        public string Line { get; set; }
        public string Shift { get; set; }
        public decimal Target { get; set; }
        public decimal OaeTarget { get; set; }
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
        public List<EndOfShiftScrapDetailDto> PurchasedScrapDetails { get; set; } = new List<EndOfShiftScrapDetailDto>();
        public string ScrapComment { get; set; }
        public string DowntimeComment { get; set; }
        public int Manning { get; set; }

    }
}
