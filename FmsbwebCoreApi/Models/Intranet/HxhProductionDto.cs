using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FmsbwebCoreApi.Models.Intranet
{
    public class HxhProductionDto
    {
        public string Department { get; set; }
        public string Area { get; set; }
        public decimal Target { get; set; }
        public int Gross { get; set; }
    }
}
