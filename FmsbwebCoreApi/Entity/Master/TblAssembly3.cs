using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Master
{
    [Table("tblAssembly3")]
    public partial class TblAssembly3
    {
        [Key]
        [Column("Assembly3ID")]
        public int Assembly3Id { get; set; }
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
        public string Orientation { get; set; }
        [StringLength(5)]
        public string EnteredBy { get; set; }
        public short? Dial1Scrap { get; set; }
        public short? Dial2Scrap { get; set; }
        public short? Dial3Scrap { get; set; }
        public short? PostAssemblyInsp { get; set; }
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
        public short? Dial3Production { get; set; }
        public short? Dial3Rejects { get; set; }
        public short? Dial3RejectsScrap1 { get; set; }
        public short? Dial3RejectsGood { get; set; }
        public short? Dial3RejectsScrap { get; set; }
        [StringLength(254)]
        public string ScrapComment { get; set; }
        public int ExpanderQty { get; set; }
        public int ExpanderQty2 { get; set; }
        public int RailQty { get; set; }
        public int RailQty2 { get; set; }
        public int LowerCompQty { get; set; }
        public int LowerCompQty2 { get; set; }
        public int UpperCompQty { get; set; }
        public int UpperCompQty2 { get; set; }
        public int PinQty { get; set; }
        public int PinQty2 { get; set; }
        public int CirclipQty { get; set; }
        public int CirclipQty2 { get; set; }
        public int RodQty { get; set; }
        public int RodQty2 { get; set; }
        public short? TargetProduction { get; set; }
        public int? ActualProduction { get; set; }
        public float? CycleTime { get; set; }
        public int? Scrap { get; set; }
        public int? Rework { get; set; }
        public short? ShiftTime { get; set; }
        [Column("DT_NoAuth")]
        public short? DtNoAuth { get; set; }
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
        [Column("DT_AwaitMeeting")]
        public int? DtAwaitMeeting { get; set; }
        public short? Dial3RejectScrapExp { get; set; }
        public short? Dial3RejectScrapRail { get; set; }
        public short? Dial3RejectScrapLowerComp { get; set; }
        public short? Dial3RejectScrapUpperComp { get; set; }
        public short? Dial3RejectScrapCirclip { get; set; }
        public short? Dial3RejectScrapPin { get; set; }
        public short? Dial3RejectScrapRod { get; set; }
        public short? Dial2RejectGrade { get; set; }
        public short? Dial2RejectPaint { get; set; }
        public short? Dial2RejectVision { get; set; }
        public short? Dial2RejectRailsMissing { get; set; }
        public short? Dial2ScrapRailsMissing { get; set; }
        public short? Dial2RejectRailsUnseated { get; set; }
        public short? Dial2ScrapRailsUnseated { get; set; }
        [Column("Dial2RejectLCRUCRMissing")]
        public short? Dial2RejectLcrucrmissing { get; set; }
        [Column("Dial2ScrapLCRUCRMissing")]
        public short? Dial2ScrapLcrucrmissing { get; set; }
        [Column("Dial2RejectLCRUCRUnseated")]
        public short? Dial2RejectLcrucrunseated { get; set; }
        [Column("Dial2ScrapLCRUCRUnseated")]
        public short? Dial2ScrapLcrucrunseated { get; set; }
        public short? Dial2RejectExpMissing { get; set; }
        public short? Dial2ScrapExpMissing { get; set; }
        public short? Dial2RejectExpUnseated { get; set; }
        public short? Dial2ScrapExpUnseated { get; set; }
        public short? Dial2RejectHandling { get; set; }
        public short? Dial2ScrapHandling { get; set; }
        public short? Dial3RejectForce { get; set; }
        public short? Dial3RejectVision { get; set; }
        public short? Dial3RejectClipCheck { get; set; }
        public short? Dial3RejectBackwardRod { get; set; }
        public short? PrePackCirclipMissing { get; set; }
        public short? PrePackCirclipUnseated { get; set; }
        public short? PrePackPinsTight { get; set; }
        public short? PrePackRingsTight { get; set; }
        public short? PrePackRailsMissing { get; set; }
        public short? PrePackRailsUnseated { get; set; }
        [Column("PrePackLCRUCRMissing")]
        public short? PrePackLcrucrmissing { get; set; }
        [Column("PrePackLCRUCRUnseated")]
        public short? PrePackLcrucrunseated { get; set; }
        public short? PrePackExpMissing { get; set; }
        public short? PrePackExpUnseated { get; set; }
        public short? PrePackLandScratch { get; set; }
        public short? PrePackHandling { get; set; }
        public short? CycleRunTime { get; set; }
        public short? CycleStopTime { get; set; }
        [Column("Dial1FTime")]
        public short? Dial1Ftime { get; set; }
        [Column("Dial1FTimeOrientation")]
        public short? Dial1FtimeOrientation { get; set; }
        [Column("Dial1FTimeExpander")]
        public short? Dial1FtimeExpander { get; set; }
        [Column("Dial1FTimeLRail")]
        public short? Dial1FtimeLrail { get; set; }
        [Column("Dial1FTimeURail")]
        public short? Dial1FtimeUrail { get; set; }
        [Column("Dial1FTimeLCRing")]
        public short? Dial1FtimeLcring { get; set; }
        [Column("Dial1FTimeUCRing")]
        public short? Dial1FtimeUcring { get; set; }
        [Column("Dial1FTimeUnload")]
        public short? Dial1FtimeUnload { get; set; }
        [Column("Dial2FTime")]
        public short? Dial2Ftime { get; set; }
        [Column("Dial2FTimeD1toD2")]
        public short? Dial2FtimeD1toD2 { get; set; }
        [Column("Dial2FTimeGrade")]
        public short? Dial2FtimeGrade { get; set; }
        [Column("Dial2FTimePaint")]
        public short? Dial2FtimePaint { get; set; }
        [Column("Dial2FTimeVision")]
        public short? Dial2FtimeVision { get; set; }
        [Column("Dial2FTimeD2toD3")]
        public short? Dial2FtimeD2toD3 { get; set; }
        [Column("Dial2FTimeReject")]
        public short? Dial2FtimeReject { get; set; }
        [Column("Dial3FTime")]
        public short? Dial3Ftime { get; set; }
        [Column("Dial3FTimeOiler")]
        public short? Dial3FtimeOiler { get; set; }
        [Column("Dial3FTimeRodLoad")]
        public short? Dial3FtimeRodLoad { get; set; }
        [Column("Dial3FTimePinInsertion")]
        public short? Dial3FtimePinInsertion { get; set; }
        [Column("Dial3FTimeForce")]
        public short? Dial3FtimeForce { get; set; }
        [Column("Dial3FTimeClip1Ins")]
        public short? Dial3FtimeClip1Ins { get; set; }
        [Column("Dial3FTimeClip2Ins")]
        public short? Dial3FtimeClip2Ins { get; set; }
        [Column("Dial3FTimeVision")]
        public short? Dial3FtimeVision { get; set; }
        [Column("Dial3FTimeClipCheck")]
        public short? Dial3FtimeClipCheck { get; set; }
        [Column("Dial3FTimeUnload")]
        public short? Dial3FtimeUnload { get; set; }
        [Column("HasMRR")]
        public bool HasMrr { get; set; }
        public bool Transferred { get; set; }
        public bool Confirmed { get; set; }
        public short? Dial3RejectMissingCmpnt { get; set; }
        public short? Dial3RejectUnseatedCmpnt { get; set; }
        [Column("Dial3RejectBrokenLCR")]
        public short? Dial3RejectBrokenLcr { get; set; }
        public short? Dial2RejectGoodToRerun { get; set; }
        public short? Dial2RejectFixAndRerun { get; set; }
        public short? Dial2ScrapStripAndRerun { get; set; }
        public short? Dial2ScrapStripAndScrap { get; set; }
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
        [Column("DT_Verifications")]
        public short? DtVerifications { get; set; }
        [Column("DT_PlannedDowntime")]
        public short? DtPlannedDowntime { get; set; }
        [Column("DT_Rework")]
        public short? DtRework { get; set; }
        public int? PistonOnlyScrapped { get; set; }
        public int? FullAssemblyScrapped { get; set; }
        public int? PistonQty { get; set; }
        public int? Runtime { get; set; }
        public int? Expander { get; set; }
        public int? LowerRail { get; set; }
        public int? UpperRail { get; set; }
        public int? PinInsertion { get; set; }
        public int? Vision { get; set; }
        public int? Oiler { get; set; }
        public int? PinForce { get; set; }
        public int? BlackDotVision { get; set; }
        public int? RodOrientation { get; set; }
        public int? PushPush { get; set; }
        [Column("LVDT")]
        public int? Lvdt { get; set; }
        public int? VisionHandling { get; set; }
        public int? RodPinFreeness { get; set; }
        public int? RingFreeness { get; set; }
        public int? LowerComp { get; set; }
        public int? UpperComp { get; set; }
    }
}
