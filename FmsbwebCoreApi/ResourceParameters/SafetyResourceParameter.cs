using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FmsbwebCoreApi.ResourceParameters
{
    public class SafetyResourceParameter
    {
        [Required]
        public DateTime StartDate { get; set; } = DateTime.Today;

        [Required]
        public DateTime EndDate { get; set; } = DateTime.Today;

        public string Department { get; set; } = "";
        public string SearchString { get; set; } = "";
        public bool ShowNearMiss { get; set; }
    }
}
