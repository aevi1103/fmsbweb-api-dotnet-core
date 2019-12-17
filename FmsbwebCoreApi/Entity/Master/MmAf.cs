using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Master
{
    public partial class MmAf
    {
        [Column(TypeName = "datetime")]
        public DateTime? Date { get; set; }
        [StringLength(50)]
        public string Machine { get; set; }
        [Column("TARGET", TypeName = "decimal(18, 2)")]
        public decimal? Target { get; set; }
        public int? AnodGross { get; set; }
        [Column("SCGross")]
        public int? Scgross { get; set; }
        public int? AssyGross { get; set; }
        public int? Gross { get; set; }
        [Column("FS")]
        public int? Fs { get; set; }
        [Column("MS")]
        public int? Ms { get; set; }
        public int? Anod { get; set; }
        [Column("SC")]
        public int Sc { get; set; }
        public int? Assy { get; set; }
        public int? Net { get; set; }
        [Column("cycle", TypeName = "decimal(18, 2)")]
        public decimal? Cycle { get; set; }
        [StringLength(10)]
        public string Dept { get; set; }
    }
}
