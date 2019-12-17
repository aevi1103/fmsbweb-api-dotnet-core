using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Master
{
    [Table("tbl_ScrapCounts")]
    public partial class TblScrapCounts
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [Column("ProdID")]
        public int ProdId { get; set; }
        [Required]
        [StringLength(50)]
        public string ScrapCode { get; set; }
        [Column("qty")]
        public int? Qty { get; set; }
        public string Comments { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime Modifieddate { get; set; }
        [Required]
        [StringLength(100)]
        public string ScrapName { get; set; }

        [ForeignKey(nameof(ProdId))]
        [InverseProperty(nameof(TblAssyProd.TblScrapCounts))]
        public virtual TblAssyProd Prod { get; set; }
        [ForeignKey(nameof(ScrapCode))]
        [InverseProperty(nameof(TblScodes.TblScrapCounts))]
        public virtual TblScodes ScrapCodeNavigation { get; set; }
    }
}
