using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.FmsbMvc
{
    [Table("ForkliftTask", Schema = "Alert")]
    public partial class ForkliftTask
    {
        public ForkliftTask()
        {
            Forklift = new HashSet<Forklift>();
        }

        [Key]
        public int ForkliftTaskId { get; set; }
        public int DepartmentId { get; set; }
        [Required]
        public string TaskName { get; set; }
        public bool IsObsolete { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime Stamp { get; set; }
        [StringLength(128)]
        public string ApplicationUserId { get; set; }

        [ForeignKey(nameof(ApplicationUserId))]
        [InverseProperty(nameof(AspNetUsers.ForkliftTask))]
        public virtual AspNetUsers ApplicationUser { get; set; }
        [ForeignKey(nameof(DepartmentId))]
        [InverseProperty(nameof(Departments.ForkliftTask))]
        public virtual Departments Department { get; set; }
        [InverseProperty("ForkliftTask")]
        public virtual ICollection<Forklift> Forklift { get; set; }
    }
}
