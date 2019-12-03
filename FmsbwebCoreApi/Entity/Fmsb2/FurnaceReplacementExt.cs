using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Fmsb2
{
    public partial class FurnaceReplacementExt
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("furnaceReplacementId")]
        public int FurnaceReplacementId { get; set; }
        [Column("machineId")]
        public int MachineId { get; set; }
        [Required]
        [Column("side")]
        [StringLength(1)]
        public string Side { get; set; }
        [Required]
        [Column("shift")]
        [StringLength(1)]
        public string Shift { get; set; }
        [Column("clockNum")]
        public int ClockNum { get; set; }
        [Column("isPreHeated")]
        public bool IsPreHeated { get; set; }
        [Required]
        [Column("comments")]
        public string Comments { get; set; }
        [Column("modifieddate", TypeName = "datetime")]
        public DateTime Modifieddate { get; set; }
        [Column("dateReplaced", TypeName = "datetime")]
        public DateTime DateReplaced { get; set; }
        [Column("dateRemoved", TypeName = "datetime")]
        public DateTime DateRemoved { get; set; }
    }
}
