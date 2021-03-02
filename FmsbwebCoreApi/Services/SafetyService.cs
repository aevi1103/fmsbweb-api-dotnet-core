using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using DateShiftLib.Extensions;
using DocumentFormat.OpenXml.Wordprocessing;
using FmsbwebCoreApi.Context.Safety;
using FmsbwebCoreApi.Entity.Safety;
using FmsbwebCoreApi.Models;
using FmsbwebCoreApi.ResourceParameters;
using FmsbwebCoreApi.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using UtilityLibrary.Service.Interface;

namespace FmsbwebCoreApi.Services
{
    public class SafetyService : ISafetyService
    {
        private readonly SafetyContext _context;
        private readonly IMapper _mapper;
        private readonly IEmailService _emailService;

        public SafetyService(SafetyContext context, IMapper mapper, IEmailService emailService)
        {
            _context = context;
            _mapper = mapper;
            _emailService = emailService;
        }

        private async Task<bool> IsRecordable(int id)
        {
            return (await _context.Incidences.AsNoTracking().FirstOrDefaultAsync(x => x.Id == id)
                .ConfigureAwait(false))
                ?.InjuryStatId
                .ToLower()
                .Contains("recordable") ?? false;
        }

        private async Task SendRecordableEmail(Incidence data)
        {
            if (data == null) throw new ArgumentNullException(nameof(data));

            if (!data.InjuryStatId.ToLower().Trim().Contains("recordable")) return;

            const string sender = "alert-safety-recordable-status@tenneco.com";
            var emailBody = new StringBuilder();

            var subject = $"Alert: Incident has been changed to {data.InjuryStatId}";

            emailBody.AppendLine($"<h1>Recordable Injury Status:</h1> <br>");
            emailBody.AppendLine($"<b>Alert:</b> Incident has been changed to {data.InjuryStatId} <br><br>");
            emailBody.AppendLine($"<b>Department:</b> {data.Dept}<br><br>");
            emailBody.AppendLine($"<b>Name:</b> {data.Fname} {data.Lname}<br><br>");
            emailBody.AppendLine($"<b>Shift:</b> {data.Shift}<br><br>");
            emailBody.AppendLine($"<b>Incident Date:</b> {data.AccidentDate}<br><br>");
            emailBody.AppendLine($"<b>Injury:</b> {data.Injury}<br><br>");
            emailBody.AppendLine($"<b>Body Part:</b> {data.BodyPart}<br><br>");
            emailBody.AppendLine($"<b>Supervisor:</b> {data.Supervisor}<br><br>");
            emailBody.AppendLine($"<b>Injury Status:</b> {data.InjuryStatId}<br><br>");
            emailBody.AppendLine($"<b>Description:</b> {data.Description}<br><br>");
            emailBody.AppendLine($"<b>Interim Action Taken:</b> {data.InterimActionTaken}<br><br>");
            emailBody.AppendLine($"<b>Final Corrective Action:</b> {data.FinalCorrectiveAction}<br><br>");

            emailBody.AppendLine($"<b>Status:</b> {((bool)data.IsClosed ? "Closed" : "Open")}<br>");
            emailBody.AppendLine($"<b>Status:</b> {((bool)data.IsFmTipsCompleted ? "Completed" : "N/A")}<br>");
            emailBody.AppendLine($"<b>FM TiPS Number:</b> {data.FmTipsNumber}<br>");

            //emailBody.AppendLine($"<a href='http://10.129.224.149/FMSB/Safety/Print/PrintIncident.aspx?id={data.SafetyId}'>Click here to view incident.</a>");

            var recipientList = await _context.RecordableRecipients.Select(x => x.Email).ToListAsync().ConfigureAwait(false);
            var recipients = string.Join(",", recipientList);

            await _emailService.SendEmailAsync(sender, recipients, subject, emailBody.ToString()).ConfigureAwait(false);

        }

        private static dynamic GetIncidentsByDepartment(IReadOnlyCollection<Incidence> data)
        {
            var distinctInjuryStatus = data.Select(x => new {x.InjuryStatId, x.InjuryStat.Color }).Distinct().ToList();

            var result = data.GroupBy(x => new {x.Dept})
                .Select(x =>
                {

                    var injuries = distinctInjuryStatus.Select(injury => new {
                        injury.InjuryStatId,
                        injury.Color,
                        Department = x.Key.Dept,
                        Count = x.Count(c => c.InjuryStatId == injury.InjuryStatId)
                    }).OrderBy(injury => injury.InjuryStatId);

                    return new
                    {
                        x.Key.Dept,
                        Count = x.Count(),
                        Injuries = injuries
                    };

                }).OrderBy(x => x.Dept);

            return result;
        }

