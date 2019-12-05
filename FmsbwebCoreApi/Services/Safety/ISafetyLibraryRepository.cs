using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using FmsbwebCoreApi.Entity.Safety;
using FmsbwebCoreApi.ResourceParameters.Safety;

namespace FmsbwebCoreApi.Services.Safety
{
    public interface ISafetyLibraryRepository
    {
        IEnumerable<Incidence> GetIncents();
        IEnumerable<Incidence> GetIncents(IncidentsResourceParameter incidentsResourceParameter);
        Incidence GetIncent(int id);
        IEnumerable<Incidence> GetIncents(IEnumerable<int> ids);
        void AddIncident(Incidence incident);
        void AddIncidentCollection(IEnumerable<Incidence> incidents);
        bool IncidentExists(int id);
        IEnumerable<Attachments> GetAttachments(int id);
        Attachments GetAttachment(int id, int attachmentId);
        void AddAttachment(int id, Attachments attachment);
        bool Save();
    }
}
