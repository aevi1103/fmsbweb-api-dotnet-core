using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Fmsb2
{
    public partial class FurnaceShellNumbers
    {
        public FurnaceShellNumbers()
        {
            FurnaceRebuild = new HashSet<FurnaceRebuild>();
            FurnaceReplacement = new HashSet<FurnaceReplacement>();
        }

        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Required]
        [Column("shellNumber")]
        [StringLength(50)]
        public string ShellNumber { get; set; }
        [Column("mosToReplace")]
        public int MosToReplace { get; set; }
        [Column("modifiedDate", TypeName = "datetime")]
        public DateTime ModifiedDate { get; set; }

        [InverseProperty("FurnaceShell")]
        public virtual ICollection<FurnaceRebuild> FurnaceRebuild { get; set; }
        [InverseProperty("FurnaceShell")]
        public virtual ICollection<FurnaceReplacement> FurnaceReplacement { get; set; }
    }
}
