﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Safety
{
    public partial class EmailNotificationLog
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("email")]
        [StringLength(50)]
        public string Email { get; set; }
        [Column("status")]
        [StringLength(50)]
        public string Status { get; set; }
        [Column("errorMsg")]
        public string ErrorMsg { get; set; }
        [Column("datemodified", TypeName = "datetime")]
        public DateTime? Datemodified { get; set; }
        [Column("incidentId")]
        public int? IncidentId { get; set; }
    }
}
