using FmsbwebCoreApi.Entity.Safety;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FmsbwebCoreApi.Models.Safety
{
    public class IncidentDto
    {
        public int Id { get; set; }
        public string Dept { get; set; }
        public string Name { get; set; }
        public string Shift { get; set; }
        public DateTime IncidentDate { get; set; }
        public string Injury { get; set; }
        public string BodyPart { get; set; }
        public string Supervisor { get; set; }
        public string InjuryStatus { get; set; }
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
        public int NumberOfAttachments { get; set; }
    }
}
