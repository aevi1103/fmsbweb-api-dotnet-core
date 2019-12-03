using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Fmsb2
{
    public partial class DowntimeReason1
    {
        public DowntimeReason1()
        {
            DowntimeReason21 = new HashSet<DowntimeReason21>();
        }

        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("modifieddate", TypeName = "datetime")]
        public DateTime Modifieddate { get; set; }
        [Column("deptId")]
        public int DeptId { get; set; }
        [Column("reason1")]
        public string Reason1 { get; set; }
        [Column("isActive")]
        public bool? IsActive { get; set; }

        [ForeignKey(nameof(DeptId))]
        [InverseProperty(nameof(Department.DowntimeReason1))]
        public virtual Department Dept { get; set; }
        [InverseProperty("Reason1")]
        public virtual ICollection<DowntimeReason21> DowntimeReason21 { get; set; }
    }
}
