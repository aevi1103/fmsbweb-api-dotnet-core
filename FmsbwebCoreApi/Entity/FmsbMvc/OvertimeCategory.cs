using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.FmsbMvc
{
    [Table("OvertimeCategory", Schema = "Overtime")]
    public partial class OvertimeCategory
    {
        public OvertimeCategory()
        {
            OvertimeLog = new HashSet<OvertimeLog>();
        }

        [Key]
        public int OvertimeCategoryId { get; set; }
        [Required]
        [StringLength(50)]
        public string Category { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime Stamp { get; set; }
        [StringLength(128)]
        public string ApplicationUserId { get; set; }

        [ForeignKey(nameof(ApplicationUserId))]
        [InverseProperty(nameof(AspNetUsers.OvertimeCategory))]
        public virtual AspNetUsers ApplicationUser { get; set; }
        [InverseProperty("OvertimeCategory")]
        public virtual ICollection<OvertimeLog> OvertimeLog { get; set; }
    }
}
