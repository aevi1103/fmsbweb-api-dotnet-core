using FmsbwebCoreApi.Models.Safety.Attachment;
using FmsbwebCoreApi.ValidationAttributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FmsbwebCoreApi.Models.Safety.Incident
{
    [DescriptionMustBeDifferentFromInterim(ErrorMessage = "Description must be different from Interim Action Taken.")]
    public abstract class IncidentForManipulation //: IValidatableObject
    {
        [Required]
        [StringLength(50, ErrorMessage = "The Department shoudn't have more than 50 characters.")]
        public string Dept { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "The First Name shoudn't have more than 50 characters.")]
        public string Fname { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "The Last Name shoudn't have more than 50 characters.")]
        public string Lname { get; set; }

        [Required]
        [StringLength(50)]
        public string Shift { get; set; }

        [Required]
        public DateTime AccidentDate { get; set; }

        [Required]
        public int InjuryId { get; set; }

        [Required]
        public int BodyPartId { get; set; }

        [Required]
        [StringLength(50)]
        public string Supervisor { get; set; }

        [Required]
        [StringLength(50)]
        public string InjuryStatId { get; set; }

        [Required]
        public string Description { get; set; }

        public virtual string InterimActionTaken { get; set; } //virtual allows ovverride.
        public string FinalCorrectiveAction { get; set; }
        public string ReasonSupportingOrirstat { get; set; }
        public DateTime Modifieddate { get; set; } = DateTime.Now;
        public bool? IsClosed { get; set; } = false;
        public bool? IsFmTipsCompleted { get; set; } = false;

        [StringLength(5000)]
        public string FmTipsNumber { get; set; }
        public bool DeletedFlag { get; set; } = false;
        public string DeletedFlagComment { get; set; }

        public ICollection<AttachmentForCreationDto> Attachments { get; set; } = new List<AttachmentForCreationDto>();

        //public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        //{
        //    if (Description == InterimActionTaken) //create a custom validation
        //    {
        //        yield return new ValidationResult(
        //                "The description should be different from interim action taken",
        //                new[] { "IncidentForCreationDto" }
        //            );
        //    }
        //}
    }
}
