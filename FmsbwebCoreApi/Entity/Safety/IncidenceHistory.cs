using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Safety
{
    public partial class IncidenceHistory
    {
        [Column("ID")]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Dept { get; set; }
        [Required]
        [Column("LName")]
        [StringLength(50)]
        public string Lname { get; set; }
        [Required]
        [StringLength(50)]
        public string Fname { get; set; }
        [Required]
        [StringLength(102)]
        public string FullName { get; set; }
        [StringLength(50)]
        public string Shift { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime AccidentDate { get; set; }
        [Required]
        [StringLength(50)]
        public string InjuryName { get; set; }
        [Required]
        [StringLength(50)]
        public string BodyPart { get; set; }
        [StringLength(50)]
        public string Supervisor { get; set; }
        [Required]
        [StringLength(50)]
        public string InjuryStat { get; set; }
        public string Description { get; set; }
        public string InterimActionTaken { get; set; }
        public string FinalCorrectiveAction { get; set; }
        [Column("ReasonSupportingORIRStat")]
        public string ReasonSupportingOrirstat { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime Modifieddate { get; set; }
        [Column("isClosed")]
        public bool? IsClosed { get; set; }
        [Column("isFmTipsCompleted")]
        public bool? IsFmTipsCompleted { get; set; }
    }
}
