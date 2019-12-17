using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Master
{
    [Table("tbl_ComponentScrap")]
    public partial class TblComponentScrap
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [Column("ProdID")]
        public int ProdId { get; set; }
        [Required]
        [StringLength(50)]
        public string ComponentCode { get; set; }
        public int? ManualQty { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ModifiedDate { get; set; }
        [StringLength(50)]
        public string PinWeight { get; set; }

        [ForeignKey(nameof(ComponentCode))]
        [InverseProperty(nameof(TblCompList.TblComponentScrap))]
        public virtual TblCompList ComponentCodeNavigation { get; set; }
        [ForeignKey(nameof(ProdId))]
        [InverseProperty(nameof(TblAssyProd.TblComponentScrap))]
        public virtual TblAssyProd Prod { get; set; }
    }
}
