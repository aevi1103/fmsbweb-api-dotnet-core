using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Master
{
    [Table("tblAnodize")]
    public partial class TblAnodize
    {
        [Key]
        [Column("AnodizeID")]
        public int AnodizeId { get; set; }
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
        [Column("PRun")]
        [StringLength(1)]
        public string Prun { get; set; }
        [Required]
        [StringLength(1)]
        public string RunNr { get; set; }
        [Required]
        [Column("PartID")]
        [StringLength(6)]
        public string PartId { get; set; }
        public bool Transferred { get; set; }
        public bool Confirmed { get; set; }
        [StringLength(2)]
        public string Grade { get; set; }
        [StringLength(5)]
        public string EnteredBy { get; set; }
        public int? GrossProduction { get; set; }
        [Column("NAD_Foundry")]
        public short? NadFoundry { get; set; }
        [Column("NAD_Machining")]
        public short? NadMachining { get; set; }
        public short? TestScrap { get; set; }
        public int? PostAnodize { get; set; }
        public int? Rejects { get; set; }
        public int? MachineHandling { get; set; }
        public int? PersonnelHandling { get; set; }
        [StringLength(254)]
        public string ScrapComment { get; set; }
        public short? TargetProduction { get; set; }
        public int? ActualProduction { get; set; }
        public float? CycleTime { get; set; }
        public int? Scrap { get; set; }
        public int? Rework { get; set; }
        public short? ShiftTime { get; set; }
        [Column("DT_AwaitMeeting")]
        public int? DtAwaitMeeting { get; set; }
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
        [Column("DT_NoAuth")]
        public short? DtNoAuth { get; set; }
        [Column("HasMRR")]
        public bool HasMrr { get; set; }
        [Column("DT_Quality")]
        public short? DtQuality { get; set; }
        [Column("DT_Downstream")]
        public short? DtDownstream { get; set; }
        [Column("DT_Upstream")]
        public short? DtUpstream { get; set; }
        [Column("DT_CompnentShortage")]
        public short? DtCompnentShortage { get; set; }
        [Column("DT_Wire")]
        public short? DtWire { get; set; }
        [Column("DT_Contact")]
        public short? DtContact { get; set; }
        [Column("DT_Mask")]
        public short? DtMask { get; set; }
        [Column("DT_Rectifier")]
        public short? DtRectifier { get; set; }
        [Column("DT_Sensor")]
        public short? DtSensor { get; set; }
        [Column("DT_Gantry")]
        public short? DtGantry { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? ModulesActive { get; set; }
        [Column("DT_Planned")]
        public short? DtPlanned { get; set; }
        public int? Runtime { get; set; }
        public int? AnodizeOnCrown { get; set; }
        public int? LightAnodize { get; set; }
        public int? OffLocation { get; set; }
        public int? TailBurn { get; set; }
        public int? PartialAnodize { get; set; }
        [Column("oae_comments")]
        public string OaeComments { get; set; }
        [Column("scrap_comments")]
        public string ScrapComments { get; set; }
        [Column("Puebla_Defect")]
        public int? PueblaDefect { get; set; }
    }
}
