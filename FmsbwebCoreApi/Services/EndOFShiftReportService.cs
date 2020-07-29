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
            if (data.EndOfShiftReportId == 0)
                return await base.CreateEos(data);

            return await UpdateEos(data);
        }
    }
}
