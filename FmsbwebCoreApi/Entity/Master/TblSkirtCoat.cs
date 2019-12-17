using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Master
{
    [Table("tblSkirtCoat")]
    public partial class TblSkirtCoat
    {
        public TblSkirtCoat()
        {
            EooUpstreamScrap = new HashSet<EooUpstreamScrap>();
        }

        [Key]
        [Column("SkirtCoatID")]
        public int SkirtCoatId { get; set; }
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
        public byte? SkirtCoaterNumber { get; set; }
        [StringLength(5)]
        public string EnteredBy { get; set; }
        public int? CounterStart { get; set; }
        public int? CounterStop { get; set; }
        public short? OffLocation { get; set; }
        public short? Debris { get; set; }
        public short? DebrisNonM { get; set; }
        public short? Voids { get; set; }
        public short? CoatingInGrooves { get; set; }
        public short? BadFinish { get; set; }
        public short? HandlingPersonnel { get; set; }
        public int? HandlingMachine { get; set; }
        public short? WipeOffReruns { get; set; }
        public short? SetUpScrap { get; set; }
        public short? ScreenLife { get; set; }
        [StringLength(254)]
        public string ScrapComment { get; set; }
        public short? TargetProduction { get; set; }
        public int? ActualProduction { get; set; }
        public float? CycleTime { get; set; }
        public int? Scrap { get; set; }
        public int? Rework { get; set; }
        public short? ShiftTime { get; set; }
        [Column("DT_AwaitParts")]
        public short? DtAwaitParts { get; set; }
        [Column("DT_AwaitPersonnel")]
        public short? DtAwaitPersonnel { get; set; }
        [Column("DT_NoAuth")]
        public short? DtNoAuth { get; set; }
        [Column("DT_AwaitMeeting")]
        public short? DtAwaitMeeting { get; set; }
        [Column("DT_BreakdownsAccumulator")]
        public short? DtBreakdownsAccumulator { get; set; }
        [Column("DT_BreakdownsPhosphate")]
        public short? DtBreakdownsPhosphate { get; set; }
        [Column("DT_BreakdownsSkirtCoater")]
        public short? DtBreakdownsSkirtCoater { get; set; }
        [Column("DT_Changeovers")]
        public short? DtChangeovers { get; set; }
        [Column("DT_PersonnelBreaks")]
        public short? DtPersonnelBreaks { get; set; }
        [Column("DT_Maintenance")]
        public short? DtMaintenance { get; set; }
        [Column("DT_Vision")]
        public short? DtVision { get; set; }
        [Column("DT_SetupAdjust")]
        public short? DtSetupAdjust { get; set; }
        [Column("HasMRR")]
        public bool HasMrr { get; set; }
        public bool Transferred { get; set; }
        public bool Confirmed { get; set; }
        public short? VisionRejects { get; set; }
        public short? TrueRejects { get; set; }
        [Column("PreCoat_Foundry")]
        public short? PreCoatFoundry { get; set; }
        [Column("PreCoat_Machining")]
        public short? PreCoatMachining { get; set; }
        [Column("PreCoat_Anodizing")]
        public short? PreCoatAnodizing { get; set; }
        [Column("PreCoat_HandlingAtSC")]
        public short? PreCoatHandlingAtSc { get; set; }
        [Column("PreCoat_NoPhos")]
        public short? PreCoatNoPhos { get; set; }
        [Column("PreCoat_ToMuch")]
        public short? PreCoatToMuch { get; set; }
        [Column("PreCoat_Handling")]
        public short? PreCoatHandling { get; set; }
        [Column("PreCoat_Contractor")]
        public short? PreCoatContractor { get; set; }
        [Column("PostCoat_Phosphate")]
        public short? PostCoatPhosphate { get; set; }
        [Column("PostCoat_Foundry")]
        public short? PostCoatFoundry { get; set; }
        [Column("PostCoat_Machining")]
        public short? PostCoatMachining { get; set; }
        [Column("PostCoat_Anodizing")]
        public short? PostCoatAnodizing { get; set; }
        [Column("PostCoat_Daubing")]
        public short? PostCoatDaubing { get; set; }
        [Column("PostCoat_Contractor")]
        public short? PostCoatContractor { get; set; }
        [Column("DT_Quality")]
        public short? DtQuality { get; set; }
        [Column("DT_Downstream")]
        public short? DtDownstream { get; set; }
        [Column("DT_Upstream")]
        public short? DtUpstream { get; set; }
        [Column("DT_Inkjet")]
        public short? DtInkjet { get; set; }
        [Column("DT_PlannedDowntime")]
        public short? DtPlannedDowntime { get; set; }
        public short? Scratches { get; set; }
        [Column("PreCoat_Accumulator")]
        public short? PreCoatAccumulator { get; set; }
        [Column("PreCoat_Other")]
        public short? PreCoatOther { get; set; }
        [Column("Foundry_SC")]
        public int? FoundrySc { get; set; }
        [Column("Machining_SC")]
        public int? MachiningSc { get; set; }
        [Column("Debris_SC")]
        public int? DebrisSc { get; set; }
        [Column("Voids_SC")]
        public int? VoidsSc { get; set; }
        [Column("Blisters_SC")]
        public int? BlistersSc { get; set; }
        [Column("RunsSags_SC")]
        public int? RunsSagsSc { get; set; }
        [Column("ScratchesInCoating_SC")]
        public int? ScratchesInCoatingSc { get; set; }
        [Column("CoatingInNonSpecificAreas_SC")]
        public int? CoatingInNonSpecificAreasSc { get; set; }
        [Column("OffLocation_SC")]
        public int? OffLocationSc { get; set; }
        [Column("OvenHandling_SC")]
        public int? OvenHandlingSc { get; set; }
        [Column("ThinCoating_SC")]
        public int? ThinCoatingSc { get; set; }
        [Column("ThickCoating_SC")]
        public int? ThickCoatingSc { get; set; }
        [Column("OperatorInspectorHandling_SC")]
        public int? OperatorInspectorHandlingSc { get; set; }
        [Column("WasherLoad_EOO")]
        public int? WasherLoadEoo { get; set; }
        [Column("WasherUnload_EOO")]
        public int? WasherUnloadEoo { get; set; }
        [Column("Accumulator_EOO")]
        public int? AccumulatorEoo { get; set; }
        [Column("SkirtCoatHandling_EOO")]
        public int? SkirtCoatHandlingEoo { get; set; }
        [Column("Voids_EOO")]
        public int? VoidsEoo { get; set; }
        [Column("Blisters_EOO")]
        public int? BlistersEoo { get; set; }
        [Column("RunsSags_EOO")]
        public int? RunsSagsEoo { get; set; }
        [Column("ScratchesInCoating_EOO")]
        public int? ScratchesInCoatingEoo { get; set; }
        [Column("CoatingInNonSpecificAreas_EOO")]
        public int? CoatingInNonSpecificAreasEoo { get; set; }
        [Column("OvenHandling_EOO")]
        public int? OvenHandlingEoo { get; set; }
        [Column("ThinCoating_EOO")]
        public int? ThinCoatingEoo { get; set; }
        [Column("ThickCoating_EOO")]
        public int? ThickCoatingEoo { get; set; }
        [Column("oae_downtime_comments")]
        public string OaeDowntimeComments { get; set; }

        [InverseProperty("SkitCoat")]
        public virtual ICollection<EooUpstreamScrap> EooUpstreamScrap { get; set; }
    }
}
