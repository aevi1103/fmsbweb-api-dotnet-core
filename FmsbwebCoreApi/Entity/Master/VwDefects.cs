using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Master
{
    public partial class VwDefects
    {
        [Required]
        [Column("DefectID")]
        [StringLength(4)]
        public string DefectId { get; set; }
        [StringLength(15)]
        public string ScrapDept { get; set; }
        [StringLength(20)]
        public string ScrapDeptArea { get; set; }
        [StringLength(40)]
        public string DefectDescription { get; set; }
        [StringLength(1)]
        public string DefectDepartment { get; set; }
        [Column("HepworthID")]
        [StringLength(4)]
        public string HepworthId { get; set; }
        [Column("SummaryID")]
        [StringLength(4)]
        public string SummaryId { get; set; }
    }
}
