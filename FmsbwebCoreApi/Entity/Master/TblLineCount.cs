using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Master
{
    [Table("tblLineCount")]
    public partial class TblLineCount
    {
        [Key]
        public byte LineNr { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? RunDate { get; set; }
        public int? CounterStart { get; set; }
        public int? CounterStop { get; set; }
    }
}
