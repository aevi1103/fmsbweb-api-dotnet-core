using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.FmsbMvc
{
    public partial class OverallCallbox
    {
        public Guid? Id { get; set; }
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
        public DateTime RequestDateTime { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? WorkingDateTime { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CompletedDateTime { get; set; }
        public string OperatorComment { get; set; }
        public string CompletionComment { get; set; }
        [Column("WaitingTime_Minutes")]
        public int? WaitingTimeMinutes { get; set; }
        [Column("RepairTime_Minutes")]
        public int? RepairTimeMinutes { get; set; }
        [Column("Downtime_Minutes")]
        public int? DowntimeMinutes { get; set; }
        [Required]
        [StringLength(15)]
        public string Type { get; set; }
    }
}
