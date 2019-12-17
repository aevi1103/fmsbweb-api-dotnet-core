using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Master
{
    public partial class FoundryDieShotCounts
    {
        [StringLength(6)]
        public string PartNr { get; set; }
        [StringLength(6)]
        public string DieNr { get; set; }
        [StringLength(6)]
        public string DieNum { get; set; }
        [Column("CastTOTAL")]
        public int? CastTotal { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? LastCastDate { get; set; }
    }
}
