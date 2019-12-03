using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Fmsb2
{
    public partial class CycleTimeList
    {
        [Required]
        [Column("deptName")]
        [StringLength(50)]
        public string DeptName { get; set; }
        [Required]
        [Column("machineName")]
        [StringLength(50)]
        public string MachineName { get; set; }
        [Required]
        [Column("part")]
        [StringLength(50)]
        public string Part { get; set; }
        [Column("cycletime_sec", TypeName = "decimal(18, 2)")]
        public decimal CycletimeSec { get; set; }
    }
}
