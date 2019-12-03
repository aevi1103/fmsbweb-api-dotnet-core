using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Fmsb2
{
    public partial class CheckSheet
    {
        [Key]
        [Column("checksheetId")]
        public int ChecksheetId { get; set; }
        [Column("deptId")]
        public int DeptId { get; set; }
        [Required]
        [Column("checksheet")]
        public string Checksheet1 { get; set; }
        [Column("modifieddate", TypeName = "datetime")]
        public DateTime Modifieddate { get; set; }
    }
}
