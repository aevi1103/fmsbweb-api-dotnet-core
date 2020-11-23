using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DateShiftLib.Extensions;
using Nager.Date;
using Nager.Date.Extensions;

namespace FmsbwebCoreApi.Models
{
    public class DatesWithWorkingDayFlag
    {
        public DateTime Date { get; set; }
        public bool IsWeekEnd => Date.IsWeekend(CountryCode.US);
        public bool IsWorkingDay => !IsWeekEnd && !DateSystem.IsPublicHoliday(Date, CountryCode.US);
        public int WeekNumber => Date.ToWeekNumber();
        public string Day => Date.ToString("ddd");
        public bool IsHoliday => DateSystem.IsPublicHoliday(Date, CountryCode.US);

        public string Holiday => DateSystem
            .GetPublicHoliday(Date, Date, CountryCode.US).FirstOrDefault()
            ?.Name;
    }
}