        private static dynamic GetOpenStatusByDepartment(IEnumerable<Incidence> data)
        {
            var result = data.GroupBy(x => new { x.Dept })
                .Select(x => new
                {
                    x.Key.Dept,
                    Count = x.Count(c => !(c.IsClosed ?? false))
                }).OrderByDescending(x => x.Count);

            return result;
        }

        private static dynamic GetMonthlyIncidents(IReadOnlyCollection<Incidence> data)
        {
            var distinctInjuryStatus = data.Select(x => new { x.InjuryStatId, x.InjuryStat.Color }).Distinct().ToList();

            var result = data.GroupBy(x => new
                {
                    x.AccidentDate.Month,
                    x.AccidentDate.Year,
                    MonthName = x.AccidentDate.ToMonthName()
                })
                .Select(x => 
                {
                    var injuries = distinctInjuryStatus.Select(injury => new {
                        injury.InjuryStatId,
                        injury.Color,
                        Count = x.Count(c => c.InjuryStatId == injury.InjuryStatId)
                    }).OrderBy(injury => injury.InjuryStatId);

                    return new
                    {
                        x.Key.Year,
                        x.Key.Month,
                        x.Key.MonthName,
                        Count = x.Count(),
                        injuries
                    };

                })
                .OrderBy(x => x.Year)
                .ThenBy(x => x.Month);

            return result;
        }

        private static dynamic GetInjuries(IEnumerable<Incidence> data)
        {
            var result = data.GroupBy(x => new
                {
                    x.Injury.InjuryName
                })
                .Select(x => new
                {
                    x.Key.InjuryName,
                    Count = x.Count()
                }).OrderByDescending(x => x.Count);

            return result;
        }

        private static dynamic GetBodyParts(IEnumerable<Incidence> data)
        {
            var result = data.GroupBy(x => new
                {
                    x.BodyPart.BodyPart1
                })
                .Select(x => new
                {
                    BodyPart = x.Key.BodyPart1,
                    Count = x.Count()
                })
                .OrderByDescending(x => x.Count);

            return result;
        }

        private static dynamic GetAverageDaysBeforeMitigation(IEnumerable<SafetyIncidenceDto> data)
        {
            var result = data
                .Where(x => x.MitigatedTimeStamp != null)
                .GroupBy(x => new
                {
                    x.Dept
                })
                .Select(x => new
                {
                    x.Key.Dept,
                    AvgDays = x.Average(a => a.DaysBeforeMitigation)
                })
                .OrderByDescending(x => x.AvgDays);

            return result;
        }

        private static dynamic GetNumberOfIssuesNotMitigateOver14Days(IEnumerable<SafetyIncidenceDto> data)
        {
            var result = data
                .GroupBy(x => new
                {
                    x.Dept
                })
                .Select(x => new
                {
                    x.Key.Dept,
                    IssuesCount = x.Count(i => i.IsNotMitigatedOver14Days)
                })
                .OrderByDescending(x => x.IssuesCount);

            return result;
        }

        private static double CalculateIncidentRates(int recordable, double manHours)
        {
            var rec = (recordable * 200000);
            var rate = manHours == 0 ? 0 : rec / manHours;
            return Math.Round(rate, 2);
        }

        private static dynamic GetMonthlyIncidentRate(List<Incidence> data, IReadOnlyCollection<ManHour> manHours, SafetyResourceParameter parameter)
        {
            var result = data
                .Where(x => x.InjuryStatId.ToLower().Contains("recordable"))
                .GroupBy(x => new
            {
                x.AccidentDate.Year,
                x.AccidentDate.Month,
                MonthName = x.AccidentDate.ToMonthName()
            }).Select(x =>
            {
                var monthlyHours = manHours
                    .Where(m => m.MosDte.Year == x.Key.Year && m.MosDte.Month == x.Key.Month)
                    .Sum(m => m.Manhrs);

                return new MonthlyIncidentRateDto
                {
                    Year = x.Key.Year,
                    Month = x.Key.Month,
                    MonthName = x.Key.MonthName,
                    Recordables = x.Count(),
                    Hours = monthlyHours,
                    Rate = CalculateIncidentRates(x.Count(), (double)monthlyHours)
                };
            })
                .OrderBy(x => x.Year)
                .ThenBy(x => x.Month)
                .ToList();

            var year = parameter.StartDate.Year;
            var months = new List<MonthlyIncidentRateDto>();
            while (year <= parameter.EndDate.Year)
            {
                for (var month = 1; month <= 12; month++)
                {
                    var record = result.FirstOrDefault(x => x.Year == year && x.Month == month);
                    months.Add(record ?? new MonthlyIncidentRateDto
                    {
                        Year = year,
                        Month = month,
                        MonthName = month.ToMonthName()
                    });
                }

                year++;
            }

            var monthlyHoursYtd = manHours.Sum(m => m.Manhrs);
            var recordablesYtd = data.Count(x => x.InjuryStatId.ToLower().Contains("recordable"));
            var ytdRate = CalculateIncidentRates(recordablesYtd, (double)monthlyHoursYtd);

            months.Add(new MonthlyIncidentRateDto
            {
                Year = 0,
                Month = 0,
                MonthName = "n/a",
                Hours = monthlyHoursYtd,
                Recordables = recordablesYtd,
                Rate = ytdRate
            });

            return months;
        }

