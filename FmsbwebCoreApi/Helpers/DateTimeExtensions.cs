using System;
using System.Collections.Generic;
using System.Globalization;
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

        public static DateTime ToDateTime(this DateTime? date)
        {
            return Convert.ToDateTime(date);
        }

        public static double ToQuarter(this DateTime date)
        {
            return Math.Ceiling(date.Month / 3.0);
        }

        public static int ToWeekNumber(this DateTime thisDate)
        {
            return CultureInfo.InvariantCulture.Calendar.GetWeekOfYear(thisDate, CalendarWeekRule.FirstDay, DayOfWeek.Sunday);
        }
    }

    public class DateTimeHelpers
    {
        public DateTime ShiftDate { get; set; }
        public string Shift { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }

        public DateTime EndOfHour(DateTime? date)
        {
            var dte = Convert.ToDateTime(date);
            var time = new TimeSpan(dte.Hour, 59, 59);
            return dte.Date + time;
        }

        public double ElapsedTime(DateTime? start, DateTime? end)
        {
            try
            {
                double downtime;

                if (start == null)
                {
                    start = DateTime.Now;
                }

                if (end == null)
                {
                    end = DateTime.Now;
                }

                downtime = Math.Round(((end.ToDateTime() - start.ToDateTime()).TotalMinutes), 0);

                return downtime;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error Msg: {ex.Message} | Stack: {ex.StackTrace}");
            }
        }

        private TimeSpan GetTimeSpan(int hour, int min = 0, int sec = 0)
        {
            var res = new TimeSpan(hour, min, sec);
            return res;
        }

        public DateTimeHelpers GetDateShiftEightHours(DateTime dateTime)
        {
            /*
             3rd shift - 11:01 pm - 7:00am
             1st shift - 7:01 am - 3:00 pm
             2nd shift - 3:01 pm - 11:00 pm
             */

            var ds = new DateTimeHelpers();
            ds.ShiftDate = dateTime.Date;

            var hour = dateTime.Hour;
            var min = dateTime.Minute;
            var timeSpan = new TimeSpan(hour, min, 0);

            if ((timeSpan >= GetTimeSpan(23)) && (timeSpan <= GetTimeSpan(23, 59, 59))) // 11pm - 11:59:59 pm
            {
                ds.Shift = "3";
                ds.ShiftDate = dateTime.Date.AddDays(1); //add the next day if its between 11pm - 12am
            }
            else if ((timeSpan >= GetTimeSpan(0, 0, 0)) && (timeSpan <= GetTimeSpan(6, 59, 59))) //12 am - 7amB
            {
                ds.Shift = "3";
            }
            else if ((timeSpan >= GetTimeSpan(7)) && (timeSpan <= GetTimeSpan(14, 59, 59))) // 7am - 3pm
            {
                ds.Shift = "1";
            }
            else if ((timeSpan >= GetTimeSpan(15)) && (timeSpan <= GetTimeSpan(22, 59, 59))) // 3pm - 11pm
            {
                ds.Shift = "2";
            }

            return ds;
        }

        public int MapHourToHxHHoursForEightHourShift(DateTime dateTime)
        {
            var hour = dateTime.Hour;
            var shift = GetDateShiftEightHours(dateTime).Shift;

            if (shift == "3")
            {
                switch (hour)
                {
                    case 23:
                        return 1;
                    case 0:
                        return 2;
                    case 1:
                        return 3;
                    case 2:
                        return 4;
                    case 3:
                        return 5;
                    case 4:
                        return 6;
                    case 5:
                        return 7;
                    case 6:
                        return 8;
                }
            }

            if (shift == "1")
            {
                switch (hour)
                {
                    case 7:
                        return 1;
                    case 8:
                        return 2;
                    case 9:
                        return 3;
                    case 10:
                        return 4;
                    case 11:
                        return 5;
                    case 12:
                        return 6;
                    case 13:
                        return 7;
                    case 14:
                        return 8;
                }
            }

            if (shift == "2")
            {
                switch (hour)
                {
                    case 15:
                        return 1;
                    case 16:
                        return 2;
                    case 17:
                        return 3;
                    case 18:
                        return 4;
                    case 19:
                        return 5;
                    case 20:
                        return 6;
                    case 21:
                        return 7;
                    case 22:
                        return 8;
                }
            }

            return 0;

        }
    }
}
