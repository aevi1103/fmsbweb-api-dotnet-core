using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Fmsb2
{
    public partial class ProdScrap
    {
        [Key]
        [Column("prodScrapId")]
        public int ProdScrapId { get; set; }
        [Column("deptId")]
        public int DeptId { get; set; }
        [Column("machineId")]
        public int MachineId { get; set; }
        [Column("defectId")]
        public int DefectId { get; set; }
        [Column("shiftDate", TypeName = "datetime")]
        public DateTime ShiftDate { get; set; }
        [Required]
        [Column("shift")]
        [StringLength(50)]
        public string Shift { get; set; }
        [Column("qty")]
        public int? Qty { get; set; }
        [Column("comments")]
        public string Comments { get; set; }
        [Column("prodId")]
        public int? ProdId { get; set; }
        [Column("modifieddate", TypeName = "datetime")]
        public DateTime Modifieddate { get; set; }
        [Required]
        [Column("part")]
        public string Part { get; set; }
        [Column("defectAreaId")]
        public int DefectAreaId { get; set; }
        [Column("cellNumber")]
        [StringLength(50)]
        public string CellNumber { get; set; }
        [Column("dieNumber")]
        [StringLength(50)]
        public string DieNumber { get; set; }

        [ForeignKey(nameof(DefectId))]
        [InverseProperty(nameof(Defects.ProdScrap))]
        public virtual Defects Defect { get; set; }
        [ForeignKey(nameof(DefectAreaId))]
        [InverseProperty("ProdScrap")]
        public virtual DefectArea DefectArea { get; set; }
        [ForeignKey(nameof(DeptId))]
        [InverseProperty(nameof(Department.ProdScrap))]
        public virtual Department Dept { get; set; }
        [ForeignKey(nameof(MachineId))]
        [InverseProperty(nameof(Machines.ProdScrap))]
        public virtual Machines Machine { get; set; }
        [ForeignKey(nameof(Shift))]
        [InverseProperty("ProdScrap")]
        public virtual Shift ShiftNavigation { get; set; }
    }
}
