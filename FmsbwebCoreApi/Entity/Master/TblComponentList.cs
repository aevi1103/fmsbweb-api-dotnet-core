using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Master
{
    [Table("tbl_Component_List")]
    public partial class TblComponentList
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [Column("ScrapID")]
        public int ScrapId { get; set; }
        [Required]
        [Column("ComponentID")]
        [StringLength(50)]
        public string ComponentId { get; set; }
        public int Multiplier { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime ModifiedDate { get; set; }
    }
}
