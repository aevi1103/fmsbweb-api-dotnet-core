using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using FmsbwebCoreApi.Enums;

namespace FmsbwebCoreApi.Entity.FmsbOee
{
    public class OeeLine
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid OeeLineId { get; set; } = Guid.NewGuid();

        [StringLength(5)]
        public string GroupName { get; set; }

        [Required]
        public string TagName { get; set; }

        [Required]
        public string WorkCenter { get; set; }

        [Required]
        public string Department { get; set; }

        [Required]
        public decimal CycleTimeSeconds { get; set; }

        [Required]
        public ScrapInspectionLocation ScrapInspectionLocation { get; set; }

        [Required]
        public DateTime DateModified { get; set; } = DateTime.Now;
    }
}
