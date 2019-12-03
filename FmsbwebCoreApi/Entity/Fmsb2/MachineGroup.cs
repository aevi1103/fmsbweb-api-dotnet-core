using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Fmsb2
{
    public partial class MachineGroup
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("machineId")]
        public int MachineId { get; set; }
        [Required]
        [Column("machineGroup")]
        [StringLength(500)]
        public string MachineGroup1 { get; set; }
        [Column("modifiedate", TypeName = "datetime")]
        public DateTime Modifiedate { get; set; }
        [Column("isActive")]
        public bool? IsActive { get; set; }
    }
}
