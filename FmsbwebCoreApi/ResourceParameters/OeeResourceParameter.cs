using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FmsbwebCoreApi.ResourceParameters
{
    public class OeeResourceParameter
    {
        [Required]
        public Guid OeeLineId { get; set; }
        public Guid? OeeId { get; set; }
        public byte[] Timestamp { get; set; }
        public DateTime? EndDateTime { get; set; }
    }
}
