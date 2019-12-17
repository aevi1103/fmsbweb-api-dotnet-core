using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Master
{
    public partial class SkirtCoatDefectHistory
    {
        [Column("SkirtCoatID")]
        public int SkirtCoatId { get; set; }
        [Required]
        [StringLength(50)]
        public string DefectArea { get; set; }
        [Required]
        public string Defect { get; set; }
        [Column("qty")]
        public int? Qty { get; set; }
    }
}
