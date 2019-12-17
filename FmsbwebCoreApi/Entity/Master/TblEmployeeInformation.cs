using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Master
{
    [Table("tblEmployeeInformation")]
    public partial class TblEmployeeInformation
    {
        [Key]
        [Column("CLK#")]
        public int Clk { get; set; }
        [Required]
        [StringLength(30)]
        public string LastName { get; set; }
        [StringLength(12)]
        public string MiddleInitial { get; set; }
        [Required]
        [StringLength(30)]
        public string FirstName { get; set; }
        [StringLength(12)]
        public string Suffix { get; set; }
        [Column("HOMEPHONE")]
        [StringLength(14)]
        public string Homephone { get; set; }
        [Column("HIREDATE", TypeName = "datetime")]
        public DateTime? Hiredate { get; set; }
        [Column("DEPT")]
        [StringLength(6)]
        public string Dept { get; set; }
        [Column("SHIFT")]
        [StringLength(1)]
        public string Shift { get; set; }
        [Column("JOBTITLE")]
        [StringLength(40)]
        public string Jobtitle { get; set; }
        [Required]
        public bool? Supervisor { get; set; }
        [Required]
        public bool? WorkOvertime { get; set; }
        [StringLength(14)]
        public string AltPhoneNumber { get; set; }
        [Column("NOTES")]
        [StringLength(75)]
        public string Notes { get; set; }
        [StringLength(60)]
        public string FullNameCalced { get; set; }
        [Required]
        public bool? Terminated { get; set; }
        [StringLength(1)]
        public string Leave { get; set; }
        [StringLength(15)]
        public string DeptDescript { get; set; }
        [StringLength(1)]
        public string Training { get; set; }
        [StringLength(30)]
        public string AddressLine1 { get; set; }
        [StringLength(30)]
        public string AddressLine2 { get; set; }
        [StringLength(20)]
        public string City { get; set; }
        [StringLength(2)]
        public string State { get; set; }
        [StringLength(10)]
        public string ZipCode { get; set; }
    }
}
