using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Fmsb2
{
    public partial class ParallelMachinesMachList
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("machNumberId")]
        public int MachNumberId { get; set; }
        [Required]
        [Column("deptName")]
        [StringLength(50)]
        public string DeptName { get; set; }
        [Required]
        [Column("machineName")]
        [StringLength(50)]
        public string MachineName { get; set; }
        [Required]
        [Column("machineGroup")]
        [StringLength(500)]
        public string MachineGroup { get; set; }
        [Column("machineNumber")]
        [StringLength(50)]
        public string MachineNumber { get; set; }
        [Column("divisor")]
        public int Divisor { get; set; }
        [Column("modifieddate", TypeName = "datetime")]
        public DateTime Modifieddate { get; set; }
    }
}
