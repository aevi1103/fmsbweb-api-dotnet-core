﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Master
{
    public partial class MhView
    {
        [Column("CoatingID")]
        public int CoatingId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime CoatDate { get; set; }
        [Required]
        [StringLength(1)]
        public string Shift { get; set; }
        [Required]
        [Column("DepartmentID")]
        [StringLength(2)]
        public string DepartmentId { get; set; }
        [Column("ProcessID")]
        [StringLength(3)]
        public string ProcessId { get; set; }
        [Required]
        [StringLength(1)]
        public string Run { get; set; }
        [Required]
        [StringLength(1)]
        public string RunNr { get; set; }
        [Required]
        [Column("PartID")]
        [StringLength(6)]
        public string PartId { get; set; }
        public int? GrossProduction { get; set; }
        [StringLength(5)]
        public string EnteredBy { get; set; }
        [Column(TypeName = "ntext")]
        public string Comment { get; set; }
        public short? TargetProduction { get; set; }
        public short? ShiftTime { get; set; }
        public int? PlannedDownTime { get; set; }
        [Column("DT_Breakdowns")]
        public short? DtBreakdowns { get; set; }
        [Column("DT_Setups")]
        public short? DtSetups { get; set; }
        [Column("DT_MinorBreaks")]
        public short? DtMinorBreaks { get; set; }
        [Column("DT_AwaitParts")]
        public short? DtAwaitParts { get; set; }
        [Column("DT_AwaitDunnage")]
        public short? DtAwaitDunnage { get; set; }
        [Column("DT_AwaitPersonnel")]
        public short? DtAwaitPersonnel { get; set; }
    }
}
