using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.FmsbMvc
{
    public partial class QualityTechCallbox
    {
        [Required]
        [StringLength(50)]
        public string Department { get; set; }
        [Required]
        [StringLength(500)]
        public string Line { get; set; }
        public string Machine { get; set; }
        public string PrimaryReason { get; set; }
        public string SecondaryReason { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime RequestTimeStamp { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? StartTimeStamp { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? EndTimeStamp { get; set; }
        public string OperatorComment { get; set; }
        public string QualityTechComment { get; set; }
        [Column("WaitingTime_Minutes")]
        public int? WaitingTimeMinutes { get; set; }
        [Column("RepairTime_Minutes")]
        public int? RepairTimeMinutes { get; set; }
        [Column("Downtime_Minutes")]
        public int? DowntimeMinutes { get; set; }
        [Required]
        [StringLength(12)]
        public string Type { get; set; }
    }
}
