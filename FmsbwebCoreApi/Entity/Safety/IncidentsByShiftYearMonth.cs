using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Safety
{
    public partial class IncidentsByShiftYearMonth
    {
        public int? Year { get; set; }
        public int? MonthNum { get; set; }
        [StringLength(30)]
        public string MonthName { get; set; }
        [Required]
        [StringLength(50)]
        public string InjuryStat { get; set; }
        [StringLength(50)]
        public string Shift { get; set; }
        public int? Count { get; set; }
    }
}
