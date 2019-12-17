using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Master
{
    [Table("tblDateShift")]
    public partial class TblDateShift
    {
        [Column("SDate", TypeName = "smalldatetime")]
        public DateTime? Sdate { get; set; }
        [StringLength(255)]
        public string Shift { get; set; }
    }
}
