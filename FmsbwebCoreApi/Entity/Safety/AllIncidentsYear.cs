using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Safety
{
    public partial class AllIncidentsYear
    {
        [Required]
        [StringLength(50)]
        public string InjuryStat { get; set; }
        public int? AccidentYr { get; set; }
        public int? Count { get; set; }
    }
}
