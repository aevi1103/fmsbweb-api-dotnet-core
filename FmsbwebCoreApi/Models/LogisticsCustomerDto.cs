using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FmsbwebCoreApi.Models
{
    public class LogisticsCustomerDto
    {
        public int Id { get; set; }
        public int LogisticsId { get; set; }
        public string Customer { get; set; }
        public string Comment { get; set; }
        public DateTime Date { get; set; }
    }
}
