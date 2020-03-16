using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.FmsbMvc
{
    [Table("GageCall", Schema = "Alert")]
    public partial class GageCall
    {
        [Key]
        public int GageCallId { get; set; }
        public int MachineId { get; set; }
        public string QualityTechName { get; set; }
        public string Characteristics { get; set; }
        [StringLength(128)]
        public string ApplicationUserId { get; set; }
        public bool TieIn { get; set; }
        public bool Containment { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime RequestTimeStamp { get; set; }
        public bool IsTurnOver { get; set; }
        public int GaugeCallTypeId { get; set; }
        public int GaugeStationId { get; set; }
        public string OperatorComment { get; set; }
        public string TechComment { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? StartTimeStamp { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? EndTimeStamp { get; set; }
        [StringLength(50)]
        public string RequestedBy { get; set; }
        public int? HourId { get; set; }
        [Column("HxHId")]
        public int? HxHid { get; set; }
        public int? OperatorDowntimeId { get; set; }

        [ForeignKey(nameof(ApplicationUserId))]
        [InverseProperty(nameof(AspNetUsers.GageCall))]
        public virtual AspNetUsers ApplicationUser { get; set; }
        [ForeignKey(nameof(GaugeCallTypeId))]
        [InverseProperty("GageCall")]
        public virtual GaugeCallType GaugeCallType { get; set; }
        [ForeignKey(nameof(GaugeStationId))]
        [InverseProperty("GageCall")]
        public virtual GaugeStation GaugeStation { get; set; }
        [ForeignKey(nameof(MachineId))]
        [InverseProperty("GageCall")]
        public virtual Machine Machine { get; set; }
        [ForeignKey(nameof(OperatorDowntimeId))]
        [InverseProperty("GageCall")]
        public virtual OperatorDowntime OperatorDowntime { get; set; }
    }
}
