using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.FmsbQuality
{
    [Table("checksheetType")]
    public partial class ChecksheetType
    {
        public ChecksheetType()
        {
            CheckSheetCharacteristics = new HashSet<CheckSheetCharacteristics>();
            ChecksheetLogin = new HashSet<ChecksheetLogin>();
        }

        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Required]
        [Column("checksheetType")]
        [StringLength(50)]
        public string ChecksheetType1 { get; set; }
        [Column("modifieddate", TypeName = "datetime")]
        public DateTime Modifieddate { get; set; }

        [InverseProperty("Type")]
        public virtual ICollection<CheckSheetCharacteristics> CheckSheetCharacteristics { get; set; }
        [InverseProperty("ChecksheetType")]
        public virtual ICollection<ChecksheetLogin> ChecksheetLogin { get; set; }
    }
}
