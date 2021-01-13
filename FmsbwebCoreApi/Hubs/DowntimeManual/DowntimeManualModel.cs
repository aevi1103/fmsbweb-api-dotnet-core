using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FmsbwebCoreApi.Hubs.DowntimeManual
{
    public class DowntimeManualModel
    {
        public Guid DowntimeEventId { get; set; }
        public int DowntimeEventType { get; set; }
        public Guid MachineId { get; set; }
        public Guid SecondaryReasonId { get; set; }
        public int Downtime { get; set; }
        public string Comment { get; set; }
        public string OeeId { get; set; }
    }
}
