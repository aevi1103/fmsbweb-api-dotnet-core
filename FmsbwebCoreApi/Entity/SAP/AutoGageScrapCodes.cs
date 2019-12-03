using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.SAP
{
    public partial class AutoGageScrapCodes
    {
        [Column("scrapCode")]
        public int ScrapCode { get; set; }
        [Required]
        [Column("defect")]
        [StringLength(50)]
        public string Defect { get; set; }
    }
}
