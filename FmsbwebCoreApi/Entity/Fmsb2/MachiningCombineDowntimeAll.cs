using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Fmsb2
{
    public partial class MachiningCombineDowntimeAll
    {
        [Column("date", TypeName = "datetime")]
        public DateTime Date { get; set; }
        [Required]
        [StringLength(50)]
        public string Shift { get; set; }
        public int? Line { get; set; }
        public int Hr { get; set; }
        [StringLength(500)]
        public string MachGroup { get; set; }
        [StringLength(200)]
        public string MachName { get; set; }
        public string Reason1 { get; set; }
        [Required]
        [StringLength(500)]
        public string Reason2 { get; set; }
        [Column(TypeName = "decimal(21, 5)")]
        public decimal? Downtime { get; set; }
        [Column("com")]
        public string Com { get; set; }
        [StringLength(50)]
        public string Part { get; set; }
        [Column(TypeName = "decimal(18, 5)")]
        public decimal? Cycle { get; set; }
        public int? LossParts { get; set; }
        [Required]
        [StringLength(7)]
        public string DtEntry { get; set; }
    }
}
