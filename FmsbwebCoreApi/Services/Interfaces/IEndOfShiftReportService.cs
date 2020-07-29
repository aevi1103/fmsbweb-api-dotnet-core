using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FmsbwebCoreApi.Entity.Fmsb2;
using FmsbwebCoreApi.Repositories.Interfaces;

namespace FmsbwebCoreApi.Services.Interfaces
{
    public interface IEndOfShiftReportService : IEndOfShiftReportRepository
    {
        Task<EndOfShiftReport> AddOrUpdate(EndOfShiftReport data);
    }
}
