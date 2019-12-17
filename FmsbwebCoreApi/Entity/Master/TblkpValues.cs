using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Master
{
    [Table("tblkpValues")]
    public partial class TblkpValues
    {
        [Key]
        [Column("ValueID")]
        [StringLength(15)]
        public string ValueId { get; set; }
        [StringLength(15)]
        public string ValueType { get; set; }
        [StringLength(15)]
        public string Value { get; set; }
    }
}
