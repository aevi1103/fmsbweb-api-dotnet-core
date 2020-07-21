using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FmsbwebCoreApi.Models.SAP;
using NUnit.Framework.Constraints;

namespace FmsbwebCoreApi.Models
{
    public class EndOfShiftScrapDetailDto
    {
        public string ScrapArea { get; set; }
        public int Qty { get; set; }
        public decimal ScrapTargetRate { get; set; }
        public decimal ScrapRate { get; set; }
        public List<Scrap> Details { get; set; } = new List<Scrap>();
    }
}
