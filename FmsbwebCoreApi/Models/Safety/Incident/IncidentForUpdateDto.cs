using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FmsbwebCoreApi.Models.Safety.Incident
{
    public class IncidentForUpdateDto : IncidentForManipulation
    {
        [Required]
        public override string InterimActionTaken { get => base.InterimActionTaken; set => base.InterimActionTaken = value; }
    }
}
