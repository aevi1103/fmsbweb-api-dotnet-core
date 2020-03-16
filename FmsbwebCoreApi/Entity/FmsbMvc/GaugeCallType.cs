using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.FmsbMvc
{
    [Table("GaugeCallType", Schema = "Gauge")]
    public partial class GaugeCallType
    {
        public GaugeCallType()
        {
            GageCall = new HashSet<GageCall>();
        }

        [Key]
        public int GaugeCallTypeId { get; set; }
        public string GaugeCall { get; set; }

        [InverseProperty("GaugeCallType")]
        public virtual ICollection<GageCall> GageCall { get; set; }
    }
}
