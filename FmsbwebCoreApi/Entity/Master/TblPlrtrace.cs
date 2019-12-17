using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Master
{
    [Table("tblPLRTrace")]
    public partial class TblPlrtrace
    {
        [Key]
        public int RowNumber { get; set; }
        public int? EventClass { get; set; }
        [Column(TypeName = "ntext")]
        public string TextData { get; set; }
        [Column(TypeName = "image")]
        public byte[] BinaryData { get; set; }
        [Column("DatabaseID")]
        public int? DatabaseId { get; set; }
        [Column("SPID")]
        public int? Spid { get; set; }
        public long? Duration { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? StartTime { get; set; }
        [Column("CPU")]
        public int? Cpu { get; set; }
        public int? EventSubClass { get; set; }
        [Column("ObjectID")]
        public int? ObjectId { get; set; }
        [StringLength(128)]
        public string ServerName { get; set; }
    }
}
