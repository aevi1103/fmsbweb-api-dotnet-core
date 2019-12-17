using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Master
{
    public partial class AfAllSc
    {
        [Column(TypeName = "datetime")]
        public DateTime? Date { get; set; }
        [StringLength(1)]
        public string Shift { get; set; }
        [StringLength(2)]
        public string Machine { get; set; }
        [Column("anod_gross")]
        public int? AnodGross { get; set; }
        [Column("sc_gross")]
        public int? ScGross { get; set; }
        [Column("assyGross")]
        public int? AssyGross { get; set; }
        [Column("FS")]
        public int? Fs { get; set; }
        [Column("MS")]
        public int? Ms { get; set; }
        [Column("ANOD")]
        public int? Anod { get; set; }
        [Column("SC")]
        public int? Sc { get; set; }
        [Column("ASSY")]
        public int? Assy { get; set; }
        [Column("CO_MIN", TypeName = "numeric(38, 6)")]
        public decimal? CoMin { get; set; }
        [Column("CO_PARTS", TypeName = "numeric(38, 6)")]
        public decimal? CoParts { get; set; }
        [Column("CYCLE", TypeName = "numeric(38, 6)")]
        public decimal? Cycle { get; set; }
        [Column("TARGET", TypeName = "numeric(14, 6)")]
        public decimal? Target { get; set; }
        public int? TotalGross { get; set; }
        [Column("net")]
        public int? Net { get; set; }
        [Column("YR")]
        public int? Yr { get; set; }
        [Column("MNT")]
        [StringLength(3)]
        public string Mnt { get; set; }
        [StringLength(10)]
        public string Dept { get; set; }
    }
}
