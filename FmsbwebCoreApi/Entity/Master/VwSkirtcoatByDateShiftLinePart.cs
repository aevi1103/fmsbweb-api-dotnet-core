using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Master
{
    public partial class VwSkirtcoatByDateShiftLinePart
    {
        [Column(TypeName = "datetime")]
        public DateTime CoatDate { get; set; }
        [Required]
        [StringLength(1)]
        public string Shift { get; set; }
        [Required]
        [Column("DepartmentID")]
        [StringLength(2)]
        public string DepartmentId { get; set; }
        [Required]
        [Column("PartID")]
        [StringLength(6)]
        public string PartId { get; set; }
        public int? GrossCount { get; set; }
        public int? ProductionScrap { get; set; }
        public int? PreCoatScrap { get; set; }
        public int? PostCoatScrap { get; set; }
        public int? NetCount { get; set; }
    }
}
