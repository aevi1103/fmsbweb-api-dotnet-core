using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.SAP
{
    public partial class Scrap2
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
        [Column("UK_DateTime", TypeName = "datetime")]
        public DateTime? UkDateTime { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? LocalDateTime { get; set; }
        [Column("offsetHr")]
        public int? OffsetHr { get; set; }
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
        [Required]
        [Column("enteredUser")]
        [StringLength(50)]
        public string EnteredUser { get; set; }
        [Column("qty")]
        public int? Qty { get; set; }
        [Required]
        [Column("uom")]
        [StringLength(50)]
        public string Uom { get; set; }
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
        [Column("hour_hxh")]
        public int? HourHxh { get; set; }
        [Column("machine2")]
        [StringLength(50)]
        public string Machine2 { get; set; }
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
        [Required]
        [StringLength(14)]
        public string IsAutoGaugeScrap2 { get; set; }
        [Required]
        [StringLength(14)]
        public string Ispurchashed2 { get; set; }
        [Required]
        [StringLength(15)]
        public string IsPurchashedExclude2 { get; set; }
        public int? WeekNumber { get; set; }
        public int? Year { get; set; }

        [Column("colorCode")]
        public string ColorCode { get; set; }

        public string CellSide => (Department == "Foundry" && Side == null) ? "n/a" : Side;
    }
}
