using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.SAP
{
    public partial class SapScrapView
    {
        [Column("id")]
        public int Id { get; set; }
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
        [Column("uk_date", TypeName = "datetime")]
        public DateTime UkDate { get; set; }
        [Required]
        [Column("uk_time")]
        [StringLength(50)]
        public string UkTime { get; set; }
        [Column("uk_DateTime_UTC_1", TypeName = "datetime")]
        public DateTime? UkDateTimeUtc1 { get; set; }
        [Column("EDT_offset", TypeName = "datetimeoffset(3)")]
        public DateTimeOffset? EdtOffset { get; set; }
        [Column("EST_offset", TypeName = "datetimeoffset(3)")]
        public DateTimeOffset? EstOffset { get; set; }
        [Column("EDT", TypeName = "datetime")]
        public DateTime? Edt { get; set; }
        [Column("EST", TypeName = "datetime")]
        public DateTime? Est { get; set; }
        [Column("offset_edt")]
        public int? OffsetEdt { get; set; }
        [Column("offset_est")]
        public int? OffsetEst { get; set; }
        [Required]
        [Column("materialNumber")]
        [StringLength(100)]
        public string MaterialNumber { get; set; }
        [Column("FMPart")]
        [StringLength(8)]
        public string Fmpart { get; set; }
        [Required]
        [Column("enteredUser")]
        [StringLength(50)]
        public string EnteredUser { get; set; }
        [Column("qty", TypeName = "decimal(18, 2)")]
        public decimal Qty { get; set; }
        [Required]
        [Column("uom")]
        [StringLength(50)]
        public string Uom { get; set; }
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
    }
}
