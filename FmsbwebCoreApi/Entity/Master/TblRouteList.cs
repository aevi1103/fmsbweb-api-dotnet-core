using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Master
{
    public partial class TblRouteList
    {
        [StringLength(1)]
        public string Area { get; set; }
        [Column("SPart")]
        [StringLength(15)]
        public string Spart { get; set; }
        [StringLength(5)]
        public string Startqty { get; set; }
        [StringLength(5)]
        public string Currentqty { get; set; }
        [StringLength(1)]
        public string Status { get; set; }
        [Column("RLink1")]
        [StringLength(8)]
        public string Rlink1 { get; set; }
        [Column("RLink2")]
        [StringLength(8)]
        public string Rlink2 { get; set; }
        [Column("RLink3")]
        [StringLength(8)]
        public string Rlink3 { get; set; }
        [Column(TypeName = "date")]
        public DateTime? Date { get; set; }
        [Column("YCode")]
        [StringLength(2)]
        public string Ycode { get; set; }
        [Column("DCode")]
        [StringLength(3)]
        public string Dcode { get; set; }
        [Column("NCode")]
        public int? Ncode { get; set; }
        [StringLength(2)]
        public string Cell { get; set; }
        [StringLength(4)]
        public string Die { get; set; }
        [Column("BCode")]
        [StringLength(10)]
        public string Bcode { get; set; }
        [Column("FMPart")]
        [StringLength(5)]
        public string Fmpart { get; set; }
    }
}
