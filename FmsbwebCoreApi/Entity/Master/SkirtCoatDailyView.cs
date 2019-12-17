using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Master
{
    public partial class SkirtCoatDailyView
    {
        [Column("SkirtCoatID")]
        public int SkirtCoatId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime Date { get; set; }
        [Required]
        [StringLength(1)]
        public string Shift { get; set; }
        [Required]
        [StringLength(2)]
        public string Machine { get; set; }
        [Required]
        [Column("PartID")]
        [StringLength(6)]
        public string PartId { get; set; }
        [StringLength(2)]
        public string Grade { get; set; }
        [StringLength(5)]
        public string EnteredBy { get; set; }
        public int? Runtime { get; set; }
        public int? Gross { get; set; }
        [Column("TotalFS")]
        public int? TotalFs { get; set; }
        [Column("TotalMS")]
        public int? TotalMs { get; set; }
        public int? TotalAnod { get; set; }
        [Column("TotalSC_Scrap")]
        public int? TotalScScrap { get; set; }
        [Column("FS_SC")]
        public int FsSc { get; set; }
        [Column("MS_SC")]
        public int MsSc { get; set; }
        [Column("Anod_SC")]
        public short AnodSc { get; set; }
        [Column("WasherLoad_SC")]
        public int WasherLoadSc { get; set; }
        [Column("washerUnload")]
        public short WasherUnload { get; set; }
        [Column("accumulator_SC")]
        public short AccumulatorSc { get; set; }
        [Column("Pretreatment_SC")]
        public short PretreatmentSc { get; set; }
        [Column("SCHandling_SC")]
        public short SchandlingSc { get; set; }
        [Column("fs_eoo")]
        public int? FsEoo { get; set; }
        [Column("ms_eoo")]
        public int? MsEoo { get; set; }
        [Column("anod_eoo")]
        public int? AnodEoo { get; set; }
        [Column("washerload_eoo")]
        public int WasherloadEoo { get; set; }
        [Column("washerunload_eoo")]
        public int WasherunloadEoo { get; set; }
        [Column("accumulator_eoo")]
        public int AccumulatorEoo { get; set; }
        [Column("Pretret_eoo")]
        public short PretretEoo { get; set; }
        [Column("schandling_eoo")]
        public int SchandlingEoo { get; set; }
        [Column("Debris_eoo")]
        public short DebrisEoo { get; set; }
        [Column("Voids_eoo")]
        public int VoidsEoo { get; set; }
        [Column("Blisters_eoo")]
        public int BlistersEoo { get; set; }
        [Column("RunSags_eoo")]
        public int RunSagsEoo { get; set; }
        [Column("ScratchesCoating_eoo")]
        public int ScratchesCoatingEoo { get; set; }
        [Column("CoatingNonScpec_eoo")]
        public int CoatingNonScpecEoo { get; set; }
        [Column("Offlocation_eoo")]
        public short OfflocationEoo { get; set; }
        [Column("OvenHandling_eoo")]
        public int OvenHandlingEoo { get; set; }
        [Column("ThinCoating_eoo")]
        public int ThinCoatingEoo { get; set; }
        [Column("ThickCoating_eoo")]
        public int ThickCoatingEoo { get; set; }
        [Column("OperatorInspectorHandling_eoo")]
        public int OperatorInspectorHandlingEoo { get; set; }
        public short? Downstream { get; set; }
        [Column("upstream")]
        public short? Upstream { get; set; }
        public short? WasherBreakDown { get; set; }
        [Column("SCBreakdown")]
        public short? Scbreakdown { get; set; }
        public short? Co { get; set; }
        public short? Vision { get; set; }
        public short? Inkjet { get; set; }
        public short? Accumulator { get; set; }
        public short? Quality { get; set; }
        [StringLength(254)]
        public string ScrapComment { get; set; }
        [Column("oae_downtime_comments")]
        public string OaeDowntimeComments { get; set; }
    }
}
