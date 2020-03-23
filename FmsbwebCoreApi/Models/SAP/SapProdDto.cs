using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FmsbwebCoreApi.Models.SAP
{
    public class SapProdDto
    {
        public string SapType { get; set; }
        public string Area { get; set; }
        public int Qty { get; set; }
        public int WeekNumber { get; set; } = 0;
        public int Year { get; set; }
    }
}
