using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Master
{
    [Table("tblPistonID_as400")]
    public partial class TblPistonIdAs400
    {
        [StringLength(4)]
        public string BuySell { get; set; }
        [Key]
        [Column("GLPartID")]
        [StringLength(18)]
        public string GlpartId { get; set; }
        [Required]
        [Column("PartID")]
        [StringLength(6)]
        public string PartId { get; set; }
    }
}
