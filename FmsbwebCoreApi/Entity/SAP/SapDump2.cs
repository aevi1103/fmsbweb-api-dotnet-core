using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.SAP
{
    [Table("SAP_Dump2")]
    public partial class SapDump2
    {
        [Required]
        [StringLength(100)]
        public string Material { get; set; }
        [Column("Total Unrest. Inv.", TypeName = "decimal(18, 2)")]
        public decimal? TotalUnrestInv { get; set; }
        [Column("0100 Raw Pistons (P7's)", TypeName = "decimal(18, 2)")]
        public decimal? _0100RawPistonsP7S { get; set; }
        [Column("0105 Assy Components", TypeName = "decimal(18, 2)")]
        public decimal? _0105AssyComponents { get; set; }
        [Column("0108  Proto compts", TypeName = "decimal(18, 2)")]
        public decimal? _0108ProtoCompts { get; set; }
        [Column("0109 SB Tr components", TypeName = "decimal(18, 2)")]
        public decimal? _0109SbTrComponents { get; set; }
        [Column("01150120", TypeName = "decimal(18, 2)")]
        public decimal? _01150120 { get; set; }
        [Column("0125 Mach lineside", TypeName = "decimal(18, 2)")]
        public decimal? _0125MachLineside { get; set; }
        [Column("0128 Proto line side", TypeName = "decimal(18, 2)")]
        public decimal? _0128ProtoLineSide { get; set; }
        [Column("0130 machined pistons (P3M)", TypeName = "decimal(18, 2)")]
        public decimal? _0130MachinedPistonsP3m { get; set; }
        [Column("0135 completed not in shipping", TypeName = "decimal(18, 2)")]
        public decimal? _0135CompletedNotInShipping { get; set; }
        [Column("0136 A & F overflow", TypeName = "decimal(18, 2)")]
        public decimal? _0136AFOverflow { get; set; }
        [Column("0137 MB pistons P2F", TypeName = "decimal(18, 2)")]
        public decimal? _0137MbPistonsP2f { get; set; }
        [Column("0140 Components assy", TypeName = "decimal(18, 2)")]
        public decimal? _0140ComponentsAssy { get; set; }
        [Column("0149 SB tr components assy", TypeName = "decimal(18, 2)")]
        public decimal? _0149SbTrComponentsAssy { get; set; }
        [Column("0160 QC Bus stop", TypeName = "decimal(18, 2)")]
        public decimal? _0160QcBusStop { get; set; }
        [Column("0161 QC Suspect Hold", TypeName = "decimal(18, 2)")]
        public decimal? _0161QcSuspectHold { get; set; }
        [Column("0162 QC PPAP Hold", TypeName = "decimal(18, 2)")]
        public decimal? _0162QcPpapHold { get; set; }
        [Column("0163 GP12", TypeName = "decimal(18, 2)")]
        public decimal? _0163Gp12 { get; set; }
        [Column("0164 MB Hold area", TypeName = "decimal(18, 2)")]
        public decimal? _0164MbHoldArea { get; set; }
        [Column("0165 scrap", TypeName = "decimal(18, 2)")]
        public decimal? _0165Scrap { get; set; }
        [Column("0169 SB Tr Hold", TypeName = "decimal(18, 2)")]
        public decimal? _0169SbTrHold { get; set; }
        [Column("0300 Fin gds SB", TypeName = "decimal(18, 2)")]
        public decimal? _0300FinGdsSb { get; set; }
        [Column("0303 FG MB", TypeName = "decimal(18, 2)")]
        public decimal? _0303FgMb { get; set; }
        [Column("0305 Hodge FG", TypeName = "decimal(18, 2)")]
        public decimal? _0305HodgeFg { get; set; }
        [Column("0309 FG SB Tr", TypeName = "decimal(18, 2)")]
        public decimal? _0309FgSbTr { get; set; }
        [Column("0400 In transit", TypeName = "decimal(18, 2)")]
        public decimal? _0400InTransit { get; set; }
        [Column("0403 MB WIP", TypeName = "decimal(18, 2)")]
        public decimal? _0403MbWip { get; set; }
        [Column("Unrst. SLOC 7000", TypeName = "decimal(18, 2)")]
        public decimal? UnrstSloc7000 { get; set; }
        [Column("Standard price", TypeName = "decimal(18, 2)")]
        public decimal? StandardPrice { get; set; }
        [Column("per")]
        public int? Per { get; set; }
        [Column("Valuation Class")]
        [StringLength(100)]
        public string ValuationClass { get; set; }
        [Column("Material Description")]
        public string MaterialDescription { get; set; }
        [Column("uploadDateTime", TypeName = "datetime")]
        public DateTime UploadDateTime { get; set; }
        [Column("date", TypeName = "datetime")]
        public DateTime Date { get; set; }
        [Key]
        [Column("id")]
        public int Id { get; set; }
    }
}
