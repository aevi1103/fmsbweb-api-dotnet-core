using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Master
{
    public partial class AssyComponentScrap
    {
        [Column("ProdID")]
        public int ProdId { get; set; }
        [Column("ScrapID")]
        public int ScrapId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime Date { get; set; }
        [Required]
        [StringLength(50)]
        public string Shift { get; set; }
        [Required]
        [StringLength(50)]
        public string MachineCode { get; set; }
        [Required]
        [StringLength(50)]
        public string PartNumber { get; set; }
        [Required]
        [StringLength(50)]
        public string Grade { get; set; }
        [StringLength(50)]
        public string ScrapCode { get; set; }
        [StringLength(100)]
        public string ScrapName { get; set; }
        public int? PistonQtyMultiplier { get; set; }
        [StringLength(50)]
        public string Component { get; set; }
        public int? Multiplier { get; set; }
        public int? ComponentScrapQty { get; set; }
        [StringLength(50)]
        public string PinWgt { get; set; }
        [Required]
        [StringLength(6)]
        public string InputStat { get; set; }
    }
}
