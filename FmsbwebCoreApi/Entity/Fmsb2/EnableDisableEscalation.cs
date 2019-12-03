using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Fmsb2
{
    public partial class EnableDisableEscalation
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("machineId")]
        public int MachineId { get; set; }
        [Column("enable")]
        public bool Enable { get; set; }
        [Column("modifieddate", TypeName = "datetime")]
        public DateTime? Modifieddate { get; set; }
    }
}
