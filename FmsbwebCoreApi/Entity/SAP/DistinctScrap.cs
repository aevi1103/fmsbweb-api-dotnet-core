using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.SAP
{
    public partial class DistinctScrap
    {
        [Column("scrapAreaCode")]
        [StringLength(1)]
        public string ScrapAreaCode { get; set; }
        [Column("scrapAreaName")]
        [StringLength(50)]
        public string ScrapAreaName { get; set; }
        [Required]
        [Column("scrapCode")]
        [StringLength(100)]
        public string ScrapCode { get; set; }
        [Required]
        [Column("scrapDesc")]
        [StringLength(100)]
        public string ScrapDesc { get; set; }
    }
}
