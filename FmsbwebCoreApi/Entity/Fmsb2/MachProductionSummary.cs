using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Fmsb2
{
    public partial class MachProductionSummary
    {
        public int ProdId { get; set; }
        [Required]
        [Column("deptName")]
        [StringLength(50)]
        public string DeptName { get; set; }
        [Required]
        [Column("machineName")]
        [StringLength(50)]
        public string MachineName { get; set; }
        [Column("shiftdate", TypeName = "datetime")]
        public DateTime Shiftdate { get; set; }
        [Required]
        [Column("shift")]
        [StringLength(50)]
        public string Shift { get; set; }
        [Column("oaeTarget", TypeName = "decimal(38, 5)")]
        public decimal? OaeTarget { get; set; }
        public int? Gross { get; set; }
        [Column("fs_hxh")]
        public int? FsHxh { get; set; }
        [Column("ms_hxh")]
        public int? MsHxh { get; set; }
        [Column("fs_visual")]
        public int? FsVisual { get; set; }
        [Column("ms_visual")]
        public int? MsVisual { get; set; }
        public int? Net { get; set; }
    }
}
