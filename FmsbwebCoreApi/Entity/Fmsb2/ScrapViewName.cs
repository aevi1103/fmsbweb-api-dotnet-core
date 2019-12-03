using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Fmsb2
{
    public partial class ScrapViewName
    {
        public ScrapViewName()
        {
            ScrapView = new HashSet<ScrapView>();
        }

        [Key]
        [Column("ScrapViewName")]
        [StringLength(100)]
        public string ScrapViewName1 { get; set; }
        [Column("modifieddate", TypeName = "datetime")]
        public DateTime Modifieddate { get; set; }

        [InverseProperty("ViewNameNavigation")]
        public virtual ICollection<ScrapView> ScrapView { get; set; }
    }
}
