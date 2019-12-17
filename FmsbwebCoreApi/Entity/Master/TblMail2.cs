using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Master
{
    [Table("tblMail2")]
    public partial class TblMail2
    {
        [Key]
        [StringLength(50)]
        public string Name { get; set; }
        [StringLength(1)]
        public string IndGroup { get; set; }
    }
}
