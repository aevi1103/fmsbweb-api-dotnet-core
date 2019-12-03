using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.SAP
{
    public partial class Production
    {
        [Required]
        [StringLength(100)]
        public string WorkCenter { get; set; }
        public long OrderNumber { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime EnteredDate { get; set; }
        [Required]
        [StringLength(50)]
        public string EnteredTime { get; set; }
        [Required]
        [StringLength(100)]
        public string Material { get; set; }
        [Required]
        [StringLength(100)]
        public string EnteredUser { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Yield { get; set; }
        [Required]
        [StringLength(50)]
        public string UoM { get; set; }
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("UK_DateTime", TypeName = "datetime")]
        public DateTime? UkDateTime { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? LocalDateTime { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ShiftDate { get; set; }
        [StringLength(5)]
        public string Shift { get; set; }
        [Column("shiftDate_8", TypeName = "datetime")]
        public DateTime? ShiftDate8 { get; set; }
        [Column("shift_8")]
        public int? Shift8 { get; set; }
        [Column("isFiveDayShift")]
        public bool? IsFiveDayShift { get; set; }
        [StringLength(200)]
        public string ExportFileName { get; set; }
    }
}
