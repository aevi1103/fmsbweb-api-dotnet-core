using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Master
{
    [Table("tblFoundryTEMPDetails")]
    public partial class TblFoundryTempdetails
    {
        [Key]
        [Column("FdryID")]
        public int FdryId { get; set; }
        [Key]
        public bool? OddEven { get; set; }
        [Key]
        [Column("ScrapID")]
        [StringLength(4)]
        public string ScrapId { get; set; }
        public int? Quantity { get; set; }

        [ForeignKey(nameof(FdryId))]
        [InverseProperty(nameof(TblFoundryTemp.TblFoundryTempdetails))]
        public virtual TblFoundryTemp Fdry { get; set; }
    }
}
