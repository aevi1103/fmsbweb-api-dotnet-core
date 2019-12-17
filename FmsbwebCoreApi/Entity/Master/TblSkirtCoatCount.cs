using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Master
{
    [Table("tblSkirtCoatCount")]
    public partial class TblSkirtCoatCount
    {
        [Key]
        public int CoatNr { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? RunDate { get; set; }
        public int? CounterStart { get; set; }
        public int? CounterStop { get; set; }
    }
}
