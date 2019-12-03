﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Safety
{
    public partial class ManHours
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [Column("mos_dte", TypeName = "datetime")]
        public DateTime MosDte { get; set; }
        [Column("manhrs", TypeName = "decimal(18, 5)")]
        public decimal Manhrs { get; set; }
        [Column("modifieddate", TypeName = "datetime")]
        public DateTime Modifieddate { get; set; }
        [Column("comments")]
        [StringLength(500)]
        public string Comments { get; set; }
    }
}
