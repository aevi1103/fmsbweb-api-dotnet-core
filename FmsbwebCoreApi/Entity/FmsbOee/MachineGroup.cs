using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FmsbwebCoreApi.Entity.FmsbOee
{
    public class MachineGroup
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid MachineGroupId { get; set; } = Guid.NewGuid();
        [Required]
        public string GroupName { get; set; }
        [Required]
        public DateTime DateModified { get; set; } = DateTime.Now;

        public ICollection<Machine> Machines { get; set; }
    }
}
