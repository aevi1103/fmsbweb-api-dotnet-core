using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Master
{
    [Table("tblUsers")]
    public partial class TblUsers
    {
        [Key]
        [Column("UserID")]
        [StringLength(10)]
        public string UserId { get; set; }
        [StringLength(15)]
        public string LastName { get; set; }
        [StringLength(15)]
        public string FirstName { get; set; }
        [StringLength(1)]
        public string Initial { get; set; }
        public short? FdrySecurity { get; set; }
        public short? InspSecurity { get; set; }
        [StringLength(50)]
        public string DataPath { get; set; }
    }
}
