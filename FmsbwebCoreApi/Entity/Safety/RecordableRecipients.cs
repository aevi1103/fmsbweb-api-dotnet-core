using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Safety
{
    public partial class RecordableRecipients
    {
        [Key]
        [Column("email")]
        [StringLength(50)]
        public string Email { get; set; }
    }
}
