using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Master
{
    public partial class AssemblyDefectHistory
    {
        [Column("AssyID")]
        public int AssyId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime Date { get; set; }
        [Required]
        [StringLength(50)]
        public string Shift { get; set; }
        [Required]
        [StringLength(50)]
        public string Line { get; set; }
        [Required]
        [StringLength(50)]
        public string PartNumber { get; set; }
        [Required]
        [StringLength(50)]
        public string Grade { get; set; }
        public int? Gross { get; set; }
        [Required]
        [StringLength(10)]
        public string DefectArea { get; set; }
        [Required]
        [Column("defect")]
        [StringLength(100)]
        public string Defect { get; set; }
        [Column("qty")]
        public int? Qty { get; set; }
    }
}
