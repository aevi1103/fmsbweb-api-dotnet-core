using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Master
{
    public partial class AfScDowntime
    {
        [Column("SkirtCoatID")]
        public int SkirtCoatId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime Date { get; set; }
        [Required]
        [StringLength(1)]
        public string Shift { get; set; }
        [Required]
        [StringLength(2)]
        public string Machine { get; set; }
        [Required]
        [StringLength(6)]
        public string Part { get; set; }
        [StringLength(2)]
        public string Grade { get; set; }
        [StringLength(5)]
        public string EnteredBy { get; set; }
        public short? Downstream { get; set; }
        public short? Upstream { get; set; }
        [Column("Washer Breakdown")]
        public short? WasherBreakdown { get; set; }
        [Column("Skirt Coat Breakdown")]
        public short? SkirtCoatBreakdown { get; set; }
        public short? Changeover { get; set; }
        public short? Vision { get; set; }
        public short? Inkjet { get; set; }
        public short? Accumulator { get; set; }
        public short? Quality { get; set; }
    }
}
