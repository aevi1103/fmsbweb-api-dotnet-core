using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Safety
{
    public partial class GetLaborHours
    {
        [Column("ID")]
        public int Id { get; set; }
        [Column("EOM")]
        [StringLength(50)]
        public string Eom { get; set; }
        [StringLength(30)]
        public string Year { get; set; }
        [StringLength(30)]
        public string Month { get; set; }
        [Required]
        [StringLength(50)]
        public string Department { get; set; }
        [Column("Man Hours")]
        [StringLength(50)]
        public string ManHours { get; set; }
        [StringLength(500)]
        public string Comments { get; set; }
        [Column("Modified Date", TypeName = "datetime")]
        public DateTime ModifiedDate { get; set; }
    }
}
