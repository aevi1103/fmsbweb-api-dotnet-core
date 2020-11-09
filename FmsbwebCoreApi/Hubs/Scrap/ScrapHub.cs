using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;

namespace FmsbwebCoreApi.Hubs.Scrap
{
    public class ScrapHub : Hub
    {
        private readonly ScrapTicker _scrapTicker;

        public ScrapHub(ScrapTicker scrapTicker)
        {
            _scrapTicker = scrapTicker;
        }
    }
}
