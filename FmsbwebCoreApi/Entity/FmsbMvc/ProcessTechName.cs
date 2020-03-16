using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.FmsbMvc
{
    [Table("ProcessTechName", Schema = "ProcessTechs")]
    public partial class ProcessTechName
    {
        [Key]
        public int ClockNumber { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        public int DepartmentId { get; set; }
        public int ShiftNameId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime Stamp { get; set; }
        [StringLength(128)]
        public string ApplicationUserId { get; set; }

        [ForeignKey(nameof(ApplicationUserId))]
        [InverseProperty(nameof(AspNetUsers.ProcessTechName))]
        public virtual AspNetUsers ApplicationUser { get; set; }
        [ForeignKey(nameof(DepartmentId))]
        [InverseProperty(nameof(Departments.ProcessTechName))]
        public virtual Departments Department { get; set; }
        [ForeignKey(nameof(ShiftNameId))]
        [InverseProperty(nameof(ShiftNames.ProcessTechName))]
        public virtual ShiftNames ShiftName { get; set; }
    }
}
