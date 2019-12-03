using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.SAP
{
    [Table("Scrap_temp")]
    public partial class ScrapTemp
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Required]
        [Column("workCenter")]
        [StringLength(100)]
        public string WorkCenter { get; set; }
        [Column("prodOrderNumber")]
        public long ProdOrderNumber { get; set; }
        [Column("eteredDate", TypeName = "datetime")]
        public DateTime EteredDate { get; set; }
        [Required]
        [Column("enteredTime")]
        [StringLength(50)]
        public string EnteredTime { get; set; }
        [Required]
        [Column("materialNumber")]
        [StringLength(100)]
        public string MaterialNumber { get; set; }
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
        [Column("scrapGroup")]
        [StringLength(100)]
        public string ScrapGroup { get; set; }
        [Column("UK_DateTime", TypeName = "datetime")]
        public DateTime? UkDateTime { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? LocalDateTime { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ShiftDate { get; set; }
        [StringLength(5)]
        public string Shift { get; set; }
        [Column("hour_hxh")]
        public int? HourHxh { get; set; }
        [Column("shiftDate_8", TypeName = "datetime")]
        public DateTime? ShiftDate8 { get; set; }
        [Column("shift_8")]
        public int? Shift8 { get; set; }
        [Column("isFiveDayShift")]
        public bool? IsFiveDayShift { get; set; }
        [Column("operationNumber")]
        [StringLength(10)]
        public string OperationNumber { get; set; }
        [Column("inputMaterialNumber")]
        [StringLength(50)]
        public string InputMaterialNumber { get; set; }
        [Column("operationNumberLoc")]
        [StringLength(10)]
        public string OperationNumberLoc { get; set; }
        public bool? IsAutoGaugeScrap { get; set; }
        public bool? IsPurchashed { get; set; }
        public bool? IsPurchashedExclude { get; set; }
        [StringLength(200)]
        public string ExportFileName { get; set; }
    }
}
