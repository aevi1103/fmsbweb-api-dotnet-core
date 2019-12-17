using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Master
{
    [Table("tblxtDefectCategory")]
    public partial class TblxtDefectCategory
    {
        [Key]
        [Column("CategoryID")]
        [StringLength(2)]
        public string CategoryId { get; set; }
        [StringLength(30)]
        public string Category { get; set; }
    }
}
