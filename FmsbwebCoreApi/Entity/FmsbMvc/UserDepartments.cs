using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.FmsbMvc
{
    public partial class UserDepartments
    {
        [Key]
        public int UserDepartmentId { get; set; }
        public int DepartmentId { get; set; }
        [StringLength(128)]
        public string ApplicationUserId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime Stamp { get; set; }

        [ForeignKey(nameof(ApplicationUserId))]
        [InverseProperty(nameof(AspNetUsers.UserDepartments))]
        public virtual AspNetUsers ApplicationUser { get; set; }
        [ForeignKey(nameof(DepartmentId))]
        [InverseProperty(nameof(Departments.UserDepartments))]
        public virtual Departments Department { get; set; }
    }
}
