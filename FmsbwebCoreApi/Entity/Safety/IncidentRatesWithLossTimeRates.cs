using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Safety
{
    public partial class IncidentRatesWithLossTimeRates
    {
        [Column("EOM")]
        [StringLength(50)]
        public string Eom { get; set; }
        [StringLength(30)]
        public string Year { get; set; }
        [StringLength(30)]
        public string Month { get; set; }
        [Column("Recordable_NotLossTime")]
        public int? RecordableNotLossTime { get; set; }
        [Column("Recordable_LossTime")]
        public int RecordableLossTime { get; set; }
        [Column("All_Recordables")]
        public int? AllRecordables { get; set; }
        [Column("Man Hours")]
        [StringLength(50)]
        public string ManHours { get; set; }
        [Column("Incident Rate", TypeName = "decimal(10, 2)")]
        public decimal? IncidentRate { get; set; }
        [Column(TypeName = "decimal(10, 2)")]
        public decimal? LossTimeRate { get; set; }
    }
}
