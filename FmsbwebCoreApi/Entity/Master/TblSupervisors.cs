using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Master
{
    [Table("tblSupervisors")]
    public partial class TblSupervisors
    {
        [Key]
        [StringLength(30)]
        public string SupName { get; set; }
    }
}
