using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.FmsbMvc
{
    [Table("EmployeeJob", Schema = "Overtime")]
    public partial class EmployeeJob
    {
        [Key]
        public int EmployeeJobId { get; set; }
        public int ClockNumberId { get; set; }
        public int DepartmentId { get; set; }
        public int ShiftNameId { get; set; }
        public int JobTitleId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime Stamp { get; set; }
        [StringLength(128)]
        public string ApplicationUserId { get; set; }

        [ForeignKey(nameof(ApplicationUserId))]
        [InverseProperty(nameof(AspNetUsers.EmployeeJob))]
        public virtual AspNetUsers ApplicationUser { get; set; }
        [ForeignKey(nameof(ClockNumberId))]
        [InverseProperty("EmployeeJob")]
        public virtual ClockNumber ClockNumber { get; set; }
        [ForeignKey(nameof(DepartmentId))]
        [InverseProperty(nameof(Departments.EmployeeJob))]
        public virtual Departments Department { get; set; }
        [ForeignKey(nameof(JobTitleId))]
        [InverseProperty("EmployeeJob")]
        public virtual JobTitle JobTitle { get; set; }
        [ForeignKey(nameof(ShiftNameId))]
        [InverseProperty(nameof(ShiftNames.EmployeeJob))]
        public virtual ShiftNames ShiftName { get; set; }
    }
}
