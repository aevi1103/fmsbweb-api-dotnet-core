using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;
using Microsoft.Extensions.Configuration;
using TableDependency.SqlClient;
using TableDependency.SqlClient.Base;
using TableDependency.SqlClient.Base.Enums;
using TableDependency.SqlClient.Base.EventArgs;

namespace FmsbwebCoreApi.Hubs.Counter
{
    public class CounterHub : Hub
    {
        private readonly CounterTicker _counterTicker;

        public CounterHub(CounterTicker counterTicker)
        {
            _counterTicker = counterTicker;
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
