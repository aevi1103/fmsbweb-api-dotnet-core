using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Fmsb2
{
    public partial class MachineList
    {
        [Column("deptId")]
        public int DeptId { get; set; }
        [Column("machineId")]
        public int MachineId { get; set; }
        [Required]
        [Column("deptName")]
        [StringLength(50)]
        public string DeptName { get; set; }
        [Required]
        [Column("machineName")]
        [StringLength(50)]
        public string MachineName { get; set; }
        [Column("lineNumber")]
        public int? LineNumber { get; set; }
        [StringLength(20)]
        public string MachineMapper { get; set; }
    }
}
