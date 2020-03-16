using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FmsbwebCoreApi.Models.Logistics
{
    public class GetStockOverviewDto
    {
        public string Program { get; set; }
        public DateTime Date { get; set; }
        public int Total { get; set; }
        public int _0111{ get; set; }
        public int _0115 { get; set; }
        public int _4000 { get; set; }
        public int _5000 { get; set; }
        public int Qc01 { get; set; }
        public int Qc02 { get; set; }
        public int Qc03 { get; set; }
        public int Qc04 { get; set; }
        public int Qc05 { get; set; }
        public int _0130 { get; set; }
        public int _0131 { get; set; }
        public int _0135 { get; set; }
        public int _0160 { get; set; }
        public int _0300 { get; set; }
        public int _0125 { get; set; }
    }
}
