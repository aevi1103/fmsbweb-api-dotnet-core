using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.FmsbQuality
{
    public partial class AcknowledgmentView2
    {
        [Column("id")]
        public int Id { get; set; }
        public string QaNum { get; set; }
        [Required]
        [Column("fmpart")]
        [StringLength(50)]
        public string Fmpart { get; set; }
        [Required]
        [Column("qaOriginator")]
        [StringLength(50)]
        public string QaOriginator { get; set; }
        [Required]
        [Column("suspectDateCode")]
        [StringLength(50)]
        public string SuspectDateCode { get; set; }
        [Column("suspectQty")]
        public int? SuspectQty { get; set; }
        [Column("issueDate", TypeName = "datetime")]
        public DateTime IssueDate { get; set; }
        [Column("expireDate", TypeName = "datetime")]
        public DateTime ExpireDate { get; set; }
        [Required]
        [Column("machine")]
        [StringLength(500)]
        public string Machine { get; set; }
        [Required]
        [Column("issueOriginatingProcess")]
        [StringLength(100)]
        public string IssueOriginatingProcess { get; set; }
        [Required]
        [Column("alertType")]
        [StringLength(100)]
        public string AlertType { get; set; }
        [Required]
        [Column("qualityAlertDesc")]
        public string QualityAlertDesc { get; set; }
        [Column("modifieddate", TypeName = "datetime")]
        public DateTime Modifieddate { get; set; }
        [Required]
        [Column("breakPointIdentifier")]
        public string BreakPointIdentifier { get; set; }
        [Column("hour")]
        public int Hour { get; set; }
        [Column("hourId")]
        public int HourId { get; set; }
        [Column("shiftdate", TypeName = "datetime")]
        public DateTime? Shiftdate { get; set; }
        [StringLength(50)]
        public string Shift { get; set; }
        [Column("stat_1")]
        public int Stat1 { get; set; }
        [Column("stat_2")]
        public int Stat2 { get; set; }
    }
}
