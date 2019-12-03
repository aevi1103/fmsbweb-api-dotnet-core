using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.SAP
{
    public partial class DistictAreas
    {
        [Required]
        [StringLength(50)]
        public string Area { get; set; }
        [Column("deptid")]
        public int? Deptid { get; set; }
    }
}
