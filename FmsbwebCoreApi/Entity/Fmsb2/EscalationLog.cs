using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Fmsb2
{
    public partial class EscalationLog
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("deptId")]
        public int DeptId { get; set; }
        [Column("date", TypeName = "datetime")]
        public DateTime Date { get; set; }
        [Required]
        [Column("shift")]
        [StringLength(50)]
        public string Shift { get; set; }
        [Required]
        [Column("line")]
        [StringLength(50)]
        public string Line { get; set; }
        [Required]
        [Column("part")]
        [StringLength(50)]
        public string Part { get; set; }
        [Column("gross")]
        public int Gross { get; set; }
        [Column("scrapcode")]
        public int Scrapcode { get; set; }
        [Required]
        [Column("defectName")]
        [StringLength(100)]
        public string DefectName { get; set; }
        [Column("scrapQty")]
        public int ScrapQty { get; set; }
        [Column("scrapRate", TypeName = "decimal(18, 5)")]
        public decimal ScrapRate { get; set; }
        [Column("mean", TypeName = "decimal(18, 5)")]
        public decimal Mean { get; set; }
        [Column("std", TypeName = "decimal(18, 5)")]
        public decimal Std { get; set; }
        [Column("std1", TypeName = "decimal(18, 5)")]
        public decimal Std1 { get; set; }
        [Column("std2", TypeName = "decimal(18, 5)")]
        public decimal Std2 { get; set; }
        [Column("modifieddate", TypeName = "datetime")]
        public DateTime Modifieddate { get; set; }
        [Column("alarmLevel")]
        public int AlarmLevel { get; set; }
    }
}
