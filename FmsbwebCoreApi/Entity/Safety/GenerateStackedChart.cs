using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Safety
{
    public partial class GenerateStackedChart
    {
        [Column("monum")]
        public int? Monum { get; set; }
        [Column("mos")]
        [StringLength(50)]
        public string Mos { get; set; }
        [Column("stat")]
        [StringLength(50)]
        public string Stat { get; set; }
        public int? Value { get; set; }
    }
}
