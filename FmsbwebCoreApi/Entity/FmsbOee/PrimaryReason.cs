using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FmsbwebCoreApi.Entity.FmsbOee
{
    public class PrimaryReason
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid PrimaryReasonId { get; set; } = Guid.NewGuid();
        [Required]
        public string Reason { get; set; }
        [Required]
        public DateTime DateModified { get; set; } = DateTime.Now;
    }
}
