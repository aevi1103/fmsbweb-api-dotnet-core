using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Fmsb2
{
    public partial class DefectList
    {
        [Column("defectAreaId")]
        public int DefectAreaId { get; set; }
        [Required]
        [Column("defectArea")]
        [StringLength(50)]
        public string DefectArea { get; set; }
        [Required]
        [Column("defectName")]
        [StringLength(500)]
        public string DefectName { get; set; }
        [Required]
        [Column("areaDefect")]
        [StringLength(553)]
        public string AreaDefect { get; set; }
        [Column("defectId")]
        public int DefectId { get; set; }
    }
}
