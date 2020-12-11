using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FmsbwebCoreApi.Entity.FmsbOee
{
    public class SecondaryReason
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid SecondaryReasonId { get; set; }
        [Required]
        public Guid PrimaryReasonId { get; set; }
        public PrimaryReason PrimaryReason { get; set; }
        [Required]
        public string Reason { get; set; }
        [Required]
        public DateTime DateModified { get; set; } = DateTime.Now;
    }
}
