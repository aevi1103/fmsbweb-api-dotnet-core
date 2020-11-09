using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;
using Microsoft.Extensions.Configuration;
using NUnit.Framework.Constraints;
using TableDependency.SqlClient;
using TableDependency.SqlClient.Base;
using TableDependency.SqlClient.Base.Enums;
using TableDependency.SqlClient.Base.EventArgs;

namespace FmsbwebCoreApi.Hubs.Counter
{
    public class CounterTicker : IDisposable
    {
        private readonly IConfiguration _configuration;
        private static SqlTableDependency<CounterModel> _tableDependency;

        public CounterTicker(IHubContext<CounterHub> counterHubContext, IConfiguration configuration)
        {
            Hub = counterHubContext;
            _configuration = configuration;

            var mapper = new ModelToTableMapper<CounterModel>();
            mapper.AddMapping(s => s.TagName, "tagName");
            mapper.AddMapping(s => s.Counter, "counter");
            mapper.AddMapping(s => s.Quality, "quality");
            mapper.AddMapping(s => s.LastUpdate, "lastUpdate");
            mapper.AddMapping(s => s.IsInitialSave, "isInitialSave");

            _tableDependency = new SqlTableDependency<CounterModel>(
                configuration.GetConnectionString("iconicsConn"),
                schemaName: "dbo",
                tableName: "KEPServer_CurrentStatus_PermCounts"
            );

            _tableDependency.OnChanged += SqlTableDependency_Changed;
            _tableDependency.OnError += SqlTableDependency_OnError;
            _tableDependency.Start();
        }

        private IHubContext<CounterHub> Hub { get; set; }

        private void SqlTableDependency_Changed(object sender, RecordChangedEventArgs<CounterModel> e) //update model class name
        {
            if (e.ChangeType == ChangeType.None) return;

            var tagName = e.Entity.TagName;
            if (tagName.EndsWith("91_PERM", StringComparison.CurrentCulture) 
                || tagName.EndsWith("PART", StringComparison.CurrentCulture) 
                || tagName.EndsWith("APC", StringComparison.CurrentCulture))
            {
                BroadCastChange(e.Entity);
            }
        }

        private async Task BroadCastChange(CounterModel data)
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

        ~CounterTicker()
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
