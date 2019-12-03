using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.SAP
{
    public partial class DistinctPrograms
    {
        [Required]
        [StringLength(50)]
        public string Department { get; set; }
        [StringLength(50)]
        public string Area { get; set; }
        [Column("program")]
        [StringLength(100)]
        public string Program { get; set; }
    }
}
