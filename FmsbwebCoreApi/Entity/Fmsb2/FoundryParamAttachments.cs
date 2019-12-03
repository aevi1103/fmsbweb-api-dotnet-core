using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Fmsb2
{
    public partial class FoundryParamAttachments
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Required]
        [Column("fileName")]
        [StringLength(500)]
        public string FileName { get; set; }
        [Required]
        [Column("contentType")]
        [StringLength(500)]
        public string ContentType { get; set; }
        [Required]
        [Column("data")]
        public byte[] Data { get; set; }
        [Required]
        [Column("imageType")]
        [StringLength(500)]
        public string ImageType { get; set; }
        [Column("fndryParamId")]
        public int FndryParamId { get; set; }
        [Column("modifiedData", TypeName = "datetime")]
        public DateTime ModifiedData { get; set; }

        [ForeignKey(nameof(FndryParamId))]
        [InverseProperty(nameof(FoundryParamSheetIds.FoundryParamAttachments))]
        public virtual FoundryParamSheetIds FndryParam { get; set; }
    }
}
