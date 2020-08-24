using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using FmsbwebCoreApi.Controllers.QualityCheckSheets;

namespace FmsbwebCoreApi.Entity.QualityCheckSheets
{
    public class CheckSheetEntry
    {
        public int CheckSheetEntryId { get; set; }
        [Required]
        public int CheckSheetId { get; set; }
        public virtual CheckSheet CheckSheet { get; set; }
        [Required]
        public int SubMachineId { get; set; }
        public virtual SubMachine SubMachine { get; set; }
        [Required]
        public int CharacteristicId { get; set; }
        public virtual Characteristic Characteristic { get; set; }
        [Required]
        public string Part { get; set; }
        [Required]
        public int Frequency { get; set; }
        public decimal? Value { get; set; }
        public bool? ValueBool { get; set; }
        public string Comment { get; set; }
        [Required]
        public DateTime TimeStamp { get; set; } = DateTime.Now;


    }
}
