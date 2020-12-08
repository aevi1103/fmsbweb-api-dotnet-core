using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FmsbwebCoreApi.Entity.FmsbOee
{
    public class Oee
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid OeeId { get; set; } = Guid.NewGuid();

        [Required]
        public Guid OeeLineId { get; set; }
        public virtual OeeLine OeeLine { get; set; }

        [Required]
        public DateTime StartDateTime { get; set; } = DateTime.Now;

        public DateTime? EndDateTime { get; set; }

        [Required]
        public DateTime DateModified { get; set; } = DateTime.Now;

        [Timestamp]
        public byte[] Timestamp { get; set; }
    }
}
