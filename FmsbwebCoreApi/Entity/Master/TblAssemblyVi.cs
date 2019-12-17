using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Master
{
    [Table("tblAssemblyVI")]
    public partial class TblAssemblyVi
    {
        [Key]
        [Column("AssemblyVID")]
        public int AssemblyVid { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime CoatDate { get; set; }
        [Required]
        [StringLength(1)]
        public string Shift { get; set; }
        [Required]
        [Column("DepartmentID")]
        [StringLength(2)]
        public string DepartmentId { get; set; }
        [Column("ProcessID")]
        [StringLength(3)]
        public string ProcessId { get; set; }
        [Required]
        [Column("PRun")]
        [StringLength(1)]
        public string Prun { get; set; }
        [Required]
        [StringLength(1)]
        public string RunNr { get; set; }
        [Required]
        [Column("PartID")]
        [StringLength(6)]
        public string PartId { get; set; }
        [StringLength(2)]
        public string Grade { get; set; }
        [StringLength(5)]
        public string Inspector { get; set; }
        public int? NrReviewed { get; set; }
        public short? AsyPart01 { get; set; }
        public short? AsyPart02 { get; set; }
        public short? AsyPart03 { get; set; }
        public short? AsyPart04 { get; set; }
        public short? AsyPart05 { get; set; }
        public short? AsyPart06 { get; set; }
        public short? AsyPart07 { get; set; }
        public short? Asy01 { get; set; }
        public short? Asy02 { get; set; }
        public short? Asy03 { get; set; }
        public short? Asy04 { get; set; }
        public short? Asy05 { get; set; }
        public short? Asy06 { get; set; }
        public short? Asy07 { get; set; }
        public short? Asy08 { get; set; }
        public short? Asy09 { get; set; }
        public short? Asy10 { get; set; }
        public short? Asy11 { get; set; }
        public short? Asy12 { get; set; }
        public short? Asy13 { get; set; }
        public short? Asy14 { get; set; }
        public short? Asy15 { get; set; }
        public short? Asy00 { get; set; }
        public short? NonAsy01 { get; set; }
        public short? NonAsy02 { get; set; }
        public short? NonAsy03 { get; set; }
        public short? NonAsy04 { get; set; }
        public short? NonAsy05 { get; set; }
        public short? NonAsy06 { get; set; }
        public short? NonAsy07 { get; set; }
        public short? NonAsy08 { get; set; }
        public short? NonAsy09 { get; set; }
        public short? NonAsy10 { get; set; }
        public short? NonScrap01 { get; set; }
        public short? NonScrap02 { get; set; }
        public short? NonScrap03 { get; set; }
        public short? NonScrap04 { get; set; }
        public short? NonScrap05 { get; set; }
        public short? NonScrap06 { get; set; }
        public short? NonScrap07 { get; set; }
        public short? NonScrap08 { get; set; }
        public short? NonScrap09 { get; set; }
        public short? NonScrap10 { get; set; }
        public short? NonScrap11 { get; set; }
        public short? NonScrap12 { get; set; }
        public short? NonScrap13 { get; set; }
        public short? NonScrap14 { get; set; }
        public short? NonScrap15 { get; set; }
        [StringLength(254)]
        public string Comments { get; set; }
        public bool Transferred { get; set; }
        public bool Confirmed { get; set; }
    }
}
