using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FmsbwebCoreApi.Models.Intranet
{
    public class HourlyProductionDto : HxHProductionByLineDto
    {
        public DateTime ShiftDate { get; set; }
        public string Shift { get; set; }
        public int Hour { get; set; }
        public int ShiftOrder => GetShiftOrder();
        public string CellSide { get; set; }
        public bool IsCurrentHour { get; set; }

        private int GetShiftOrder()
        {
            return Shift switch
            {
                "3" => 1,
                "1" => 2,
                "2" => 3,
                _ => 999
            };
        }
    }
}
