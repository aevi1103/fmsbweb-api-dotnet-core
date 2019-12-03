using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.SAP
{
    public partial class AvgShipDayPart
    {
        [Key]
        [Column("material")]
        [StringLength(100)]
        public string Material { get; set; }
        [Column("avg_ship_day")]
        public int? AvgShipDay { get; set; }
        [Column("show")]
        public bool? Show { get; set; }
        [Column("skidQty")]
        public int? SkidQty { get; set; }
    }
}
