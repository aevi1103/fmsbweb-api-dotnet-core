using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Fmsb2
{
    public partial class FurnaceReplacement
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("shiftDate", TypeName = "datetime")]
        public DateTime ShiftDate { get; set; }
        [Column("furnaceShellId")]
        public int FurnaceShellId { get; set; }
        [Column("machineId")]
        public int MachineId { get; set; }
        [Required]
        [Column("side")]
        [StringLength(1)]
        public string Side { get; set; }
        [Column("isPreHeated")]
        public bool IsPreHeated { get; set; }
        [Required]
        [Column("shift")]
        [StringLength(2)]
        public string Shift { get; set; }
        [Column("clockNum")]
        public int ClockNum { get; set; }
        [Column("comments")]
        public string Comments { get; set; }
        [Column("modifiedDate", TypeName = "datetime")]
        public DateTime ModifiedDate { get; set; }
        [Column("status")]
        [StringLength(50)]
        public string Status { get; set; }
        [Column("usedDays")]
        public int? UsedDays { get; set; }

        [ForeignKey(nameof(FurnaceShellId))]
        [InverseProperty(nameof(FurnaceShellNumbers.FurnaceReplacement))]
        public virtual FurnaceShellNumbers FurnaceShell { get; set; }
        [ForeignKey(nameof(MachineId))]
        [InverseProperty(nameof(Machines.FurnaceReplacement))]
        public virtual Machines Machine { get; set; }
    }
}
