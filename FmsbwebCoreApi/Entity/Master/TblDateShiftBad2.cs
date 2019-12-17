using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Master
{
    [Table("tblDateShift_BAD2")]
    public partial class TblDateShiftBad2
    {
        [Column("SDate", TypeName = "smalldatetime")]
        public DateTime? Sdate { get; set; }
        [StringLength(255)]
        public string Shift { get; set; }
    }
}
