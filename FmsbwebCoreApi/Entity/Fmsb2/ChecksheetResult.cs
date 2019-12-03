using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Fmsb2
{
    public partial class ChecksheetResult
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("hourId")]
        public int HourId { get; set; }
        [Column("checksheetId")]
        public int ChecksheetId { get; set; }
        [Column("status")]
        public bool Status { get; set; }
        [Column("modifieddate", TypeName = "datetime")]
        public DateTime Modifieddate { get; set; }
        [Column("checkId")]
        public int CheckId { get; set; }
    }
}
