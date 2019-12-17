using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Master
{
    [Table("asmSwitchboard")]
    public partial class AsmSwitchboard
    {
        [Column("SwitchboardID")]
        public int SwitchboardId { get; set; }
        public int ItemNumber { get; set; }
        [Required]
        [StringLength(100)]
        public string ItemText { get; set; }
        public int Command { get; set; }
        [StringLength(50)]
        public string Argument { get; set; }
    }
}
