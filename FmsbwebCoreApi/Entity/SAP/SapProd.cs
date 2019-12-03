using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.SAP
{
    public partial class SapProd
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
        [Column("uk_date", TypeName = "datetime")]
        public DateTime UkDate { get; set; }
        [Column("uk_time")]
        public TimeSpan? UkTime { get; set; }
        [Column("uk_DateTime_UTC_1", TypeName = "datetime")]
        public DateTime? UkDateTimeUtc1 { get; set; }
        [Column("EDT", TypeName = "datetime")]
        public DateTime? Edt { get; set; }
        [Column("EST", TypeName = "datetime")]
        public DateTime? Est { get; set; }
        [Column("shiftDate_edt", TypeName = "date")]
        public DateTime? ShiftDateEdt { get; set; }
        [Column("shiftDate_est", TypeName = "date")]
        public DateTime? ShiftDateEst { get; set; }
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
        [Column(TypeName = "decimal(18, 2)")]
        public decimal QtyProd { get; set; }
        [Column("id")]
        public int Id { get; set; }
        [Column("edt_shift")]
        public int EdtShift { get; set; }
        [Column("est_shift")]
        public int EstShift { get; set; }
    }
}
