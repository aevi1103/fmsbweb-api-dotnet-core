using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.FmsbQuality
{
    [Table("Machine_Frequency")]
    public partial class MachineFrequency
    {
        public MachineFrequency()
        {
            ChecksheetResults = new HashSet<ChecksheetResults>();
        }

        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("sort")]
        public int Sort { get; set; }
        [Required]
        [Column("value")]
        [StringLength(50)]
        public string Value { get; set; }
        [Column("modifieddate", TypeName = "datetime")]
        public DateTime Modifieddate { get; set; }
        [Column("machineId")]
        public int MachineId { get; set; }
        [Required]
        [Column("map")]
        [StringLength(52)]
        public string Map { get; set; }
        [Column("typeId")]
        public int? TypeId { get; set; }

        [InverseProperty("Frequency")]
        public virtual ICollection<ChecksheetResults> ChecksheetResults { get; set; }
    }
}
