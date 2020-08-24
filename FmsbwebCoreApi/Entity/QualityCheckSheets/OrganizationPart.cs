using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace FmsbwebCoreApi.Entity.QualityCheckSheets
{
    public class OrganizationPart
    {
        public int OrganizationPartId { get; set; }
        [Required]
        public int ControlMethodId { get; set; }
        public ControlMethod ControlMethod { get; set; }
        [Required]
        public string LeftHandPart { get; set; }
        public string RightHandPart { get; set; }
        public string Part => !string.IsNullOrEmpty(RightHandPart) ? $"{LeftHandPart} - {RightHandPart}" : LeftHandPart;
        [Required]
        public DateTime TimeStamp { get; set; } = DateTime.Now;
        public ICollection<Characteristic> Characteristics { get; set; } = new List<Characteristic>();
        public List<string> Parts => new List<string> { LeftHandPart, RightHandPart };
    }
}
