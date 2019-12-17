using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Master
{
    [Table("MRRScrapDetails")]
    public partial class MrrscrapDetails
    {
        [Column("ID")]
        public int Id { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime DateScrapped { get; set; }
        [Required]
        [Column("SAPPart")]
        [StringLength(50)]
        public string Sappart { get; set; }
        [Required]
        [StringLength(50)]
        public string BatchNumber { get; set; }
        [Required]
        [Column("SLOC")]
        [StringLength(50)]
        public string Sloc { get; set; }
        public int CostCenter { get; set; }
        public int ScrapQty { get; set; }
        [Column("MRRNumber")]
        [StringLength(50)]
        public string Mrrnumber { get; set; }
        public string Comments { get; set; }
        [Column("SAPMaterialDocNumber")]
        [StringLength(50)]
        public string SapmaterialDocNumber { get; set; }
        [StringLength(50)]
        public string LeadInitial { get; set; }
    }
}
