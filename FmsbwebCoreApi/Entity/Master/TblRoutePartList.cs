using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Master
{
    public partial class TblRoutePartList
    {
        [Required]
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
        [Column("FMPart")]
        [StringLength(5)]
        public string Fmpart { get; set; }
    }
}
