using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Master
{
    [Table("tblHepworth")]
    public partial class TblHepworth
    {
        [Key]
        [StringLength(1)]
        public string DefectDepartment { get; set; }
        [Key]
        [Column("HepworthID")]
        [StringLength(4)]
        public string HepworthId { get; set; }
        [StringLength(25)]
        public string HepworthDesc { get; set; }
    }
}
