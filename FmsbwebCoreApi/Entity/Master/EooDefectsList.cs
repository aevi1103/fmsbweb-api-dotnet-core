using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Master
{
    [Table("EOO_DefectsList")]
    public partial class EooDefectsList
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string DefectArea { get; set; }
        public int DefectCode { get; set; }
        [Required]
        public string DefectName { get; set; }
        public string DefectDescription { get; set; }
    }
}
