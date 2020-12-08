using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FmsbwebCoreApi.Entity.FmsbOee
{
    public class OeeLine
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid OeeLineId { get; set; } = Guid.NewGuid();

        [StringLength(5)]
        public string GroupName { get; set; }

        [Required]
        public string TagName { get; set; }

        [Required]
        public string WorkCenter { get; set; }

        [Required]
        public string Department { get; set; }

        [Required]
        public DateTime DateModified { get; set; } = DateTime.Now;
    }
}
