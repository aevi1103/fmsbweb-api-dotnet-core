using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FmsbwebCoreApi.Models.Intranet
{
    public class DailyHxHTargetDto
    {
        public string Area { get; set; }
        public DateTime ShiftDate { get; set; }
        public int Target { get; set; }
    }
}
