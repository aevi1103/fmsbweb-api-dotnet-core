using System;
using System.ComponentModel.DataAnnotations;

namespace FmsbwebCoreApi.Models
{
    public class SafetyIncidenceDto
    {
        public int Id { get; set; }

        [Required]
        public string Dept { get; set; }

        [Required]
        public string Fname { get; set; }

        [Required]
        public string Lname { get; set; }

        [Required]
        public string Shift { get; set; }

        [Required]
        public DateTime AccidentDate { get; set; }

        [Required]
        public int InjuryId { get; set; }

        [Required]
        public int BodyPartId { get; set; }

        public string Supervisor { get; set; }

        [Required]
        public string InjuryStatId { get; set; }

        [Required]
        public string Description { get; set; }

        public string InterimActionTaken { get; set; }

        public string FinalCorrectiveAction { get; set; }

        public string ReasonSupportingOrirstat { get; set; }

        [Required]
        public DateTime Modifieddate { get; set; } = DateTime.Now;

        public bool? IsClosed { get; set; }

        public bool? IsFmTipsCompleted { get; set; }

        public string FmTipsNumber { get; set; }

        public bool DeletedFlag { get; set; }

        public string DeletedFlagComment { get; set; }

        public bool? Mitigated { get; set; }

        public DateTime? MitigatedTimeStamp { get; set; }

        public string Notes { get; set; }

        public double DaysBeforeMitigation
        {
            get
            {
                var daysBeforeMitigation = MitigatedTimeStamp?.Date.Subtract(AccidentDate.Date).TotalDays ?? 0d;
                return daysBeforeMitigation;
            }
        }

        public bool IsNotMitigatedOver14Days
        {
            get
            {
                if (Mitigated ?? false) return false;
                var elapsedDays = DateTime.Today.Date.Subtract(AccidentDate.Date).TotalDays;
                const int maxDaysOpenForMitigation = 14;
                return elapsedDays > maxDaysOpenForMitigation;
            }
        }
    }
}
