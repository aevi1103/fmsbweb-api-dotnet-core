using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Fmsb2
{
    public partial class ClockNumberListConcat
    {
        [Column("hxhid")]
        public int Hxhid { get; set; }
        public string ClockNums { get; set; }
    }
}
