using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Master
{
    [Table("tblManualPackout")]
    public partial class TblManualPackout
    {
        [Key]
        [Column("AssemblyMID")]
        public int AssemblyMid { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CoatDate { get; set; }
        [StringLength(1)]
        public string Shift { get; set; }
        [Column("DepartmentID")]
        [StringLength(2)]
        public string DepartmentId { get; set; }
        [Column("ProcessID")]
        [StringLength(3)]
        public string ProcessId { get; set; }
        [Column("PRun")]
        [StringLength(1)]
        public string Prun { get; set; }
        [StringLength(1)]
        public string RunNr { get; set; }
        [Column("partID")]
        [StringLength(6)]
        public string PartId { get; set; }
        [StringLength(2)]
        public string Grade { get; set; }
        [StringLength(5)]
        public string EnteredBy { get; set; }
        public short? PackoutTotal { get; set; }
        public short? Handling { get; set; }
        [Column("NAD_Foundry")]
        public short? NadFoundry { get; set; }
        [Column("NAD_Machining")]
        public short? NadMachining { get; set; }
        [Column("NAD_SkirtCoat")]
        public short? NadSkirtCoat { get; set; }
        [Column("NAD_Anodizing")]
        public short? NadAnodizing { get; set; }
        [Column("NAD_TinPlate")]
        public short? NadTinPlate { get; set; }
        [StringLength(1000)]
        public string ScrapComment { get; set; }
        [Column("HasMRR")]
        public bool? HasMrr { get; set; }
        public bool? Transferred { get; set; }
        public bool? Confirmed { get; set; }
    }
}
