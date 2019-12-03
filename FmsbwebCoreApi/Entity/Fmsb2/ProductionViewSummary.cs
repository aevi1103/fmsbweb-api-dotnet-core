using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Fmsb2
{
    public partial class ProductionViewSummary
    {
        [Column("approved")]
        public bool? Approved { get; set; }
        [Required]
        [Column("deptName")]
        [StringLength(50)]
        public string DeptName { get; set; }
        [Column("runtime", TypeName = "decimal(38, 2)")]
        public decimal Runtime { get; set; }
        [Column("mainMachine")]
        [StringLength(50)]
        public string MainMachine { get; set; }
        [Column("shiftDate", TypeName = "datetime")]
        public DateTime ShiftDate { get; set; }
        [Required]
        [Column("shift")]
        [StringLength(50)]
        public string Shift { get; set; }
        [Required]
        [Column("part")]
        public string Part { get; set; }
        [Column("gross")]
        public int? Gross { get; set; }
        [Column("foundry")]
        public int? Foundry { get; set; }
        [Column("mach")]
        public int? Mach { get; set; }
        [Column("anod")]
        public int? Anod { get; set; }
        [Column("sc")]
        public int? Sc { get; set; }
        [Column("assy")]
        public int? Assy { get; set; }
        [Column("net")]
        public int? Net { get; set; }
    }
}
