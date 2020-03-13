using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FmsbwebCoreApi.Entity.Fmsb2
{
    public class AnodizeChecklist
    {
        [Key]
        public int AnodizeChecklistId { get; set; }

        [Required]
        public int MachineId { get; set; }

        [Required]
        public string Group { get; set; }

        [Required]
        public string Description { get; set; }
        public int? Min { get; set; }
        public int? Max { get; set; }

        [Required]
        public string Type { get; set; }
        public string DropDownList { get; set; }

        [Required]
        public DateTime Stamp { get; set; } = DateTime.Now;
    }
}
