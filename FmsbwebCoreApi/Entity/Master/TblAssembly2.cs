using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Master
{
    [Table("tblAssembly2")]
    public partial class TblAssembly2
    {
        [Key]
        [Column("Assembly2ID")]
        public int Assembly2Id { get; set; }
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
        [Column("NAD_Foundry")]
        public short? NadFoundry { get; set; }
        [Column("NAD_Machining")]
        public short? NadMachining { get; set; }
        [Column("NAD_SkirtCoat")]
        public short? NadSkirtCoat { get; set; }
        [Column("NAD_Anodizing")]
        public short? NadAnodizing { get; set; }
        [Column("NAD_TinPlate")]
        public short? NadTinPlate { get; set; }
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
        [Column("DT_Pin")]
        public short? DtPin { get; set; }
        [Column("DT_Rod")]
        public short? DtRod { get; set; }
        [Column("DT_Circlip")]
        public short? DtCirclip { get; set; }
        [Column("DT_Inkjet")]
        public short? DtInkjet { get; set; }
        [Column("DT_Packout")]
        public short? DtPackout { get; set; }
        [Column("DT_Verifications")]
        public short? DtVerifications { get; set; }
        [Column("DT_PlannedDowntime")]
        public short? DtPlannedDowntime { get; set; }
        public int? RodQty { get; set; }
        public int? ClipQty { get; set; }
        public int? PistonOnlyScrapped { get; set; }
        public int? FullAssemblyScrapped { get; set; }
        public int? ExpanderQty2 { get; set; }
        public int? RailQty2 { get; set; }
        public int? LowerCompQty2 { get; set; }
        public int? UpperCompQty2 { get; set; }
        public int? PinQty2 { get; set; }
        public int? RodQty2 { get; set; }
        public int? ClipQty2 { get; set; }
        public int? PistonQty { get; set; }
        public int? Runtime { get; set; }
        public int? Expander { get; set; }
        public int? LowerRail { get; set; }
        public int? UpperRail { get; set; }
        public int? LowerComp { get; set; }
        public int? UpperComp { get; set; }
        public int? PinInsertion { get; set; }
        public int? Vision { get; set; }
        [Column("PRAM")]
        public int? Pram { get; set; }
        public int? BlackDot { get; set; }
        public int? LaserPro { get; set; }
        public int? NoCirclips { get; set; }
        [Column("1stSnapRing")]
        public int? _1stSnapRing { get; set; }
        [Column("2ndSnapRing")]
        public int? _2ndSnapRing { get; set; }
        public int? FalseReject { get; set; }
        [Column("2ClipsSeated")]
        public int? _2clipsSeated { get; set; }
        public int? RodPinFreeness { get; set; }
        public int? RingFreeness { get; set; }
        public int? Shape { get; set; }
        public int? OffLocation { get; set; }
        public int? Size { get; set; }
        public int? WipeOff { get; set; }
    }
}
