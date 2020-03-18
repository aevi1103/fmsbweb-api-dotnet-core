using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FmsbwebCoreApi.Entity.Fmsb2
{
    public class DowntimeOwner
    {
        [Key]
        public string Owner { get; set; }
        public string Color { get; set; }
    }
}
