using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FmsbwebCoreApi.Models.FmsbQuality
{
    public class CustomerComplaintDto
    {
        public int Prr { get; set; }
        public int Pir { get; set; }
        public int Qr { get; set; }
        public int Total { get; set; }
    }
}
