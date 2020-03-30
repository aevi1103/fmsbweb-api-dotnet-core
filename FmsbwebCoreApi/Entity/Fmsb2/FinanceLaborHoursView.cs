using FmsbwebCoreApi.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;

namespace FmsbwebCoreApi.Entity.Fmsb2
{
    public partial class FinanceLaborHoursView
    {
        public static readonly CultureInfo cultureInfo = new CultureInfo("en-US");

        [StringLength(100)]
        public string Name { get; set; }
        [Column("ID_")]
        [StringLength(50)]
        public string Id { get; set; }
        public int? Dept { get; set; }
        [Column("deptName")]
        [StringLength(50)]
        public string DeptName { get; set; }
        [Column("GLAccount")]
        public int? Glaccount { get; set; }
        public int? Shift { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DateIn { get; set; }

        public int? Year => DateIn == null ? null : (int?)Convert.ToDateTime(DateIn, cultureInfo).Year;
        public int? Month => DateIn == null ? null : (int?)Convert.ToDateTime(DateIn, cultureInfo).Month;
        public int? Quarter => DateIn == null ? null : (int?)Convert.ToDateTime(DateIn, cultureInfo).ToQuarter();

        public TimeSpan? TimeIn { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DateOut { get; set; }
        public TimeSpan? TimeOut { get; set; }
        [Column(TypeName = "decimal(18, 5)")]
        public decimal? Regular { get; set; }
        [Column(TypeName = "decimal(18, 5)")]
        public decimal? OtHalfTime { get; set; }
        [Column(TypeName = "decimal(18, 5)")]
        public decimal? Ot7d { get; set; }
        [Column(TypeName = "decimal(18, 5)")]
        public decimal? Overtime { get; set; }
        [Column(TypeName = "decimal(18, 5)")]
        public decimal? DoubleTime { get; set; }
        [Column(TypeName = "decimal(18, 5)")]
        public decimal? Orientation { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime UploadTime { get; set; }
        [Required]
        [StringLength(50)]
        public string Type { get; set; }
        [Column("Id")]
        public int Id1 { get; set; }
        public int? WeekNumber { get; set; }
        [Column("isPSO")]
        public bool? IsPso { get; set; }

        public DateTime? DateInTimeIn => DateIn == null 
                                            ? null 
                                            : (DateTime?)Convert.ToDateTime(DateIn).Add((TimeSpan)TimeIn);

        public string Shift2 => DateIn == null
                                    ? null
                                    : new DateTimeHelpers().GetDateShiftEightHours((DateTime)DateInTimeIn).Shift;

    }
}
