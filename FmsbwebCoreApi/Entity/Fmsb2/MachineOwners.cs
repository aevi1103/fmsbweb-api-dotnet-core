using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Fmsb2
{
    public partial class MachineOwners
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("machineId")]
        public int MachineId { get; set; }
        [Required]
        [Column("machineName")]
        [StringLength(50)]
        public string MachineName { get; set; }
        [Column("owners")]
        [StringLength(50)]
        public string Owners { get; set; }
        [Column("modifiedate", TypeName = "datetime")]
        public DateTime Modifiedate { get; set; }
    }
}
