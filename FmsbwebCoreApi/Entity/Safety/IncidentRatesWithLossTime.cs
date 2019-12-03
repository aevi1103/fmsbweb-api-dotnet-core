using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Safety
{
    public partial class IncidentRatesWithLossTime
    {
        public int? Year { get; set; }
        public int? MonthNum { get; set; }
        [StringLength(30)]
        public string MonthName { get; set; }
        [Column("Recordables_NotLossTime")]
        public int? RecordablesNotLossTime { get; set; }
        [Column("Recordable_LossTime")]
        public int? RecordableLossTime { get; set; }
        [Required]
        [StringLength(50)]
        public string InjuryStat { get; set; }
    }
}
