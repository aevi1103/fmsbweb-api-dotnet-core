using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FmsbwebCoreApi.Entity.QualityCheckSheets
{
    public class Machine
    {
        public int MachineId { get; set; }

        [Required]
        public int LineId { get; set; }
        public virtual Line Line { get; set; }

        [Required]
        public string Value { get; set; }

        [Required]
        public DateTime TimeStamp { get; set; } = DateTime.Now;

    }
}
