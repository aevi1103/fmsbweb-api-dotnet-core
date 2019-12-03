using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Safety
{
    [Table("temp_stacked")]
    public partial class TempStacked
    {
        [Column("yr")]
        public int? Yr { get; set; }
        [Column("mos")]
        [StringLength(50)]
        public string Mos { get; set; }
        [Column("stat")]
        [StringLength(50)]
        public string Stat { get; set; }
        [Column("monum")]
        public int? Monum { get; set; }
    }
}
