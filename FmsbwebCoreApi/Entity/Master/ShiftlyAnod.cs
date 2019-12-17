using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Master
{
    public partial class ShiftlyAnod
    {
        [Column(TypeName = "datetime")]
        public DateTime CoatDate { get; set; }
        [Required]
        [StringLength(1)]
        public string Shift { get; set; }
        [Required]
        [StringLength(2)]
        public string Line { get; set; }
        public int? Gross { get; set; }
        [Column("fs")]
        public int? Fs { get; set; }
        [Column("ms")]
        public int? Ms { get; set; }
        [Column("anod")]
        public int? Anod { get; set; }
        [Column("sc")]
        public int Sc { get; set; }
        [Column("assy")]
        public int Assy { get; set; }
        [Column("co_min")]
        public int? CoMin { get; set; }
        [Column("co_Parts", TypeName = "numeric(38, 6)")]
        public decimal? CoParts { get; set; }
        [Column(TypeName = "numeric(3, 1)")]
        public decimal CycleTime { get; set; }
        [Column(TypeName = "numeric(23, 6)")]
        public decimal? Target { get; set; }
        public int? Yr { get; set; }
        [Column("mnt")]
        [StringLength(3)]
        public string Mnt { get; set; }
    }
}
