using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Safety
{
    public partial class IncidentRatesNum
    {
        [Column("EOM")]
        [StringLength(50)]
        public string Eom { get; set; }
        [StringLength(30)]
        public string Year { get; set; }
        [StringLength(30)]
        public string Month { get; set; }
        public int? Recordable { get; set; }
        [Column("Man Hours", TypeName = "decimal(18, 5)")]
        public decimal ManHours { get; set; }
        [Column("Incident Rate", TypeName = "decimal(10, 2)")]
        public decimal? IncidentRate { get; set; }
    }
}
