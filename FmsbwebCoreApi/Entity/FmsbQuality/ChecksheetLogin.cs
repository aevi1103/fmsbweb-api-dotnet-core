using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.FmsbQuality
{
    [Table("Checksheet_Login")]
    public partial class ChecksheetLogin
    {
        public ChecksheetLogin()
        {
            ChecksheetResults = new HashSet<ChecksheetResults>();
        }

        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("date", TypeName = "datetime")]
        public DateTime Date { get; set; }
        [Column("lineId")]
        public int LineId { get; set; }
        [Required]
        [Column("shift")]
        [StringLength(50)]
        public string Shift { get; set; }
        [Column("machinist")]
        [StringLength(50)]
        public string Machinist { get; set; }
        [Column("clockNum")]
        public int? ClockNum { get; set; }
        [Column("modifieddate", TypeName = "datetime")]
        public DateTime Modifieddate { get; set; }
        [Column("checksheetTypeId")]
        public int ChecksheetTypeId { get; set; }
        [Required]
        [Column("part")]
        [StringLength(50)]
        public string Part { get; set; }

        [ForeignKey(nameof(ChecksheetTypeId))]
        [InverseProperty("ChecksheetLogin")]
        public virtual ChecksheetType ChecksheetType { get; set; }
        [InverseProperty("ChecksheetLogin")]
        public virtual ICollection<ChecksheetResults> ChecksheetResults { get; set; }
    }
}
