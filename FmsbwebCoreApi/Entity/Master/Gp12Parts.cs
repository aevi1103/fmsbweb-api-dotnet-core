using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Master
{
    [Table("GP12_Parts")]
    public partial class Gp12Parts
    {
        [Key]
        [StringLength(100)]
        public string PartName { get; set; }
        [Column("modifieddate", TypeName = "datetime")]
        public DateTime Modifieddate { get; set; }
    }
}
