using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FmsbwebCoreApi.Models.FMSB2
{
    public class HxHProdDto
    {
        public int DeptId { get; set; }
        public string Area { get; set; }
        public string DeptName { get; set; }
        public int MachineId { get; set; }
        public string MachineName { get; set; }
        public string Line { get; set; }
        public int Hour { get; set; }
        public string PartNumber { get; set; }
        public string Program { get; set; }
        public int Production { get; set; }
        public string CellSide { get; set; }
        public decimal Target { get; set; }
        public DateTime ShiftDate { get; set; }
        public string Shift { get; set; }
        public int Gross { get; set; }
        public int GrossWithWarmers { get; set; }
        public int Net { get; set; }
        public int MachiningEosScrap { get; set; }
    }
}
