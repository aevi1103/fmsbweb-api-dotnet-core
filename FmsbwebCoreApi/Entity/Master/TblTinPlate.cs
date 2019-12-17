using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Master
{
    [Table("tblTinPlate")]
    public partial class TblTinPlate
    {
        [Key]
        [Column("TinPlateID")]
        public int TinPlateId { get; set; }
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
        public int? GrossProduction { get; set; }
        [Column("NAD_Foundry")]
        public short? NadFoundry { get; set; }
        [Column("NAD_Machining")]
        public short? NadMachining { get; set; }
        [Column("NAD_SkirtCoat")]
        public short? NadSkirtCoat { get; set; }
        [Column("NAD_Anodizing")]
        public short? NadAnodizing { get; set; }
        public short? Handling { get; set; }
        public int? Adhesion { get; set; }
        public int? CoatThick { get; set; }
        public int? IncompleteCoat { get; set; }
        public int? Corrosion { get; set; }
        public int? TestScrap { get; set; }
        public int? HoistFail { get; set; }
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
        public bool Transferred { get; set; }
        public bool Confirmed { get; set; }
    }
}
