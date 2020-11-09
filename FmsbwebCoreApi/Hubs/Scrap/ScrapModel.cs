using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FmsbwebCoreApi.Hubs.Scrap
{
    public class ScrapModel
    {
        public string WorkCenter { get; set; }
        public decimal Qty { get; set; }
        public string ScrapCode { get; set; }
        public string ScrapDesc { get; set; }
        public DateTime? ShiftDate { get; set; }
        public string Shift { get; set; }
        public int? Hour { get; set; }
        public string OperationNumberLocation { get; set; }
    }
}
