using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Fmsb2
{
    public partial class MachineCycleTimeMasterEntries
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("hourId")]
        public int HourId { get; set; }
        [Column("machineCycleTimeId")]
        public int MachineCycleTimeId { get; set; }
        [Column("cycleTime", TypeName = "decimal(18, 5)")]
        public decimal? CycleTime { get; set; }
        [Column("stamp", TypeName = "datetime")]
        public DateTime Stamp { get; set; }
    }
}
