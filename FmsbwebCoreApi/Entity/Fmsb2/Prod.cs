using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Fmsb2
{
    public partial class Prod
    {
        [Key]
        [Column("prodId")]
        public int ProdId { get; set; }
        [Column("deptId")]
        public int DeptId { get; set; }
        [Column("machineId")]
        public int MachineId { get; set; }
        [Column("shiftDate", TypeName = "datetime")]
        public DateTime ShiftDate { get; set; }
        [Required]
        [Column("shift")]
        [StringLength(50)]
        public string Shift { get; set; }
        [Column("gross")]
        public int? Gross { get; set; }
        [Column("approved")]
        public bool? Approved { get; set; }
        [Column("comments")]
        public string Comments { get; set; }
        [Column("modifieddate", TypeName = "datetime")]
        public DateTime Modifieddate { get; set; }
        [Required]
        [Column("part")]
        public string Part { get; set; }
        [Column("clockNumber")]
        public int ClockNumber { get; set; }
        [Column("runtime", TypeName = "decimal(18, 2)")]
        public decimal? Runtime { get; set; }
        [Column("cell")]
        [StringLength(50)]
        public string Cell { get; set; }
        [Column("die")]
        [StringLength(50)]
        public string Die { get; set; }

        [ForeignKey(nameof(DeptId))]
        [InverseProperty(nameof(Department.Prod))]
        public virtual Department Dept { get; set; }
        [ForeignKey(nameof(MachineId))]
        [InverseProperty(nameof(Machines.Prod))]
        public virtual Machines Machine { get; set; }
        [ForeignKey(nameof(Shift))]
        [InverseProperty("Prod")]
        public virtual Shift ShiftNavigation { get; set; }
    }
}
