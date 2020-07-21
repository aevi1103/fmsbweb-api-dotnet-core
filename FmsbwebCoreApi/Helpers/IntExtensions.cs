using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace FmsbwebCoreApi.Helpers
{
    public static class IntExtensions
    {
        private static CultureInfo CultureInfo { get; } = new CultureInfo("en-US");

        public static int ToInt(this int? value)
        {
            return Convert.ToInt32(value, CultureInfo);
        }

        public static int ToInt(this decimal value)
        {
            return Convert.ToInt32(value, CultureInfo);
        }

    }
}
