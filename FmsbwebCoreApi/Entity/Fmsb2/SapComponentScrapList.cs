using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Fmsb2
{
    public partial class SapComponentScrapList
    {
        [Column("deptName")]
        [StringLength(50)]
        public string DeptName { get; set; }
        [Column("machineName")]
        [StringLength(50)]
        public string MachineName { get; set; }
        [Column("shiftdate", TypeName = "datetime")]
        public DateTime? Shiftdate { get; set; }
        [Column("shift")]
        [StringLength(50)]
        public string Shift { get; set; }
        [Column("defectArea")]
        [StringLength(50)]
        public string DefectArea { get; set; }
        [Column("defectName")]
        [StringLength(500)]
        public string DefectName { get; set; }
        [Column("defectid")]
        public int? Defectid { get; set; }
        [Column("pn")]
        public string Pn { get; set; }
        [Column("qty")]
        public int? Qty { get; set; }
        [StringLength(9)]
        public string Page { get; set; }
        public int? CostCenter { get; set; }
        [StringLength(3)]
        public string Type { get; set; }
        [Column("SAPPart")]
        [StringLength(30)]
        public string Sappart { get; set; }
        [Column("component")]
        [StringLength(50)]
        public string Component { get; set; }
        [Column("multiplier")]
        public int? Multiplier { get; set; }
        [Column("componentScrap")]
        public int? ComponentScrap { get; set; }
        [Required]
        [StringLength(23)]
        public string Stat { get; set; }
    }
}
