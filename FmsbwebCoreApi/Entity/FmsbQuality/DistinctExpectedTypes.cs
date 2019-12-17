using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.FmsbQuality
{
    public partial class DistinctExpectedTypes
    {
        [Column("expectedValueType")]
        [StringLength(50)]
        public string ExpectedValueType { get; set; }
    }
}
