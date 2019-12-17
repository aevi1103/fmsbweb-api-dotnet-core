using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Master
{
    [Table("tblFoundryTEMP")]
    public partial class TblFoundryTemp
    {
        public TblFoundryTemp()
        {
            TblFoundryTempdetails = new HashSet<TblFoundryTempdetails>();
        }

        [Key]
        [Column("FdryID")]
        public int FdryId { get; set; }
        [Column("OldID")]
        public int? OldId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? FdryDate { get; set; }
        [Column("PartID")]
        [StringLength(6)]
        public string PartId { get; set; }
        [StringLength(1)]
        public string Shift { get; set; }
        public short? Cell { get; set; }
        [StringLength(1)]
        public string MachineLetter { get; set; }
        public short? Cycle { get; set; }
        [Column("OperatorID")]
        public short? OperatorId { get; set; }
        public int? TotalCast { get; set; }
        [StringLength(4)]
        public string OddDieNr { get; set; }
        [StringLength(4)]
        public string EvenDieNr { get; set; }

        [InverseProperty("Fdry")]
        public virtual ICollection<TblFoundryTempdetails> TblFoundryTempdetails { get; set; }
    }
}
