using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.FmsbQuality
{
    [Table("MachineGaugeLog_Notifications")]
    public partial class MachineGaugeLogNotifications
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Required]
        [Column("subject")]
        [StringLength(50)]
        public string Subject { get; set; }
        [Required]
        [Column("recipients")]
        public string Recipients { get; set; }
        [Required]
        [Column("body")]
        public string Body { get; set; }
        [Column("datetime", TypeName = "datetime")]
        public DateTime Datetime { get; set; }
        [Required]
        [StringLength(5000)]
        public string DaysOfOccurence { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime TimeOfOccurence { get; set; }
    }
}
