using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Fmsb2
{
    public partial class FurnaceRebuild
    {
        [Column("furnaceShellid")]
        public int FurnaceShellid { get; set; }
        [Column("isFurnaceReady")]
        public bool IsFurnaceReady { get; set; }
        [Column("date", TypeName = "datetime")]
        public DateTime Date { get; set; }
        [Column("clockNum")]
        public int ClockNum { get; set; }
        [Required]
        [Column("comment")]
        public string Comment { get; set; }
        [Column("thingsToLookFor")]
        public string ThingsToLookFor { get; set; }
        [Column("timeStamp", TypeName = "datetime")]
        public DateTime TimeStamp { get; set; }
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [ForeignKey(nameof(FurnaceShellid))]
        [InverseProperty(nameof(FurnaceShellNumbers.FurnaceRebuild))]
        public virtual FurnaceShellNumbers FurnaceShell { get; set; }
    }
}
