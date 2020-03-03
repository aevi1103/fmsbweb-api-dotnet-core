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
        public int Id { get; set; }
        public int MachineId { get; set; }
        public string Group { get; set; }
        public string Description { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }
        public string Type { get; set; }
        public string DropDownList { get; set; }
        public string Value { get; set; }
        public string Comments { get; set; }
        public DateTime Stamp { get; set; }
    }
}
