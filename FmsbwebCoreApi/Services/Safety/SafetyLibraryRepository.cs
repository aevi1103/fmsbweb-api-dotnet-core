using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FmsbwebCoreApi.Context.Safety;
using FmsbwebCoreApi.Entity.Safety;
using FmsbwebCoreApi.Enums;
using FmsbwebCoreApi.Helpers;
using FmsbwebCoreApi.Models.Safety.Incident;
using FmsbwebCoreApi.ResourceParameters.Safety;
using Microsoft.EntityFrameworkCore;

using NinjaNye.SearchExtensions;

namespace FmsbwebCoreApi.Services.Safety
{
    public class SafetyLibraryRepository : ISafetyLibraryRepository, IDisposable
    {
        private readonly SafetyContext _context;
        private readonly IPropertyMappingService _propertyMappingService;

        public SafetyLibraryRepository(SafetyContext context, IPropertyMappingService propertyMappingService)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
            _propertyMappingService = propertyMappingService ?? throw new ArgumentNullException(nameof(propertyMappingService));
        }

        public IEnumerable<Incidence> GetIncents()
        {
            return _context
                    .Incidence
                    .Include(injury => injury.Injury)
                    .Include(body => body.BodyPart)
                    .Include(attach => attach.Attachments)
                    .OrderBy(x => x.AccidentDate)
                    .ToList<Incidence>();
        }

        public PagedList<Incidence> GetIncents(IncidentsResourceParameter incidentsResourceParameter)
        {
            if (incidentsResourceParameter == null)
            {
                throw new ArgumentNullException(nameof(incidentsResourceParameter));
            }

            var p = incidentsResourceParameter;

            // convert set to iqueryable
            var collection = _context.Incidence as IQueryable<Incidence>; //builds the sql commands

            //check if not dept is not emnpty the apply filter
            if (!string.IsNullOrWhiteSpace(p.Dept))
            {
                p.Dept = p.Dept.Trim();
                collection = collection.Where(x => x.Dept.Trim() == p.Dept.Trim());
            };

            if (!string.IsNullOrWhiteSpace(p.Start.ToShortDateString()) && !string.IsNullOrWhiteSpace(p.End.ToShortDateString()))
            {
                collection = collection.Where(x => x.AccidentDate >= p.Start && x.AccidentDate <= p.End);
            };

            //check if not qry string is empty, if yes apply search to all string props
            if (!string.IsNullOrWhiteSpace(p.SearchQuery))
            {
                p.SearchQuery = p.SearchQuery.Trim();
                collection = collection.Search(
                                    x => x.Dept,
                                    x => x.Fname,
                                    x => x.Lname,
                                    x => x.Shift,
                                    x => x.Injury.InjuryName,
                                    x => x.BodyPart.BodyPart1,
                                    x => x.Supervisor,
                                    x => x.InjuryStatId,
                                    x => x.Description,
                                    x => x.InterimActionTaken,
                                    x => x.FinalCorrectiveAction,
                                    x => x.ReasonSupportingOrirstat,
                                    x => x.FmTipsNumber
                                ).Containing(p.SearchQuery);
            };

            //sorting
            if (!string.IsNullOrWhiteSpace(p.OrderBy))
            {
                //get property mapping dictionary
                var incidentPropertyMappingDictionary = _propertyMappingService.GetPropertyMapping<IncidentDto, Incidence>();
                collection = collection.ApplySort(p.OrderBy, incidentPropertyMappingDictionary);
            }

            //apply joins
            collection = collection
                        .Include(injury => injury.Injury)
                        .Include(body => body.BodyPart)
                        .Include(attach => attach.Attachments);

            return PagedList<Incidence>.Create(collection, p.PageNumber, p.PageSize);
        }

        public Incidence GetIncent(int id)
        {
            if (string.IsNullOrEmpty(id.ToString()))
            {
                throw new ArgumentNullException(nameof(id));
            }

            return _context
                    .Incidence
                    .Include(injury => injury.Injury)
                    .Include(body => body.BodyPart)
                    .Include(attach => attach.Attachments)
                    .FirstOrDefault(x => x.Id == id);
        }

