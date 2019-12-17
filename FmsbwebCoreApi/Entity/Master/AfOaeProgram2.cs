﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Master
{
    public partial class AfOaeProgram2
    {
        [Column(TypeName = "datetime")]
        public DateTime? Date { get; set; }
        [StringLength(50)]
        public string Shift { get; set; }
        public int? ShiftHours { get; set; }
        [StringLength(50)]
        public string Line { get; set; }
        [Column(TypeName = "decimal(18, 5)")]
        public decimal? CycleTime { get; set; }
        [StringLength(50)]
        public string Part { get; set; }
        [StringLength(50)]
        public string Grade { get; set; }
        [Column("part2")]
        [StringLength(101)]
        public string Part2 { get; set; }
        public int? Runtime { get; set; }
        [Column(TypeName = "decimal(18, 5)")]
        public decimal? Target { get; set; }
        [Column("Anod_Gross")]
        public int? AnodGross { get; set; }
        [Column("SC_Gross")]
        public int? ScGross { get; set; }
        [Column("Assy_Gross")]
        public int? AssyGross { get; set; }
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
        [Column("net")]
        public int? Net { get; set; }
        [StringLength(10)]
        public string Dept { get; set; }
        [StringLength(14)]
        public string Program { get; set; }
        public int? WkNum { get; set; }
        [Column("Co_count")]
        public int? CoCount { get; set; }
        [Column("Target_100p", TypeName = "decimal(38, 17)")]
        public decimal? Target100p { get; set; }
    }
}
