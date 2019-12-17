using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Master
{
    [Table("tblPartsOfInterest")]
    public partial class TblPartsOfInterest
    {
        [Key]
        [Column("PartID")]
        [StringLength(6)]
        public string PartId { get; set; }
        public bool? Fdry { get; set; }
        [Column("EOL")]
        public bool? Eol { get; set; }
    }
}
