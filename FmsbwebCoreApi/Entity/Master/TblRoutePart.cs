using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Master
{
    [Table("tblRoutePart")]
    public partial class TblRoutePart
    {
        [Key]
        [Column("ID")]
        [StringLength(10)]
        public string Id { get; set; }
        [Required]
        [StringLength(15)]
        public string Fpart { get; set; }
        [Required]
        [StringLength(4)]
        public string Metal { get; set; }
        [Required]
        [StringLength(15)]
        public string Mpart { get; set; }
        [Column("FWeight", TypeName = "decimal(4, 3)")]
        public decimal? Fweight { get; set; }
        [Column("FBasket")]
        [StringLength(4)]
        public string Fbasket { get; set; }
    }
}
