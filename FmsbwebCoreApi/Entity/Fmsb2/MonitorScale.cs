using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Fmsb2
{
    public partial class MonitorScale
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("machId")]
        public int MachId { get; set; }
        [Column("width")]
        public int Width { get; set; }
        [Column("height")]
        public int Height { get; set; }
        [Column("modifieddate", TypeName = "datetime")]
        public DateTime Modifieddate { get; set; }
    }
}
