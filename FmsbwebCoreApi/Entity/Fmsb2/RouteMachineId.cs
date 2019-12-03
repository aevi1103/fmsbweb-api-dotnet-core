using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Fmsb2
{
    public partial class RouteMachineId
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("deptId")]
        public int? DeptId { get; set; }
        [Column("machineId")]
        public int? MachineId { get; set; }
        [Column("machineIdRoute")]
        public int? MachineIdRoute { get; set; }
    }
}
