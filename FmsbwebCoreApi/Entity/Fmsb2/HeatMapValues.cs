using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Fmsb2
{
    public partial class HeatMapValues
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("heatMapLoginId")]
        public int HeatMapLoginId { get; set; }
        [Column("x_value")]
        public int XValue { get; set; }
        [Column("y_value")]
        public int YValue { get; set; }
        [Column("modifiedDate", TypeName = "datetime")]
        public DateTime ModifiedDate { get; set; }
        [Column("radius")]
        public int Radius { get; set; }
        [Column("value")]
        public int Value { get; set; }
    }
}