        public IEnumerable<Incidence> GetIncents(IEnumerable<int> ids)
        {
            if (ids == null)
            {
                throw new ArgumentNullException(nameof(ids));
            }

            return _context
                    .Incidence
                    .Where(x => ids.Contains(x.Id))
                    .Include(injury => injury.Injury)
                    .Include(body => body.BodyPart)
                    .Include(attach => attach.Attachments)
                    .ToList();
        }

        public void AddIncident(Incidence incident)
        {
            if (incident == null)
            {
                throw new ArgumentNullException(nameof(incident));
            }

            _context.Incidence.Add(incident);
        }

        public void UpdateIncident(Incidence incident)
        {
            // no code in this implementation
        }

        public void DeleteIncident(Incidence incident)
        {
            if (incident == null)
            {
                throw new ArgumentNullException(nameof(incident));
            }

            _context.Remove(incident);
        }

        public void AddIncidentCollection(IEnumerable<Incidence> incidents)
        {
            if (incidents == null)
            {
                throw new ArgumentNullException(nameof(incidents));
            }

            _context.Incidence.AddRange(incidents);
        }

        public bool IncidentExists(int id)
        {
            if (string.IsNullOrEmpty(id.ToString()))
            {
                throw new ArgumentNullException(nameof(id));
            }

            return _context.Incidence.Any(x => x.Id == id);
        }

        public IEnumerable<Attachments> GetAttachments(int id)
        {
            if (string.IsNullOrEmpty(id.ToString()))
            {
                throw new ArgumentNullException(nameof(id));
            }

            return _context.Attachments.Where(x => x.Incidentid == id);
        }

        public Attachments GetAttachment(int id, int attachmentId)
        {
            if (string.IsNullOrEmpty(id.ToString()))
            {
                throw new ArgumentNullException(nameof(id));
            }

            if (string.IsNullOrEmpty(attachmentId.ToString()))
            {
                throw new ArgumentNullException(nameof(attachmentId));
            }

            return _context.Attachments.FirstOrDefault(x => x.Incidentid == id && x.Id == attachmentId);
        }

        public void AddAttachment(int id, Attachments attachment)
        {
            if (attachment == null)
            {
                throw new ArgumentNullException(nameof(attachment));
            }

            attachment.Incidentid = id;
            _context.Attachments.Add(attachment);
        }

        public IEnumerable<MonthlyIncidentRateDto> GetMonthlyIncidentRate(DateTime start, DateTime end)
        {

            var recordables = _context
                                .Incidence
                                .Where(x => x.AccidentDate >= start && x.AccidentDate <= end)
                                .Where(x => x.InjuryStatId.ToLower().Contains("recordable"))
                                .GroupBy(x => new { x.AccidentDate.Month, x.AccidentDate, x.InjuryStatId })
                                .Select(x => new
                                {
                                    x.Key.Month,
                                    x.Key.AccidentDate,
                                    x.Key.InjuryStatId
                                })
                                .OrderBy(x => x.Month)
                                .ToList();

            var manHours = _context
                            .ManHours
                            .Where(x => x.MosDte >= start && x.MosDte <= end)
                            .GroupBy(x => new { x.MosDte.Month })
                            .Select(x => new
                            {
                                x.Key.Month,
                                ManHOurs = x.Sum(s => s.Manhrs)
                            })
                            .ToList();

            var monthlyIncidentRates = new List<MonthlyIncidentRateDto>();

            foreach (var month in Enum.GetValues(typeof(MonthEnum)).Cast<MonthEnum>())
            {
                var monthInt = (int)month;
                var isExist = recordables.Any(x => x.Month == monthInt);

                if (isExist)
                {
                    monthlyIncidentRates.Add(new MonthlyIncidentRateDto
                    {
                        MonthNumber = monthInt,
                        Month = month.ToString(),
                        NumberOfRecordable = recordables.Where(x => x.Month == monthInt).Count(),
                        ManHours = (int)manHours.FirstOrDefault(x => x.Month == monthInt).ManHOurs,
                        IncidentRate = new SafetyFormula().CalculateIncidentRates(
                                            recordables.Where(x => x.Month == monthInt).Count(),
                                            (double)manHours.FirstOrDefault(x => x.Month == monthInt).ManHOurs)
                    });
                }
                else
                {
                    monthlyIncidentRates.Add(new MonthlyIncidentRateDto
                    {
                        MonthNumber = monthInt,
                        Month = month.ToString(),
                        NumberOfRecordable = 0,
                        ManHours = manHours.Any(x => x.Month == monthInt) ? (int)manHours.FirstOrDefault(x => x.Month == monthInt).ManHOurs : 0,
                        IncidentRate = 0
                    });
                }
            }

            return monthlyIncidentRates.OrderBy(x => x.MonthNumber);
        }

