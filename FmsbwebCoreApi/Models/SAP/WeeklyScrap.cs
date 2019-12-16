using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FmsbwebCoreApi.Models.SAP
{
    public class WeeklyScrap : Scrap
    {
        public int WeekNumber { get; set; } = 0;
    }
}
