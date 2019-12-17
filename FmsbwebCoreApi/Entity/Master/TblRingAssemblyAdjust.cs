using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Master
{
    [Table("tblRingAssemblyAdjust")]
    public partial class TblRingAssemblyAdjust
    {
        [Key]
        [Column("RingPartID")]
        [StringLength(18)]
        public string RingPartId { get; set; }
        [Key]
        [Column(TypeName = "datetime")]
        public DateTime AdjustDate { get; set; }
        public int? Adjustment { get; set; }
    }
}
