using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FmsbwebCoreApi.Models.SAP
{
    public class ProductionByLineDto : ProductionDetailsDto
    {
        public string Line { get; set; }

        public decimal OaeTarget { get; set; }
        public decimal FoundryScrapRateTarget { get; set; }
        public decimal MachiningScrapRateTarget { get; set; }
        public decimal AfScrapRateTarget { get; set; }

        public int ComponentScrap { get; set; }
        public decimal ComponentScrapRate { get; set; }
        public decimal DowntimeRate { get; set; }
    }
}
