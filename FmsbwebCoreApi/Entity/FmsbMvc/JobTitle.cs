using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.FmsbMvc
{
    [Table("JobTitle", Schema = "Overtime")]
    public partial class JobTitle
    {
        public JobTitle()
        {
            EmployeeJob = new HashSet<EmployeeJob>();
        }

        [Key]
        public int JobTitleId { get; set; }
        public int DepartmentId { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        [StringLength(8000)]
        public string Description { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime Stamp { get; set; }
        [StringLength(128)]
        public string ApplicationUserId { get; set; }

        [ForeignKey(nameof(ApplicationUserId))]
        [InverseProperty(nameof(AspNetUsers.JobTitle))]
        public virtual AspNetUsers ApplicationUser { get; set; }
        [ForeignKey(nameof(DepartmentId))]
        [InverseProperty(nameof(Departments.JobTitle))]
        public virtual Departments Department { get; set; }
        [InverseProperty("JobTitle")]
        public virtual ICollection<EmployeeJob> EmployeeJob { get; set; }
    }
}
