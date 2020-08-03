using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FmsbwebCoreApi.Entity.QualityCheckSheets
{
    public class ControlMethod
    {
        public int ControlMethodId { get; set; }

        [Required]
        public string Method { get; set; }

        [Required]
        public DateTime TimeStamp { get; set; } = DateTime.Now;
    }
}
