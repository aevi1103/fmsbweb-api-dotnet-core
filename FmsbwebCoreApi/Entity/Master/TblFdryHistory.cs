using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Master
{
    [Table("tblFdryHistory")]
    public partial class TblFdryHistory
    {
        [StringLength(10)]
        public string Cell { get; set; }
        [StringLength(10)]
        public string StatGroup { get; set; }
        public int? Addr { get; set; }
        [StringLength(10)]
        public string Side { get; set; }
        [StringLength(10)]
        public string Cavity { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? Date { get; set; }
        [StringLength(10)]
        public string Shift { get; set; }
        [StringLength(50)]
        public string Operator { get; set; }
        [StringLength(10)]
        public string Core { get; set; }
        [StringLength(50)]
        public string Partno { get; set; }
        public int? Misrun { get; set; }
        public int? Inclusions { get; set; }
        public int? Drags { get; set; }
        public int? Damage { get; set; }
        public int? Weepers { get; set; }
        public int? Shortpours { get; set; }
        public int? Paint { get; set; }
        public int? Other { get; set; }
        public int? Warmers { get; set; }
        public int? Acount { get; set; }
        public int? Strcount { get; set; }
        public int? Endcount { get; set; }
        public int? Supcount { get; set; }
        public int? CalcType { get; set; }
        public int? Laddle { get; set; }
        public bool? Approved { get; set; }
        public bool? AutoFinalize { get; set; }
        [Column("FOperator")]
        [StringLength(50)]
        public string Foperator { get; set; }
        public bool? Transfered { get; set; }
        [Column("OperatorID")]
        public int? OperatorId { get; set; }
        public int? StrDiff { get; set; }
    }
}
