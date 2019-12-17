using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Master
{
    public partial class ShiftlyA6
    {
        [Column(TypeName = "datetime")]
        public DateTime CoatDate { get; set; }
        [Required]
        [StringLength(1)]
        public string Shift { get; set; }
        [Required]
        [Column("DepartmentID")]
        [StringLength(2)]
        public string DepartmentId { get; set; }
        [Column("gross")]
        public int? Gross { get; set; }
        [Column("fs")]
        public int? Fs { get; set; }
        [Column("ms")]
        public int? Ms { get; set; }
        [Column("anod")]
        public int? Anod { get; set; }
        [Column("sc")]
        public int? Sc { get; set; }
        [Column("assy")]
        public int? Assy { get; set; }
        [Column("co_min")]
        public int? CoMin { get; set; }
        [Column("co_parts", TypeName = "numeric(38, 6)")]
        public decimal? CoParts { get; set; }
        [Column("cycle", TypeName = "numeric(2, 1)")]
        public decimal Cycle { get; set; }
        [Column(TypeName = "numeric(23, 6)")]
        public decimal? Target { get; set; }
        public int? Yr { get; set; }
        [Column("mnt")]
        [StringLength(3)]
        public string Mnt { get; set; }
    }
}
