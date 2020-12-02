using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FmsbwebCoreApi.Entity.Iconics
{
    [Table("KEPserverTagNames")]
    public class KepServerTagName
    {
        [Key]
        [Column(TypeName = "varchar(100)")]
        public string TagName { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public string DataType { get; set; }
        [Required]
        public string Description { get; set; }
        public DateTime? Stamp { get; set; }
        [Required]
        public string TagId { get; set; }
        [Column("line")]
        public string Line { get; set; }
        [Column("dept")]
        public string Dept { get; set; }
        [Column("isLastCounter")]
        public bool? IsLastCounter { get; set; }
    }
}
