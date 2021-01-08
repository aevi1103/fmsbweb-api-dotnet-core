using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FmsbwebCoreApi.Enums;

namespace FmsbwebCoreApi.ResourceParameters
{
    public class DowntimeInputResourceParameter
    {
        public Guid DowntimeId { get; set; } = Guid.Empty;
        public bool PlannedDowntime { get; set; }
        public Guid MachineId { get; set; }
        public Guid SecondaryReasonId { get; set; }
        public int Downtime { get; set; }
        public string Comment { get; set; }
        public Guid OeeId { get; set; }
        public byte[] Timestamp { get; set; }
    }
}
