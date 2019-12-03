using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Fmsb2
{
    public partial class ScrapHourRefs
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("hxhid")]
        public int Hxhid { get; set; }
        [Required]
        [Column("machineName")]
        [StringLength(50)]
        public string MachineName { get; set; }
        [Column("defectid")]
        public int Defectid { get; set; }
        [Column("htmlInputId")]
        [StringLength(8000)]
        public string HtmlInputId { get; set; }
        [Column("qty")]
        public int Qty { get; set; }
        [Column("comments")]
        public string Comments { get; set; }
        [Column("modifieddate", TypeName = "datetime")]
        public DateTime Modifieddate { get; set; }
        [Column("hourNum")]
        public int HourNum { get; set; }
    }
}
