using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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
        [Column("Value", TypeName = "decimal(18, 5)")]
        public decimal? Value { get; set; }
        public bool? ValueBool { get; set; }
        public string Comment { get; set; }
        [Required]
        public bool IsInitialValue { get; set; } = false;
        [Required]
        public DateTime TimeStamp { get; set; } = DateTime.Now;
    }
}
