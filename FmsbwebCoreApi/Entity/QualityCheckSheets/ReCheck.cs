using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FmsbwebCoreApi.Entity.QualityCheckSheets
{
    public class ReCheck
    {
        public int ReCheckId { get; set; }
        [Required]
        public int CheckSheetEntryId { get; set; }
        public virtual CheckSheetEntry CheckSheetEntry { get; set; }
        public decimal? Value { get; set; }
        public bool? ValueBool { get; set; }
        public string Comment { get; set; }
        [Required]
        public DateTime TimeStamp { get; set; } = DateTime.Now;
    }
}
