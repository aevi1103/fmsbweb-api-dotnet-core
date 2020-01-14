using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FmsbwebCoreApi.Entity.Fmsb2
{
    public class SapBOM
    {
        public int SapBOMId { get; set; }
        public string Material { get; set; }
        public string MaterialDesc { get; set; }
        public string Component { get; set; }
        public string ComponentDesc { get; set; }
    }
}
