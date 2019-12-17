using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Master
{
    [Table("tblScrapCodes")]
    public partial class TblScrapCodes
    {
        [Key]
        [Column("DefectID")]
        [StringLength(4)]
        public string DefectId { get; set; }
        [StringLength(40)]
        public string DefectDescription { get; set; }
    }
}
