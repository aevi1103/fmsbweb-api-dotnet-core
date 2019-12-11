using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FmsbwebCoreApi.Models.Logistics
{
    public class CustomerCommentsDto
    {
        public DateTime Date { get; set; }
        public string Customer { get; set; }
        public string Comments { get; set; }
    }
}
