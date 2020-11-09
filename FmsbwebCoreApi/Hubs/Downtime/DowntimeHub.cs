using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;

namespace FmsbwebCoreApi.Hubs.Downtime
{
    public class DowntimeHub : Hub
    {
        private readonly DowntimeTicker _downtimeTicker;

        public DowntimeHub(DowntimeTicker downtimeTicker)
        {
            _downtimeTicker = downtimeTicker;
        }
    }
}
