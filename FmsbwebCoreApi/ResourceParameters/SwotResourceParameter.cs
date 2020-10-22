using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Linq;
using FluentDateTime;
using FmsbwebCoreApi.Models;
using FmsbwebCoreApi.Services;
using Microsoft.EntityFrameworkCore.Internal;

namespace FmsbwebCoreApi.ResourceParameters
{
    public class SwotResourceParameter
    {
        [Required]
        public DateTime StartDate { get; set; }

        [Required]
        public DateTime EndDate { get; set; }

        [Required]
        public string Dept { get; set; }

        public string Lines { get; set; } = "";
        public bool ShowMonthlyCharts { get; set; } = false;
        public bool ShowLastSevenDays { get; set; } = false;

        public int LastMonths { get; set; } = 3;
        public int LastWeeks { get; set; } = 3;
        public int LastDays { get; set; } = 7;
        public int Take { get; set; } = 0; // last x number of defects for scrap pareto

        public List<string> LinesArr =>
            string.IsNullOrEmpty(Lines)
                ? new List<string>()
                : Lines.Split(',').Select(x => x.Trim()).ToList();

        public DateTime MonthStart => EndDate.BeginningOfMonth().AddMonths(-LastMonths + 1);
        public DateTime MonthEnd => EndDate;

        public DateTime WeekEnd => EndDate;
        public DateTime WeekStart => GetWeekStart();

        public DateTime LastDayStart => EndDate.AddDays(-LastDays + 1);
        public DateTime LastDayEnd => EndDate;

        public string Area => new UtilityService().MapDepartmentToArea(Dept);

        public bool IsFinishing => Dept.ToLower() == "anodize" || Dept.ToLower() == "skirt coat";

        private DateTime GetWeekStart()
        {
            var daysToSubtract = ((LastWeeks - 1) * 7) - 1;
            var wkEnd = EndDate.BeginningOfWeek().AddDays(-1);
            return wkEnd.AddDays(-daysToSubtract);
        }

    }
}
