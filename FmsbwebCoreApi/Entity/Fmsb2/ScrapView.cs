using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Fmsb2
{
    public partial class ScrapView
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("deptId")]
        public int DeptId { get; set; }
        [Column("defectAreaId")]
        public int DefectAreaId { get; set; }
        [Column("defectId")]
        public int DefectId { get; set; }
        [Column("modifieddate", TypeName = "datetime")]
        public DateTime Modifieddate { get; set; }
        [Column("machineId")]
        public int MachineId { get; set; }
        [Column("viewName")]
        [StringLength(100)]
        public string ViewName { get; set; }

        [ForeignKey(nameof(DefectId))]
        [InverseProperty(nameof(Defects.ScrapView))]
        public virtual Defects Defect { get; set; }
        [ForeignKey(nameof(DefectAreaId))]
        [InverseProperty("ScrapView")]
        public virtual DefectArea DefectArea { get; set; }
        [ForeignKey(nameof(DeptId))]
        [InverseProperty(nameof(Department.ScrapView))]
        public virtual Department Dept { get; set; }
        [ForeignKey(nameof(MachineId))]
        [InverseProperty(nameof(Machines.ScrapView))]
        public virtual Machines Machine { get; set; }
        [ForeignKey(nameof(ViewName))]
        [InverseProperty(nameof(ScrapViewName.ScrapView))]
        public virtual ScrapViewName ViewNameNavigation { get; set; }
    }
}
