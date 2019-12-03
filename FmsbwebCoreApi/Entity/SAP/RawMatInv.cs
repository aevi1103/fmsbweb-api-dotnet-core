using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.SAP
{
    public partial class RawMatInv
    {
        [Column("first")]
        [StringLength(1)]
        public string First { get; set; }
        [Column("type_sap")]
        [StringLength(3)]
        public string TypeSap { get; set; }
        [Column("Total Unrest. Inv. $$", TypeName = "decimal(38, 6)")]
        public decimal? TotalUnrestInv { get; set; }
        [StringLength(50)]
        public string Material { get; set; }
        [Column("Total Unrest. Inv.", TypeName = "decimal(18, 2)")]
        public decimal? TotalUnrestInv1 { get; set; }
        [Column("0111", TypeName = "decimal(18, 2)")]
        public decimal? _0111 { get; set; }
        [Column("0115", TypeName = "decimal(18, 2)")]
        public decimal? _0115 { get; set; }
        [Column("4000", TypeName = "decimal(18, 2)")]
        public decimal? _4000 { get; set; }
        [Column("5000", TypeName = "decimal(18, 2)")]
        public decimal? _5000 { get; set; }
        [Column("QC01", TypeName = "decimal(18, 2)")]
        public decimal? Qc01 { get; set; }
        [Column("QC02", TypeName = "decimal(18, 2)")]
        public decimal? Qc02 { get; set; }
        [Column("0130", TypeName = "decimal(18, 2)")]
        public decimal? _0130 { get; set; }
        [Column("0131", TypeName = "decimal(18, 2)")]
        public decimal? _0131 { get; set; }
        [Column("0135", TypeName = "decimal(18, 2)")]
        public decimal? _0135 { get; set; }
        [Column("0160", TypeName = "decimal(18, 2)")]
        public decimal? _0160 { get; set; }
        [Column("0300", TypeName = "decimal(18, 2)")]
        public decimal? _0300 { get; set; }
        [Column("0125", TypeName = "decimal(18, 2)")]
        public decimal? _0125 { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? NotIn0300 { get; set; }
        [Column("Standard price", TypeName = "decimal(18, 2)")]
        public decimal? StandardPrice { get; set; }
        [Column("per")]
        public int? Per { get; set; }
        [Column("Valuation Class")]
        [StringLength(100)]
        public string ValuationClass { get; set; }
        [Column("Material Description")]
        [StringLength(100)]
        public string MaterialDescription { get; set; }
        [StringLength(100)]
        public string Program { get; set; }
        [Column("uploadDateTime", TypeName = "datetime")]
        public DateTime? UploadDateTime { get; set; }
        [Column("date", TypeName = "datetime")]
        public DateTime? Date { get; set; }
        [Column("id")]
        public int Id { get; set; }
        [Column("0300 Fin gds SB $$", TypeName = "decimal(38, 6)")]
        public decimal? _0300FinGdsSb { get; set; }
        [Column(TypeName = "decimal(19, 2)")]
        public decimal? InventoryNotIn0300 { get; set; }
        [Column("InventoryNotIn0300_$$", TypeName = "decimal(38, 6)")]
        public decimal? InventoryNotIn03001 { get; set; }
    }
}
