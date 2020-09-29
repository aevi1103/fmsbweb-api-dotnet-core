using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FmsbwebCoreApi.Entity.Fmsb2
{
    public class AnodizeChecklistEntries
    {
        [Key]
        public int Id { get; set; }
        public virtual AnodizeChecklist AnodizeChecklist { get; set; }
        [Required]
        public int AnodizeChecklistId { get; set; }
        public decimal Value { get; set; }
        public virtual CreateHxH CreateHxH { get; set; }
        [Required]
        public DateTime Stamp { get; set; } = DateTime.Now;
    }
}
