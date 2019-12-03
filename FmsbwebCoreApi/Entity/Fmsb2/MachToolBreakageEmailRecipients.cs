using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Fmsb2
{
    [Table("Mach_ToolBreakageEmailRecipients")]
    public partial class MachToolBreakageEmailRecipients
    {
        [Key]
        [Column("email")]
        [StringLength(50)]
        public string Email { get; set; }
    }
}
