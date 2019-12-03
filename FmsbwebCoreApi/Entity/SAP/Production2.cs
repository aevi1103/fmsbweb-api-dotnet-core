using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.SAP
{
    public partial class Production2
    {
        [Required]
        [StringLength(100)]
        public string WorkCenter { get; set; }
        [Required]
        [Column("machine_hxh")]
        [StringLength(100)]
        public string MachineHxh { get; set; }
        [Required]
        [Column("side")]
        [StringLength(50)]
        public string Side { get; set; }
        [Required]
        [StringLength(50)]
        public string Department { get; set; }
        [Required]
        [StringLength(50)]
        public string Area { get; set; }
        public long OrderNumber { get; set; }
        [Column("UK_DateTime", TypeName = "datetime")]
        public DateTime? UkDateTime { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? LocalDateTime { get; set; }
        [Column("hourOffset")]
        public int? HourOffset { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ShiftDate { get; set; }
        [StringLength(5)]
        public string Shift { get; set; }
        [Required]
        [StringLength(100)]
        public string Material { get; set; }
        [Column("program")]
        [StringLength(100)]
        public string Program { get; set; }
        [Column("FMPart")]
        [StringLength(8)]
        public string Fmpart { get; set; }
        [Required]
        [StringLength(100)]
        public string EnteredUser { get; set; }
        public int? QtyProd { get; set; }
        [Column("id")]
        public int Id { get; set; }
    }
}
