using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Master
{
    public partial class ViewAnodizeReport2016
    {
        [Column("AnodizeID")]
        public int AnodizeId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime CoatDate { get; set; }
        [Required]
        [StringLength(1)]
        public string Shift { get; set; }
        [StringLength(5)]
        public string EnteredBy { get; set; }
        public int ShiftHours { get; set; }
        [Required]
        [Column("DepartmentID")]
        [StringLength(2)]
        public string DepartmentId { get; set; }
        [Column(TypeName = "numeric(3, 1)")]
        public decimal CycleTime { get; set; }
        [Required]
        [Column("PartID")]
        [StringLength(6)]
        public string PartId { get; set; }
        [StringLength(2)]
        public string Grade { get; set; }
        public int? Runtime { get; set; }
        public int? GrossProduction { get; set; }
        [Column("FS")]
        public short? Fs { get; set; }
        [Column("MS")]
        public short? Ms { get; set; }
        public int? GantryError { get; set; }
        public int? BadMask { get; set; }
        public int? WasherLoad { get; set; }
        public int? OpsHandling { get; set; }
        public short? BadSeal { get; set; }
        public int? AnodizeOnCrown { get; set; }
        public int? LightAnodize { get; set; }
        public int? OffLocation { get; set; }
        public int? TailBurn { get; set; }
        public int? PartialAnodize { get; set; }
        [Column("Puebla_Defect")]
        public int PueblaDefect { get; set; }
        public int? TotalAnodizeScrap { get; set; }
        public int? OverallScrap { get; set; }
        [Column("net")]
        public int? Net { get; set; }
        [Column("dt_ReplacingCables")]
        public short? DtReplacingCables { get; set; }
        public short? ReplacingElectricalContacts { get; set; }
        public short? BrokenMask { get; set; }
        public short? RectifierModuleDown { get; set; }
        public short? ReplacingSensor { get; set; }
        public short? GantryBreakdown { get; set; }
        public short? LackofMaterials { get; set; }
        public short? DownStream { get; set; }
        public short? QualityIssueUpstream { get; set; }
        [Column("Changeover_min")]
        public short? ChangeoverMin { get; set; }
        public short? SealChange { get; set; }
        public short? TotalDowntime { get; set; }
        [StringLength(254)]
        public string ScrapComment { get; set; }
        [Column("oae_comments")]
        public string OaeComments { get; set; }
        [Column("scrap_comments")]
        public string ScrapComments { get; set; }
    }
}
