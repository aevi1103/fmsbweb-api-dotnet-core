using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FmsbwebCoreApi.Models.Logistics
{
    public class LogisticsCommentDto
    {
        public DateTime Date { get; set; }
        public string Category { get; set; }
        public string Comments { get; set; }
    }
}
