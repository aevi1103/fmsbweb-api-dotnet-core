using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Master
{
    [Table("tblMRRHold")]
    public partial class TblMrrhold
    {
        public TblMrrhold()
        {
            TblMrrholdDetails = new HashSet<TblMrrholdDetails>();
        }

        [Key]
        [Column("MRRYear")]
        public short Mrryear { get; set; }
        [Key]
        [Column("MRRCode")]
        public short Mrrcode { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? IncidentDate { get; set; }
        [StringLength(1)]
        public string Shift { get; set; }
        [Column("DepartmentID")]
        [StringLength(2)]
        public string DepartmentId { get; set; }
        [Column("ProcessID")]
        [StringLength(15)]
        public string ProcessId { get; set; }
        public int? Line { get; set; }
        [StringLength(1)]
        public string Run { get; set; }
        [StringLength(1)]
        public string RunNr { get; set; }
        [Column("PartID")]
        [StringLength(6)]
        public string PartId { get; set; }
        [Column("DefectID")]
        [StringLength(4)]
        public string DefectId { get; set; }
        public int Quantity { get; set; }
        [StringLength(50)]
        public string Customer { get; set; }
        [StringLength(50)]
        public string Technician { get; set; }
        [StringLength(2)]
        public string LastOp { get; set; }
        [Column("LastOpTXT")]
        [StringLength(50)]
        public string LastOpTxt { get; set; }
        [Column("FromCFD")]
        public bool FromCfd { get; set; }
        [Column("CFDID")]
        [StringLength(25)]
        public string Cfdid { get; set; }
        [StringLength(5)]
        public string DispSortScrapBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DispSortScrapDate { get; set; }
        [StringLength(50)]
        public string DispSortScrapDetails { get; set; }
        [StringLength(5)]
        public string DispScrapBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DispScrapDate { get; set; }
        [StringLength(50)]
        public string DispScrapDetails { get; set; }
        [StringLength(5)]
        public string DispAsIsBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DispAsIsDate { get; set; }
        [StringLength(50)]
        public string DispAsIsDetails { get; set; }
        [StringLength(5)]
        public string DispOtherBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DispOtherDate { get; set; }
        [StringLength(50)]
        public string DispOtherDetails { get; set; }
        [StringLength(1000)]
        public string Notes { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? TimeFound { get; set; }
        [StringLength(15)]
        public string PartNum { get; set; }
        [StringLength(15)]
        public string Catagory { get; set; }
        [StringLength(50)]
        public string ResolutionBy { get; set; }
        [StringLength(1000)]
        public string ResComment { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ClosedDate { get; set; }
        [StringLength(15)]
        public string DeptName { get; set; }
        [Column("SAPDocumentNumber")]
        [StringLength(15)]
        public string SapdocumentNumber { get; set; }
        public bool? SamplePiston { get; set; }
        public int? ReworkTime { get; set; }
        public double? PercentSuspect { get; set; }
        public int? MachQty { get; set; }
        [StringLength(50)]
        public string Sloc { get; set; }

        [InverseProperty("Mrr")]
        public virtual ICollection<TblMrrholdDetails> TblMrrholdDetails { get; set; }
    }
}
