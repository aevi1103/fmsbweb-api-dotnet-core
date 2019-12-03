using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.SAP
{
    public partial class Scrap2Summary
    {
        [Column("id")]
        public Guid? Id { get; set; }
        [Required]
        [Column("workCenter")]
        [StringLength(100)]
        public string WorkCenter { get; set; }
        [Required]
        [Column("machine_hxh")]
        [StringLength(100)]
        public string MachineHxh { get; set; }
        [Column("side")]
        [StringLength(50)]
        public string Side { get; set; }
        [Required]
        [StringLength(50)]
        public string Department { get; set; }
        [Required]
        [StringLength(50)]
        public string Area { get; set; }
        [Column("prodOrderNumber")]
        public long ProdOrderNumber { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ShiftDate { get; set; }
        [StringLength(5)]
        public string Shift { get; set; }
        [Required]
        [Column("materialNumber")]
        [StringLength(100)]
        public string MaterialNumber { get; set; }
        [Column("FMPart")]
        [StringLength(8)]
        public string Fmpart { get; set; }
        [Column("scrapAreaCode")]
        [StringLength(1)]
        public string ScrapAreaCode { get; set; }
        [Column("scrapAreaName")]
        [StringLength(50)]
        public string ScrapAreaName { get; set; }
        [Required]
        [Column("scrapCode")]
        [StringLength(100)]
        public string ScrapCode { get; set; }
        [Required]
        [Column("scrapDesc")]
        [StringLength(100)]
        public string ScrapDesc { get; set; }
        [Column("program")]
        [StringLength(100)]
        public string Program { get; set; }
        [Column("qty")]
        public int? Qty { get; set; }
    }
}
