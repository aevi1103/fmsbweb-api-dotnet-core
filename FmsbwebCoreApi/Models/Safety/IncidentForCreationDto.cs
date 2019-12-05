using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FmsbwebCoreApi.Models.Safety
{
    public class IncidentForCreationDto
    {
        public string Dept { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }
        public string Shift { get; set; }
        public DateTime AccidentDate { get; set; }
        public int InjuryId { get; set; }
        public int BodyPartId { get; set; }
        public string Supervisor { get; set; }
        public string InjuryStatId { get; set; }
        public string Description { get; set; }
        public string InterimActionTaken { get; set; }
        public string FinalCorrectiveAction { get; set; }
        public string ReasonSupportingOrirstat { get; set; }
        public DateTime Modifieddate { get; set; }
        public bool? IsClosed { get; set; }
        public bool? IsFmTipsCompleted { get; set; }
        public string FmTipsNumber { get; set; }
        public bool DeletedFlag { get; set; }
        public string DeletedFlagComment { get; set; }

        public ICollection<AttachmentForCreationDto> Attachments { get; set; } = new List<AttachmentForCreationDto>();
    }
}
