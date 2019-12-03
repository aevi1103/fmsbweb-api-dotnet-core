using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.SAP
{
    public partial class Production2SummaryShift
    {
        [Column("id")]
        public Guid? Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Department { get; set; }
        [Required]
        [StringLength(50)]
        public string Area { get; set; }
        [Required]
        [Column("machine_hxh")]
        [StringLength(100)]
        public string MachineHxh { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ShiftDate { get; set; }
        [StringLength(5)]
        public string Shift { get; set; }
        [Required]
        [StringLength(100)]
        public string Material { get; set; }
        [Column("FMPart")]
        [StringLength(8)]
        public string Fmpart { get; set; }
        [Column("program")]
        [StringLength(100)]
        public string Program { get; set; }
        [Column("qty")]
        public int? Qty { get; set; }
    }
}
