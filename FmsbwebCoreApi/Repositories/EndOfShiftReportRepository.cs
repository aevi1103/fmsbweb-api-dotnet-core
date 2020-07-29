using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FmsbwebCoreApi.Context.Fmsb2;
using FmsbwebCoreApi.Entity.Fmsb2;
using FmsbwebCoreApi.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace FmsbwebCoreApi.Repositories
{
    public class EndOfShiftReportRepository : IEndOfShiftReportRepository
    {
        private readonly Fmsb2Context _fmsb2Context;

        public EndOfShiftReportRepository(Fmsb2Context fmsb2Context)
        {
            _fmsb2Context = fmsb2Context ?? throw new ArgumentNullException(nameof(fmsb2Context));
        }

        public virtual async Task<EndOfShiftReport> CreateEos(EndOfShiftReport data)
        {
            data.ShiftDate = data.ShiftDate.Date;
            await _fmsb2Context.EndOfShiftReports.AddAsync(data);
            await _fmsb2Context.SaveChangesAsync().ConfigureAwait(false);
            return data;
        }

        public async Task<EndOfShiftReport> UpdateEos(EndOfShiftReport data)
        {
            data.ShiftDate = data.ShiftDate.Date;
            _fmsb2Context.EndOfShiftReports.Update(data);
            await _fmsb2Context.SaveChangesAsync().ConfigureAwait(false);
            return data;
        }

        public async Task DeleteEos(int id)
        {
            _fmsb2Context.EndOfShiftReports.Remove(new EndOfShiftReport {EndOfShiftReportId = id});
            await _fmsb2Context.SaveChangesAsync().ConfigureAwait(false);
        }

        public async Task<bool> IsEosExist(EndOfShiftReport data)
        {
            return await _fmsb2Context.EndOfShiftReports.AnyAsync(x =>
                x.ShiftDate == data.ShiftDate.Date && x.Shift == data.Shift && x.MachineId == data.MachineId).ConfigureAwait(false);
        }

        public async Task<List<EndOfShiftReport>> GetEos(DateTime shiftDate, string shift, string dept)
        {
            return await _fmsb2Context.EndOfShiftReports
                .Include(x => x.Machine)
                .Where(x => x.ShiftDate == shiftDate 
                            && x.Shift == shift 
                            && x.Machine.Dept.DeptName == dept)
                .ToListAsync().ConfigureAwait(false);
        }

        public async Task<EndOfShiftReport> GetEos(DateTime shiftDate, string shift, int machineId)
        {
            return await _fmsb2Context.EndOfShiftReports
                .Include(x => x.Machine)
                .FirstOrDefaultAsync(x => x.ShiftDate == shiftDate
                                          && x.Shift == shift
                                          && x.MachineId == machineId)
                .ConfigureAwait(false);
        }

        public async Task<List<EmailNotification>> GetEosEmailRecipients(string dept)
        {
            dept = (dept == "Assembly" || dept == "Anodize" || dept == "Skirt Coat") ? "A&F" : dept;
            return await _fmsb2Context.EmailNotification.Where(x => x.Dept == dept).ToListAsync().ConfigureAwait(false);
        }
    }
}
