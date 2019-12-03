using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Fmsb2
{
    [Table("DowntimeReason2.1")]
    public partial class DowntimeReason21
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("deptid")]
        public int Deptid { get; set; }
        [Column("reason1id")]
        public int Reason1id { get; set; }
        [Required]
        [Column("reason2")]
        [StringLength(500)]
        public string Reason2 { get; set; }
        [Column("modifieddate", TypeName = "datetime")]
        public DateTime Modifieddate { get; set; }
        [Column("isActive")]
        public bool? IsActive { get; set; }

        [ForeignKey(nameof(Deptid))]
        [InverseProperty(nameof(Department.DowntimeReason21))]
        public virtual Department Dept { get; set; }
        [ForeignKey(nameof(Reason1id))]
        [InverseProperty(nameof(DowntimeReason1.DowntimeReason21))]
        public virtual DowntimeReason1 Reason1 { get; set; }
    }
}
