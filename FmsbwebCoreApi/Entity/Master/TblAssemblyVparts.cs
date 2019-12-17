using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Master
{
    [Table("tblAssemblyVParts")]
    public partial class TblAssemblyVparts
    {
        [Key]
        [Column("PartID")]
        [StringLength(6)]
        public string PartId { get; set; }
        [StringLength(10)]
        public string AsyPart01Desc { get; set; }
        [StringLength(15)]
        public string AsyPart01Code { get; set; }
        [StringLength(10)]
        public string AsyPart02Desc { get; set; }
        [StringLength(15)]
        public string AsyPart02Code { get; set; }
        [StringLength(10)]
        public string AsyPart03Desc { get; set; }
        [StringLength(15)]
        public string AsyPart03Code { get; set; }
        [StringLength(10)]
        public string AsyPart04Desc { get; set; }
        [StringLength(15)]
        public string AsyPart04Code { get; set; }
        [StringLength(10)]
        public string AsyPart05Desc { get; set; }
        [StringLength(15)]
        public string AsyPart05Code { get; set; }
        [StringLength(10)]
        public string AsyPart06Desc { get; set; }
        [StringLength(15)]
        public string AsyPart06Code { get; set; }
        [StringLength(10)]
        public string AsyPart07Desc { get; set; }
        [StringLength(15)]
        public string AsyPart07Code { get; set; }
        [StringLength(30)]
        public string Asy01Text { get; set; }
        [StringLength(4)]
        public string Asy01Code { get; set; }
        [StringLength(30)]
        public string Asy02Text { get; set; }
        [StringLength(4)]
        public string Asy02Code { get; set; }
        [StringLength(30)]
        public string Asy03Text { get; set; }
        [StringLength(4)]
        public string Asy03Code { get; set; }
        [StringLength(30)]
        public string Asy04Text { get; set; }
        [StringLength(4)]
        public string Asy04Code { get; set; }
        [StringLength(30)]
        public string Asy05Text { get; set; }
        [StringLength(4)]
        public string Asy05Code { get; set; }
        [StringLength(30)]
        public string Asy06Text { get; set; }
        [StringLength(4)]
        public string Asy06Code { get; set; }
        [StringLength(30)]
        public string Asy07Text { get; set; }
        [StringLength(4)]
        public string Asy07Code { get; set; }
        [StringLength(30)]
        public string Asy08Text { get; set; }
        [StringLength(4)]
        public string Asy08Code { get; set; }
        [StringLength(30)]
        public string Asy09Text { get; set; }
        [StringLength(4)]
        public string Asy09Code { get; set; }
        [StringLength(30)]
        public string Asy10Text { get; set; }
        [StringLength(4)]
        public string Asy10Code { get; set; }
        [StringLength(30)]
        public string Asy11Text { get; set; }
        [StringLength(4)]
        public string Asy11Code { get; set; }
        [StringLength(30)]
        public string Asy12Text { get; set; }
        [StringLength(4)]
        public string Asy12Code { get; set; }
        [StringLength(30)]
        public string Asy13Text { get; set; }
        [StringLength(4)]
        public string Asy13Code { get; set; }
        [StringLength(30)]
        public string Asy14Text { get; set; }
        [StringLength(4)]
        public string Asy14Code { get; set; }
        [StringLength(30)]
        public string Asy15Text { get; set; }
        [StringLength(4)]
        public string Asy15Code { get; set; }
        [StringLength(30)]
        public string Asy00Text { get; set; }
        [StringLength(4)]
        public string Asy00Code { get; set; }
        [StringLength(40)]
        public string NonAsy01Text { get; set; }
        [StringLength(4)]
        public string NonAsy01Code { get; set; }
        [StringLength(40)]
        public string NonAsy02Text { get; set; }
        [StringLength(4)]
        public string NonAsy02Code { get; set; }
        [StringLength(40)]
        public string NonAsy03Text { get; set; }
        [StringLength(4)]
        public string NonAsy03Code { get; set; }
        [StringLength(40)]
        public string NonAsy04Text { get; set; }
        [StringLength(4)]
        public string NonAsy04Code { get; set; }
        [StringLength(40)]
        public string NonAsy05Text { get; set; }
        [StringLength(4)]
        public string NonAsy05Code { get; set; }
        [StringLength(40)]
        public string NonAsy06Text { get; set; }
        [StringLength(4)]
        public string NonAsy06Code { get; set; }
        [StringLength(40)]
        public string NonAsy07Text { get; set; }
        [StringLength(4)]
        public string NonAsy07Code { get; set; }
        [StringLength(40)]
        public string NonAsy08Text { get; set; }
        [StringLength(4)]
        public string NonAsy08Code { get; set; }
        [StringLength(40)]
        public string NonAsy09Text { get; set; }
        [StringLength(4)]
        public string NonAsy09Code { get; set; }
        [StringLength(40)]
        public string NonAsy10Text { get; set; }
        [StringLength(4)]
        public string NonAsy10Code { get; set; }
        [StringLength(25)]
        public string NonScrap01Text { get; set; }
        [StringLength(25)]
        public string NonScrap02Text { get; set; }
        [StringLength(25)]
        public string NonScrap03Text { get; set; }
        [StringLength(25)]
        public string NonScrap04Text { get; set; }
        [StringLength(25)]
        public string NonScrap05Text { get; set; }
        [StringLength(25)]
        public string NonScrap06Text { get; set; }
        [StringLength(25)]
        public string NonScrap07Text { get; set; }
        [StringLength(25)]
        public string NonScrap08Text { get; set; }
        [StringLength(25)]
        public string NonScrap09Text { get; set; }
        [StringLength(25)]
        public string NonScrap10Text { get; set; }
        [StringLength(25)]
        public string NonScrap11Text { get; set; }
        [StringLength(25)]
        public string NonScrap12Text { get; set; }
        [StringLength(25)]
        public string NonScrap13Text { get; set; }
        [StringLength(25)]
        public string NonScrap14Text { get; set; }
        [StringLength(25)]
        public string NonScrap15Text { get; set; }
    }
}
