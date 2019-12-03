using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Fmsb2
{
    public partial class DowntimeReportRecipients
    {
        [Key]
        [Column("email")]
        [StringLength(100)]
        public string Email { get; set; }
        [Column("deptName")]
        [StringLength(50)]
        public string DeptName { get; set; }
    }
}
