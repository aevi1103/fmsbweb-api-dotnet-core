using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Safety
{
    public partial class SafetyStatusRecords
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("dateOpen", TypeName = "datetime")]
        public DateTime DateOpen { get; set; }
        [Required]
        [Column("status")]
        [StringLength(50)]
        public string Status { get; set; }
        [Required]
        [Column("dept")]
        [StringLength(50)]
        public string Dept { get; set; }
        [Required]
        [Column("description")]
        public string Description { get; set; }
        [Column("correctiveAction")]
        public string CorrectiveAction { get; set; }
        [Column("dateClose", TypeName = "datetime")]
        public DateTime? DateClose { get; set; }
        [Column("stamp", TypeName = "datetime")]
        public DateTime Stamp { get; set; }
        [Column("responsiblePerson")]
        [StringLength(100)]
        public string ResponsiblePerson { get; set; }
    }
}
