using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Safety
{
    [Table("audit_incidence_deleted")]
    public partial class AuditIncidenceDeleted
    {
        [Column("ID")]
        public int? Id { get; set; }
        [Column("dept")]
        [StringLength(50)]
        public string Dept { get; set; }
        [Column("fname")]
        [StringLength(50)]
        public string Fname { get; set; }
        [Column("lname")]
        [StringLength(50)]
        public string Lname { get; set; }
        [Column("shift")]
        [StringLength(50)]
        public string Shift { get; set; }
        [Column("accidentdate", TypeName = "datetime")]
        public DateTime? Accidentdate { get; set; }
        [Column("injuryid")]
        [StringLength(50)]
        public string Injuryid { get; set; }
        [Column("bodyid")]
        [StringLength(50)]
        public string Bodyid { get; set; }
        [Column("supervisor")]
        [StringLength(50)]
        public string Supervisor { get; set; }
        [Column("injurystatid")]
        [StringLength(50)]
        public string Injurystatid { get; set; }
        [Column("description")]
        public string Description { get; set; }
        [Column("iat")]
        public string Iat { get; set; }
        [Column("final")]
        public string Final { get; set; }
        [Column("reason")]
        public string Reason { get; set; }
        [Column("triggerdate", TypeName = "datetime")]
        public DateTime? Triggerdate { get; set; }
        [Column("triggerStatus")]
        [StringLength(50)]
        public string TriggerStatus { get; set; }
    }
}
