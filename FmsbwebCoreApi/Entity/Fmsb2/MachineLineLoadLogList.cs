using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Fmsb2
{
    public partial class MachineLineLoadLogList
    {
        [Column("id")]
        public int Id { get; set; }
        public int MachineLoadId { get; set; }
        [Required]
        [StringLength(50)]
        public string Barcode { get; set; }
        [Column(TypeName = "date")]
        public DateTime? DateHeatTreat { get; set; }
        [StringLength(15)]
        public string SapPart { get; set; }
        [StringLength(2)]
        public string Cell { get; set; }
        [Column("die")]
        [StringLength(4000)]
        public string Die { get; set; }
        [Column("basketStartQty")]
        [StringLength(5)]
        public string BasketStartQty { get; set; }
        [Required]
        [Column("machineName")]
        [StringLength(50)]
        public string MachineName { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime MachShiftDate { get; set; }
        [Required]
        [StringLength(50)]
        public string MachShift { get; set; }
        [Required]
        [Column("partMach")]
        public string PartMach { get; set; }
        [Column("clockNumber")]
        public int ClockNumber { get; set; }
        [Column("dateTimeLoaded", TypeName = "datetime")]
        public DateTime DateTimeLoaded { get; set; }
        [Column("clorindo")]
        public int? Clorindo { get; set; }
        [Column("gsa")]
        public int? Gsa { get; set; }
        [Column("total_bol_scrap")]
        public int? TotalBolScrap { get; set; }
    }
}
