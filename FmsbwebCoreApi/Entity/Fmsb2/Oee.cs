using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using FmsbwebCoreApi.Entity.SAP;

namespace FmsbwebCoreApi.Entity.Fmsb2
{
    public class Oee
    {
        public int OeeId { get; set; }
        [ForeignKey("MachineId")]
        public Machines Machines { get; set; }
        public int MachineId { get; set; }
        public DateTime StartDateTime { get; set; } = DateTime.Now;
        public DateTime? EndDateTime { get; set; }
        public DateTime TimeStamp { get; set; } = DateTime.Now;
    }
}
