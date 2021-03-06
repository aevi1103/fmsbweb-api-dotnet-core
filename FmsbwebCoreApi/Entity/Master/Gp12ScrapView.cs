﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Master
{
    public partial class Gp12ScrapView
    {
        [Column("ID")]
        public int Id { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime Date { get; set; }
        [Required]
        [StringLength(50)]
        public string Part { get; set; }
        [Required]
        [StringLength(50)]
        public string Defect { get; set; }
        [Column("qty")]
        public int Qty { get; set; }
        public string Comments { get; set; }
        [Column("modifieddate", TypeName = "datetime")]
        public DateTime Modifieddate { get; set; }
        [Required]
        [StringLength(50)]
        public string Area { get; set; }
        public int? WkNum { get; set; }
        [StringLength(11)]
        public string Program { get; set; }
    }
}
