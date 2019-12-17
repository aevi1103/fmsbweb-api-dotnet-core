using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Master
{
    [Table("tblMaxProdFactors")]
    public partial class TblMaxProdFactors
    {
        [Key]
        public byte Line { get; set; }
        public short? SecondsPerCycle { get; set; }
        public short? HoursPerShift { get; set; }
        public short? ShiftsPerWeek { get; set; }
    }
}
