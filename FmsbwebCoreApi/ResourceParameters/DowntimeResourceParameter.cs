using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FmsbwebCoreApi.Enums;

namespace FmsbwebCoreApi.ResourceParameters
{
    public class DowntimeResourceParameter
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string TagName { get; set; } = "";
        public string Line { get; set; } = "";
        public Guid OeeId { get; set; }
        public DowntimeEventType DowntimeEventType { get; set; } = DowntimeEventType.None;
    }
}
