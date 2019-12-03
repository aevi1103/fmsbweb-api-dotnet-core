using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Fmsb2
{
    public partial class SwotTargetEscalationView
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("swotTargetId")]
        public int SwotTargetId { get; set; }
        [Required]
        [Column("type")]
        [StringLength(50)]
        public string Type { get; set; }
        [Required]
        [Column("emailRecipients")]
        [StringLength(1000)]
        public string EmailRecipients { get; set; }
        [Required]
        [Column("message")]
        public string Message { get; set; }
        [Column("stamp", TypeName = "datetime")]
        public DateTime Stamp { get; set; }
        [Column("machineId")]
        public int MachineId { get; set; }
        [Column("oaeTarget", TypeName = "decimal(18, 5)")]
        public decimal OaeTarget { get; set; }
        [Column("targetPartsPerHour")]
        public int TargetPartsPerHour { get; set; }
    }
}
