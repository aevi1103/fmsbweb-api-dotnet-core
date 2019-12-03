using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.SAP
{
    public partial class ScrapEscalationLog
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Required]
        [Column("workCenter")]
        [StringLength(50)]
        public string WorkCenter { get; set; }
        [Column("scrapCode")]
        public int ScrapCode { get; set; }
        [Column("alertLevel")]
        public int AlertLevel { get; set; }
        [Column("shiftDate", TypeName = "datetime")]
        public DateTime ShiftDate { get; set; }
        [Required]
        [Column("shift")]
        [StringLength(5)]
        public string Shift { get; set; }
        [Column("qty")]
        public int Qty { get; set; }
        [Column("scrapEscalationId")]
        public int ScrapEscalationId { get; set; }
        [Column("isAcknowledged")]
        public bool IsAcknowledged { get; set; }
        [Column("acknowledgeComment")]
        public string AcknowledgeComment { get; set; }
        [Column("acknowledgeStamp", TypeName = "datetime")]
        public DateTime? AcknowledgeStamp { get; set; }
        [Column("stamp", TypeName = "datetime")]
        public DateTime Stamp { get; set; }

        [ForeignKey(nameof(ScrapEscalationId))]
        [InverseProperty("ScrapEscalationLog")]
        public virtual ScrapEscalation ScrapEscalation { get; set; }
    }
}
