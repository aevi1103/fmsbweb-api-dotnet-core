using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FmsbwebCoreApi.Entity.QualityCheckSheets
{
    public class SubMachine
    {
        public int SubMachineId { get; set; }

        [Required]
        public int MachineId { get; set; }
        public virtual Machine Machine { get; set; }

        [Required]
        public string Value { get; set; }

        [Required]
        public DateTime TimeStamp { get; set; } = DateTime.Now;
    }
}
