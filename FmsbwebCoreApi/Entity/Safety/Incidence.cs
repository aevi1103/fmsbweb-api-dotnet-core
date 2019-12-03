using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Safety
{
    public partial class Incidence
    {
        public Incidence()
        {
            Attachments = new HashSet<Attachments>();
        }

        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Dept { get; set; }
        [Required]
        [StringLength(50)]
        public string Fname { get; set; }
        [Required]
        [Column("LName")]
        [StringLength(50)]
        public string Lname { get; set; }
        [StringLength(50)]
        public string Shift { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime AccidentDate { get; set; }
        [Column("InjuryID")]
        public int InjuryId { get; set; }
        [Column("BodyPartID")]
        public int BodyPartId { get; set; }
        [StringLength(50)]
        public string Supervisor { get; set; }
        [Required]
        [Column("InjuryStatID")]
        [StringLength(50)]
        public string InjuryStatId { get; set; }
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
        [Column("fmTipsNumber")]
        [StringLength(5000)]
        public string FmTipsNumber { get; set; }
        [Column("deletedFlag")]
        public bool DeletedFlag { get; set; }
        [Column("deletedFlagComment")]
        [StringLength(5000)]
        public string DeletedFlagComment { get; set; }

        [ForeignKey(nameof(BodyPartId))]
        [InverseProperty("Incidence")]
        public virtual BodyPart BodyPart { get; set; }
        [ForeignKey(nameof(Dept))]
        [InverseProperty("Incidence")]
        public virtual Dept DeptNavigation { get; set; }
        [ForeignKey(nameof(InjuryId))]
        [InverseProperty(nameof(Injuries.Incidence))]
        public virtual Injuries Injury { get; set; }
        [InverseProperty("Incident")]
        public virtual ICollection<Attachments> Attachments { get; set; }
    }
}
