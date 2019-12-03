using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Fmsb2
{
    [Table("Mach_ToolBreakage")]
    public partial class MachToolBreakage
    {
        [Key]
        public int Id { get; set; }
        [Column("hourId")]
        public int HourId { get; set; }
        [Required]
        [Column("reason")]
        [StringLength(50)]
        public string Reason { get; set; }
        [Required]
        [Column("supervisorClock")]
        [StringLength(50)]
        public string SupervisorClock { get; set; }
        [Column("isGood")]
        public bool IsGood { get; set; }
        [Column("stamp", TypeName = "datetime")]
        public DateTime Stamp { get; set; }
        [Required]
        [Column("machineNumber")]
        [StringLength(50)]
        public string MachineNumber { get; set; }
    }
}
