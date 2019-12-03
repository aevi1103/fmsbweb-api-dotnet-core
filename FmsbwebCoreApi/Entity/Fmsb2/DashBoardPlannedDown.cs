using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Fmsb2
{
    public partial class DashBoardPlannedDown
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("machineId")]
        public int MachineId { get; set; }
        [Column("planedDown")]
        public bool PlanedDown { get; set; }
        [Column("datemodified", TypeName = "datetime")]
        public DateTime Datemodified { get; set; }
    }
}
