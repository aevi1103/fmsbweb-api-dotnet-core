using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Master
{
    [Table("tblRouteScrap")]
    public partial class TblRouteScrap
    {
        [Key]
        [Column("ID")]
        [StringLength(10)]
        public string Id { get; set; }
        [StringLength(1)]
        public string Area { get; set; }
        [Column("BCode")]
        [StringLength(8)]
        public string Bcode { get; set; }
        [Column("SCode")]
        [StringLength(5)]
        public string Scode { get; set; }
        [Column(TypeName = "date")]
        public DateTime? Date { get; set; }
        [StringLength(5)]
        public string Qty { get; set; }
        [Column("EEID")]
        [StringLength(5)]
        public string Eeid { get; set; }
    }
}
