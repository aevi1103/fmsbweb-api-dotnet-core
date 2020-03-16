using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.FmsbMvc
{
    public partial class OperatorAutoCallbox
    {
        [Required]
        [StringLength(50)]
        public string Department { get; set; }
        [Required]
        [StringLength(500)]
        public string Line { get; set; }
        [Required]
        [StringLength(500)]
        public string Machine { get; set; }
        [Required]
        public string PrimaryReason { get; set; }
        [Required]
        public string SecondaryReason { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime RequestDateTime { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime WorkingDateTime { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CompletedDateTime { get; set; }
        public string OperatorComment { get; set; }
        [Required]
        [StringLength(1)]
        public string MaintenanceComment { get; set; }
        [Column("WaitingTime_Minutes")]
        public int WaitingTimeMinutes { get; set; }
        [Column("RepairTime_Minutes")]
        public int? RepairTimeMinutes { get; set; }
        [Column("Downtime_Minutes")]
        public int? DowntimeMinutes { get; set; }
        [Required]
        [StringLength(15)]
        public string Type { get; set; }
    }
}
