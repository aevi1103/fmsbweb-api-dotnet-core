using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Fmsb2
{
    public partial class Machines
    {
        public Machines()
        {
            FurnaceReplacement = new HashSet<FurnaceReplacement>();
            Prod = new HashSet<Prod>();
            ProdScrap = new HashSet<ProdScrap>();
            ScrapView = new HashSet<ScrapView>();
        }

        [Key]
        [Column("machineId")]
        public int MachineId { get; set; }
        [Required]
        [Column("machineName")]
        [StringLength(50)]
        public string MachineName { get; set; }
        [Column("machineDesc")]
        [StringLength(500)]
        public string MachineDesc { get; set; }
        [Column("modifieddate", TypeName = "datetime")]
        public DateTime? Modifieddate { get; set; }
        [Column("deptId")]
        public int DeptId { get; set; }
        [StringLength(20)]
        public string MachineMapper { get; set; }
        [Column("lineNumber")]
        public int? LineNumber { get; set; }

        public string Line2 { get; set; }

        [ForeignKey(nameof(DeptId))]
        [InverseProperty(nameof(Department.Machines))]
        public virtual Department Dept { get; set; }
        [InverseProperty("Machine")]
        public virtual ICollection<FurnaceReplacement> FurnaceReplacement { get; set; }
        [InverseProperty("Machine")]
        public virtual ICollection<Prod> Prod { get; set; }
        [InverseProperty("Machine")]
        public virtual ICollection<ProdScrap> ProdScrap { get; set; }
        [InverseProperty("Machine")]
        public virtual ICollection<ScrapView> ScrapView { get; set; }
    }
}
