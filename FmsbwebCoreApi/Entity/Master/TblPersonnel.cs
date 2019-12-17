using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Master
{
    [Table("tblPersonnel")]
    public partial class TblPersonnel
    {
        [Key]
        [Column("CodeID")]
        [StringLength(20)]
        public string CodeId { get; set; }
        [StringLength(20)]
        public string FullName { get; set; }
    }
}
