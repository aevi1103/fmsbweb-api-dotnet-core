using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Master
{
    public partial class ScrapTopAnod
    {
        [Column(TypeName = "datetime")]
        public DateTime Date { get; set; }
        [Required]
        [StringLength(1)]
        public string Shift { get; set; }
        [Column("fs")]
        public int? Fs { get; set; }
        [Column("ms")]
        public int? Ms { get; set; }
        public int? GantryError { get; set; }
        public int? BadMask { get; set; }
        public int? WasherLoad { get; set; }
        public int? OpsHandling { get; set; }
        public int? BadSeal { get; set; }
        public int? AnodizeOnCrown { get; set; }
        public int? LightAnodize { get; set; }
        public int? OffLocation { get; set; }
        public int? TailBurn { get; set; }
        public int? PartialAnodize { get; set; }
        [Column("Puebla_Defect")]
        public int? PueblaDefect { get; set; }
    }
}
