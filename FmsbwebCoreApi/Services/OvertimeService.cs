using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FmsbwebCoreApi.Context.Overtime;
using FmsbwebCoreApi.Enums;
using FmsbwebCoreApi.Models;
using FmsbwebCoreApi.Repositories;
using FmsbwebCoreApi.ResourceParameters;
using FmsbwebCoreApi.Services.Interfaces;

namespace FmsbwebCoreApi.Services
{
    public class OvertimeService : OvertimeRepository, IOvertimeService
    {
        public OvertimeService(OvertimeContext context) : base(context)
        {
        }

        public async Task<List<OvertimeDto>> GetOvertimeTotalHours(OvertimeResourceParameter parameter)
        {
            if (parameter == null) throw new ArgumentNullException(nameof(parameter));

            var employees = await GetEmployees().ConfigureAwait(false);
            var overtime = await GetOvertime(parameter.Year).ConfigureAwait(false);
            const int daysInYear = 365;

            var result = employees.Select(x =>
            {
                var hoursQry = overtime.AsQueryable();
                hoursQry = hoursQry.Where(h => h.ClockNumber == x.ClockNumber);
                
                if (parameter.Date != null)
                    hoursQry = hoursQry.Where(h => h.Date == parameter.Date);

                return new OvertimeDto
                {
                    DepartmentId = x.DepartmentId,
                    Department = x.Department,
                    DateHired = x.DateHired,
                    FirstName = x.FirstName,
                    LastName = x.LastName,
                    ClockNumber = x.ClockNumber,
                    Hours = hoursQry.Where(h => h.TypeName == parameter.TypeName).Sum(h => h.Hours),
                    YearsOfService = DateTime.Today.Subtract(x.DateHired).TotalDays / daysInYear,

                    OvertimeDate = parameter.Date != null ? hoursQry.FirstOrDefault()?.Date : null,
                    OvertimeModifiedDate = parameter.Date != null ? hoursQry.FirstOrDefault()?.ModifiedDate : null,
                    OvertimeId = parameter.Date != null ? hoursQry.FirstOrDefault()?.OvertimeId ?? 0 : 0,
                    TypeName = parameter.Date != null ? hoursQry.FirstOrDefault()?.TypeName : null,

                    ParameterDate = parameter.Date,
                };
            });

            return parameter.TypeName switch
            {
                "Voluntary" => result.OrderByDescending(x => x.YearsOfService).ThenBy(x => x.Hours).ToList(),
                "Mandatory" => result.OrderBy(x => x.Hours).ThenBy(x => x.YearsOfService).ToList(),
                "Asked" => result.ToList(),
                _ => throw new ArgumentOutOfRangeException()
            };
        }
    }
}
