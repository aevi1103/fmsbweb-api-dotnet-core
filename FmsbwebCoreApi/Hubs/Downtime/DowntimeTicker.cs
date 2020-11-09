using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using FmsbwebCoreApi.Hubs.Counter;
using Microsoft.AspNetCore.SignalR;
using Microsoft.Extensions.Configuration;
using TableDependency.SqlClient;
using TableDependency.SqlClient.Base;
using TableDependency.SqlClient.Base.Enums;
using TableDependency.SqlClient.Base.EventArgs;

namespace FmsbwebCoreApi.Hubs.Downtime
{
    public class DowntimeTicker : IDisposable
    {
        private readonly IConfiguration _configuration;
        private static SqlTableDependency<DowntimeModel> _tableDependency;

        public DowntimeTicker(IHubContext<DowntimeHub> counterHubContext, IConfiguration configuration)
        {
            Hub = counterHubContext;
            _configuration = configuration;

            var mapper = new ModelToTableMapper<DowntimeModel>();
            mapper.AddMapping(s => s.TagName, "tagName");
            mapper.AddMapping(s => s.LastUpdate, "lastUpdate");
            mapper.AddMapping(s => s.IsDown, "isDown");

            _tableDependency = new SqlTableDependency<DowntimeModel>(
                configuration.GetConnectionString("iconicsConn"),
                schemaName: "dbo",
                tableName: "KEPServer_CurrentStatus_MachineDowntime"
            );

            _tableDependency.OnChanged += SqlTableDependency_Changed;
            _tableDependency.OnError += SqlTableDependency_OnError;
            _tableDependency.Start();
        }

        private IHubContext<DowntimeHub> Hub { get; set; }

        private void SqlTableDependency_Changed(object sender, RecordChangedEventArgs<DowntimeModel> e) 
        {
            if (e.ChangeType == ChangeType.None) return;

            if (e.Entity.TagName != null)
            {
                BroadCastChange(e.Entity);
            }

        }

        private async Task BroadCastChange(DowntimeModel data)
        {
            await Hub.Clients.All.SendAsync("BroadCastChange", data);
        }

        private static void SqlTableDependency_OnError(object sender, ErrorEventArgs e)
        {
            throw e.Error;
        }

        private bool _disposed; // To detect redundant calls

        protected virtual void Dispose(bool disposing)
        {
            if (_disposed) return;

            if (disposing)
            {
                _tableDependency.Stop();
                _tableDependency.Dispose();
            }

            _disposed = true;
        }

        ~DowntimeTicker()
        {
            Dispose(false);
        }

        // This code added to correctly implement the disposable pattern.
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

    }
}
