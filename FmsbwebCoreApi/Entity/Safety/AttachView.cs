using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Safety
{
    public partial class AttachView
    {
        [Column("id")]
        public int Id { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime AccidentDate { get; set; }
        [StringLength(50)]
        public string Shift { get; set; }
        [Column("filename")]
        [StringLength(50)]
        public string Filename { get; set; }
        [Column("contentType")]
        [StringLength(100)]
        public string ContentType { get; set; }
        [Column("data")]
        public byte[] Data { get; set; }
        [Column("incidentid")]
        public int Incidentid { get; set; }
        [Column("modifieddate", TypeName = "datetime")]
        public DateTime Modifieddate { get; set; }
    }
}
