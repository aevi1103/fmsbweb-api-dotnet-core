using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.SAP
{
    public partial class ScrapAreaCode
    {
        [Key]
        [Column("scrapAreaCode")]
        public int ScrapAreaCode1 { get; set; }
        [Required]
        [Column("scrapAreaName")]
        [StringLength(50)]
        public string ScrapAreaName { get; set; }
        [Column("colorCode")]
        [StringLength(50)]
        public string ColorCode { get; set; }
    }
}
