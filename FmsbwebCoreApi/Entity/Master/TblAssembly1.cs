using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Master
{
    [Table("tblAssembly1")]
    public partial class TblAssembly1
    {
        [Key]
        [Column("Assembly1ID")]
        public int Assembly1Id { get; set; }
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
        public short? PersonnelHandling { get; set; }
        [Column("NAD_Foundry")]
        public short? NadFoundry { get; set; }
        [Column("NAD_Machining")]
        public short? NadMachining { get; set; }
        [Column("NAD_SkirtCoat")]
        public short? NadSkirtCoat { get; set; }
        public short? MachineHandling { get; set; }
        [StringLength(254)]
        public string ScrapComment { get; set; }
        [Column("SRWrongPartGood")]
        public int? SrwrongPartGood { get; set; }
        [Column("SRCameraRejectGood")]
        public int? SrcameraRejectGood { get; set; }
        [Column("SRPinDepthGood")]
        public int? SrpinDepthGood { get; set; }
        [Column("SRPinCradleGood")]
        public int? SrpinCradleGood { get; set; }
        [Column("SRPromessColorGood")]
        public int? SrpromessColorGood { get; set; }
        [Column("SRWrongPartCounter")]
        public int? SrwrongPartCounter { get; set; }
        [Column("SRCameraRejectCounter")]
        public int? SrcameraRejectCounter { get; set; }
        [Column("SRPinDepthCounter")]
        public int? SrpinDepthCounter { get; set; }
        [Column("SRPinCradleCounter")]
        public int? SrpinCradleCounter { get; set; }
        [Column("SRPromessColorCounter")]
        public int? SrpromessColorCounter { get; set; }
        public short? TargetProduction { get; set; }
        public int? ActualProduction { get; set; }
        public int? PinQty { get; set; }
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
        [Column("DT_Verifications")]
        public short? DtVerifications { get; set; }
        [Column("DT_PlannedDownTime")]
        public short? DtPlannedDownTime { get; set; }
        public int? PistonOnlyScrapped { get; set; }
        public int? FullAssemblyScrapped { get; set; }
        public int? Runtime { get; set; }
    }
}
