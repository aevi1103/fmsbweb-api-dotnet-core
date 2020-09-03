using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FmsbwebCoreApi.Entity.Intranet
{
    public partial class EolvsEosView
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("shiftDate")]
        public DateTime ShiftDate { get; set; }
        [Column("shift")]
        public string Shift { get; set; }
        [Column("line")]
        public int Line { get; set; }
        [Column("pn")]
        public string Part { get; set; }
        [Column("program")]
        public string Program { get; set; }
        [Column("target")]
        public decimal Target { get; set; }
        [Column("gross")]
        public int Gross { get; set; }
        [Column("ms")]
        public int Ms { get; set; }
        [Column("fs")]
        public int Fs { get; set; }
    }
}
