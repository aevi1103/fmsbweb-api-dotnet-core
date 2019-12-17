using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Master
{
    [Table("tblFoundry")]
    public partial class TblFoundry
    {
        public TblFoundry()
        {
            TblFoundryDetails = new HashSet<TblFoundryDetails>();
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
        public int? FdryYear { get; set; }
        public int? FdryWeek { get; set; }
        [StringLength(1)]
        public string Shift { get; set; }
        public short? Cell { get; set; }
        [StringLength(1)]
        public string MachineLetter { get; set; }
        public short? Cycle { get; set; }
        [Column("OperatorID")]
        public short? OperatorId { get; set; }
        public int? DownTime { get; set; }
        public int? TotalCast { get; set; }
        [StringLength(4)]
        public string OddDieNr { get; set; }
        [StringLength(4)]
        public string EvenDieNr { get; set; }
        [Column("odd1129")]
        public int? Odd1129 { get; set; }
        [Column("odd1122")]
        public int? Odd1122 { get; set; }
        [Column("odd1123")]
        public int? Odd1123 { get; set; }
        [Column("odd1109")]
        public int? Odd1109 { get; set; }
        [Column("odd1106")]
        public int? Odd1106 { get; set; }
        [Column("odd1141")]
        public int? Odd1141 { get; set; }
        [Column("odd1139")]
        public int? Odd1139 { get; set; }
        [Column("odd1113")]
        public int? Odd1113 { get; set; }
        [Column("odd1108")]
        public int? Odd1108 { get; set; }
        [Column("odd1111")]
        public int? Odd1111 { get; set; }
        [Column("odd1115")]
        public int? Odd1115 { get; set; }
        [Column("odd1116")]
        public int? Odd1116 { get; set; }
        [Column("odd1146")]
        public int? Odd1146 { get; set; }
        [Column("odd1118")]
        public int? Odd1118 { get; set; }
        [Column("odd1128")]
        public int? Odd1128 { get; set; }
        [Column("odd1100")]
        public int? Odd1100 { get; set; }
        public int? TotalOddScrap { get; set; }
        [Column("evn1129")]
        public int? Evn1129 { get; set; }
        [Column("evn1122")]
        public int? Evn1122 { get; set; }
        [Column("evn1123")]
        public int? Evn1123 { get; set; }
        [Column("evn1109")]
        public int? Evn1109 { get; set; }
        [Column("evn1106")]
        public int? Evn1106 { get; set; }
        [Column("evn1141")]
        public int? Evn1141 { get; set; }
        [Column("evn1139")]
        public int? Evn1139 { get; set; }
        [Column("evn1113")]
        public int? Evn1113 { get; set; }
        [Column("evn1108")]
        public int? Evn1108 { get; set; }
        [Column("evn1111")]
        public int? Evn1111 { get; set; }
        [Column("evn1115")]
        public int? Evn1115 { get; set; }
        [Column("evn1116")]
        public int? Evn1116 { get; set; }
        [Column("evn1146")]
        public int? Evn1146 { get; set; }
        [Column("evn1118")]
        public int? Evn1118 { get; set; }
        [Column("evn1128")]
        public int? Evn1128 { get; set; }
        [Column("evn1100")]
        public int? Evn1100 { get; set; }
        public int? TotalEvenScrap { get; set; }

        [InverseProperty("Fdry")]
        public virtual TblDownTime TblDownTime { get; set; }
        [InverseProperty("Fdry")]
        public virtual ICollection<TblFoundryDetails> TblFoundryDetails { get; set; }
    }
}
