using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.FmsbMvc
{
    [Table("OvertimeLog", Schema = "Overtime")]
    public partial class OvertimeLog
    {
        [Key]
        public int OvertimeLogId { get; set; }
        public int DepartmentId { get; set; }
        public int ClockNumberId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime DateOffered { get; set; }
        [Required]
        public string OvertimeShift { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Hours { get; set; }
        public int OvertimeCategoryId { get; set; }
        [StringLength(8000)]
        public string Comments { get; set; }
        [Required]
        [StringLength(50)]
        public string Supervisor { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime Stamp { get; set; }
        [StringLength(128)]
        public string ApplicationUserId { get; set; }

        [ForeignKey(nameof(ApplicationUserId))]
        [InverseProperty(nameof(AspNetUsers.OvertimeLog))]
        public virtual AspNetUsers ApplicationUser { get; set; }
        [ForeignKey(nameof(ClockNumberId))]
        [InverseProperty("OvertimeLog")]
        public virtual ClockNumber ClockNumber { get; set; }
        [ForeignKey(nameof(DepartmentId))]
        [InverseProperty(nameof(Departments.OvertimeLog))]
        public virtual Departments Department { get; set; }
        [ForeignKey(nameof(OvertimeCategoryId))]
        [InverseProperty("OvertimeLog")]
        public virtual OvertimeCategory OvertimeCategory { get; set; }
    }
}
