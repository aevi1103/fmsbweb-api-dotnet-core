using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Master
{
    [Table("tblprotopartparameters")]
    public partial class Tblprotopartparameters
    {
        [Required]
        [StringLength(23)]
        public string PartNumber { get; set; }
        [StringLength(50)]
        public string Customer { get; set; }
        [StringLength(50)]
        public string Weldment { get; set; }
        [StringLength(50)]
        public string PreMachinedTop { get; set; }
        [Column(TypeName = "decimal(6, 1)")]
        public decimal? PreMachinedBottom { get; set; }
        [Column(TypeName = "decimal(6, 1)")]
        public decimal? MachinedTop { get; set; }
        [Column(TypeName = "decimal(6, 1)")]
        public decimal? MachinedBottom { get; set; }
        [StringLength(50)]
        public string Quantity { get; set; }
        [Required]
        [StringLength(50)]
        public string StorageRackRow { get; set; }
        public bool? LocationNotes { get; set; }
        public long? CerMinMetalTemp { get; set; }
        public long? CerMaxMetalTemp { get; set; }
        public bool? CastIronLadle { get; set; }
        [Column("CIMinMetalTemp")]
        public long? CiminMetalTemp { get; set; }
        [Column("CIMaxMetalTemp")]
        public long? CimaxMetalTemp { get; set; }
        [Column(TypeName = "decimal(5, 2)")]
        public decimal? PourSpeed { get; set; }
        [Column(TypeName = "decimal(5, 2)")]
        public decimal? VibTime { get; set; }
        public long? VibPressure { get; set; }
        public long? CycleTime { get; set; }
        public long? UnloaderJawsOpen { get; set; }
        public long? CorePinsRelease { get; set; }
        public long? BlocksOpen { get; set; }
        public long? CenterCoreDown { get; set; }
        public long? RobotStart { get; set; }
        public long? WaterOnBlocks { get; set; }
        public long? WaterOffBlocks { get; set; }
        public long? WaterOnCtrCore { get; set; }
        public long? WaterOffCtrCore { get; set; }
        public long? WaterOnPins { get; set; }
        public long? WaterOffPins { get; set; }
        [StringLength(50)]
        public string Mismatch { get; set; }
        [StringLength(50)]
        public string BossPanelWidth { get; set; }
        [StringLength(50)]
        public string CastPipOnly { get; set; }
        [StringLength(50)]
        public string CastCrownFeatures { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? Updated { get; set; }
        public long? RevLevel { get; set; }
        [StringLength(50)]
        public string WarmerRejectSetup { get; set; }
        [StringLength(50)]
        public string BlkCorRngTopChanges { get; set; }
        [StringLength(50)]
        public string TopCoreSetting { get; set; }
        [Column("Production Notes")]
        [StringLength(50)]
        public string ProductionNotes { get; set; }
        [Column("Revision Notes1")]
        [StringLength(100)]
        public string RevisionNotes1 { get; set; }
        [Column("revision_notes2")]
        [StringLength(100)]
        public string RevisionNotes2 { get; set; }
    }
}
