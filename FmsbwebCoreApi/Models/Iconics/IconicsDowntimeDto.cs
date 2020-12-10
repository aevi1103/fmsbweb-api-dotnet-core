using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FmsbwebCoreApi.Models.Iconics
{
    public class IconicsDowntimeDto
    {
        private DateTime _startStamp;
        private DateTime _endStamp;

        public string TagName { get; set; }
        public string Dept { get; set; }
        public string Line { get; set; }
        public string MachineName { get; set; }

        public DateTime StartStamp
        {
            get => _startStamp;
            set => _startStamp = DateTime.Parse(value.ToString("MM/dd/yyyy HH:mm"));
        }

        public DateTime EndStamp
        {
            get => _endStamp;
            set => _endStamp = DateTime.Parse(value.ToString("MM/dd/yyyy HH:mm"));
        }

        public int StarHour => StartStamp.Hour;
        public int EndHour => EndStamp.Hour;
        public decimal Downtime { get; set; }

        public bool IsSameHour => StartStamp.Date == EndStamp.Date && StartStamp.Hour == EndStamp.Hour;
    }
}
