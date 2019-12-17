using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Master
{
    [Table("tblPartsSold")]
    public partial class TblPartsSold
    {
        [Required]
        [StringLength(15)]
        public string PartNr { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime SoldDate { get; set; }
        [Column(TypeName = "decimal(11, 3)")]
        public decimal SoldQty { get; set; }
    }
}
