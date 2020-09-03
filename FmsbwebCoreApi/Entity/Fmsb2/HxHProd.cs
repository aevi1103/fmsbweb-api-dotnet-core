using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FmsbwebCoreApi.Entity.Fmsb2
{
    public class HxHProd
    {
        [Column("deptid")]
        public int DeptId { get; set; }
        [Column("deptName")]
        public string DeptName { get; set; }
        [Column("machineid")]
        public int MachineId { get; set; }
        [Column("machineName")]
        public string MachineName { get; set; }
        [Column("Line2")]
        public string Line { get; set; }
        [Column("hour")]
        public int Hour { get; set; }
        [Column("pn")]
        public string PartNumber { get; set; }

        [Column("part2")]
        public string Part2 { get; set; }

        [Column("program")]
        public string Program { get; set; }

        [Column("production")]
        public int Production { get; set; }
        [Column("cellSide_foundry")]
        public string CellSide { get; set; }
        [Column("HourId")]
        public int HourId { get; set; }
        [Column("runningTotal")]
        public int RunningTotal { get; set; }
        [Column("grossWithWarmers")]
        public int GrossWithWarmers { get; set; }
        [Column("PPH_Target")]
        public decimal Target { get; set; }
        [Column("shiftdate")]
        public DateTime ShiftDate { get; set; }
        [Column("shift")]
        public string Shift { get; set; }
        [Column("area")]
        public string Area { get; set; }
    }
}
