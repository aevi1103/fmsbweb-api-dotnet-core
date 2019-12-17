using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Master
{
    public partial class MhOnlineComments
    {
        [Column("UserID")]
        [StringLength(20)]
        public string UserId { get; set; }
        [Column("TDate", TypeName = "datetime")]
        public DateTime? Tdate { get; set; }
        [StringLength(20)]
        public string MachineDesc { get; set; }
        [StringLength(1000)]
        public string Comments { get; set; }
    }
}
