using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Fmsb2
{
    public partial class ScrapHxhScrapUnion
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
        public int Defectid { get; set; }
        [Column("pn")]
        public string Pn { get; set; }
        [Column("qty")]
        public int? Qty { get; set; }
        [Required]
        [StringLength(9)]
        public string Page { get; set; }
        [Column("hxhid")]
        public int Hxhid { get; set; }
        [Required]
        [Column("assyLoad")]
        [StringLength(6)]
        public string AssyLoad { get; set; }
    }
}
