using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using FmsbwebCoreApi.Enums;

namespace FmsbwebCoreApi.Entity.FmsbOee
{
    public class DowntimeEvent
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid DowntimeEventId { get; set; }

        [Required]
        public Guid OeeId { get; set; }
        public Oee Oee { get; set; }

        [Required]
        public DowntimeEventType DowntimeEventType { get; set; }

        [Required]
        public Guid MachineId { get; set; }
        public Machine Machine { get; set; }

        [Required]
        public Guid SecondaryReasonId { get; set; }
        public SecondaryReason SecondaryReason { get; set; }

        [Required]
        public int Downtime { get; set; }

        public string Comment { get; set; }

        [Required]
        public DateTime DateModified { get; set; } = DateTime.Now;

        [Timestamp]
        public byte[] Timestamp { get; set; }
    }
}
