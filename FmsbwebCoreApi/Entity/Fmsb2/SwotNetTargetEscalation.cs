using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Fmsb2
{
    [Table("SWOT_NetTargetEscalation")]
    public partial class SwotNetTargetEscalation
    {
        [Key]
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
    }
}
