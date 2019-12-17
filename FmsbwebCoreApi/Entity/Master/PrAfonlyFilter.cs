using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Master
{
    public partial class PrAfonlyFilter
    {
        [Column("EDate", TypeName = "datetime")]
        public DateTime Edate { get; set; }
        [Required]
        [StringLength(1)]
        public string Shift { get; set; }
        [Column("AFOnly")]
        public short? Afonly { get; set; }
        [Column("AFOT")]
        public int? Afot { get; set; }
        [Column("AFDOT")]
        public int? Afdot { get; set; }
    }
}
