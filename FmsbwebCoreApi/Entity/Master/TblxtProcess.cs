using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Master
{
    [Table("tblxtProcess")]
    public partial class TblxtProcess
    {
        [Key]
        [Column("ProcessID")]
        [StringLength(3)]
        public string ProcessId { get; set; }
        [Column("DepartmentID")]
        [StringLength(1)]
        public string DepartmentId { get; set; }
        [StringLength(30)]
        public string ProcessDescription { get; set; }
    }
}
