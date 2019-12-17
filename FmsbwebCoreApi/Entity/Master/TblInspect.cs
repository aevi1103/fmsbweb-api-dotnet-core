using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Master
{
    [Table("tblInspect")]
    public partial class TblInspect
    {
        public TblInspect()
        {
            TblInspectDetails = new HashSet<TblInspectDetails>();
        }

        [Column("InspectID")]
        public int InspectId { get; set; }
        [Key]
        [Column(TypeName = "datetime")]
        public DateTime InspDate { get; set; }
        [Key]
        [StringLength(1)]
        public string Shift { get; set; }
        [Key]
        public byte Line { get; set; }
        [Key]
        [StringLength(1)]
        public string Run { get; set; }
        [Key]
        [StringLength(1)]
        public string RunNr { get; set; }
        [Key]
        [Column("PartID")]
        [StringLength(6)]
        public string PartId { get; set; }
        public int CounterStart { get; set; }
        public int CounterStop { get; set; }
        [Required]
        [StringLength(5)]
        public string EnteredBy { get; set; }
        [StringLength(254)]
        public string Comment { get; set; }

        [InverseProperty("TblInspect")]
        public virtual ICollection<TblInspectDetails> TblInspectDetails { get; set; }
    }
}
