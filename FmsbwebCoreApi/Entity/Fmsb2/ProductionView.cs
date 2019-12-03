using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Fmsb2
{
    public partial class ProductionView
    {
        [Column("prodId")]
        public int ProdId { get; set; }
        [Column("approved")]
        public bool? Approved { get; set; }
        [Required]
        [Column("deptName")]
        [StringLength(50)]
        public string DeptName { get; set; }
        [Column("runtime", TypeName = "decimal(18, 2)")]
        public decimal? Runtime { get; set; }
        [Required]
        [Column("machineName")]
        [StringLength(50)]
        public string MachineName { get; set; }
        [Column("mainMachine")]
        [StringLength(50)]
        public string MainMachine { get; set; }
        [Column("shiftDate", TypeName = "datetime")]
        public DateTime ShiftDate { get; set; }
        [Required]
        [Column("shift")]
        [StringLength(50)]
        public string Shift { get; set; }
        [Required]
        [Column("part")]
        public string Part { get; set; }
        [Column("gross")]
        public int Gross { get; set; }
        public int Foundry { get; set; }
        public int Machining { get; set; }
        public int Anod { get; set; }
        [Column("SC")]
        public int Sc { get; set; }
        public int Assy { get; set; }
        [Column("comments")]
        public string Comments { get; set; }
        [Column("modifieddate", TypeName = "datetime")]
        public DateTime Modifieddate { get; set; }
    }
}
