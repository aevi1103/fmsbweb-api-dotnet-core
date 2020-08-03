using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FmsbwebCoreApi.Entity.QualityCheckSheets
{
    public class OrganizationPart
    {
        public int OrganizationPartId { get; set; }

        [Required]
        public string LeftHandPart { get; set; }

        public string RightHandPart { get; set; }

        public string Part => !string.IsNullOrEmpty(RightHandPart) ? $"{LeftHandPart} - {RightHandPart}" : LeftHandPart;

        [Required]
        public DateTime TimeStamp { get; set; } = DateTime.Now;
    }
}
