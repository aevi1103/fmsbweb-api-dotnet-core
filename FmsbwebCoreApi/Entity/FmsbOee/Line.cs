using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using FmsbwebCoreApi.Enums;

namespace FmsbwebCoreApi.Entity.FmsbOee
{
    public class Line
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid LineId { get; set; } = Guid.NewGuid();

        [StringLength(5)]
        public string GroupName { get; set; }

        public string MachineName { get; set; }

        [Required]
        public string TagName { get; set; }

        [Required]
        public string WorkCenter { get; set; }

        [Required]
        public string Department { get; set; }

        [Required]
        public decimal CycleTimeSeconds { get; set; }

        public decimal CycleTimeMinutes => CycleTimeSeconds / 60;

        [Required]
        public ScrapInspectionLocation ScrapInspectionLocation { get; set; }

        [Required]
        public DateTime DateModified { get; set; } = DateTime.Now;

        public ICollection<MachineGroup> MachineGroups { get; set; }
    }
}
