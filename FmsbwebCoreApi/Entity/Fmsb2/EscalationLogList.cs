using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Fmsb2
{
    public partial class EscalationLogList
    {
        [Column("id")]
        public int Id { get; set; }
        [Required]
        [Column("deptName")]
        [StringLength(50)]
        public string DeptName { get; set; }
        [Column("shiftDate", TypeName = "datetime")]
        public DateTime ShiftDate { get; set; }
        [Required]
        [Column("shift")]
        [StringLength(50)]
        public string Shift { get; set; }
        [Required]
        [Column("machineName")]
        [StringLength(50)]
        public string MachineName { get; set; }
        [Required]
        [Column("defectName")]
        [StringLength(500)]
        public string DefectName { get; set; }
        [Column("scrapQty")]
        public int ScrapQty { get; set; }
        [Column("alarmLevel")]
        public int AlarmLevel { get; set; }
        [Column("modifieddate", TypeName = "datetime")]
        public DateTime Modifieddate { get; set; }
        [Required]
        [Column("page")]
        [StringLength(50)]
        public string Page { get; set; }
    }
}
