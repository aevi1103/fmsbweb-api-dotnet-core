using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Fmsb2
{
    public partial class DefectListWithGross
    {
        [Column("shiftdate", TypeName = "datetime")]
        public DateTime? Shiftdate { get; set; }
        [Column("shift")]
        [StringLength(50)]
        public string Shift { get; set; }
        [StringLength(50)]
        public string Line { get; set; }
        [Column("machineName")]
        [StringLength(50)]
        public string MachineName { get; set; }
        [Column("pn")]
        public string Pn { get; set; }
        [Column("gross")]
        public int? Gross { get; set; }
        [Column("defectArea")]
        [StringLength(50)]
        public string DefectArea { get; set; }
        [Column("defectName")]
        [StringLength(500)]
        public string DefectName { get; set; }
        [Column("qty")]
        public int? Qty { get; set; }
        [Column("deptName")]
        [StringLength(50)]
        public string DeptName { get; set; }
    }
}
