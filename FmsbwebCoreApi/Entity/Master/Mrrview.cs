using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Master
{
    public partial class Mrrview
    {
        [Column("MRRNum")]
        [StringLength(8000)]
        public string Mrrnum { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? IncidentDate { get; set; }
        [StringLength(1)]
        public string Shift { get; set; }
        [Column("ProcessID")]
        [StringLength(15)]
        public string ProcessId { get; set; }
        public int? Line { get; set; }
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
        [StringLength(50)]
        public string DispSortScrapDetails { get; set; }
        [StringLength(50)]
        public string DispAsIsDetails { get; set; }
        [StringLength(50)]
        public string DispOtherDetails { get; set; }
        [StringLength(1000)]
        public string Notes { get; set; }
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
        public bool? SamplePiston { get; set; }
        [Column("daysInHold")]
        public int? DaysInHold { get; set; }
        [Column("weekNum")]
        public int? WeekNum { get; set; }
        [StringLength(14)]
        public string Program { get; set; }
        [Required]
        [StringLength(5)]
        public string Status { get; set; }
    }
}
