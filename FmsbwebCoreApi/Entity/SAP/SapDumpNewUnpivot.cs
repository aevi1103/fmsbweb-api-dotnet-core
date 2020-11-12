using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.SAP
{
    public partial class SapDumpNewUnpivot
    {
        public long Id { get; set; }
        [StringLength(50)]
        public string Material { get; set; }
        [StringLength(100)]
        public string Program { get; set; }
        [Column("Valuation Class")]
        [StringLength(100)]
        public string ValuationClass { get; set; }
        [Column("date", TypeName = "datetime")]
        public DateTime? Date { get; set; }
        [StringLength(128)]
        public string Location { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? Qty { get; set; }
        [Column("Safety Stock", TypeName = "decimal(18, 2)")]
        public decimal? SafetyStock { get; set; }
        [Column("Standard price", TypeName = "decimal(18, 2)")]
        public decimal? StandardPrice { get; set; }
        [Column("per")]
        public int? Per { get; set; }
        [StringLength(3)]
        public string Type { get; set; }
        [Column(TypeName = "decimal(29, 13)")]
        public decimal? StandardPricePerPc { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? PricePerQty { get; set; }
        [Column("slocOrder")]
        public int SlocOrder { get; set; }
    }
}
