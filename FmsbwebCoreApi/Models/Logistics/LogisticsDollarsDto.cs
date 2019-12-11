using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FmsbwebCoreApi.Models.Logistics
{
    public class LogisticsDollarsDto
    {
        public DateTime Date { get; set; }
        public string Category { get; set; }
        public decimal Cost { get; set; }
        public decimal Target { get; set; }
    }
}
