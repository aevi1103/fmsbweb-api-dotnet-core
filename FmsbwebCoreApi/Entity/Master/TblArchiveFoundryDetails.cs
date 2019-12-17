using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Master
{
    [Table("tblArchiveFoundryDetails")]
    public partial class TblArchiveFoundryDetails
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
        [InverseProperty(nameof(TblArchiveFoundry.TblArchiveFoundryDetails))]
        public virtual TblArchiveFoundry Fdry { get; set; }
    }
}
