using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Master
{
    public partial class MrrEosLink
    {
        [Column("MRRNum")]
        [StringLength(8000)]
        public string Mrrnum { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? IncidentDate { get; set; }
        [StringLength(1)]
        public string Shift { get; set; }
        [StringLength(15)]
        public string DeptName { get; set; }
        [Required]
        [StringLength(5)]
        public string Status { get; set; }
        [Column("SAPPart")]
        [StringLength(15)]
        public string Sappart { get; set; }
        public int Quantity { get; set; }
        [StringLength(50)]
        public string Technician { get; set; }
        [StringLength(1000)]
        public string Notes { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ClosedDate { get; set; }
        [Column("daysInHold")]
        public int? DaysInHold { get; set; }
    }
}
