using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Fmsb2
{
    public partial class CurrentGrossProdEolMach
    {
        public int Line { get; set; }
        public double? Gross { get; set; }
    }
}
