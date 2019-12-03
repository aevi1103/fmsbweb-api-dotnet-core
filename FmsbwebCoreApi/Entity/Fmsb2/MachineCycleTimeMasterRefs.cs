using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Fmsb2
{
    public partial class MachineCycleTimeMasterRefs
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Required]
        [Column("machineName")]
        [StringLength(50)]
        public string MachineName { get; set; }
        [Column("machineId")]
        public int MachineId { get; set; }
        [Column("target")]
        public int? Target { get; set; }
        [Column("cycle")]
        public int Cycle { get; set; }
        [Column("stamp", TypeName = "datetime")]
        public DateTime Stamp { get; set; }
    }
}
