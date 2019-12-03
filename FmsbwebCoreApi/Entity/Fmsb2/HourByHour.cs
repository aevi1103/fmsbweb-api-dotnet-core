using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Fmsb2
{
    public partial class HourByHour
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("hour")]
        public int Hour { get; set; }
        [Column("pn")]
        [StringLength(50)]
        public string Pn { get; set; }
        [Column("production")]
        public int? Production { get; set; }
        [Column("modifieddate", TypeName = "datetime")]
        public DateTime Modifieddate { get; set; }
        [Column("cellSide_foundry")]
        [StringLength(50)]
        public string CellSideFoundry { get; set; }
        [Column("cavities_foundry")]
        public int? CavitiesFoundry { get; set; }
        public int HourId { get; set; }
        [Column("runningTotal")]
        public int? RunningTotal { get; set; }
        [Column("grossWithWarmers")]
        public int? GrossWithWarmers { get; set; }

        [ForeignKey(nameof(HourId))]
        [InverseProperty(nameof(CreateHxH.HourByHour))]
        public virtual CreateHxH HourNavigation { get; set; }
    }
}
