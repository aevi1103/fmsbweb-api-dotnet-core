using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FmsbwebCoreApi.Helpers
{
    public static class DateTimeExtensions
    {
        public static bool IsYesterday(this DateTime date)
        {
            return date.Date == DateTime.Today.AddDays(-1) ? true : false;
        }
    }
}
