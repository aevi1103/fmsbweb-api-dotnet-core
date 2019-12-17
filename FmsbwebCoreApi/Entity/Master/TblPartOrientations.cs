using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Master
{
    [Table("tblPartOrientations")]
    public partial class TblPartOrientations
    {
        [Key]
        [Column("PartID")]
        [StringLength(6)]
        public string PartId { get; set; }
        [Key]
        [StringLength(2)]
        public string Orientation { get; set; }
    }
}
