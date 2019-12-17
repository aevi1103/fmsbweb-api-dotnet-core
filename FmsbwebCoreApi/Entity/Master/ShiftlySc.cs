using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Master
{
    public partial class ShiftlySc
    {
        [Column(TypeName = "datetime")]
        public DateTime Date { get; set; }
        [Required]
        [StringLength(1)]
        public string Shift { get; set; }
        [Required]
        [StringLength(2)]
        public string Machine { get; set; }
        [Column("gross")]
        public int? Gross { get; set; }
        [Column("fs")]
        public int? Fs { get; set; }
        [Column("ms")]
        public int? Ms { get; set; }
        [Column("anod")]
        public int? Anod { get; set; }
        [Column("sc_washer")]
        public int? ScWasher { get; set; }
        [Column("assy")]
        public int Assy { get; set; }
        [Column("co_min")]
        public int? CoMin { get; set; }
        [Column("co_parts")]
        public int? CoParts { get; set; }
        [Column("cycleTime")]
        public int CycleTime { get; set; }
        public int? Target { get; set; }
        public int? Yr { get; set; }
        [Column("mnt")]
        [StringLength(3)]
        public string Mnt { get; set; }
    }
}
