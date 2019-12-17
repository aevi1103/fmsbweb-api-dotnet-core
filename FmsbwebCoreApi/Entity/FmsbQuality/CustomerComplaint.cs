using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.FmsbQuality
{
    public partial class CustomerComplaint
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("date", TypeName = "datetime")]
        public DateTime Date { get; set; }
        [Column("prr")]
        public int? Prr { get; set; }
        [Column("pir")]
        public int? Pir { get; set; }
        [Column("qr")]
        public int? Qr { get; set; }
        [Column("prr_com")]
        public string PrrCom { get; set; }
        [Column("pir_com")]
        public string PirCom { get; set; }
        [Column("qr_com")]
        public string QrCom { get; set; }
        [Column("newIssue")]
        public string NewIssue { get; set; }
        [Column("criticalIssue")]
        public string CriticalIssue { get; set; }
        [Column("modifiedDate", TypeName = "datetime")]
        public DateTime ModifiedDate { get; set; }
    }
}
