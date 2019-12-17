using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.FmsbQuality
{
    public partial class Machine
    {
        public Machine()
        {
            CheckSheetCharacteristics = new HashSet<CheckSheetCharacteristics>();
        }

        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Required]
        [Column("machine")]
        [StringLength(50)]
        public string Machine1 { get; set; }
        [Column("modifiedDate", TypeName = "datetime")]
        public DateTime ModifiedDate { get; set; }
        [Column("typeId")]
        public int TypeId { get; set; }
        [Column("line")]
        public int? Line { get; set; }

        [InverseProperty("Machine")]
        public virtual ICollection<CheckSheetCharacteristics> CheckSheetCharacteristics { get; set; }
    }
}
