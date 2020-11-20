using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FmsbwebCoreApi.Entity.Fmsb2
{
    public class LogisticsInventoryLocation
    {
        [Key]
        public string LogisticsInventoryLocationId { get; set; }

        public DateTime TimeStamp { get; set; } = DateTime.Now;
    }
}
