using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Master
{
    [Table("tblMRRHoldDetails")]
    public partial class TblMrrholdDetails
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [Column("MRRYear")]
        public short? Mrryear { get; set; }
        [Column("MRRCode")]
        public short? Mrrcode { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ResolutionDate { get; set; }
        public int? ToScrap { get; set; }
        public int? ToGood { get; set; }
        [StringLength(5)]
        public string ResolutionBy { get; set; }
        [StringLength(254)]
        public string ResolutionComment { get; set; }

        [ForeignKey("Mrryear,Mrrcode")]
        [InverseProperty(nameof(TblMrrhold.TblMrrholdDetails))]
        public virtual TblMrrhold Mrr { get; set; }
    }
}
