using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Fmsb2
{
    public partial class Attachments
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("filename")]
        [StringLength(50)]
        public string Filename { get; set; }
        [Column("contentType")]
        [StringLength(100)]
        public string ContentType { get; set; }
        [Column("data")]
        public byte[] Data { get; set; }
        [Column("deptComId")]
        public int DeptComId { get; set; }
        [Column("modifieddate", TypeName = "datetime")]
        public DateTime Modifieddate { get; set; }
    }
}
