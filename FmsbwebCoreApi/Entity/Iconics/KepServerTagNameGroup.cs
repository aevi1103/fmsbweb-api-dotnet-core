using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FmsbwebCoreApi.Entity.Iconics
{
    public class KepServerTagNameGroup
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid KepServerTagNameGroupId { get; set; } = Guid.NewGuid();

        [StringLength(5)]
        public string GroupName { get; set; }

        public string Department { get; set; }

        [Required]
        public DateTime TimeStamp { get; set; } = DateTime.Now;

    }
}
