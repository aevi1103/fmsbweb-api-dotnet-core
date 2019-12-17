using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Master
{
    public partial class ViewAssyRejects
    {
        [Column("ID")]
        public int Id { get; set; }
        [Column("date", TypeName = "datetime")]
        public DateTime Date { get; set; }
        [Required]
        [Column("shift")]
        [StringLength(50)]
        public string Shift { get; set; }
        [Required]
        [Column("mach")]
        [StringLength(50)]
        public string Mach { get; set; }
        [Required]
        [Column("part")]
        [StringLength(50)]
        public string Part { get; set; }
        [Required]
        [Column("ops")]
        [StringLength(50)]
        public string Ops { get; set; }
        [Required]
        [StringLength(200)]
        public string Component { get; set; }
        public int RejectQty { get; set; }
        public string Commnents { get; set; }
        public bool? Reviewed { get; set; }
        [Column("modifieddate", TypeName = "datetime")]
        public DateTime Modifieddate { get; set; }
        [StringLength(14)]
        public string Program { get; set; }
        public int? WkNum { get; set; }
        public int? AssyGross { get; set; }
        public int? CountP { get; set; }
        [Column("AssyGrossDivide_Countp", TypeName = "decimal(38, 20)")]
        public decimal? AssyGrossDivideCountp { get; set; }
        [Column(TypeName = "decimal(18, 5)")]
        public decimal? RejectP { get; set; }
    }
}
