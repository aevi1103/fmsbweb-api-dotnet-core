using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FmsbwebCoreApi.Models
{
    public class SwotTargetDto
    {
        public decimal OaeTarget { get; set; }
        public int TargetPartsPerHour { get; set; }
        public decimal FoundryScrapTarget { get; set; }
        public decimal MachineScrapTarget { get; set; }
        public decimal AfScrapTarget { get; set; }

        public int NetRate => (int)Math.Round((TargetPartsPerHour * OaeTarget), 0);
        public decimal OverallScrapTarget => FoundryScrapTarget + MachineScrapTarget + AfScrapTarget;
    }
}
