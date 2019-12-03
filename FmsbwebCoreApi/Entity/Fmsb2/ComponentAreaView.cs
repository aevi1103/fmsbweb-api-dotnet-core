using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Fmsb2
{
    public partial class ComponentAreaView
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("date", TypeName = "datetime")]
        public DateTime Date { get; set; }
        [Required]
        [Column("shift")]
        [StringLength(50)]
        public string Shift { get; set; }
        [Required]
        [Column("clockNum")]
        [StringLength(50)]
        public string ClockNum { get; set; }
        [Required]
        [Column("partNum")]
        [StringLength(50)]
        public string PartNum { get; set; }
        [Column("qtyToReclaim")]
        public int QtyToReclaim { get; set; }
        [Column("modifieddate", TypeName = "datetime")]
        public DateTime Modifieddate { get; set; }
        public int? RodReclaimed { get; set; }
        public int? RodScrapped { get; set; }
        public int? PinReclaimed { get; set; }
        public int? PinScrapped { get; set; }
    }
}
