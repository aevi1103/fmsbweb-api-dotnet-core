using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FmsbwebCoreApi.Context.Overtime;
using FmsbwebCoreApi.Entity.Overtime;
using FmsbwebCoreApi.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace FmsbwebCoreApi.Repositories
{
    public class OvertimeRepository : IOvertimeRepository
    {
        private readonly OvertimeContext _context;

        public OvertimeRepository(OvertimeContext context)
        {
            _context = context;
        }

        public async Task<List<Employee>> GetEmployees()
        {
            return await _context.Employees.Include(x => x.Department).ToListAsync().ConfigureAwait(false);
        }

        public async Task<List<Overtime>> GetOvertime(int year)
        {
            return await _context
                .Overtime
                .Where(x => x.Date.Year == year)
                .ToListAsync()
                .ConfigureAwait(false);
        }

        public async Task<Overtime> AddOrUpdate(Overtime overtime)
        {
            await using var transaction = await _context.Database.BeginTransactionAsync().ConfigureAwait(false);
            try
            {
                _context.Overtime.Update(overtime);
                await _context.SaveChangesAsync().ConfigureAwait(false);
                await transaction.CommitAsync().ConfigureAwait(false);

                return overtime;
            }
            catch (Exception e)
            {
                await transaction.RollbackAsync().ConfigureAwait(false);
                throw new Exception(e.Message);
            }
        }

        public async Task<Overtime> Delete(int id)
        {
            await using var transaction = await _context.Database.BeginTransactionAsync().ConfigureAwait(false);
            try
            {
                var data = _context.Overtime.Remove(new Overtime { OvertimeId = id});
                await _context.SaveChangesAsync().ConfigureAwait(false);
                await transaction.CommitAsync().ConfigureAwait(false);

                return data.Entity;
            }
            catch (Exception e)
            {
                await transaction.RollbackAsync().ConfigureAwait(false);
                throw new Exception(e.Message);
            }
        }
    }
}
