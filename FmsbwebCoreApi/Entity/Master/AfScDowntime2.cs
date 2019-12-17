using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Master
{
    public partial class AfScDowntime2
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
        [StringLength(6)]
        public string Part { get; set; }
        [StringLength(2)]
        public string Grade { get; set; }
        [StringLength(5)]
        public string EnteredBy { get; set; }
        public short? Qty { get; set; }
        [Required]
        [StringLength(20)]
        public string Defect { get; set; }
        [Required]
        [StringLength(10)]
        public string Area { get; set; }
        [Required]
        [StringLength(3)]
        public string Department { get; set; }
    }
}