        public async Task<Incidence> AddOrUpdate(SafetyIncidenceDto resourceParameter)
        {
            if (resourceParameter == null) throw new ArgumentNullException("resourceParameter cannot be null.");

            var injuryStatus = await _context
                .InjuryStats
                .AsNoTracking()
                .FirstOrDefaultAsync(x => x.InjuryStat1 == resourceParameter.InjuryStatId)
                .ConfigureAwait(false);

            var injuryStatusName = injuryStatus?.InjuryStat1 ?? "";

            var isClosed = resourceParameter?.IsClosed ?? false;
            var hasFmTips = !resourceParameter?.IsFmTipsCompleted ?? false;

            if (injuryStatusName.ToLower().Contains("recordable") && isClosed && hasFmTips)
                throw new OperationCanceledException("FM Tips must be completed first before changing status to close.");


            var data = _mapper.Map<Incidence>(resourceParameter);

            await using var transaction = await _context.Database.BeginTransactionAsync().ConfigureAwait(false);

            try
            {
                var isRecordable = resourceParameter.Id > 0 && await IsRecordable(resourceParameter.Id).ConfigureAwait(false);

                var entity = _context.Incidences.Update(data);
                await _context.SaveChangesAsync().ConfigureAwait(false);
                await transaction.CommitAsync().ConfigureAwait(false);

                if (isRecordable && resourceParameter.Id > 0)
                {
                    await SendRecordableEmail(entity.Entity).ConfigureAwait(false);
                }

                return entity.Entity;
            }
            catch (Exception e)
            {
                await transaction.RollbackAsync().ConfigureAwait(false);
                throw new Exception(e.Message);
            }

        }

        public async Task<Incidence> Delete(int id)
        {
            var entity = _context.Incidences.Remove(new Incidence { Id = id });
            await _context.SaveChangesAsync().ConfigureAwait(false);
            return entity.Entity;
        }

        public async Task<dynamic> GetChartsData(SafetyResourceParameter parameter)
        {
            if (parameter == null) throw new ArgumentNullException(nameof(parameter));

            var data = await _context
                .Incidences
                .Include(x => x.Injury)
                .Include(x => x.BodyPart)
                .Include(x => x.InjuryStat)
                .AsNoTracking()
                .Where(x => x.AccidentDate.Date >= parameter.StartDate && x.AccidentDate.Date <= parameter.EndDate)
                .OrderByDescending(x => x.AccidentDate)
                .ToListAsync()
                .ConfigureAwait(false);

            var manHours = await _context.ManHours
                .Where(x => x.MosDte.Date >= parameter.StartDate && x.MosDte.Date <= parameter.EndDate)
                .ToListAsync()
                .ConfigureAwait(false);

            var incidenceDto = _mapper.Map<List<SafetyIncidenceDto>>(data);

            var filteredData = parameter.ShowNearMiss
                ? data
                : data.Where(x => x.InjuryStatId != "Near Miss").ToList();

            var filteredDataByDept = filteredData.Where(x => x.Dept.Contains(parameter.Department)).ToList();
            var monthlyNearMissData = data.Where(x => x.InjuryStatId == "Near Miss" && x.Dept.Contains(parameter.Department)).ToList();
            
            return new
            { 
                IncidentsByDepartment = GetIncidentsByDepartment(filteredData),
                OpenStatusByDepartment = GetOpenStatusByDepartment(data),
                MonthlyIncidentRate = GetMonthlyIncidentRate(data, manHours, parameter),
                MonthlyIncidents = GetMonthlyIncidents(filteredDataByDept),
                MonthlyNearMissIncidents = GetMonthlyIncidents(monthlyNearMissData),
                InjuryByDepartment = GetInjuries(filteredDataByDept),
                BodyPartByDepartment = GetBodyParts(filteredDataByDept),
                Mitigation = GetAverageDaysBeforeMitigation(incidenceDto),
                NotMitigatedOver14Days = GetNumberOfIssuesNotMitigateOver14Days(incidenceDto), //change name later when front end is deployed

            };
        }
    }
}
