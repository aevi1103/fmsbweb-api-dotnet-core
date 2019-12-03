using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Fmsb2
{
    public partial class FoundryCellCounterView
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("hourId")]
        public int HourId { get; set; }
        [Column("shiftdate", TypeName = "datetime")]
        public DateTime Shiftdate { get; set; }
        [Required]
        [Column("shift")]
        [StringLength(50)]
        public string Shift { get; set; }
        [Column("shiftOrder")]
        public int? ShiftOrder { get; set; }
        [Required]
        [Column("deptName")]
        [StringLength(50)]
        public string DeptName { get; set; }
        [Required]
        [Column("machineName")]
        [StringLength(50)]
        public string MachineName { get; set; }
        [Column("machineid")]
        public int Machineid { get; set; }
        [StringLength(10)]
        public string CellSide { get; set; }
        [Column("cavities")]
        public int Cavities { get; set; }
        [Column("startCount")]
        public long StartCount { get; set; }
        [Column("endCount")]
        public long EndCount { get; set; }
        [Column("shotCount")]
        public long? ShotCount { get; set; }
        [Column("grossParts")]
        public long? GrossParts { get; set; }
        public string ClockNums { get; set; }
        [Column("stamp", TypeName = "datetime")]
        public DateTime Stamp { get; set; }
    }
}
