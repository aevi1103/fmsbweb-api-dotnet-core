using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.FmsbMvc
{
    public partial class Assignments
    {
        public Assignments()
        {
            SupervisorConversations = new HashSet<SupervisorConversations>();
        }

        [Key]
        public int AssignmentsId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime StartDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime EndDate { get; set; }
        public int NumOfConversation { get; set; }
        public int DepartmentId { get; set; }
        public int TopicsId { get; set; }
        [Required]
        public string Comments { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime Stamp { get; set; }
        [StringLength(128)]
        public string ApplicationUserId { get; set; }

        [ForeignKey(nameof(ApplicationUserId))]
        [InverseProperty(nameof(AspNetUsers.Assignments))]
        public virtual AspNetUsers ApplicationUser { get; set; }
        [ForeignKey(nameof(DepartmentId))]
        [InverseProperty(nameof(Departments.Assignments))]
        public virtual Departments Department { get; set; }
        [ForeignKey(nameof(TopicsId))]
        [InverseProperty("Assignments")]
        public virtual Topics Topics { get; set; }
        [InverseProperty("Assignments")]
        public virtual ICollection<SupervisorConversations> SupervisorConversations { get; set; }
    }
}
