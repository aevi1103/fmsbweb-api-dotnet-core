using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Master
{
    public partial class ShiftlyNewAssyAll
    {
        [Column(TypeName = "datetime")]
        public DateTime? Date { get; set; }
        [StringLength(50)]
        public string Shift { get; set; }
        [StringLength(50)]
        public string MachineCode { get; set; }
        [Column("gross")]
        public int? Gross { get; set; }
        [Column("fs")]
        public int Fs { get; set; }
        [Column("ms")]
        public int Ms { get; set; }
        [Column("anod")]
        public int Anod { get; set; }
        [Column("sc")]
        public int Sc { get; set; }
        [Column("assy")]
        public int Assy { get; set; }
        [Column("co_min", TypeName = "decimal(38, 2)")]
        public decimal CoMin { get; set; }
        [Column("co_parts", TypeName = "decimal(38, 6)")]
        public decimal? CoParts { get; set; }
        [Column("cycleTime", TypeName = "decimal(18, 5)")]
        public decimal CycleTime { get; set; }
        [Column(TypeName = "decimal(38, 17)")]
        public decimal? Target { get; set; }
        public int? Yr { get; set; }
        [Column("mnt")]
        [StringLength(3)]
        public string Mnt { get; set; }
    }
}
