using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Master
{
    [Table("tblOperators")]
    public partial class TblOperators
    {
        [Key]
        [Column("OperatorID")]
        public short OperatorId { get; set; }
        [StringLength(30)]
        public string LastName { get; set; }
        [StringLength(30)]
        public string FirstName { get; set; }
        [StringLength(12)]
        public string MiddleInitial { get; set; }
    }
}
