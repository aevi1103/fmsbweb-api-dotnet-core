using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.FmsbMvc
{
    [Table("GaugeStation", Schema = "Gauge")]
    public partial class GaugeStation
    {
        public GaugeStation()
        {
            GageCall = new HashSet<GageCall>();
        }

        [Key]
        public int GaugeStationId { get; set; }
        public string Station { get; set; }

        [InverseProperty("GaugeStation")]
        public virtual ICollection<GageCall> GageCall { get; set; }
    }
}
