using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Master
{
    [Table("tblBrokenRings")]
    public partial class TblBrokenRings
    {
        [Key]
        [Column("BrokenRingID")]
        public int BrokenRingId { get; set; }
        public short? Assembly { get; set; }
        [Column("BDate", TypeName = "datetime")]
        public DateTime? Bdate { get; set; }
        [StringLength(1)]
        public string Shift { get; set; }
        [Column("PartID")]
        [StringLength(6)]
        public string PartId { get; set; }
        public short? OutOfBox { get; set; }
        [Column("B4Laser")]
        public short? B4laser { get; set; }
        public short? LaserChute { get; set; }
        public short? VisionChute { get; set; }
        public short? Inspection { get; set; }
        public short? Dunnage { get; set; }
        public bool? VisionBypassed { get; set; }
        public short? AtModule { get; set; }
    }
}
