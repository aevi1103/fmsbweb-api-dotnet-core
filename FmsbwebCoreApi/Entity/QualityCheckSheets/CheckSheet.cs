using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using FmsbwebCoreApi.Entity.QualityCheckSheets;
using Microsoft.VisualStudio.Web.CodeGeneration.DotNet;

namespace FmsbwebCoreApi.Entity.QualityCheckSheets
{
    public class CheckSheet
    {
        public int CheckSheetId { get; set; }
        [Required]
        public int ControlMethodId { get; set; }
        public ControlMethod ControlMethod { get; set; }
        [Required]
        public int LineId { get; set; }
        public Line Line { get; set; }
        [Required]
        public int OrganizationPartId { get; set; }
        public OrganizationPart OrganizationPart { get; set; }
        [Required]
        public DateTime ShiftDate { get; set; }
        [Required]
        public string Shift { get; set; }
        [Required]

        public int ClockNumber { get; set; }
        public int? HourId { get; set; }
        [Required]
        public DateTime TimeStamp { get; set; } = DateTime.Now;

        public ICollection<CheckSheetEntry> CheckSheetEntries { get; set; }
    }
}
