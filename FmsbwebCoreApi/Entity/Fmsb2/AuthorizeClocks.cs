using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Fmsb2
{
    public partial class AuthorizeClocks
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("clocknum")]
        public int Clocknum { get; set; }
        [Column("machineId")]
        public int MachineId { get; set; }
        [Column("modifieddate", TypeName = "datetime")]
        public DateTime Modifieddate { get; set; }
    }
}
