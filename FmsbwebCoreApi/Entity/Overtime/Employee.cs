using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using NUnit.Framework.Constraints;

namespace FmsbwebCoreApi.Entity.Overtime
{
    public class Employee
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ClockNumber { get; set; }

        public virtual Department Department { get; set; }

        [Required]
        public int DepartmentId { get; set; }

        [Required]
        public DateTime DateHired { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public DateTime ModifiedDate { get; set; } = DateTime.Now;

    }
}
