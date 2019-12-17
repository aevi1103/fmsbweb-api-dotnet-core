using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Master
{
    [Table("tblAssembly4")]
    public partial class TblAssembly4
    {
        [Key]
        [Column("Assembly4ID")]
        public int Assembly4Id { get; set; }
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
        [StringLength(2)]
        public string Grade { get; set; }
        [StringLength(5)]
        public string EnteredBy { get; set; }
        public short? PackOutTotal { get; set; }
        public int? GrossProduction { get; set; }
        public short? AssyScrap { get; set; }
        public short? LaserScrap { get; set; }
        public short? VisionScrap { get; set; }
        public short? PrePackInsp { get; set; }
        public short? Handling { get; set; }
        public short? PistonRejects { get; set; }
        public short? PistonScrap { get; set; }
        [Column("NAD_FoundryPre")]
        public short? NadFoundryPre { get; set; }
        [Column("NAD_MachiningPre")]
        public short? NadMachiningPre { get; set; }
        [Column("NAD_SkirtCoatPre")]
        public short? NadSkirtCoatPre { get; set; }
        [Column("NAD_AnodizingPre")]
        public short? NadAnodizingPre { get; set; }
        [Column("NAD_TinPlatePre")]
        public short? NadTinPlatePre { get; set; }
        [Column("NAD_HandlingPre")]
        public short? NadHandlingPre { get; set; }
        [Column("NAD_FoundryPost")]
        public short? NadFoundryPost { get; set; }
        [Column("NAD_MachiningPost")]
        public short? NadMachiningPost { get; set; }
        [Column("NAD_SkirtCoatPost")]
        public short? NadSkirtCoatPost { get; set; }
        [Column("NAD_AnodizingPost")]
        public short? NadAnodizingPost { get; set; }
        [Column("NAD_TinPlatePost")]
        public short? NadTinPlatePost { get; set; }
        [Column("NAD_HandlingPost")]
        public short? NadHandlingPost { get; set; }
        [StringLength(254)]
        public string ScrapComment { get; set; }
        public int? ExpanderQty { get; set; }
        public int? RailQty { get; set; }
        public int? LowerCompQty { get; set; }
        public int? UpperCompQty { get; set; }
        public int? PinQty { get; set; }
        public short? TargetProduction { get; set; }
        public int? ActualProduction { get; set; }
        public float? CycleTime { get; set; }
        public int? Scrap { get; set; }
        public int? Rework { get; set; }
        public short? ShiftTime { get; set; }
        [Column("DT_NoAuth")]
        public short? DtNoAuth { get; set; }
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
        [Column("HasMRR")]
        public bool HasMrr { get; set; }
        public bool Transferred { get; set; }
        public bool Confirmed { get; set; }
        [Column("DT_Quality")]
        public short? DtQuality { get; set; }
        [Column("DT_Upstream")]
        public short? DtUpstream { get; set; }
        [Column("DT_Downstream")]
        public short? DtDownstream { get; set; }
        [Column("DT_ComponentShortage")]
        public short? DtComponentShortage { get; set; }
        [Column("DT_Vision")]
        public short? DtVision { get; set; }
        [Column("DT_Expander")]
        public short? DtExpander { get; set; }
        [Column("DT_LowerRail")]
        public short? DtLowerRail { get; set; }
        [Column("DT_UpperRail")]
        public short? DtUpperRail { get; set; }
        [Column("DT_LowerRing")]
        public short? DtLowerRing { get; set; }
        [Column("DT_UpperRing")]
        public short? DtUpperRing { get; set; }
        [Column("DT_Verifications")]
        public short? DtVerifications { get; set; }
        [Column("DT_PlannedDowntime")]
        public short? DtPlannedDowntime { get; set; }
        [Column("DT_Rework")]
        public short? DtRework { get; set; }
        public int? PistonOnlyScrapped { get; set; }
        public int? FullAssemblyScrapped { get; set; }
        public int? Runtime { get; set; }
        public int? Expander { get; set; }
        public int? LowerRail { get; set; }
        public int? UpperRail { get; set; }
        public int? LowerComp { get; set; }
        public int? UpperComp { get; set; }
        public int? CrownVisionReject { get; set; }
        public int? RingPackVisionReject { get; set; }
        public int? Casting { get; set; }
        public int? NicksDings { get; set; }
        public int? Dropped { get; set; }
        public int? Piston { get; set; }
        public int? Scratches { get; set; }
        public int? TightPin { get; set; }
    }
}
