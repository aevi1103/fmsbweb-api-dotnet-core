using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Master
{
    [Table("tblFoundryDetailsXXX")]
    public partial class TblFoundryDetailsXxx
    {
        [Column("FdryID")]
        public int FdryId { get; set; }
        [Required]
        public bool? OddEven { get; set; }
        [Required]
        [Column("ScrapID")]
        [StringLength(4)]
        public string ScrapId { get; set; }
        public int? Quantity { get; set; }
    }
}
