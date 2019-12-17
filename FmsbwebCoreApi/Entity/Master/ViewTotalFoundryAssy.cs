using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Master
{
    public partial class ViewTotalFoundryAssy
    {
        [Column("ProdID")]
        public int ProdId { get; set; }
        [Required]
        [StringLength(10)]
        public string Area { get; set; }
        [Column("totalScrap")]
        public int? TotalScrap { get; set; }
    }
}
