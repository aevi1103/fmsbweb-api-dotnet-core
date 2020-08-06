using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FmsbwebCoreApi.Models.Intranet
{
    public class HxHProductionByLineDto : HxhProductionDto
    {
        public string Line { get; set; }
        public int MachineId { get; set; }
        public string HxHUrl { get; set; }
    }
}
