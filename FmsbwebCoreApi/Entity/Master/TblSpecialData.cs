using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Master
{
    [Table("tblSpecialData")]
    public partial class TblSpecialData
    {
        [Key]
        [StringLength(15)]
        public string FieldName { get; set; }
        [StringLength(15)]
        public string DataType { get; set; }
        [StringLength(50)]
        public string TheData { get; set; }
    }
}
