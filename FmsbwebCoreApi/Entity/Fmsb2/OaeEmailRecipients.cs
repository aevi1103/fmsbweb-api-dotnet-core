using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Fmsb2
{
    public partial class OaeEmailRecipients
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("deptId")]
        public int DeptId { get; set; }
        [Required]
        [Column("shift")]
        [StringLength(50)]
        public string Shift { get; set; }
        [Column("alarmLevel")]
        public int AlarmLevel { get; set; }
        [Required]
        [Column("emailAddress")]
        [StringLength(50)]
        public string EmailAddress { get; set; }
        [Column("modifieddate", TypeName = "datetime")]
        public DateTime Modifieddate { get; set; }
    }
}
