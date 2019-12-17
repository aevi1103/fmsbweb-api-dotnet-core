using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Master
{
    [Table("tblTolerances")]
    public partial class TblTolerances
    {
        [Key]
        [Column("PartID")]
        [StringLength(6)]
        public string PartId { get; set; }
        [Key]
        [Column("ComponentID")]
        [StringLength(2)]
        public string ComponentId { get; set; }
        public float? PctofGross { get; set; }
        public short? Multiplier { get; set; }
    }
}
