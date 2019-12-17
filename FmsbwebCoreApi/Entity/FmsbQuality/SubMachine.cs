using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.FmsbQuality
{
    public partial class SubMachine
    {
        public SubMachine()
        {
            ChecksheetResults = new HashSet<ChecksheetResults>();
        }

        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("machineId")]
        public int MachineId { get; set; }
        [Required]
        [Column("subMachine")]
        [StringLength(50)]
        public string SubMachine1 { get; set; }
        [Column("modifieddate", TypeName = "datetime")]
        public DateTime Modifieddate { get; set; }

        [InverseProperty("SubMachine")]
        public virtual ICollection<ChecksheetResults> ChecksheetResults { get; set; }
    }
}
