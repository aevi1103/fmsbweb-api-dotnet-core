using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FmsbwebCoreApi.Entity.Fmsb2;

namespace FmsbwebCoreApi.Repositories.Interfaces
{
    public interface IEndOfShiftReportRepository
    {
        Task<EndOfShiftReport> CreateEos(EndOfShiftReport data);
        Task<EndOfShiftReport> UpdateEos(EndOfShiftReport data);
        Task DeleteEos(int id);
        Task<bool> IsEosExist(EndOfShiftReport data);
        Task<List<EndOfShiftReport>> GetEos(DateTime shiftDate, string shift, string dept);
        Task<EndOfShiftReport> GetEos(DateTime shiftDate, string shift, int machineId);
        Task<List<EmailNotification>> GetEosEmailRecipients(string dept);
    }
}
