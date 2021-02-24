using System;
using System.ComponentModel.DataAnnotations;
using FmsbwebCoreApi.Enums;

namespace FmsbwebCoreApi.ResourceParameters
{
    public class OvertimePostDto
    {
        public int OvertimeId { get; set; }

        [Required]
        public DateTime Date { get; set; }

        [Required]
        public string TypeName { get; set; }

        [Required]
        public int ClockNumber { get; set; }

        public string Comment { get; set; }

        [Required]
        public double Hours { get; set; }

        [Required]
        public DateTime ModifiedDate { get; set; } = DateTime.Now;
    }
}
