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

        public async Task AddToGroup(string groupName)
        {
            var connectionId = Context.ConnectionId;
            await Groups.AddToGroupAsync(connectionId, groupName).ConfigureAwait(false);
            await Clients.Group(groupName).SendAsync("BroadCastChange", $"{connectionId} has joined the group {groupName}.")
                .ConfigureAwait(false);
        }
    }
}
