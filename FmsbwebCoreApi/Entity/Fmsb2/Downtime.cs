using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Fmsb2
{
    public partial class Downtime
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("hxhId")]
        public int HxhId { get; set; }
        [Column("reason1Id")]
        public int Reason1Id { get; set; }
        [Column("reason2Id")]
        public int? Reason2Id { get; set; }
        public string Comments { get; set; }
        [Column("modifieddate", TypeName = "datetime")]
        public DateTime Modifieddate { get; set; }
        [Column("downtimeloss", TypeName = "decimal(18, 2)")]
        public decimal? Downtimeloss { get; set; }
        [Column("machineGroupId")]
        public int? MachineGroupId { get; set; }
        [Column("machineNumberId")]
        public int? MachineNumberId { get; set; }
    }
}
