using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Safety
{
    public partial class IncidentsByDeptYear
    {
        public int? Year { get; set; }
        [Required]
        [StringLength(50)]
        public string InjuryStat { get; set; }
        [Required]
        [StringLength(50)]
        public string Dept { get; set; }
        public int? Count { get; set; }
    }
}
