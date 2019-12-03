using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Fmsb2
{
    public partial class DowntimeReason2
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Required]
        [Column("reason2")]
        public string Reason2 { get; set; }
        [Column("modifieddate", TypeName = "datetime")]
        public DateTime Modifieddate { get; set; }
        [Column("deptId")]
        public int DeptId { get; set; }

        [ForeignKey(nameof(DeptId))]
        [InverseProperty(nameof(Department.DowntimeReason2))]
        public virtual Department Dept { get; set; }
    }
}
