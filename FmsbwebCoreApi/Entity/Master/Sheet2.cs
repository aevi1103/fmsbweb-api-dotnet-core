using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Master
{
    [Table("Sheet2$")]
    public partial class Sheet2
    {
        [Column("ID")]
        [StringLength(255)]
        public string Id { get; set; }
        [StringLength(255)]
        public string Fpart { get; set; }
        [StringLength(255)]
        public string Metal { get; set; }
        [StringLength(255)]
        public string Mpart { get; set; }
    }
}
