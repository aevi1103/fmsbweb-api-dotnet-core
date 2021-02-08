using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using FmsbwebCoreApi.Enums;

namespace FmsbwebCoreApi.Entity.Fmsb2
{
    public class ProjectTracker
    {
        public int ProjectTrackerId { get; set; }

        [ForeignKey("CreateHxH")]
        public int HourByHourId { get; set; }
        public virtual CreateHxH CreateHxH { get; set; }

        [Required]
        public DateTime DateTimeRequested { get; set; } = DateTime.Now;

        [Required]
        public string ProjectName { get; set; }

        [Required]
        public string ProjectDescription { get; set; }

        public ProjectStatusEnum Status { get; set; } = ProjectStatusEnum.New;

        public DateTime? StartDate { get; set; }
        public DateTime? CompletionDate { get; set; }
        public string Comments { get; set; }
        public DateTime ModifiedDate { get; set; } = DateTime.Now;
    }
}
