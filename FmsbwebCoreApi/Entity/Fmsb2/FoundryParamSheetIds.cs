using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Fmsb2
{
    public partial class FoundryParamSheetIds
    {
        public FoundryParamSheetIds()
        {
            FoundryParamAttachments = new HashSet<FoundryParamAttachments>();
            FoundryParamSheets = new HashSet<FoundryParamSheets>();
        }

        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Required]
        [Column("fmsbPart")]
        [StringLength(50)]
        public string FmsbPart { get; set; }
        [Required]
        [Column("customer")]
        [StringLength(50)]
        public string Customer { get; set; }
        [Column("modifieddate", TypeName = "datetime")]
        public DateTime Modifieddate { get; set; }
        [Column("revisionNumber")]
        public int RevisionNumber { get; set; }

        [InverseProperty("FndryParam")]
        public virtual ICollection<FoundryParamAttachments> FoundryParamAttachments { get; set; }
        [InverseProperty("Param")]
        public virtual ICollection<FoundryParamSheets> FoundryParamSheets { get; set; }
    }
}
