using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Fmsb2
{
    public partial class FoundryParamCharView
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("groupId")]
        public int GroupId { get; set; }
        [Required]
        [Column("groupName")]
        [StringLength(50)]
        public string GroupName { get; set; }
        [Required]
        [Column("characteristics")]
        [StringLength(50)]
        public string Characteristics { get; set; }
        [Column("modifieddate", TypeName = "datetime")]
        public DateTime Modifieddate { get; set; }
    }
}
