using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Fmsb2
{
    public partial class EscalationLog2
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("deptId")]
        public int DeptId { get; set; }
        [Column("shiftDate", TypeName = "datetime")]
        public DateTime ShiftDate { get; set; }
        [Required]
        [Column("shift")]
        [StringLength(50)]
        public string Shift { get; set; }
        [Column("machineId")]
        public int MachineId { get; set; }
        [Column("defectId")]
        public int DefectId { get; set; }
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
