using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Master
{
    [Table("tblAFCycleTimes")]
    public partial class TblAfcycleTimes
    {
        [Key]
        [Column("ProcessID")]
        [StringLength(12)]
        public string ProcessId { get; set; }
        [Column(TypeName = "decimal(9, 4)")]
        public decimal CycleTime { get; set; }
    }
}
