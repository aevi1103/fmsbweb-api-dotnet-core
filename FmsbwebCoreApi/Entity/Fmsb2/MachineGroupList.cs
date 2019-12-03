using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Fmsb2
{
    public partial class MachineGroupList
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
        [Column("machineGroup")]
        [StringLength(500)]
        public string MachineGroup { get; set; }
        [Column("deptId")]
        public int DeptId { get; set; }
        [Column("machinegroupid")]
        public int Machinegroupid { get; set; }
        [Column("machineid")]
        public int Machineid { get; set; }
        [Column("modifiedate", TypeName = "datetime")]
        public DateTime Modifiedate { get; set; }
    }
}
