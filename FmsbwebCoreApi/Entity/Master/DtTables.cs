using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Master
{
    [Table("dtTables")]
    public partial class DtTables
    {
        [Required]
        [StringLength(128)]
        public string TableName { get; set; }
        [Required]
        [StringLength(20)]
        public string Source { get; set; }
    }
}
