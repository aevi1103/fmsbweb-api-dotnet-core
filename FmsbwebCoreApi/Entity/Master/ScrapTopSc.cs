using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Master
{
    public partial class ScrapTopSc
    {
        [Column(TypeName = "datetime")]
        public DateTime Date { get; set; }
        [Required]
        [StringLength(1)]
        public string Shift { get; set; }
        [Required]
        [StringLength(2)]
        public string Machine { get; set; }
        public int? Foundry { get; set; }
        public int? Mach { get; set; }
        public int? Anod { get; set; }
        [Column("washerLoad")]
        public int? WasherLoad { get; set; }
        [Column("washerUnload")]
        public int? WasherUnload { get; set; }
        public int? Accumulator { get; set; }
        public int? Pretreat { get; set; }
        [Column("SChandling")]
        public int? Schandling { get; set; }
        public int? Debris { get; set; }
        public int? Voids { get; set; }
        public int? Blisters { get; set; }
        public int? RunSags { get; set; }
        public int? ScratchesCoating { get; set; }
        public int? CoatingNonSpec { get; set; }
        public int? OffLoc { get; set; }
        public int? OvenHandling { get; set; }
        public int? ThinCoating { get; set; }
        public int? ThickCoating { get; set; }
        public int? OpHandling { get; set; }
    }
}
