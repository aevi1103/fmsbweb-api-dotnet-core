using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FmsbwebCoreApi.Models
{
    public class Mtbb
    {
        public DateTime Date { get; set; }
        public DateTime RequestDateTime { get; set; }
        public DateTime? PreviousRequestDateTime { get; set; }
        public double? MtbbMinutes { get; set; }
        public double? MtbbHours { get; set; }
    }
}
