using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FmsbwebCoreApi.Models.SAP
{
    public class DailyScrapByShiftDto :DailyScrap
    {
        public string Shift { get; set; }
        public int ShiftOrder { get; set; }
    }
}
