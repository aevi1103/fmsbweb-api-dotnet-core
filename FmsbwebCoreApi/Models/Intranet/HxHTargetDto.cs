using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FmsbwebCoreApi.Models.Intranet
{
    public class HxHTargetDto
    {
        public string Area { get; set; }
        public int Target { get; set; }
        public int Gross { get; set; }
        public int Net { get; set; }
    }
}
