using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.SAP
{
    public partial class ViewPrograms
    {
        [Column("id")]
        public long Id { get; set; }
        [StringLength(100)]
        public string Program { get; set; }
    }
}
