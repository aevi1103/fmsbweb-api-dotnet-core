using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Master
{
    public partial class AfAnodDowntime
    {
        [Column("AnodizeID")]
        public int AnodizeId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime Date { get; set; }
        [Required]
        [StringLength(1)]
        public string Shift { get; set; }
        [Required]
        [StringLength(2)]
        public string Machine { get; set; }
        [Required]
        [StringLength(6)]
        public string Part { get; set; }
        [StringLength(2)]
        public string Grade { get; set; }
        [StringLength(5)]
        public string EnteredBy { get; set; }
        [Column("Replacing cables")]
        public short? ReplacingCables { get; set; }
        [Column("Replacing electrical contacts")]
        public short? ReplacingElectricalContacts { get; set; }
        [Column("Broken Mask")]
        public short? BrokenMask { get; set; }
        [Column("Replacing Module Down")]
        public short? ReplacingModuleDown { get; set; }
        [Column("Replacing Sensor")]
        public short? ReplacingSensor { get; set; }
        [Column("Gantry Breakdown")]
        public short? GantryBreakdown { get; set; }
        [Column("Lack of Materials")]
        public short? LackOfMaterials { get; set; }
        public short? Downstream { get; set; }
        [Column("Quality Issue Upstream")]
        public short? QualityIssueUpstream { get; set; }
        [Column("Seal Change")]
        public short? SealChange { get; set; }
        public short? Changeovers { get; set; }
    }
}
