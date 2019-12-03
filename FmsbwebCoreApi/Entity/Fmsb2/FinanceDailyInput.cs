using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Fmsb2
{
    [Table("Finance_DailyInput")]
    public partial class FinanceDailyInput
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("date", TypeName = "datetime")]
        public DateTime Date { get; set; }
        [Column("pistonScrapDollars_mtd", TypeName = "decimal(18, 5)")]
        public decimal PistonScrapDollarsMtd { get; set; }
        [Column("pisonScrapDollars_dailyAvg", TypeName = "decimal(18, 5)")]
        public decimal PisonScrapDollarsDailyAvg { get; set; }
        [Column("mroDollars_mtd", TypeName = "decimal(18, 5)")]
        public decimal MroDollarsMtd { get; set; }
        [Column("mroDollars_dailyAvg", TypeName = "decimal(18, 5)")]
        public decimal MroDollarsDailyAvg { get; set; }
        [Column("foundry_units_mtd")]
        public int FoundryUnitsMtd { get; set; }
        [Column("mach_units_mtd")]
        public int MachUnitsMtd { get; set; }
        [Column("assy_units_mtd")]
        public int AssyUnitsMtd { get; set; }
        [Column("DL_hoursWorked_mtd", TypeName = "decimal(18, 5)")]
        public decimal? DlHoursWorkedMtd { get; set; }
        [Column("DL_hoursEarned_mtd", TypeName = "decimal(18, 5)")]
        public decimal? DlHoursEarnedMtd { get; set; }
        [Column("comments")]
        public string Comments { get; set; }
        [Column("stamp", TypeName = "datetime")]
        public DateTime Stamp { get; set; }
    }
}
