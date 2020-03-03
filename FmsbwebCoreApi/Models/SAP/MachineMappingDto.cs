using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FmsbwebCoreApi.Models.SAP
{
    public class MachineMappingDto
    {
        public string WorkCenter { get; set; }
        public string Area { get; set; }
        public string Line { get; set; }
        public string Side { get; set; }
    }
}
