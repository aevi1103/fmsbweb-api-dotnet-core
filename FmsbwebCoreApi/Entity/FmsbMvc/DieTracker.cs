using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.FmsbMvc
{
    [Table("DieTracker", Schema = "DieStatus")]
    public partial class DieTracker
    {
        [Key]
        public int DieTrackerId { get; set; }
        public int CastingCellName { get; set; }
        public int CellSideEnum { get; set; }
        public int DieLocationEnum { get; set; }
        public int OddEvenEnum { get; set; }
        public string Comments { get; set; }
        public int DieId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime TimeStamp { get; set; }
        [StringLength(128)]
        public string ApplicationUserId { get; set; }
        [StringLength(128)]
        public string PartNumberId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? BlockChangeDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DieChangeDate { get; set; }

        [ForeignKey(nameof(ApplicationUserId))]
        [InverseProperty(nameof(AspNetUsers.DieTracker))]
        public virtual AspNetUsers ApplicationUser { get; set; }
        [ForeignKey(nameof(CastingCellName))]
        [InverseProperty(nameof(CastingCell.DieTracker))]
        public virtual CastingCell CastingCellNameNavigation { get; set; }
        [ForeignKey(nameof(DieId))]
        [InverseProperty("DieTracker")]
        public virtual Die Die { get; set; }
        [ForeignKey(nameof(PartNumberId))]
        [InverseProperty("DieTracker")]
        public virtual PartNumber PartNumber { get; set; }
    }
}
