using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FmsbwebCoreApi.Context.Safety;
using FmsbwebCoreApi.Entity.Safety;
using FmsbwebCoreApi.ResourceParameters.Safety;
using Microsoft.EntityFrameworkCore;

using NinjaNye.SearchExtensions;

namespace FmsbwebCoreApi.Services.Safety
{
    public class SafetyLibraryRepository : ISafetyLibraryRepository, IDisposable
    {
        private readonly SafetyContext _context;

        public SafetyLibraryRepository(SafetyContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
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

        public IEnumerable<Incidence> GetIncents(IncidentsResourceParameter incidentsResourceParameter)
        {
            if (incidentsResourceParameter == null)
            {
                throw new ArgumentNullException(nameof(incidentsResourceParameter));
            }

            var dept = incidentsResourceParameter.Dept;
            var searchQuery = incidentsResourceParameter.SearchQuery;

            if (string.IsNullOrWhiteSpace(dept) && string.IsNullOrWhiteSpace(searchQuery))
            {
                return GetIncents();
            }

            var collection = _context.Incidence as IQueryable<Incidence>;

            if (!string.IsNullOrWhiteSpace(dept))
            {
                dept = dept.Trim();
                collection = collection.Where(x => x.Dept.Trim() == dept.Trim());
            };

            if(!string.IsNullOrWhiteSpace(searchQuery))
            {
                searchQuery = searchQuery.Trim();
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
                                ).Containing(searchQuery);
            };

            return collection
                    .Include(injury => injury.Injury)
                    .Include(body => body.BodyPart)
                    .Include(attach => attach.Attachments)
                    .OrderBy(x => x.AccidentDate)
                    .ToList();

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
