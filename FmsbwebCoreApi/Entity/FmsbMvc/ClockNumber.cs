using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.FmsbMvc
{
    [Table("ClockNumber", Schema = "Overtime")]
    public partial class ClockNumber
    {
        public ClockNumber()
        {
            EmployeeJob = new HashSet<EmployeeJob>();
            OvertimeLog = new HashSet<OvertimeLog>();
        }

        [Key]
        public int ClockNumberId { get; set; }
        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }
        [Required]
        [StringLength(50)]
        public string LastName { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime DateHired { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime Stamp { get; set; }
        [StringLength(128)]
        public string ApplicationUserId { get; set; }

        [ForeignKey(nameof(ApplicationUserId))]
        [InverseProperty(nameof(AspNetUsers.ClockNumber))]
        public virtual AspNetUsers ApplicationUser { get; set; }
        [InverseProperty("ClockNumber")]
        public virtual ICollection<EmployeeJob> EmployeeJob { get; set; }
        [InverseProperty("ClockNumber")]
        public virtual ICollection<OvertimeLog> OvertimeLog { get; set; }
    }
}
