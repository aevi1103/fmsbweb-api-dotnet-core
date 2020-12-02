using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FmsbwebCoreApi.Entity.Iconics
{
    public class KepServerTagNameMonitor
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; } = Guid.NewGuid();

        [Required]
        [ForeignKey("KepServerTagName")]
        [Column(TypeName = "varchar(100)")]
        public string TagName { get; set; }
        public KepServerTagName KepServerTagName { get; set; }

        [Required]
        public Guid KepServerTagNameGroupId { get; set; }
        public KepServerTagNameGroup KepServerTagNameGroup { get; set; }

        [Required]
        public DateTime TimeStamp { get; set; } = DateTime.Now;
    }
}
