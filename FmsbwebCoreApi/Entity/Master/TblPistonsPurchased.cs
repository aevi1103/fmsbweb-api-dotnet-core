using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Master
{
    [Table("tblPistonsPurchased")]
    public partial class TblPistonsPurchased
    {
        [Required]
        [Column("PONumber")]
        [StringLength(10)]
        public string Ponumber { get; set; }
        [Required]
        [Column("PartID")]
        [StringLength(6)]
        public string PartId { get; set; }
        [Column(TypeName = "decimal(11, 3)")]
        public decimal Quantity { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime RcvdDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime TransDate { get; set; }
    }
}
