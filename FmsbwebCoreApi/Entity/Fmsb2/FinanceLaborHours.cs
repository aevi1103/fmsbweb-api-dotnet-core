using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Fmsb2
{
    [Table("Finance_LaborHours")]
    public partial class FinanceLaborHours
    {
        [StringLength(100)]
        public string Name { get; set; }
        [Column("ID_")]
        [StringLength(50)]
        public string Id { get; set; }
        public int? Dept { get; set; }
        [Column("GLAccount")]
        public int? Glaccount { get; set; }
        public int? Shift { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DateIn { get; set; }
        public TimeSpan? TimeIn { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DateOut { get; set; }
        public TimeSpan? TimeOut { get; set; }
        [Column(TypeName = "decimal(18, 5)")]
        public decimal? Regular { get; set; }
        [Column(TypeName = "decimal(18, 5)")]
        public decimal? OtHalfTime { get; set; }
        [Column(TypeName = "decimal(18, 5)")]
        public decimal? Ot7d { get; set; }
        [Column(TypeName = "decimal(18, 5)")]
        public decimal? Overtime { get; set; }
        [Column(TypeName = "decimal(18, 5)")]
        public decimal? DoubleTime { get; set; }
        [Column(TypeName = "decimal(18, 5)")]
        public decimal? Orientation { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime UploadTime { get; set; }
        [Required]
        [StringLength(50)]
        public string Type { get; set; }
        [Key]
        [Column("Id")]
        public int Id1 { get; set; }
    }
}
