using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using FmsbwebCoreApi.Enums;

namespace FmsbwebCoreApi.Entity.Overtime
{
    public class Overtime
    {
        public int OvertimeId { get; set; }

        [Required]
        public DateTime Date { get; set; }

        [Required]
        [ForeignKey("Type")]
        public string TypeName { get; set; }

        public virtual Employee Employee { get; set; }

        [Required]
        [ForeignKey("Employee")]
        public int ClockNumber { get; set; }

        public string Comment { get; set; }

        [Required]
        public double Hours { get; set; }

        [Required]
        public DateTime ModifiedDate { get; set; } = DateTime.Now;
    }
}
