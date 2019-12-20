using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FmsbwebCoreApi.Models.SAP
{
    public class SapProdDetailDto
    {
        public DateTime DateScanned { get; set; }
        public DateTime ShiftDate { get; set; }
        public string Shift { get; set; }
        public string Line { get; set; }
        public string Program { get; set; }
        public string Part { get; set; }
        public string User { get; set; }
        public int SapNet { get; set; }
    }
}
