using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.VisualStudio.Web.CodeGeneration.DotNet;

namespace FmsbwebCoreApi.Entity.QualityCheckSheets
{
    public class Characteristic
    {
        public int CharacteristicId { get; set; }
        [Required]
        public int OrganizationPartId { get; set; }
        public OrganizationPart OrganizationPart { get; set; }
        [Required]
        public int DisplayAsId { get; set; }
        public DisplayAs DisplayAs { get; set; }
        [Required]
        public string ReferenceNo { get; set; }
        [Required]
        public string Value { get; set; }
        [Required]
        public string Gauge { get; set; }
        [Required]
        public string MachineName { get; set; }
        [Required]
        public int Frequency { get; set; }
        public decimal? Min { get; set; }
        public decimal? Nom { get; set; }
        public decimal? Max { get; set; }
        public bool? PassFail { get; set; }
        public string HelperText { get; set; }
        [Required]
        public DateTime TimeStamp { get; set; } = DateTime.Now;

        public ICollection<CheckSheetEntry> CheckSheetEntries { get; set; } = new List<CheckSheetEntry>();
    }
}
