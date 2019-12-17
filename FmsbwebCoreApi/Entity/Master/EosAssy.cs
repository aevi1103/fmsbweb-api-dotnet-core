using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Master
{
    public partial class EosAssy
    {
        [Column(TypeName = "datetime")]
        public DateTime? Date { get; set; }
        [StringLength(50)]
        public string Shift { get; set; }
        [Column("shiftHours")]
        public int? ShiftHours { get; set; }
        [StringLength(50)]
        public string MachineCode { get; set; }
        [Column("cycleTime", TypeName = "decimal(38, 5)")]
        public decimal? CycleTime { get; set; }
        [StringLength(50)]
        public string Parts { get; set; }
        [StringLength(50)]
        public string Grade { get; set; }
        [Column("runtime")]
        public int? Runtime { get; set; }
        [Column(TypeName = "decimal(38, 20)")]
        public decimal? Target { get; set; }
        [Column("gross")]
        public int Gross { get; set; }
        [Column("fs")]
        public int Fs { get; set; }
        [Column("ms")]
        public int Ms { get; set; }
        [Column("anod")]
        public int Anod { get; set; }
        [Column("sc")]
        public int Sc { get; set; }
        [Column("assy")]
        public int Assy { get; set; }
        public int? Net { get; set; }
        [Column("OAE_Comments")]
        public string OaeComments { get; set; }
        [Column("Scrap_Comments")]
        public string ScrapComments { get; set; }
        [Column("otherCom")]
        public string OtherCom { get; set; }
    }
}
