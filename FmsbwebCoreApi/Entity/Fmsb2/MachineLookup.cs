using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Fmsb2
{
    public partial class MachineLookup
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("mainMachineId")]
        public int MainMachineId { get; set; }
        [Column("refMachineId")]
        public int RefMachineId { get; set; }
        [Column("modifieddate", TypeName = "datetime")]
        public DateTime Modifieddate { get; set; }
    }
}
