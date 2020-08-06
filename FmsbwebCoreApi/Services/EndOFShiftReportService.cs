using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FmsbwebCoreApi.Context.Fmsb2;
using FmsbwebCoreApi.Entity.Fmsb2;
using FmsbwebCoreApi.Repositories;
using FmsbwebCoreApi.Services.Interfaces;

namespace FmsbwebCoreApi.Services
{
    public class EndOFShiftReportService : EndOfShiftReportRepository, IEndOfShiftReportService
    {
        public EndOFShiftReportService(Fmsb2Context fmsb2Context) : base(fmsb2Context)
        {
        }
        public async Task<EndOfShiftReport> AddOrUpdate(EndOfShiftReport data)
        {
            if (data == null) throw new ArgumentNullException(nameof(data));

            var isExist = await IsEosExist(data).ConfigureAwait(false);

            if (!isExist)
                return await base.CreateEos(data).ConfigureAwait(false);

            return await UpdateEos(data).ConfigureAwait(false);
        }
    }
}
