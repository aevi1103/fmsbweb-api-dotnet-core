using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Safety
{
    [Table("tempStacked_NoDate")]
    public partial class TempStackedNoDate
    {
        [StringLength(50)]
        public string Label { get; set; }
        [StringLength(50)]
        public string Series { get; set; } 

    }
}
