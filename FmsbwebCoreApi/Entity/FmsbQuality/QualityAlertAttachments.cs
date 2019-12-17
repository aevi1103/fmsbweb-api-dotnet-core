using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.FmsbQuality
{
    public partial class QualityAlertAttachments
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("qaId")]
        public int QaId { get; set; }
        [Required]
        [Column("filename")]
        [StringLength(500)]
        public string Filename { get; set; }
        [Required]
        [Column("contentType")]
        [StringLength(500)]
        public string ContentType { get; set; }
        [Required]
        [Column("data")]
        public byte[] Data { get; set; }
        [Column("modifieddate", TypeName = "datetime")]
        public DateTime Modifieddate { get; set; }
    }
}
