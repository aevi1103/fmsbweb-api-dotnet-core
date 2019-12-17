using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Master
{
    public partial class ViewSc2016
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
        public int? Foundry { get; set; }
        public int? Machining { get; set; }
        public int? Anodize { get; set; }
        public int? WasherUnload { get; set; }
        public int? WasherLoad { get; set; }
        [Column("TotalSC_Scrap_noWasher")]
        public int? TotalScScrapNoWasher { get; set; }
        [Column("TotalSC_Washer")]
        public int? TotalScWasher { get; set; }
        public int? OverallScrap { get; set; }
        public int? Net { get; set; }
        [Column("changeover_min")]
        public short? ChangeoverMin { get; set; }
        [Column("OAECom")]
        public string Oaecom { get; set; }
        [StringLength(254)]
        public string ScrapCom { get; set; }
    }
}
