using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using FmsbwebCoreApi.Entity.QualityCheckSheets;

namespace FmsbwebCoreApi.Models.QualityCheckSheets
{
    public class CheckSheetDto
    {
        [Required]
        public int ControlMethodId { get; set; }
        [Required]
        public int LineId { get; set; }
        [Required]
        public int OrganizationPartId { get; set; }
        [Required]
        public int ClockNumber { get; set; }
        public int? HourId { get; set; }
    }
}
