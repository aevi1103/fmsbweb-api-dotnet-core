using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using FluentDateTime;

namespace FmsbwebCoreApi.ResourceParameters
{
    public class SwotResourceParameter
    {
        [Required]
        public DateTime StartDate { get; set; }

        [Required]
        public DateTime EndDate { get; set; }

        public int LastMonths { get; set; } = 3;
        public int LastWeeks { get; set; } = 3;
        public int LastDays { get; set; } = 7;

        [Required]
        public string Dept { get; set; }

        public List<string> Lines { get; set; } = new List<string>();

        public bool ShowMonthlyCharts { get; set; } = false;
        public bool ShowLastSevenDays { get; set; } = false;

        public DateTime MonthStart => EndDate.BeginningOfMonth().AddMonths(-LastMonths);
        public DateTime MonthEnd => EndDate;

        public DateTime WeekEnd => EndDate.BeginningOfWeek().AddDays(-1);
        public DateTime WeekStart => WeekEnd.AddDays((LastWeeks * 7) + 1);

        public DateTime LastDayStart => EndDate.AddDays(-LastDays);
        public DateTime LastDayEnd => EndDate;
    }
}
