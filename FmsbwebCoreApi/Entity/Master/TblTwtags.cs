using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Master
{
    [Table("tbl_TWTags")]
    public partial class TblTwtags
    {
        [Column("Logging_name")]
        [StringLength(255)]
        public string LoggingName { get; set; }
        [Required]
        [Column("signal_name")]
        [StringLength(4000)]
        public string SignalName { get; set; }
    }
}
