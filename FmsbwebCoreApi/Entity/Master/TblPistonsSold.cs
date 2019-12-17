using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Master
{
    [Table("tblPistonsSold")]
    public partial class TblPistonsSold
    {
        [Required]
        [Column("PartID")]
        [StringLength(6)]
        public string PartId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime SoldDate { get; set; }
        [Column(TypeName = "decimal(11, 3)")]
        public decimal SoldQty { get; set; }
    }
}
