using System;
using System.Threading.Tasks;
using FmsbwebCoreApi.Hubs.Downtime;
using Microsoft.AspNetCore.SignalR;
using Microsoft.Extensions.Configuration;
using TableDependency.SqlClient;
using TableDependency.SqlClient.Base;
using TableDependency.SqlClient.Base.Enums;
using TableDependency.SqlClient.Base.EventArgs;

namespace FmsbwebCoreApi.Hubs.DowntimeManual
{
    public class DowntimeManualTicker : IDisposable
    {
        private readonly IConfiguration _configuration;
        private static SqlTableDependency<DowntimeManualModel> _tableDependency;

        public DowntimeManualTicker(IHubContext<DowntimeManualHub> counterHubContext, IConfiguration configuration)
        {
            Hub = counterHubContext;
            _configuration = configuration;

            var mapper = new ModelToTableMapper<DowntimeManualModel>();

            _tableDependency = new SqlTableDependency<DowntimeManualModel>(
                configuration.GetConnectionString("fmsbOeeConn"),
                schemaName: "dbo",
                tableName: "DowntimeEvents"
            );

            _tableDependency.OnChanged += SqlTableDependency_Changed;
            _tableDependency.OnError += SqlTableDependency_OnError;
            _tableDependency.Start();
        }

        private IHubContext<DowntimeManualHub> Hub { get; set; }

        private void SqlTableDependency_Changed(object sender, RecordChangedEventArgs<DowntimeManualModel> e)
        {
            if (e.ChangeType == ChangeType.None) return;

            BroadCastChange(e.Entity);

        }

        private async Task BroadCastChange(DowntimeManualModel data)
        {
            //await Hub.Clients.All.SendAsync("BroadCastChange", data);
            Console.WriteLine(data.MachineId);
            await Hub.Clients
                .Group(data.MachineId.ToString())
                .SendAsync("BroadCastChange", data)
                .ConfigureAwait(false);
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

        ~DowntimeManualTicker()
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
