using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Fmsb2
{
    public partial class Department
    {
        public Department()
        {
            DowntimeReason1 = new HashSet<DowntimeReason1>();
            DowntimeReason2 = new HashSet<DowntimeReason2>();
            DowntimeReason21 = new HashSet<DowntimeReason21>();
            Machines = new HashSet<Machines>();
            Prod = new HashSet<Prod>();
            ProdScrap = new HashSet<ProdScrap>();
            ScrapView = new HashSet<ScrapView>();
        }

        [Key]
        [Column("deptId")]
        public int DeptId { get; set; }
        [Required]
        [Column("deptName")]
        [StringLength(50)]
        public string DeptName { get; set; }
        [Column("modifieddate", TypeName = "datetime")]
        public DateTime Modifieddate { get; set; }

        [InverseProperty("Dept")]
        public virtual ICollection<DowntimeReason1> DowntimeReason1 { get; set; }
        [InverseProperty("Dept")]
        public virtual ICollection<DowntimeReason2> DowntimeReason2 { get; set; }
        [InverseProperty("Dept")]
        public virtual ICollection<DowntimeReason21> DowntimeReason21 { get; set; }
        [InverseProperty("Dept")]
        public virtual ICollection<Machines> Machines { get; set; }
        [InverseProperty("Dept")]
        public virtual ICollection<Prod> Prod { get; set; }
        [InverseProperty("Dept")]
        public virtual ICollection<ProdScrap> ProdScrap { get; set; }
        [InverseProperty("Dept")]
        public virtual ICollection<ScrapView> ScrapView { get; set; }
    }
}
