using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Safety
{
    public partial class RatesChartView
    {
        [Column("EOM", TypeName = "date")]
        public DateTime? Eom { get; set; }
        [Column("Incident Rate", TypeName = "decimal(10, 2)")]
        public decimal? IncidentRate { get; set; }
        [Column(TypeName = "decimal(10, 2)")]
        public decimal? LossTimeRate { get; set; }
    }
}