        public IncidentsByDepartmentForChartDto GetIncidedentsByDepartment(DateTime start, DateTime end)
        {
            var exclude = new List<string> { "Property Damage", "N/A", "Personal Med" };

            var data = _context
                        .Incidence
                        .Where(x => x.AccidentDate >= start && x.AccidentDate <= end)
                        .Where(x => !exclude.Contains(x.InjuryStatId))
                        .ToList();

            var depts = data.Select(x => x.Dept).Distinct();
            var distinctInjuryStat = _context.InjuryStat
                                        .Where(x => !exclude.Contains(x.InjuryStat1))
                                        .Select(x => new InjuryStatusDto { InjuryStatus = x.InjuryStat1, ColorCode = x.Color } ).ToList();

            var injuryStats = data.GroupBy(x => new { x.Dept, x.InjuryStatId })
                                .Select(x => new
                                {
                                    x.Key.Dept,
                                    x.Key.InjuryStatId,
                                    Count = x.Count()
                                })
                                .ToList();

            var injuryStatColors = _context.InjuryStat.ToList();

            var listOfIncidentsByDept = new List<IncidentsByDepartmentDto>();
            foreach (var dept in depts)
            {

                var listOfInjuryStats = new List<InjuryStatusDto>();
                foreach (var injuryStat in distinctInjuryStat)
                {
                    var isExist = injuryStats.Any(x => x.InjuryStatId == injuryStat.InjuryStatus && x.Dept == dept);

                    if (isExist)
                    {
                        var stat = injuryStats.Where(x => x.InjuryStatId == injuryStat.InjuryStatus && x.Dept == dept).FirstOrDefault();
                        listOfInjuryStats.Add(new InjuryStatusDto
                        {
                            InjuryStatus = injuryStat.InjuryStatus,
                            NumberOfIncidents = stat.Count,
                            ColorCode = injuryStatColors.Any(c => c.InjuryStat1 == injuryStat.InjuryStatus)
                                        ? injuryStatColors.Where(c => c.InjuryStat1 == injuryStat.InjuryStatus).FirstOrDefault().Color
                                        : ""
                        });
                    }
                    else
                    {
                        listOfInjuryStats.Add(new InjuryStatusDto
                        {
                            InjuryStatus = injuryStat.InjuryStatus,
                            NumberOfIncidents = 0,
                            ColorCode = injuryStatColors.Any(c => c.InjuryStat1 == injuryStat.InjuryStatus)
                                        ? injuryStatColors.Where(c => c.InjuryStat1 == injuryStat.InjuryStatus).FirstOrDefault().Color
                                        : ""
                        });
                    }
                }

                listOfIncidentsByDept.Add(new IncidentsByDepartmentDto
                {
                    Department = dept,
                    Total = !injuryStats.Any(i => i.Dept == dept) ? 0 : injuryStats.Where(i => i.Dept == dept).Sum(i => i.Count),
                    Injuries = listOfInjuryStats
                });
            }

            var result = new IncidentsByDepartmentForChartDto
            {
                Categories = depts,
                Series = distinctInjuryStat,
                Data = listOfIncidentsByDept
            };

            return result;
        }

        public bool Save()
        {
            return (_context.SaveChanges() >= 0);
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                // dispose resources when needed
            }
        }


    }
}
