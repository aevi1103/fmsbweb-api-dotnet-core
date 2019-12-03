using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Fmsb2
{
    public partial class HourlyScrapList
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("hxhid")]
        public int Hxhid { get; set; }
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
        [Column("hourNum")]
        public int HourNum { get; set; }
        [Column("defectArea")]
        [StringLength(50)]
        public string DefectArea { get; set; }
        [Column("defectName")]
        [StringLength(500)]
        public string DefectName { get; set; }
        [Column("defectid")]
        public int Defectid { get; set; }
        [Column("pn")]
        [StringLength(50)]
        public string Pn { get; set; }
        [Column("qty")]
        public int Qty { get; set; }
        [Column("comments")]
        public string Comments { get; set; }
        [Column("modifieddate", TypeName = "datetime")]
        public DateTime Modifieddate { get; set; }
    }
}
