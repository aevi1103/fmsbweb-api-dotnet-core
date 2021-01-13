using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;

namespace FmsbwebCoreApi.Hubs.DowntimeManual
{
    public class DowntimeManualHub : Hub
    {
        private readonly DowntimeManualTicker _downtimeManualTicker;

        public DowntimeManualHub(DowntimeManualTicker downtimeManualTicker)
        {
            _downtimeManualTicker = downtimeManualTicker;
        }

        public async Task AddToGroup(string machineId)
        {
            var connectionId = Context.ConnectionId;
            await Groups.AddToGroupAsync(connectionId, machineId).ConfigureAwait(false);
            await Clients.Group(machineId).SendAsync("onJoin", $"{connectionId} has joined the group {machineId}.")
                .ConfigureAwait(false);
        }

        public async Task RemoveToGroup(string machineId)
        {
            var connectionId = Context.ConnectionId;
            await Groups.RemoveFromGroupAsync(connectionId, machineId).ConfigureAwait(false);
            await Clients.Group(machineId).SendAsync("onLeave", $"{connectionId} has left the group {machineId}.")
                .ConfigureAwait(false);
        }
    }
}
