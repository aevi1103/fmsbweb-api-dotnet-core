using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.FmsbMvc
{
    [Table("Discipline", Schema = "Discipline")]
    public partial class Discipline
    {
        [Key]
        public int DisciplineLogId { get; set; }
        public int DepartmentId { get; set; }
        public int SupervisorClockNumber { get; set; }
        [Required]
        [StringLength(50)]
        public string SupervisorName { get; set; }
        public int ShiftNameId { get; set; }
        public int ClockNumber { get; set; }
        [Required]
        [StringLength(25)]
        public string FirstName { get; set; }
        [Required]
        [StringLength(25)]
        public string LastName { get; set; }
        [Required]
        [StringLength(1000)]
        public string Comments { get; set; }
        public int DisciplineTopicId { get; set; }
        public int DisciplineLevelsId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime Stamp { get; set; }
        [StringLength(128)]
        public string ApplicationUserId { get; set; }

        [ForeignKey(nameof(ApplicationUserId))]
        [InverseProperty(nameof(AspNetUsers.Discipline))]
        public virtual AspNetUsers ApplicationUser { get; set; }
        [ForeignKey(nameof(DepartmentId))]
        [InverseProperty(nameof(Departments.Discipline))]
        public virtual Departments Department { get; set; }
        [ForeignKey(nameof(DisciplineLevelsId))]
        [InverseProperty("Discipline")]
        public virtual DisciplineLevels DisciplineLevels { get; set; }
        [ForeignKey(nameof(DisciplineTopicId))]
        [InverseProperty("Discipline")]
        public virtual DisciplineTopic DisciplineTopic { get; set; }
        [ForeignKey(nameof(ShiftNameId))]
        [InverseProperty(nameof(ShiftNames.Discipline))]
        public virtual ShiftNames ShiftName { get; set; }
    }
}
