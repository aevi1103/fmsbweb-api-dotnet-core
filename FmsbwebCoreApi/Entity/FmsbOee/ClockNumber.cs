using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FmsbwebCoreApi.Entity.FmsbOee
{
    public class ClockNumber
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid ClockNumberId { get; set; } = Guid.NewGuid();

        [Required]
        public Guid OeeId { get; set; }
        public Oee Oee { get; set; }

        [Required]
        public int Clock { get; set; }

        [Required]
        public DateTime DateModified { get; set; } = DateTime.Now;

    }
}
