using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Iconics
{
    public partial class KepserverTagNamesView
    {
        [Required]
        [StringLength(100)]
        public string TagName { get; set; }
        [Required]
        [StringLength(500)]
        public string Address { get; set; }
        [Required]
        [StringLength(50)]
        public string DataType { get; set; }
        [StringLength(5000)]
        public string Description { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? Stamp { get; set; }
        [Required]
        [StringLength(50)]
        public string TagId { get; set; }
        [Column("line")]
        [StringLength(5)]
        public string Line { get; set; }
        [Column("dept")]
        [StringLength(10)]
        public string Dept { get; set; }
        [Column("isLastCounter")]
        public bool? IsLastCounter { get; set; }
        public int? AddressId { get; set; }
        [Required]
        [Column("cellSide")]
        [StringLength(3)]
        public string CellSide { get; set; }
        [StringLength(50)]
        public string MachineName { get; set; }
        [Column("line_hxh")]
        [StringLength(50)]
        public string LineHxh { get; set; }
        [StringLength(20)]
        public string MachineMapper { get; set; }
        [StringLength(62)]
        public string MachineName2 { get; set; }
        public int DontUse { get; set; }
    }
}
