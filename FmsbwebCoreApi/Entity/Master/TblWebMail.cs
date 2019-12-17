using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Master
{
    [Table("tblWebMail")]
    public partial class TblWebMail
    {
        [Key]
        [Column("EMail")]
        [StringLength(50)]
        public string Email { get; set; }
        [Key]
        [StringLength(25)]
        public string MailGroup { get; set; }
    }
}
