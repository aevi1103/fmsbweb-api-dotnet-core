using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FmsbwebCoreApi.Entity.QualityCheckSheets
{
    public class Line
    {
        public int LineId { get; set; }

        [Required]
        public string Value { get; set; }

        [Required]
        public DateTime TimeStamp { get; set; } = DateTime.Now;

        public ICollection<Machine> Machines { get; set; } = new List<Machine>();
    }
}
