using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.SAP
{
    public partial class ExcludedProgram
    {
        [Key]
        [StringLength(50)]
        public string Program { get; set; }
        [Required]
        public byte[] Stamp { get; set; }
    }
}
