using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Master
{
    public partial class MhAfoeeData
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
        public int ShiftTime { get; set; }
        public float? CycleTime { get; set; }
        [Column("GP")]
        public int? Gp { get; set; }
        [Column("NP")]
        public int? Np { get; set; }
        public int? Scrap { get; set; }
        [Column("PlannedDT")]
        public int? PlannedDt { get; set; }
        [Column("UnplannedDT")]
        public int? UnplannedDt { get; set; }
        [Column("DTAwaitParts")]
        public int? DtawaitParts { get; set; }
        [Column("DTAwaitPersonnel")]
        public int? DtawaitPersonnel { get; set; }
        [Column("DTNoAuth")]
        public int? DtnoAuth { get; set; }
        [Column("DTAwaitMeetings")]
        public int? DtawaitMeetings { get; set; }
        [Column("DTMinorBreaks")]
        public int? DtminorBreaks { get; set; }
        [Column("DTPlannedMaintenance")]
        public int? DtplannedMaintenance { get; set; }
        [Column("DTBreakdowns")]
        public int? Dtbreakdowns { get; set; }
        [Column("DTSetups")]
        public int? Dtsetups { get; set; }
    }
}
