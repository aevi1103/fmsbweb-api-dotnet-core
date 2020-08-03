using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FmsbwebCoreApi.Entity.QualityCheckSheets
{
    public class Characteristic
    {
        public int CharacteristicId { get; set; }

        public int ControlMethodId { get; set; }
        public ControlMethod ControlMethod { get; set; }

        public int MachineId { get; set; }
        public virtual Machine Machine { get; set; }

        public int OrganizationPartId { get; set; }
        public virtual OrganizationPart OrganizationPart { get; set; }

        [Required]
        public string ReferenceNo { get; set; }
        [Required]
        public string Value { get; set; }
        [Required]
        public string Gauge { get; set; }
        [Required]
        public int Frequency { get; set; }
        public decimal? Min { get; set; }
        public decimal? Nom { get; set; }
        public decimal? Max { get; set; }
        public bool? PassFail { get; set; }

        [Required]
        public int DisplayAsId { get; set; }
        public virtual DisplayAs DisplayAs { get; set; }

        public string HelperText { get; set; }

        [Required]
        public DateTime TimeStamp { get; set; } = DateTime.Now;
    }
}
