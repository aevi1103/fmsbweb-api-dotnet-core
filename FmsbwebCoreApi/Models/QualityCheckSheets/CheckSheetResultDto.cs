using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FmsbwebCoreApi.Models.QualityCheckSheets
{
    public class CheckSheetResultDto
    {
        public int Status { get; set; }
        public string StatusText { get; set; }
        public dynamic Result { get; set; }
    }
}
