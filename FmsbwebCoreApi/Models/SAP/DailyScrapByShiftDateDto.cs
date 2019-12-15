using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FmsbwebCoreApi.Models.SAP
{
    public class DailyScrapByShiftDateDto
    {
        public string ScrapArea { get; set; }
        public DateTime ShiftDate { get; set; }
        public int SapGross { get; set; }
        public int SapNet { get; set; }
        public int TotalScrap { get; set; }
        public decimal? ScrapRate { get; set; }
    }
}
