using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Master
{
    [Table("tblCycleTimeMach")]
    public partial class TblCycleTimeMach
    {
        [Required]
        [StringLength(15)]
        public string PartFamily { get; set; }
        public int MachCycleTime { get; set; }
    }
}
