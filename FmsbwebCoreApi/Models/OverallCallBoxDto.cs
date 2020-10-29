using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FmsbwebCoreApi.Entity.FmsbMvc;

namespace FmsbwebCoreApi.Models
{
    public class OverallCallBoxDto : OverallCallbox
    {
        public DateTime StartDateTime => RequestDateTime;
        public DateTime WorkDateTime => WorkingDateTime ?? DateTime.Now;
        public DateTime EndDateTime => CompletedDateTime ?? DateTime.Now;
        public bool IsSameHour => StartDateTime.Hour == EndDateTime.Hour
                                  && StartDateTime.Date == EndDateTime.Date;
    }
}
