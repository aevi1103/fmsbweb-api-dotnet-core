using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Fmsb2
{
    public partial class FoundryCellCounter
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("hourId")]
        public int HourId { get; set; }
        [Column("startCount")]
        public long StartCount { get; set; }
        [Column("endCount")]
        public long EndCount { get; set; }
        [Column("stamp", TypeName = "datetime")]
        public DateTime Stamp { get; set; }
    }
}
