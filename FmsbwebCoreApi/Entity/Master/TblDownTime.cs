using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Master
{
    [Table("tblDownTime")]
    public partial class TblDownTime
    {
        [Key]
        [Column("FdryID")]
        public int FdryId { get; set; }
        [Column("S_01")]
        public int? S01 { get; set; }
        [Column("S_02")]
        public int? S02 { get; set; }
        [Column("S_03")]
        public int? S03 { get; set; }
        [Column("S_04")]
        public int? S04 { get; set; }
        [Column("S_05")]
        public int? S05 { get; set; }
        [Column("S_06")]
        public int? S06 { get; set; }
        [Column("S_07")]
        public int? S07 { get; set; }
        [Column("S_08")]
        public int? S08 { get; set; }
        [Column("S_09")]
        public int? S09 { get; set; }
        [Column("U_01")]
        public int? U01 { get; set; }
        [Column("U_02")]
        public int? U02 { get; set; }
        [Column("U_03")]
        public int? U03 { get; set; }
        [Column("U_04")]
        public int? U04 { get; set; }
        [Column("U_05")]
        public int? U05 { get; set; }
        [Column("U_06")]
        public int? U06 { get; set; }
        [Column("U_07")]
        public int? U07 { get; set; }
        [Column("U_08")]
        public int? U08 { get; set; }
        [Column("U_09")]
        public int? U09 { get; set; }
        [Column("U_10")]
        public int? U10 { get; set; }
        [Column("U_11")]
        public int? U11 { get; set; }
        [Column("U_12")]
        public int? U12 { get; set; }
        [Column("U_13")]
        public int? U13 { get; set; }

        [ForeignKey(nameof(FdryId))]
        [InverseProperty(nameof(TblFoundry.TblDownTime))]
        public virtual TblFoundry Fdry { get; set; }
    }
}
