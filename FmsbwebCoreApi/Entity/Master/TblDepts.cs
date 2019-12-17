using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Master
{
    [Table("tblDepts")]
    public partial class TblDepts
    {
        [Key]
        [Column("DEPT")]
        [StringLength(6)]
        public string Dept { get; set; }
        [StringLength(15)]
        public string DeptDescription { get; set; }
    }
}
