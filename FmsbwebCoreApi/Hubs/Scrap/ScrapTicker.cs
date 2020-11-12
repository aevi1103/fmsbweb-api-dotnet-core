using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;
using Microsoft.Extensions.Configuration;
using TableDependency.SqlClient;
using TableDependency.SqlClient.Base;
using TableDependency.SqlClient.Base.Enums;
using TableDependency.SqlClient.Base.EventArgs;

namespace FmsbwebCoreApi.Hubs.Scrap
{
    public class ScrapTicker : IDisposable
    {
        private readonly IConfiguration _configuration;
        private static SqlTableDependency<ScrapModel> _tableDependency;

        public ScrapTicker(IHubContext<ScrapHub> counterHubContext, IConfiguration configuration)
        {
            Hub = counterHubContext;
            _configuration = configuration;

            var mapper = new ModelToTableMapper<ScrapModel>();
            mapper.AddMapping(s => s.WorkCenter, "workCenter");
            mapper.AddMapping(s => s.Qty, "qty");
            mapper.AddMapping(s => s.ScrapCode, "scrapCode");
            mapper.AddMapping(s => s.ScrapDesc, "scrapDesc");
            mapper.AddMapping(s => s.ShiftDate, "ShiftDate");
            mapper.AddMapping(s => s.Shift, "Shift");
            mapper.AddMapping(s => s.Hour, "hour_hxh");
            mapper.AddMapping(s => s.OperationNumberLocation, "operationNumberLoc");

            _tableDependency = new SqlTableDependency<ScrapModel>(
                configuration.GetConnectionString("sapConn"),
                schemaName: "dbo",
                tableName: "Scrap"
            );

            _tableDependency.OnChanged += SqlTableDependency_Changed;
            _tableDependency.OnError += SqlTableDependency_OnError;
            _tableDependency.Start();
        }

        private IHubContext<ScrapHub> Hub { get; set; }

        private void SqlTableDependency_Changed(object sender, RecordChangedEventArgs<ScrapModel> e)
        {
            if (e.ChangeType == ChangeType.None) return;

            BroadCastChange(e.Entity);

        }

        private async Task BroadCastChange(ScrapModel data)
        {
            await Hub.Clients.All.SendAsync("BroadCastChange", data).ConfigureAwait(false);
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

        ~ScrapTicker()
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
