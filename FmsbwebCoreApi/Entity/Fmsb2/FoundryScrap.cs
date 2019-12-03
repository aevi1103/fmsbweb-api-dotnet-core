using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Fmsb2
{
    public partial class FoundryScrap
    {
        [Column("id")]
        public int Id { get; set; }
        [Required]
        [Column("deptName")]
        [StringLength(50)]
        public string DeptName { get; set; }
        [Required]
        [Column("machineName")]
        [StringLength(50)]
        public string MachineName { get; set; }
        [Column("shiftDate", TypeName = "datetime")]
        public DateTime ShiftDate { get; set; }
        [Required]
        [Column("shift")]
        [StringLength(50)]
        public string Shift { get; set; }
        [Required]
        [Column("part")]
        public string Part { get; set; }
        [Required]
        [Column("defectArea")]
        [StringLength(50)]
        public string DefectArea { get; set; }
        [Required]
        [Column("defectName")]
        [StringLength(500)]
        public string DefectName { get; set; }
        [Column("qty")]
        public int? Qty { get; set; }
        [Column("comments")]
        public string Comments { get; set; }
        [Column("prodId")]
        public int? ProdId { get; set; }
    }
}
