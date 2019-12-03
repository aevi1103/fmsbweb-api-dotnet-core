using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Fmsb2
{
    public partial class MachineCycleTimeMasterView
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
        public int ShiftOrder { get; set; }
        [Column("day_shift")]
        [StringLength(83)]
        public string DayShift { get; set; }
        [Column("machineCycleTimeId")]
        public int MachineCycleTimeId { get; set; }
        [Column("machineId")]
        public int? MachineId { get; set; }
        [Column("machineName")]
        [StringLength(50)]
        public string MachineName { get; set; }
        [Column("actual", TypeName = "decimal(18, 5)")]
        public decimal? Actual { get; set; }
        [Column("target")]
        public int? Target { get; set; }
        [Column("stamp", TypeName = "datetime")]
        public DateTime Stamp { get; set; }
    }
}
