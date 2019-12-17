using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Master
{
    public partial class AnodizeDefectHistory2
    {
        [Column("AnodizeID")]
        public int AnodizeId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime CoatDate { get; set; }
        [Required]
        [StringLength(1)]
        public string Shift { get; set; }
        [Required]
        [StringLength(2)]
        public string Line { get; set; }
        [Required]
        [StringLength(6)]
        public string Part { get; set; }
        [StringLength(2)]
        public string Grade { get; set; }
        public int? GrossProduction { get; set; }
        [Required]
        [StringLength(9)]
        public string DefectArea { get; set; }
        [Required]
        [StringLength(14)]
        public string Defect { get; set; }
        public int? Qty { get; set; }
    }
}
