using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FmsbwebCoreApi.Entity.SAP
{
    [Table("SAP_Dump_With_SafetyStock")]
    public class SapDumpWithSafetyStock
    {
        [StringLength(50)]
        public string Material { get; set; }
        [Column("Total Unrest. Inv.", TypeName = "decimal(18, 2)")]
        public decimal? TotalUnrestInv { get; set; }
        [Column("0111", TypeName = "decimal(18, 2)")]
        public decimal? _0111 { get; set; }
        [Column("0115", TypeName = "decimal(18, 2)")]
        public decimal? _0115 { get; set; }
        [Column("4001", TypeName = "decimal(18, 2)")]
        public decimal? _4001 { get; set; }
        [Column("4002", TypeName = "decimal(18, 2)")]
        public decimal? _4002 { get; set; }
        [Column("4003", TypeName = "decimal(18, 2)")]
        public decimal? _4003 { get; set; }
        [Column("4004", TypeName = "decimal(18, 2)")]
        public decimal? _4004 { get; set; }
        [Column("4005", TypeName = "decimal(18, 2)")]
        public decimal? _4005 { get; set; }
        [Column("4006", TypeName = "decimal(18, 2)")]
        public decimal? _4006 { get; set; }
        [Column("4007", TypeName = "decimal(18, 2)")]
        public decimal? _4007 { get; set; }
        [Column("4008", TypeName = "decimal(18, 2)")]
        public decimal? _4008 { get; set; }
        [Column("4009", TypeName = "decimal(18, 2)")]
        public decimal? _4009 { get; set; }
        [Column("4010", TypeName = "decimal(18, 2)")]
        public decimal? _4010 { get; set; }
        [Column("5001", TypeName = "decimal(18, 2)")]
        public decimal? _5001 { get; set; }
        [Column("5002", TypeName = "decimal(18, 2)")]
        public decimal? _5002 { get; set; }
        [Column("5003", TypeName = "decimal(18, 2)")]
        public decimal? _5003 { get; set; }
        [Column("5004", TypeName = "decimal(18, 2)")]
        public decimal? _5004 { get; set; }
        [Column("5005", TypeName = "decimal(18, 2)")]
        public decimal? _5005 { get; set; }
        [Column("5006", TypeName = "decimal(18, 2)")]
        public decimal? _5006 { get; set; }
        [Column("5007", TypeName = "decimal(18, 2)")]
        public decimal? _5007 { get; set; }
        [Column("5008", TypeName = "decimal(18, 2)")]
        public decimal? _5008 { get; set; }
        [Column("5009", TypeName = "decimal(18, 2)")]
        public decimal? _5009 { get; set; }
        [Column("5010", TypeName = "decimal(18, 2)")]
        public decimal? _5010 { get; set; }
        [Column("QC01", TypeName = "decimal(18, 2)")]
        public decimal? Qc01 { get; set; }
        [Column("QC02", TypeName = "decimal(18, 2)")]
        public decimal? Qc02 { get; set; }

        [Column("QC03", TypeName = "decimal(18, 2)")]
        public decimal? Qc03 { get; set; }
        [Column("QC04", TypeName = "decimal(18, 2)")]
        public decimal? Qc04 { get; set; }
        [Column("QC05", TypeName = "decimal(18, 2)")]
        public decimal? Qc05 { get; set; }

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
        [Column("0140", TypeName = "decimal(18, 2)")]
        public decimal? _0140 { get; set; }
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

        [Column("Safety Stock", TypeName = "decimal(18, 2)")]
        public decimal? SafetyStock { get; set; }

        [Column("uploadDateTime", TypeName = "datetime")]
        public DateTime? UploadDateTime { get; set; }
        [Column("date", TypeName = "datetime")]
        public DateTime? Date { get; set; }
        [Key]
        [Column("id")]
        public int id { get; set; }
    }
}
