using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Master
{
    [Table("tblxtDepart")]
    public partial class TblxtDepart
    {
        public TblxtDepart()
        {
            TblCoating = new HashSet<TblCoating>();
        }

        [Key]
        [Column("DepartmentID")]
        [StringLength(2)]
        public string DepartmentId { get; set; }
        [StringLength(5)]
        public string DeptAbbrev { get; set; }
        [StringLength(20)]
        public string DeptDescription { get; set; }

        [InverseProperty("Department")]
        public virtual ICollection<TblCoating> TblCoating { get; set; }
    }
}
