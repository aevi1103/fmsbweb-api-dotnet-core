using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FmsbwebCoreApi.Models.Iconics
{
    public class IconicsDowntimeDto
    {
        public string TagName { get; set; }
        public string Dept { get; set; }
        public string Line { get; set; }
        public string MachineName { get; set; }
        public DateTime StartStamp { get; set; }
        public DateTime EndStamp { get; set; }
        public int StarHour { get; set; }
        public int EndHour { get; set; }
        public decimal Downtime { get; set; }
    }
}
