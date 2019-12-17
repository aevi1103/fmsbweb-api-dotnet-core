using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Master
{
    [Table("tblPartsPurchased")]
    public partial class TblPartsPurchased
    {
        [Required]
        [Column("PONumber")]
        [StringLength(10)]
        public string Ponumber { get; set; }
        [Required]
        [StringLength(18)]
        public string PartNr { get; set; }
        [Column(TypeName = "decimal(11, 3)")]
        public decimal Quantity { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime RcvdDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime TransDate { get; set; }
    }
}
