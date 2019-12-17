using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Master
{
    public partial class EosSc
    {
        [Column(TypeName = "datetime")]
        public DateTime Date { get; set; }
        [Required]
        [StringLength(1)]
        public string Shift { get; set; }
        [Column("shiftHours")]
        public int? ShiftHours { get; set; }
        [Required]
        [StringLength(2)]
        public string Machine { get; set; }
        [Column("cycleTime")]
        public int CycleTime { get; set; }
        [Required]
        [Column("PartID")]
        [StringLength(6)]
        public string PartId { get; set; }
        [StringLength(2)]
        public string Grade { get; set; }
        [Column("runtime")]
        public int Runtime { get; set; }
        public int? Target { get; set; }
        [Column("gross")]
        public int? Gross { get; set; }
        [Column("fs")]
        public int? Fs { get; set; }
        [Column("ms")]
        public int? Ms { get; set; }
        [Column("anod")]
        public int? Anod { get; set; }
        [Column("sc_washer")]
        public int? ScWasher { get; set; }
        [Column("assy")]
        public int Assy { get; set; }
        [Column("net")]
        public int? Net { get; set; }
        [Required]
        [Column("OAECom")]
        [StringLength(500)]
        public string Oaecom { get; set; }
        [Required]
        [StringLength(500)]
        public string ScrapCom { get; set; }
        [Required]
        [StringLength(1)]
        public string OtherCom { get; set; }
    }
}
