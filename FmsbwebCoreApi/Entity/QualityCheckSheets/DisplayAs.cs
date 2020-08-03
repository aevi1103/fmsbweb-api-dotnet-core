using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FmsbwebCoreApi.Entity.QualityCheckSheets
{
    public class DisplayAs
    {
        public int DisplayAsId { get; set; }

        [Required]
        public string Display { get; set; }

        [Required]
        public DateTime TimeStamp { get; set; } = DateTime.Now;
    }
}
